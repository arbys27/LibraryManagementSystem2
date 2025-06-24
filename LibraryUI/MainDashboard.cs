using LibraryCommon;
using LibraryManagementSystem_Service;

namespace LibraryUI
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BookListForm bookListForm = new BookListForm();
            bookListForm.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate updateBookForm = new btnUpdate();
            updateBookForm.ShowDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBookForm deleteBookForm = new DeleteBookForm();
            deleteBookForm.ShowDialog();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.ShowDialog();
        }

        private void btnAddBook_Click_2(object sender, EventArgs e)
        {
            try
            {
                var book = new Book()
                {
                    BookNumber = int.Parse(txtBookNumber.Text),
                    Title = txtBookTitle.Text,
                    Author = txtBookAuthor.Text,
                    Year = int.Parse(txtBookYear.Text),
                    IsBorrowed = false,
                    BorrowedBy = string.Empty,
                    BorrowedDate = null
                };
                LibraryProcess.PerformAction(LibraryAction.Add, book);
                MessageBox.Show("Book added successfully.");

                txtBookNumber.Clear();
                txtBookTitle.Clear();
                txtBookAuthor.Clear();
                txtBookYear.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBorrowBookNumber.Text, out int bookNo))
                {
                    MessageBox.Show("Invalid book number.");
                    return;
                }

                string borrower = txtBorrowerName.Text.Trim();
                if (string.IsNullOrWhiteSpace(borrower))
                {
                    MessageBox.Show("Please enter the borrower's name.");
                    return;
                }

                bool success = LibraryProcess.BorrowBook(bookNo, borrower);
                MessageBox.Show(success ? "Book borrowed successfully." : "Failed to borrow. Book might already be borrowed.");

                txtBorrowBookNumber.Clear();
                txtBorrowerName.Clear();
                txtBorrowBookTitle.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
