namespace LibraryUI
{
    partial class DeleteBookForm
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
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(118, 24);
            label1.TabIndex = 0;
            label1.Text = "Delete Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 78);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Book No:";
            // 
            // txtBookNumber
            // 
            txtBookNumber.Location = new Point(117, 75);
            txtBookNumber.Name = "txtBookNumber";
            txtBookNumber.Size = new Size(174, 23);
            txtBookNumber.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(165, 115);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 28);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // DeleteBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 189);
            Controls.Add(btnDelete);
            Controls.Add(txtBookNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeleteBookForm";
            Text = "DeleteBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBookNumber;
        private Button btnDelete;
    }
}