using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace PAIN
{
    public partial class CategoryControl : UserControl
    {
        [Browsable(true)]
        [Editor(typeof(CategoryControlVSEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public BookCategory CurrentCategory { get { return currentCategory; } set { currentCategory = value; Invalidate(); } }
        private BookCategory currentCategory;

        public event Action<BookCategory> GenreChanged;

        public CategoryControl()
        {
            currentCategory = BookCategory.poezja;
            InitializeComponent();
        }

        private void bookCategoryControl_Load(object sender, EventArgs e)
        {
            GenreChanged?.Invoke(currentCategory);
            Invalidate();
        }

        private void bookCategoryControl_Click(object sender, EventArgs e)
        {
            currentCategory = NextbookCategory();
            GenreChanged?.Invoke(currentCategory);
            Invalidate();
        }

        private BookCategory NextbookCategory(BookCategory currentCategory)
        {
            return (BookCategory)(((int)currentCategory + 1) % 3);
        }

        private BookCategory NextbookCategory()
        {
            return NextbookCategory(currentCategory);
        }

        private Bitmap GetBookCategoryImage(BookCategory currentCategory)
        {
            switch (currentCategory)
            {
                case BookCategory.poezja:
                    return Properties.Resources.poezja;
                case BookCategory.fantastyka:
                    return Properties.Resources.fantastyka;
                case BookCategory.kryminal:
                    return Properties.Resources.kryminal;
            }
            return null;
        }
    }

    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]


    public class CategoryControlVSEditor : UITypeEditor
    {

    }

}
