using System.Collections.Generic;
using System.Windows.Forms;

namespace PhotoManager
{
    public partial class QueryDuplicates : Form
    {
        public QueryDuplicates(IList<string> list)
        {
            InitializeComponent();

            lbDuplicates.DataSource = list;
            lblDuplicates.Text = list.Count + " duplicate file(s)";
        }
    }
}
