using LibraryManagementSystem_Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI
{
    public partial class btnUpdate : Form
    {
        public btnUpdate()
        {
            InitializeComponent();
        }

        private void UpdateBookForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateBooks_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBookNumber.Text, out int bookNumber))
                {
                    MessageBox.Show("Invalid Book Number.");
                    return;
                }

                var existingBook = LibraryProcess.GetBooks()
                                                 .FirstOrDefault(b => b.BookNumber == bookNumber);

                if (existingBook == null)
                {
                    MessageBox.Show("Book not found.");
                    return;
                }

                string newTitle = txtTitle.Text.Trim();
                string newAuthor = txtAuthor.Text.Trim();
                if (!int.TryParse(txtYear.Text, out int newYear))
                {
                    MessageBox.Show("Invalid Year.");
                    return;
                }

                existingBook.Title = newTitle;
                existingBook.Author = newAuthor;
                existingBook.Year = newYear;

                bool success = LibraryProcess.PerformAction(LibraryAction.Update, existingBook);

                if (success)
                {
                    MessageBox.Show("Book updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}

