namespace LibraryUI
{
    partial class MainDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnAddBook = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtBookYear = new TextBox();
            label5 = new Label();
            txtBookAuthor = new TextBox();
            label4 = new Label();
            txtBookTitle = new TextBox();
            label3 = new Label();
            txtBookNumber = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnBooks = new Button();
            panel2 = new Panel();
            btnReturn = new Button();
            btnBorrow = new Button();
            txtBorrowBookTitle = new TextBox();
            lblBorrowBookTitle = new Label();
            txtBorrowerName = new TextBox();
            lblName = new Label();
            lblBorrowBook = new Label();
            label8 = new Label();
            txtBorrowBookNumber = new TextBox();
            label9 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnAddBook);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(txtBookYear);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBookAuthor);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBookTitle);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBookNumber);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(70, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 263);
            panel1.TabIndex = 0;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBook.Location = new Point(16, 217);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(87, 34);
            btnAddBook.TabIndex = 12;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click_2;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(224, 214);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 37);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete Book";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(115, 214);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 37);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update Book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBookYear
            // 
            txtBookYear.Location = new Point(109, 168);
            txtBookYear.Name = "txtBookYear";
            txtBookYear.Size = new Size(186, 23);
            txtBookYear.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 169);
            label5.Name = "label5";
            label5.Size = new Size(46, 22);
            label5.TabIndex = 7;
            label5.Text = "Year:";
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Location = new Point(109, 128);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(186, 23);
            txtBookAuthor.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 129);
            label4.Name = "label4";
            label4.Size = new Size(63, 22);
            label4.TabIndex = 5;
            label4.Text = "Author:";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(109, 88);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(186, 23);
            txtBookTitle.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 89);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 3;
            label3.Text = "Title:";
            // 
            // txtBookNumber
            // 
            txtBookNumber.Location = new Point(109, 50);
            txtBookNumber.Name = "txtBookNumber";
            txtBookNumber.Size = new Size(186, 23);
            txtBookNumber.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 51);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 1;
            label2.Text = "Book No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(70, 27);
            label1.TabIndex = 0;
            label1.Text = "Books";
            // 
            // btnBooks
            // 
            btnBooks.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.Location = new Point(948, 559);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(82, 37);
            btnBooks.TabIndex = 12;
            btnBooks.Text = "Records";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(btnBorrow);
            panel2.Controls.Add(txtBorrowBookTitle);
            panel2.Controls.Add(lblBorrowBookTitle);
            panel2.Controls.Add(txtBorrowerName);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(lblBorrowBook);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtBorrowBookNumber);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(691, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 263);
            panel2.TabIndex = 12;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(181, 214);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(103, 37);
            btnReturn.TabIndex = 18;
            btnReturn.Text = "Return Book";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnBorrow
            // 
            btnBorrow.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrow.Location = new Point(52, 214);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(101, 37);
            btnBorrow.TabIndex = 14;
            btnBorrow.Text = "Borrow Book";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // txtBorrowBookTitle
            // 
            txtBorrowBookTitle.Location = new Point(109, 150);
            txtBorrowBookTitle.Name = "txtBorrowBookTitle";
            txtBorrowBookTitle.Size = new Size(186, 23);
            txtBorrowBookTitle.TabIndex = 17;
            // 
            // lblBorrowBookTitle
            // 
            lblBorrowBookTitle.AutoSize = true;
            lblBorrowBookTitle.BackColor = Color.Transparent;
            lblBorrowBookTitle.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBorrowBookTitle.Location = new Point(28, 153);
            lblBorrowBookTitle.Name = "lblBorrowBookTitle";
            lblBorrowBookTitle.Size = new Size(48, 22);
            lblBorrowBookTitle.TabIndex = 16;
            lblBorrowBookTitle.Text = "Title:";
            // 
            // txtBorrowerName
            // 
            txtBorrowerName.Location = new Point(109, 107);
            txtBorrowerName.Name = "txtBorrowerName";
            txtBorrowerName.Size = new Size(186, 23);
            txtBorrowerName.TabIndex = 15;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(28, 108);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 22);
            lblName.TabIndex = 14;
            lblName.Text = "Name:";
            // 
            // lblBorrowBook
            // 
            lblBorrowBook.AutoSize = true;
            lblBorrowBook.BackColor = Color.Transparent;
            lblBorrowBook.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBorrowBook.Location = new Point(15, 8);
            lblBorrowBook.Name = "lblBorrowBook";
            lblBorrowBook.Size = new Size(138, 27);
            lblBorrowBook.TabIndex = 13;
            lblBorrowBook.Text = "Borrow Book";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 89);
            label8.Name = "label8";
            label8.Size = new Size(77, 22);
            label8.TabIndex = 3;
            label8.Text = "Borrower";
            // 
            // txtBorrowBookNumber
            // 
            txtBorrowBookNumber.Location = new Point(109, 50);
            txtBorrowBookNumber.Name = "txtBorrowBookNumber";
            txtBorrowBookNumber.Size = new Size(186, 23);
            txtBorrowBookNumber.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 51);
            label9.Name = "label9";
            label9.Size = new Size(75, 22);
            label9.TabIndex = 1;
            label9.Text = "Book No:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(28, 107);
            label11.Name = "label11";
            label11.Size = new Size(56, 22);
            label11.TabIndex = 12;
            label11.Text = "Name:";
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LibraryBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1124, 624);
            Controls.Add(panel2);
            Controls.Add(btnBooks);
            Controls.Add(panel1);
            Name = "MainDashboard";
            Text = "MainDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtBookYear;
        private Label label5;
        private TextBox txtBookAuthor;
        private Label label4;
        private TextBox txtBookTitle;
        private Label label3;
        private TextBox txtBookNumber;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnBooks;
        private Panel panel2;
        private Button btnAddBook;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private TextBox txtBorrowBookNumber;
        private Label label9;
        private Label label11;
        
        private Button btnReturn;
        private Button btnBorrow;
        private TextBox txtBorrowBookTitle;
        private Label lblBorrowBookTitle;
        private TextBox txtBorrowerName;
        private Label lblName;
        private Label lblBorrowBook;
    }
}
