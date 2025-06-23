using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryCommon; 
using LibraryManagementSystem_Service;

namespace LibraryUI
{
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();
            LoadBooks();
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(txtSearch.Text); // Reload filtered books as you type
        }
        private void LoadBooks(string search = "")
        {
            var books = LibraryProcess.GetBooks();


            if (!string.IsNullOrWhiteSpace(search))
            {
                books = books.Where(b => b.Title.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = books;
        }
    }
}
