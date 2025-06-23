namespace LibraryUI
{
    partial class BookListForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookListForm));
            txtSearch = new TextBox();
            label1 = new Label();
            dataGridViewBooks = new DataGridView();
            libraryDBDataServiceBindingSource = new BindingSource(components);
            colBookNumber = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colIsBorrowed = new DataGridViewTextBoxColumn();
            colBorrowedBy = new DataGridViewTextBoxColumn();
            colBorrowedDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)libraryDBDataServiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(549, 70);
            txtSearch.MaximumSize = new Size(227, 28);
            txtSearch.MinimumSize = new Size(227, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(227, 25);
            txtSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(479, 70);
            label1.Name = "label1";
            label1.Size = new Size(67, 22);
            label1.TabIndex = 1;
            label1.Text = "Search:";
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AllowUserToDeleteRows = false;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { colBookNumber, colTitle, colAuthor, colYear, colIsBorrowed, colBorrowedBy, colBorrowedDate });
            dataGridViewBooks.Location = new Point(62, 99);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.Size = new Size(740, 448);
            dataGridViewBooks.TabIndex = 2;
            // 
            // libraryDBDataServiceBindingSource
            // 
            libraryDBDataServiceBindingSource.DataSource = typeof(LibraryDataService.LibraryDBDataService);
            // 
            // colBookNumber
            // 
            colBookNumber.DataPropertyName = "BookNumber";
            colBookNumber.HeaderText = "BookNumber";
            colBookNumber.Name = "colBookNumber";
            colBookNumber.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.DataPropertyName = "Title";
            colTitle.HeaderText = "Title";
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colAuthor
            // 
            colAuthor.DataPropertyName = "Author";
            colAuthor.HeaderText = "Author";
            colAuthor.Name = "colAuthor";
            colAuthor.ReadOnly = true;
            // 
            // colYear
            // 
            colYear.DataPropertyName = "Year";
            colYear.HeaderText = "Year";
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            // 
            // colIsBorrowed
            // 
            colIsBorrowed.DataPropertyName = "IsBorrowed";
            colIsBorrowed.HeaderText = "BorrowStatus";
            colIsBorrowed.Name = "colIsBorrowed";
            colIsBorrowed.ReadOnly = true;
            // 
            // colBorrowedBy
            // 
            colBorrowedBy.DataPropertyName = "BorrowedBy";
            colBorrowedBy.HeaderText = "BorrowedBy";
            colBorrowedBy.Name = "colBorrowedBy";
            colBorrowedBy.ReadOnly = true;
            // 
            // colBorrowedDate
            // 
            colBorrowedDate.DataPropertyName = "BorrowedDate";
            colBorrowedDate.HeaderText = "BorrowedDate";
            colBorrowedDate.Name = "colBorrowedDate";
            colBorrowedDate.ReadOnly = true;
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(868, 596);
            Controls.Add(dataGridViewBooks);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Name = "BookListForm";
            Text = "BookListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)libraryDBDataServiceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label label1;
        private DataGridView dataGridViewBooks;
        private BindingSource libraryDBDataServiceBindingSource;
        private DataGridViewTextBoxColumn colBookNumber;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colIsBorrowed;
        private DataGridViewTextBoxColumn colBorrowedBy;
        private DataGridViewTextBoxColumn colBorrowedDate;
    }
}