using System;
using System.Windows.Forms;

namespace PAIN
{
    public partial class Books : Form
    {
        //private Document Document { get; set; }
        private readonly Document Document;
        public Books(Document document)
        {
            InitializeComponent();
            allToolStripButton.Checked = true;
            before2000ToolStripButton.Checked = false;
            after2000ToolStripButton.Checked = false;
            editBookToolStripMenuItem.Enabled = false;
            deleteBookToolStripMenuItem.Enabled = false;
            this.Document = document;
           // Document = document;
            Document.AddBookEvent += AddedBook;
            Document.EditBookEvent += EditedBook;
            Document.DeleteBookEvent += DeletedBook;
        }

        private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(null, Document.books);
        

            if(bookForm.ShowDialog() == DialogResult.OK)
            {
                Book newBook = new Book(bookForm.Title, bookForm.Author, bookForm.ReleaseDate, bookForm.Category);
                Document.AddBook(newBook);
                //updateStatusLabel();
            }
            //BookForm bookForm = new BookForm();
            //bookForm.MdiParent = this;
            //bookForm.Show();
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book selectedItem = (Book)booksListView.SelectedItems[0].Tag;
            BookForm bookForm = new BookForm(selectedItem, Document.books);
            if (bookForm.ShowDialog() == DialogResult.OK)
            {
                selectedItem.Title = bookForm.Title;
                selectedItem.Author = bookForm.Author;
                selectedItem.ReleaseDate = bookForm.ReleaseDate;
                selectedItem.Category = bookForm.Category;
                Document.EditBook(selectedItem);

            }
            //BookForm bookForm = new BookForm();
            //bookForm.MdiParent = this;
            //bookForm.Show();
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy jesteś pewien, że chcesz usunąć tę książkę?", "Usuwanie książki", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Book selectedItem = (Book)booksListView.SelectedItems[0].Tag;
                Document.DeleteBook(selectedItem);
            }


        }

        private void Books_Load(object sender, EventArgs e)
        {
            DeleteItems();
            LoadItems();
           // UpdateItems();
            
        }

        private void AddedBook(Book obj)
        {
            DateTime filterDate = new DateTime(2000, 1, 1);
            if (allToolStripButton.Checked || (before2000ToolStripButton.Checked && DateTime.Compare(obj.ReleaseDate, filterDate) < 0)
               || (after2000ToolStripButton.Checked && DateTime.Compare(obj.ReleaseDate, filterDate) >= 0))
            {
                //ListViewItem item = new ListViewItem();
                //item.Tag = obj;
                //UpdateItem(item);
                //booksListView.Items.Add(item);
                booksListView.Items.Add(UpdateItem(obj));
                updateStatusLabel();
            }

        }

        private void EditedBook(Book book)
        {
            DateTime filterDate = new DateTime(2000, 1, 1);
            foreach (ListViewItem item in booksListView.Items)
            {
                if((Book)item.Tag == book)
                {

                    if ((before2000ToolStripButton.Checked && DateTime.Compare(book.ReleaseDate, filterDate) >= 0)
                                || (after2000ToolStripButton.Checked && DateTime.Compare(book.ReleaseDate, filterDate) < 0))
                    {
                        booksListView.Items.Remove(item);
                    }
                    else
                    {
                        item.SubItems[0].Text = book.Title.ToString();
                        item.SubItems[1].Text = book.Author.ToString();
                        item.SubItems[2].Text = book.ReleaseDate.ToShortDateString();
                        item.SubItems[3].Text = book.Category.ToString();
                    }
                    updateStatusLabel();
                    return;
                   
                }
            }
            if ((before2000ToolStripButton.Checked && DateTime.Compare(book.ReleaseDate, filterDate) < 0)
                                || (after2000ToolStripButton.Checked && DateTime.Compare(book.ReleaseDate, filterDate) >= 0))
            {
                booksListView.Items.Add(UpdateItem(book));
                updateStatusLabel();
            }

        }

        private void DeletedBook(Book book)
        {
            foreach (ListViewItem item in booksListView.Items)
            {
                if ((Book)item.Tag == book)
                {
                    Console.WriteLine($"deleted all {((Book)item.Tag).Title}");
                    booksListView.Items.Remove(item);
                    updateStatusLabel();
                    return;
                }
            }
        }

        private void LoadItems()
        {
            foreach (Book book in Document.books)
            {
                //ListViewItem item = new ListViewItem();
                //item.Tag = book;
                //booksListView.Items.Add(item);
                booksListView.Items.Add(UpdateItem(book));
               // Console.WriteLine($"loaded items {((Book)item.Tag).Title}");
            }
            updateStatusLabel();
        }

        private void LoadItems(bool before2000)
        {
            DateTime filterDate = new DateTime(2000, 1, 1);
            //foreach (ListViewItem item in booksListView.Items)
            foreach (Book book in Document.books)
            {
                //if ((before2000 && DateTime.Compare(((Book)item.Tag).ReleaseDate, filterDate) < 0)
                //|| (!before2000 && DateTime.Compare(((Book)item.Tag).ReleaseDate, filterDate) >= 0))
                if ((before2000 && DateTime.Compare(book.ReleaseDate, filterDate) < 0)
                    || (!before2000 && DateTime.Compare(book.ReleaseDate, filterDate) >= 0))
                {
                    //Console.WriteLine($"loaded item br: {((Book)item.Tag).Title}");
                    //booksListView.Items.Add(item);
                    booksListView.Items.Add(UpdateItem(book));


                }
            }
            updateStatusLabel();

        }
        /*private void UpdateItem(ListViewItem item)
        {
            Book book = (Book)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = book.Title;
            item.SubItems[1].Text = book.Author;
            item.SubItems[2].Text = book.ReleaseDate.ToShortDateString();
            item.SubItems[3].Text = book.Category.ToString();
            Console.WriteLine($"updated {((Book)item.Tag).Title}");
        }*/

        private ListViewItem UpdateItem(Book book)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = book;
            
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = book.Title.ToString();
            item.SubItems[1].Text = book.Author.ToString();
            item.SubItems[2].Text = book.ReleaseDate.ToShortDateString();
            item.SubItems[3].Text = book.Category.ToString();
            //Console.WriteLine($"updated {((Book)item.Tag).Title}");
            return item;
        }

        /*private void UpdateItems()
        {
            booksListView.Items.Clear();
            foreach (Book book in Document.books)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = book;
                UpdateItem(item);
                booksListView.Items.Add(item);
            }
            updateStatusLabel();
        }*/

        private void DeleteItems()
        {
            booksListView.Items.Clear();
        }

        private void DeleteItems(bool before2000)
        {
            DateTime filterDate = new DateTime(2000, 1, 1);
            foreach (ListViewItem item in booksListView.Items)
            {
                if ((before2000 && DateTime.Compare(((Book)item.Tag).ReleaseDate, filterDate) < 0)
                    || (!before2000 && DateTime.Compare(((Book)item.Tag).ReleaseDate, filterDate) >= 0))
                {
                    Console.WriteLine($"deleted: {((Book)item.Tag).Title}");
                    booksListView.Items.Remove(item);
                }
            }
            updateStatusLabel();
            
        }
    

        private void updateStatusLabel()
        {
            toolStripStatusLabel1.Text = "Liczba elementów w aktywnym widoku: " + booksListView.Items.Count;
        }

        

        private void before2000ToolStripButton_Click(object sender, EventArgs e)
        {
            if(!before2000ToolStripButton.Checked)
            {
                if(after2000ToolStripButton.Checked)
                {
                    DeleteItems();
                    LoadItems(true);
                }
                else
                {
                    DeleteItems(false);
                }
                allToolStripButton.Checked = false;
                before2000ToolStripButton.Checked = true;
                after2000ToolStripButton.Checked = false;
            }
        }

        private void after2000ToolStripButton_Click(object sender, EventArgs e)
        {
            if (!after2000ToolStripButton.Checked)
            {
                if (before2000ToolStripButton.Checked)
                {
                    DeleteItems();
                    LoadItems(false);
                }
                else
                {
                    DeleteItems(true);
                }
                allToolStripButton.Checked = false;
                before2000ToolStripButton.Checked = false;
                after2000ToolStripButton.Checked = true;
            }
        }

        private void allToolStripButton_Click(object sender, EventArgs e)
        {
            if (!allToolStripButton.Checked)
            {
                if (before2000ToolStripButton.Checked == true)
                {
                    LoadItems(false);
                }
                else
                {
                    LoadItems(true);
                }
                allToolStripButton.Checked = true;
                before2000ToolStripButton.Checked = false;
                after2000ToolStripButton.Checked = false;
            }
        }

        private void Books_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(booksStatusStrip, ((MainForm)MdiParent).booksStatusStrip);
            ToolStripManager.Merge(toolStrip1, ((MainForm)MdiParent).toolStrip1);
        }

        private void Books_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)MdiParent).booksStatusStrip, booksStatusStrip);
            ToolStripManager.RevertMerge(((MainForm)MdiParent).toolStrip1, toolStrip1);
        }

        private void booksListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (booksListView.SelectedItems.Count == 1)
            {
                editBookToolStripMenuItem.Enabled = true;
                deleteBookToolStripMenuItem.Enabled = true;
            }
                
            else
            {
                editBookToolStripMenuItem.Enabled = false;
                deleteBookToolStripMenuItem.Enabled = false;
            }
                
        }

        private void Books_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Document.mdiChildrenCounter == 1 && e.CloseReason != CloseReason.MdiFormClosing)
                e.Cancel = true;
        }

        private void Books_FormClosed(object sender, FormClosedEventArgs e)
        {
            Document.mdiChildrenCounter--;
        }
    }
}
