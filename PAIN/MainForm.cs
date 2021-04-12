using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN
{
    public partial class MainForm : Form
    {
        Document document = new Document();
        public MainForm()
        {
            InitializeComponent();
        }

        private void noweOknoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books books = new Books(document);
            books.MdiParent = this;
            document.mdiChildrenCounter++;
            books.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Books books = new Books(document);
            books.MdiParent = this;
            document.mdiChildrenCounter++;
            books.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
