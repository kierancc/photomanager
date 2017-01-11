using System;
using System.Windows.Forms;

namespace PhotoManager
{
    public partial class MainForm : Form
    {
        public string CurrentWorkingDirectory
        {
            get { return currentWorkingDirectory; }
        }

        protected string currentWorkingDirectory;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSetWorkingDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentWorkingDirectory = dialog.SelectedPath;
                tbCurrentWorkingDirectory.Text = currentWorkingDirectory;
            }

            btnEliminateDuplicates.Enabled = true;
        }

        private void btnClearWorkingDirectory_Click(object sender, EventArgs e)
        {
            currentWorkingDirectory = "";
            tbCurrentWorkingDirectory.Text = "";
            btnEliminateDuplicates.Enabled = false;
        }

        private void btnEliminateDuplicates_Click(object sender, EventArgs e)
        {
            EliminateDuplicates ed = new EliminateDuplicates(this);
            ed.Show();
        }
    }
}
