using LibraryCommon;
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
    public partial class DeleteBookForm : Form
    {
        public DeleteBookForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBookNumber.Text, out int bookNumber))
                {
                    MessageBox.Show("Invalid book number.");
                    return;
                }

                var book = LibraryProcess.GetBooks()
                                         .FirstOrDefault(b => b.BookNumber == bookNumber);

                if (book == null)
                {
                    MessageBox.Show("Book not found.");
                    return;
                }

                var result = MessageBox.Show($"Are you sure you want to delete \"{book.Title}\"?",
                                             "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    LibraryProcess.PerformAction(LibraryAction.Delete, book);
                    MessageBox.Show("Book deleted successfully.");
                    this.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
    
    
}
