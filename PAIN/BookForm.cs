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
    public partial class BookForm : Form
    {
        private Book book;
        private List<Book> books;
        enum bookCategory { poezja, fantastyka, kryminal}
        bookCategory currentBookCategory = bookCategory.poezja;

        public string Title
        {
            get { return titleTextBox.Text; }
        }

        public string Author
        {
            get { return authorTextBox.Text; }
        }

        public DateTime ReleaseDate
        {
            get { return releaseDateTimePicker.Value; }
        }

        public string Category
        {
            get { return categoryComboBox.Text; }
        }
        public BookForm(Book book, List<Book> books)
        {
            InitializeComponent();
            this.book = book;
            this.books = books;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            //this.Close();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.categoryComboBox.SelectedIndex)
            {
                case 0:
                    this.categoryPictureBox.Image = global::PAIN.Properties.Resources.poezja;
                    break;
                case 1:
                    this.categoryPictureBox.Image = global::PAIN.Properties.Resources.fantastyka;
                    break;
                case 2:
                    this.categoryPictureBox.Image = global::PAIN.Properties.Resources.kryminal;
                    break;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void titleTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (titleTextBox.Text == "")
                    throw new Exception("Książka musi posiadać tytuł");
            }
            catch(Exception exception)
            {
                e.Cancel = true;
                errorProvider.SetError(titleTextBox, exception.Message);
            }
        }

        private void titleTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(titleTextBox, "");
        }

        private void authorTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (authorTextBox.Text == "")
                    throw new Exception("Książka musi posiadać autora");
            }
            catch (Exception exception)
            {
                e.Cancel = true;
                errorProvider.SetError(authorTextBox, exception.Message);
            }
        }

        private void authorTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(authorTextBox, "");
        }

        private void categoryPictureBox_Click(object sender, EventArgs e)
        {
            currentBookCategory = (bookCategory)(((int)currentBookCategory + 1) % 3);
            if (currentBookCategory.Equals(bookCategory.poezja))
            {
                this.categoryPictureBox.Image = global::PAIN.Properties.Resources.poezja;
                this.categoryComboBox.SelectedIndex = 0;
            }
            else if (currentBookCategory.Equals(bookCategory.fantastyka))
            {
                this.categoryPictureBox.Image = global::PAIN.Properties.Resources.fantastyka;
                this.categoryComboBox.SelectedIndex = 1;
            }
            else if (currentBookCategory.Equals(bookCategory.kryminal))
            {
                this.categoryPictureBox.Image = global::PAIN.Properties.Resources.kryminal;
                this.categoryComboBox.SelectedIndex = 2;
            }
        }

        private void categoryComboBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (categoryComboBox.SelectedIndex != 0 && categoryComboBox.SelectedIndex != 1 && 
                    categoryComboBox.SelectedIndex != 2 /*|| categoryComboBox.Text == ""*/)
                    throw new Exception("Należy wybrać 1 z 3 kategorii");
            }
            catch (Exception exception)
            {
                e.Cancel = true;
                errorProvider.SetError(categoryComboBox, exception.Message);
            }
        }

        private void categoryComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(categoryComboBox, "");
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            if (book != null)
            {
                titleTextBox.Text = book.Title;
                authorTextBox.Text = book.Author;
                releaseDateTimePicker.Value = book.ReleaseDate;
                if (book.Category == "poezja") categoryComboBox.SelectedIndex = 0;
                else if (book.Category == "fantastyka") categoryComboBox.SelectedIndex = 1;
                else if (book.Category == "kryminał") categoryComboBox.SelectedIndex = 2;
                
            }
            else
            {
                titleTextBox.Text = "Tytuł";
                authorTextBox.Text = "Jan Kowalski";
                releaseDateTimePicker.Value = new DateTime(1980, 1, 1);
            }
        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
