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
    public partial class ReturnBookForm : Form
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBookNumber.Text.Trim(), out int bookNumber))
                {
                    MessageBox.Show("Please enter a valid Book Number.");
                    return;
                }

                var book = LibraryProcess.GetBooks()
                                         .FirstOrDefault(b => b.BookNumber == bookNumber);

                if (book == null)
                {
                    MessageBox.Show("Book not found.");
                    return;
                }

                if (!book.IsBorrowed)
                {
                    MessageBox.Show("This book is not currently borrowed.");
                    return;
                }

                var confirm = MessageBox.Show(
                    $"Are you sure you want to return:\n\nTitle: {book.Title}\nBorrowed By: {book.BorrowedBy}",
                    "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    bool success = LibraryProcess.ReturnBook(bookNumber);

                    if (success)
                    {
                        MessageBox.Show("Book returned successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to return the book.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    
}
