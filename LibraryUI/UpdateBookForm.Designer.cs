namespace LibraryUI
{
    partial class btnUpdate
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
            label1 = new Label();
            label2 = new Label();
            txtBookNumber = new TextBox();
            txtTitle = new TextBox();
            label3 = new Label();
            txtYear = new TextBox();
            label4 = new Label();
            txtAuthor = new TextBox();
            label5 = new Label();
            btnUpdateBooks = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(123, 24);
            label1.TabIndex = 0;
            label1.Text = "Update Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 80);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Book No:";
            // 
            // txtBookNumber
            // 
            txtBookNumber.Location = new Point(132, 77);
            txtBookNumber.Name = "txtBookNumber";
            txtBookNumber.Size = new Size(210, 23);
            txtBookNumber.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(132, 115);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(210, 23);
            txtTitle.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 118);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "New Title:";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(132, 191);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(210, 23);
            txtYear.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 194);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "New Year:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(132, 153);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(210, 23);
            txtAuthor.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 156);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 5;
            label5.Text = "New Author:";
            // 
            // btnUpdateBooks
            // 
            btnUpdateBooks.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateBooks.Location = new Point(200, 233);
            btnUpdateBooks.Name = "btnUpdateBooks";
            btnUpdateBooks.Size = new Size(75, 31);
            btnUpdateBooks.TabIndex = 9;
            btnUpdateBooks.Text = "Update";
            btnUpdateBooks.UseVisualStyleBackColor = true;
            btnUpdateBooks.Click += btnUpdateBooks_Click;
            // 
            // btnUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LibraryBG;
            ClientSize = new Size(391, 289);
            Controls.Add(btnUpdateBooks);
            Controls.Add(txtYear);
            Controls.Add(label4);
            Controls.Add(txtAuthor);
            Controls.Add(label5);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(txtBookNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "btnUpdate";
            Text = "UpdateBookForm";
            Load += UpdateBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBookNumber;
        private TextBox txtTitle;
        private Label label3;
        private TextBox txtYear;
        private Label label4;
        private TextBox txtAuthor;
        private Label label5;
        private Button btnUpdateBooks;
    }
}