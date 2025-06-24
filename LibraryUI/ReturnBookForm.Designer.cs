namespace LibraryUI
{
    partial class ReturnBookForm
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
            txtBookNumber = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // txtBookNumber
            // 
            txtBookNumber.Location = new Point(124, 75);
            txtBookNumber.Name = "txtBookNumber";
            txtBookNumber.Size = new Size(174, 23);
            txtBookNumber.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 78);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Book No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(120, 24);
            label1.TabIndex = 4;
            label1.Text = "Return Book";
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(168, 114);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 31);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // ReturnBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 189);
            Controls.Add(btnReturn);
            Controls.Add(txtBookNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReturnBookForm";
            Text = "ReturnBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBookNumber;
        private Label label2;
        private Label label1;
        private Button btnReturn;
    }
}