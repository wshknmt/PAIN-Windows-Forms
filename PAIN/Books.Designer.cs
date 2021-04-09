namespace PAIN
{
    partial class Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.booksListView = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReleaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.allToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.before2000ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.after2000ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.booksListView);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(585, 262);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(585, 346);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(585, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(108, 17);
            this.toolStripStatusLabel1.Text = "Liczba elementów: ";
            // 
            // booksListView
            // 
            this.booksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderAuthor,
            this.columnHeaderReleaseDate,
            this.columnHeaderCategory});
            this.booksListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksListView.HideSelection = false;
            this.booksListView.Location = new System.Drawing.Point(0, 0);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(585, 262);
            this.booksListView.TabIndex = 3;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Tytuł";
            this.columnHeaderTitle.Width = 112;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Autor";
            this.columnHeaderAuthor.Width = 85;
            // 
            // columnHeaderReleaseDate
            // 
            this.columnHeaderReleaseDate.Text = "Data wydania";
            this.columnHeaderReleaseDate.Width = 93;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Kategoria";
            this.columnHeaderCategory.Width = 116;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookToolStripMenuItem,
            this.editBookToolStripMenuItem,
            this.deleteBookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newBookToolStripMenuItem
            // 
            this.newBookToolStripMenuItem.Name = "newBookToolStripMenuItem";
            this.newBookToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.newBookToolStripMenuItem.Text = "Dodaj nową książkę";
            this.newBookToolStripMenuItem.Click += new System.EventHandler(this.newBookToolStripMenuItem_Click);
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            this.editBookToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.editBookToolStripMenuItem.Text = "Edytuj wybraną książkę";
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.deleteBookToolStripMenuItem.Text = "Usuń wybraną książkę";
            this.deleteBookToolStripMenuItem.Click += new System.EventHandler(this.deleteBookToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripButton,
            this.before2000ToolStripButton,
            this.after2000ToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(489, 38);
            this.toolStrip1.TabIndex = 1;
            // 
            // allToolStripButton
            // 
            this.allToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("allToolStripButton.Image")));
            this.allToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.allToolStripButton.Name = "allToolStripButton";
            this.allToolStripButton.Size = new System.Drawing.Size(99, 35);
            this.allToolStripButton.Text = "Wszystkie książki";
            this.allToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.allToolStripButton.Click += new System.EventHandler(this.allToolStripButton_Click);
            // 
            // before2000ToolStripButton
            // 
            this.before2000ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("before2000ToolStripButton.Image")));
            this.before2000ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.before2000ToolStripButton.Name = "before2000ToolStripButton";
            this.before2000ToolStripButton.Size = new System.Drawing.Size(172, 35);
            this.before2000ToolStripButton.Text = "Książki wydane przed 2000r.";
            this.before2000ToolStripButton.Click += new System.EventHandler(this.before2000ToolStripButton_Click);
            // 
            // after2000ToolStripButton
            // 
            this.after2000ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("after2000ToolStripButton.Image")));
            this.after2000ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.after2000ToolStripButton.Name = "after2000ToolStripButton";
            this.after2000ToolStripButton.Size = new System.Drawing.Size(175, 35);
            this.after2000ToolStripButton.Text = "Książki wydane w i po 2000r.";
            this.after2000ToolStripButton.Click += new System.EventHandler(this.after2000ToolStripButton_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 346);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Books";
            this.Text = "Książki";
            this.Load += new System.EventHandler(this.Books_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListView booksListView;
        private System.Windows.Forms.ToolStripMenuItem newBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton allToolStripButton;
        private System.Windows.Forms.ToolStripButton before2000ToolStripButton;
        private System.Windows.Forms.ToolStripButton after2000ToolStripButton;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.ColumnHeader columnHeaderReleaseDate;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
    }
}