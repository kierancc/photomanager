using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace PhotoManager
{
    public partial class EliminateDuplicates : Form
    {
        protected MainForm parentForm;
        protected PhotoList photoList;

        public EliminateDuplicates(MainForm parent)
        {
            InitializeComponent();
            parentForm = parent;
            photoList = new PhotoList();
            ScanFiles();

            foreach (string extension in photoList.GetExtensions())
            {
                CheckBox cb = new CheckBox();
                cb.Name = "cb" + extension;
                cb.Text = extension;
                cb.Checked = true;

                tbDestinationDirectory.Text = parentForm.CurrentWorkingDirectory + "\\duplicates";
                flpFileTypes.Controls.Add(cb);
            }
        }

        protected void ScanFiles()
        {
            var files = Directory.EnumerateFiles(parentForm.CurrentWorkingDirectory);

            foreach (string file in files)
            {
                photoList.AddPhoto(file.Substring(file.LastIndexOf("\\") + 1));
            }
        }

        private void ProcessFiles(bool eliminate)
        {
            // Ensure only one file type to keep is selected
            int numChecked = 0;
            string toKeep = "";

            foreach (CheckBox cb in flpFileTypes.Controls)
            {
                if (cb.Checked)
                {
                    toKeep = cb.Text;
                    numChecked++;

                    if (numChecked > 1)
                    {
                        MessageBox.Show("Select only one file type to keep");
                        return;
                    }
                }
            }

            if (eliminate)
            {
                // Ensure destination directory exists
                if (!Directory.Exists(tbDestinationDirectory.Text))
                {
                    Directory.CreateDirectory(tbDestinationDirectory.Text);
                }
            }

            // Find all duplicate files corresponding to the selected file type to keep
            int countMoved = 0;
            List<string> duplicateFiles = new List<string>();

            foreach (string extension in photoList.GetExtensions())
            {
                if (string.Compare(toKeep, extension, true) == 0) continue;

                foreach (string fileName in photoList.GetFileNames(toKeep).Intersect(photoList.GetFileNames(extension)))
                {
                    string fullFileName = fileName + "." + extension;

                    if (eliminate)
                    {
                        File.Move(parentForm.CurrentWorkingDirectory + "\\" + fullFileName, tbDestinationDirectory.Text + "\\" + fullFileName);
                        countMoved++;
                    }
                    else
                    {
                        duplicateFiles.Add(fullFileName);
                    }
                }
            }

            if (eliminate)
            {
                MessageBox.Show(countMoved + " duplicate file(s) eliminated");
            }
            else
            {
                QueryDuplicates qd = new QueryDuplicates(duplicateFiles);
                qd.Show();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            ProcessFiles(false);
        }

        private void btnEliminate_Click(object sender, EventArgs e)
        {
            ProcessFiles(true);
        }
    }
}
