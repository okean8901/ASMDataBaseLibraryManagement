using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ASM_library_management_database
{
    public partial class BookManagement : Form
    {
        SqlConnection connection;

        public BookManagement()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-NB4LK8U\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
        }
        public BookManagement(string username)
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-NB4LK8U\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Dispose();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to exit?", " Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void dgvBookManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void lblTitleError_Click(object sender, EventArgs e)
        {

        }
        private void BookManagement_Load(object sender, EventArgs e)
        {
            connection.Open();
            FilldataCategory();
            Filldata();
            FilldataAuthor();
            FilldataBorrow();
            FilldataReturn();
            FilldataStudents();
            FilldataMemberCards();
            FilldataBookAuthor();
            FilldataBookDescription();
            GetCategories();
            GetAuthor();
            GetStudents();
            GetBookId();
            GetCardId();
            GetBorrowId();
            GetBookIdDes();
        }

        private void FilldataCategory()
        {
            string queryCategory = "select * from categories";
            DataTable tblCategory = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(queryCategory, connection);
            ad.Fill(tblCategory);
            dgvCategory.DataSource = tblCategory;
            connection.Close();
        }
        public void Filldata()
        {
            string query = "select * from books";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dgvBookManagement.DataSource = tbl;
            connection.Close();
        }

        public void FilldataAuthor()
        {
            string queryAuthor = "select *from authors";
            DataTable tblAuthor = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(queryAuthor, connection);
            ad.Fill(tblAuthor);
            dgvAuthor.DataSource = tblAuthor;
            connection.Close();
        }
        public void FilldataBorrow()
        {
            string queryBorrow = "select *from borrowings";
            DataTable tblBorrow = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(queryBorrow, connection);
            ad.Fill(tblBorrow);
            dgvBorrow.DataSource = tblBorrow;
            connection.Close();
        }
        public void FilldataReturn()
        {
            string queryReturn = "select *from returns";
            DataTable tblReturn = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(queryReturn, connection);
            ad.Fill(tblReturn);
            dgvReturn.DataSource = tblReturn;
            connection.Close();
        }
        public void FilldataStudents()
        {
            string queryStudents = "select *from students";
            DataTable tblStudents = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(queryStudents, connection);
            ad.Fill(tblStudents);
            dgvStudents.DataSource = tblStudents;
            connection.Close();
        }
        public void FilldataMemberCards()
        {
            string queryMemberCards = "select * from member_cards";
            DataTable tblMemberCards = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(queryMemberCards, connection);
            ad.Fill(tblMemberCards);
            dgvMemberCards.DataSource = tblMemberCards;
            connection.Close();
        }
        public void FilldataBookAuthor()
        {
            string queryBookAuthor = "select * from book_authors";
            DataTable tblBookAuthor = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(queryBookAuthor, connection);
            ad.Fill(tblBookAuthor);
            dgvBookAuthor.DataSource = tblBookAuthor;
            connection.Close();

        }
        public void FilldataBookDescription()
        {
            string queryBookDescription = "select * from book_descriptions";
            DataTable tblBookDescription = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(queryBookDescription, connection);
            ad.Fill(tblBookDescription);
            dgvBookDescription.DataSource = tblBookDescription;
            connection.Close();
        }

        public void GetCategories()
        {
            string query = "select category_id, category_name from categories";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(table);
            cbxCategoryId.DataSource = table;
            cbxCategoryId.DisplayMember = "category_name";
            cbxCategoryId.ValueMember = "category_id";
        }
        public void GetAuthor()
        {
            string query = "select author_id, first_name, last_name from authors";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(table);
            cbxAuthor.DataSource = table;
            cbxAuthor.DisplayMember = "first_name";
            cbxAuthor.DisplayMember = "last_name";
            cbxAuthor.ValueMember = "author_id";
        }
        public void GetStudents()
        {
            string queryStudents = "select student_id, student_name, student_code from students";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(queryStudents, connection);
            adapter.Fill(table);
            cbxStudentId.DataSource = table;
            cbxStudentId.DisplayMember = "student_name";
            cbxStudentId.DisplayMember = "student_code";
            cbxStudentId.ValueMember = "student_id";
        }


        public void GetBorrowId()
        {
            string queryBorrowId = "select borrow_id, book_id, card_id, borrow_date from borrowings";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(queryBorrowId, connection);
            adapter.Fill(table);
            cbxBorrowId.DataSource = table;
            cbxBorrowId.DisplayMember = "borrow_date_card_id";
            cbxBorrowId.ValueMember = "borrow_id";
        }
        public void GetBookIdDes()
        {

            string queryBookIdDes = "select book_id, book_name, title, author_id, category_id, quantity from books";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(queryBookIdDes, connection);
            adapter.Fill(table);
            cbxBookIdDes.DataSource = table;
            cbxBookIdDes.DisplayMember = "book_name_title";
            cbxBookIdDes.ValueMember = "book_id";
        }
        public void GetBookId()
        {

            string queryBookId = "select book_id, book_name, title, author_id, category_id, quantity from books";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(queryBookId, connection);
            adapter.Fill(table);

            table.Columns.Add("book_name_author_id", typeof(string), "book_name + ' - ' + author_id");

            cbxBookId.DataSource = table;
            cbxBookId.DisplayMember = "book_name_author_id";
            cbxBookId.ValueMember = "book_id";
        }
        public void GetCardId()
        {

            string queryCardId = "select student_id, card_id, member_name, address, phone_number, email from member_cards";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(queryCardId, connection);
            adapter.Fill(table);

            table.Columns.Add("card_id_member_name", typeof(string), "card_id + '-' + member_name");

            cbxCardId.DataSource = table;
            cbxCardId.DisplayMember = "card_id_member_name";
            cbxCardId.ValueMember = "card_id";
        }

        //public void GetCardid ()
        //{
        //    string querycard = "select student_id, card_id, member_name, address, phone_number, email from membercard";
        //    DataTable table = new DataTable();
        //    SqlDataAdapter adapter = new SqlDataAdapter( querycard, connection);
        //    cbxCardId.DataBindings.DefaultDataSourceUpdateMode
        //}

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int error = 0;

            string BookID = txbBookId.Text;
            if (BookID.Equals(""))
            {
                error = error + 1;
                lblBookIdError.Text = "Book ID can not be blank";
            }
            else
                lblBookIdError.Text = "";

            string BookName = txbBookName.Text;
            if (BookName.Equals(""))
            {
                error = error + 1;
                lblBookNameError.Text = "Book Name can not be blank";
            }
            else
                lblBookNameError.Text = "";

            string Title = txbTitle.Text;
            if (Title.Equals(""))
            {
                error = error + 1;
                lblTitleError.Text = "Title can not be blank";
            }
            else
                lblTitleError.Text = "";

            string Quantity = txbQuantity.Text;
            if (Quantity.Equals(""))
            {
                error = error + 1;
                lblQuantityError.Text = "Quantity can not be blank";
            }
            else
            {
                string query = "select * from books where book_id = @BookID";
                connection.Open();
                SqlCommand cmdcheck = new SqlCommand(query, connection);
                cmdcheck.Parameters.Add("@BookID", SqlDbType.VarChar);
                cmdcheck.Parameters["@BookID"].Value = BookID;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lblBookIdError.Text = "This ID is existing,please choose another ";

                }
                else
                {
                    lblQuantityError.Text = "";
                }
                reader.Close();
                connection.Close();

                string AuthorID = cbxAuthor.SelectedValue.ToString();
                string CategoryID = cbxCategoryId.SelectedValue.ToString();
                if (error == 0)
                {
                    string insert = "insert into books values  (@BookID,@BookName,@Title,@CategoryID,@Quantity,@AuthorID)";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(insert, connection);
                    cmd.Parameters.Add("@BookID", SqlDbType.NChar);
                    cmd.Parameters["@BookID"].Value = BookID;

                    cmd.Parameters.Add("@BookName", SqlDbType.NVarChar);
                    cmd.Parameters["@BookName"].Value = BookName;

                    cmd.Parameters.Add("@Title", SqlDbType.NVarChar);
                    cmd.Parameters["@Title"].Value = Title;

                    cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                    cmd.Parameters["@Quantity"].Value = Convert.ToInt32(Quantity);

                    cmd.Parameters.Add("@AuthorID", SqlDbType.NChar);
                    cmd.Parameters["@AuthorID"].Value = AuthorID;

                    cmd.Parameters.Add("@CategoryID", SqlDbType.NChar);
                    cmd.Parameters["@CategoryID"].Value = CategoryID;

                    cmd.ExecuteNonQuery();
                    Filldata();
                    MessageBox.Show(this, "Insert successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                int selectAuthorID = Convert.ToInt32(cbxAuthor.SelectedValue);
                int selectCategoryID = Convert.ToInt32(cbxCategoryId.SelectedValue);
                string edit = "UPDATE books SET book_name = @BookName, title = @Title, quantity = @Quantity, author_id = @AuthorID" + " WHERE book_id = @BookID AND category_id = @CategoryID";
                connection.Open();
                SqlCommand cmd3 = new SqlCommand(edit, connection);
                cmd3.Parameters.Add("@BookId", SqlDbType.NChar);
                cmd3.Parameters["@BookID"].Value = txbBookId.Text;

                cmd3.Parameters.Add("@BookName", SqlDbType.VarChar);
                cmd3.Parameters["@BookName"].Value = txbBookName.Text;

                cmd3.Parameters.Add("@Title", SqlDbType.NVarChar);
                cmd3.Parameters["@Title"].Value = txbTitle.Text;

                cmd3.Parameters.Add("@Quantity", SqlDbType.Int);
                cmd3.Parameters["@Quantity"].Value = int.Parse(txbQuantity.Text);

                cmd3.Parameters.Add("@AuthorID", SqlDbType.NChar);
                cmd3.Parameters["@AuthorID"].Value = selectAuthorID;

                cmd3.Parameters.Add("@CategoryID", SqlDbType.NChar);
                cmd3.Parameters["@CategoryID"].Value = selectCategoryID;

                int i = cmd3.ExecuteNonQuery();
                if (i > 0)
                {
                    Filldata();
                    MessageBox.Show(this, "Update successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                connection.Open();
            string delete = "delete from books where book_id = @BookID";
            SqlCommand cmd = new SqlCommand(delete, connection);
            cmd.Parameters.Add("@BookID", SqlDbType.NChar);
            cmd.Parameters["@BookID"].Value = txbBookId.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            Filldata();
            MessageBox.Show(this, "Delete successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbxAuthor.Text = "";
            txbBookId.Text = "";
            txbBookName.Text = "";
            txbQuantity.Text = "";
            txbTitle.Text = "";
            cbxCategoryId.Text = "";
        }
        private void dgvBookManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBookManagement.Rows[e.RowIndex];
                txbTitle.Text = row.Cells["title"].Value.ToString();
                txbBookId.Text = row.Cells["book_id"].Value.ToString();
                txbBookName.Text = row.Cells["book_name"].Value.ToString();
                txbQuantity.Text = row.Cells["quantity"].Value.ToString();
                cbxAuthor.SelectedValue = row.Cells["author_id"].Value.ToString();
                cbxCategoryId.SelectedValue = row.Cells["category_id"].Value.ToString();
            }
        }

        private void btnInsertAuthor_Click(object sender, EventArgs e)
        {

            int error = 0;
            string AuthorID = txbAuthorID.Text;
            if (AuthorID.Equals(""))
            {
                error = error + 1;
                lblAuthorIdEr.Text = "Author ID can not be blank";

            }
            else
                lblAuthorIdEr.Text = "";

            string FirstName = txbFirstName.Text;
            if (FirstName.Equals(""))
            {
                error = error + 1;
                lblFirstNameEr.Text = "First name can not be blank";
            }
            else
                lblFirstNameEr.Text = "";


            string LastName = txbLastName.Text.ToString();
            if (LastName.Equals(""))
            {
                error = error + 1;
                lblLastNameEr.Text = "Last name can not be blank";

            }
            else
            {
                string insert = "insert into authors values (@AuthorID,@FirstName, @LastName)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(insert, connection);
                cmd.Parameters.Add("@AuthorID", SqlDbType.NChar);
                cmd.Parameters["@AuthorID"].Value = AuthorID;

                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar);
                cmd.Parameters["@FirstName"].Value = FirstName;

                cmd.Parameters.Add("@LastName", SqlDbType.NChar);
                cmd.Parameters["@LastName"].Value = LastName;

                cmd.ExecuteNonQuery();
                FilldataAuthor();
                MessageBox.Show(this, "Insert successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEditAuthor_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {

                string update = "update authors set first_name =@FirstName, last_name = @LastName"
                    + " where author_id = @AuthorID";
                connection.Open();
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar);
                cmd.Parameters["@FirstName"].Value = txbFirstName.Text;

                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar);
                cmd.Parameters["@LastName"].Value = txbLastName.Text;

                cmd.Parameters.Add("@AuthorID", SqlDbType.NChar);
                cmd.Parameters["@AuthorID"].Value = txbAuthorID.Text;



                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FilldataAuthor();
                    MessageBox.Show(this, "Update successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                connection.Open();
            string delete = "delete from authors where author_id = @AuthorID";
            SqlCommand cmd = new SqlCommand(delete, connection);
            cmd.Parameters.Add("@AuthorID", SqlDbType.NChar);
            cmd.Parameters["@AuthorID"].Value = txbAuthorID.Text;
            cmd.ExecuteNonQuery();
            FilldataAuthor();
            MessageBox.Show(this, "Delete successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCancelAuthor_Click(object sender, EventArgs e)
        {
            txbAuthorID.Text = "";
            txbFirstName.Text = "";
            txbLastName.Text = "";
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAuthor.Rows[e.RowIndex];
                txbAuthorID.Text = row.Cells["author_id"].Value.ToString();
                txbFirstName.Text = row.Cells["first_name"].Value.ToString();
                txbLastName.Text = row.Cells["last_name"].Value.ToString();

            }
        }

        private void btnInsertCategory_Click(object sender, EventArgs e)
        {
            int error = 0;
            string CategoryID = tbxCategoryId.Text;
            if (CategoryID.Equals(""))
            {
                error = error + 1;
                lblErrorCategoryId.Text = "Category can not be blank";

            }
            else lblErrorCategoryId.Text = "";

            string CategoryName = tbxCategoryName.Text;
            if (CategoryName.Equals(""))
            {
                error = error + 1;
                lblErrorCategoryName.Text = "Category name can not be blank";

            }
            else
            {
                string insert = "insert into categories values (@CategoryID,@CategoryName)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(insert, connection);
                cmd.Parameters.Add("@CategoryID", SqlDbType.NChar);
                cmd.Parameters["@CategoryID"].Value = CategoryID;

                cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar);
                cmd.Parameters["@CategoryName"].Value = CategoryName;

                cmd.ExecuteNonQuery();
                FilldataCategory();
                MessageBox.Show(this, "Insert successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {

                string edit = " update categories set category_name =@CategoryName"
                    + " where category_id = @CategoryID";
                connection.Open();
                SqlCommand cmd = new SqlCommand(edit, connection);
                cmd.Parameters.Add("@CategoryID", SqlDbType.NChar);
                cmd.Parameters["@CategoryID"].Value = tbxCategoryId.Text;

                cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar);
                cmd.Parameters["@CategoryName"].Value = tbxCategoryName.Text;

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FilldataCategory();
                    MessageBox.Show(this, "Update successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                connection.Open();
            string delete = "delete from categories where category_id = @CategoryID";
            SqlCommand cmd = new SqlCommand(delete, connection);
            cmd.Parameters.Add("@CategoryID", SqlDbType.Int);
            cmd.Parameters["@CategoryID"].Value = tbxCategoryId.Text;
            cmd.ExecuteNonQuery();
            FilldataCategory();
            MessageBox.Show(this, "Delete successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelCategory_Click(object sender, EventArgs e)
        {
            tbxCategoryId.Text = "";
            tbxCategoryName.Text = "";
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCategory.Rows[e.RowIndex];
                tbxCategoryId.Text = row.Cells["category_id"].Value.ToString();
                tbxCategoryName.Text = row.Cells["category_name"].Value.ToString();

            }
        }

        private void btnInsertStudents_Click(object sender, EventArgs e)
        {

            int error = 0;
            string StudentID = tbxStudentId.Text;
            if (StudentID.Equals(""))
            {
                error = error + 1;
                lblErrorStudentId.Text = "Student ID can not be blank";

            }
            else
                lblErrorStudentId.Text = "";

            string StudentName = tbxStudentName.Text;
            if (StudentName.Equals(""))
            {
                error = error + 1;
                lbLErrorStudentName.Text = "Student name can not be blank";
            }
            else
                lbLErrorStudentName.Text = "";


            string StudentCode = tbxStudentCode.Text.ToString();
            if (StudentCode.Equals(""))
            {
                error = error + 1;
                lblErrorStudentCode.Text = "Student code can not be blank";

            }
            else
            {
                string insert = "insert into students values (@StudentID,@StudentName, @StudentCode)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(insert, connection);
                cmd.Parameters.Add("@StudentID", SqlDbType.NChar);
                cmd.Parameters["@StudentID"].Value = StudentID;

                cmd.Parameters.Add("@StudentName", SqlDbType.NVarChar);
                cmd.Parameters["@StudentName"].Value = StudentName;

                cmd.Parameters.Add("@StudentCode", SqlDbType.NVarChar);
                cmd.Parameters["@StudentCode"].Value = StudentCode;

                cmd.ExecuteNonQuery();
                FilldataStudents();
                MessageBox.Show(this, "Insert successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditStudents_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {

                string update = "update students set student_name =@StudentName, student_code = @StudentCode"
                    + " where student_id = @StudentID";
                connection.Open();
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.Add("@StudentName", SqlDbType.NVarChar);
                cmd.Parameters["@StudentName"].Value = tbxStudentName.Text;

                cmd.Parameters.Add("@StudentCode", SqlDbType.NVarChar);
                cmd.Parameters["@StudentCode"].Value = tbxStudentCode.Text;

                cmd.Parameters.Add("@StudentID", SqlDbType.NChar);
                cmd.Parameters["@StudentID"].Value = tbxStudentId.Text;



                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {

                    FilldataStudents();
                    MessageBox.Show(this, "Update successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDeleteStudents_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                connection.Open();
            string delete = "delete from students where student_id = @StudentID";
            SqlCommand cmd = new SqlCommand(delete, connection);
            cmd.Parameters.Add("@StudentID", SqlDbType.NChar);
            cmd.Parameters["@StudentID"].Value = tbxStudentId.Text;
            cmd.ExecuteNonQuery();
            FilldataStudents();
            MessageBox.Show(this, "Delete successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelStudents_Click(object sender, EventArgs e)
        {
            tbxStudentId.Text = "";
            tbxStudentName.Text = "";
            tbxStudentCode.Text = "";
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvStudents.Rows[e.RowIndex];
                tbxStudentId.Text = row.Cells["student_id"].Value.ToString();
                tbxStudentName.Text = row.Cells["student_name"].Value.ToString();
                tbxStudentCode.Text = row.Cells["student_code"].Value.ToString();

            }
        }
        private void btnInsertMemberCard_Click(object sender, EventArgs e)
        {
            int error = 0;
            string CardID = tbxCardId.Text;
            if (CardID.Equals(""))
            {
                error = error + 1;
                lblErrorCardId.Text = "Card ID can not be blank";
            }
            else
                lblErrorCardId.Text = "";

            string MemberName = tbxMemberName.Text;
            if (MemberName.Equals(""))
            {
                error = error + 1;
                lblErrorMemberName.Text = "Member Name can not be blank";
            }
            else
                lblErrorMemberName.Text = "";
            string Address = tbxAddress.Text;
            if (Address.Equals(""))
            {
                error = error + 1;
                lblErrorAddress.Text = "Address can not be blank";
            }
            else
                lblErrorAddress.Text = "";
            string PhoneNumber = tbxPhoneNumber.Text;
            if (PhoneNumber.Equals(""))
            {
                error = error + 1;
                lblErrorPhoneNumber.Text = "Phone number can not be blank";
            }
            else
                lblErrorPhoneNumber.Text = "";

            string Email = tbxEmail.Text;
            if (Email.Equals(""))
            {
                error = error + 1;
                lblErrorEmail.Text = "Eamil can not be blank";
            }
            else
            {
                string query = "select * from member_cards where card_id = @CardID";
                connection.Open();
                SqlCommand cmdcheck = new SqlCommand(query, connection);
                cmdcheck.Parameters.Add("@CardID", SqlDbType.NVarChar);
                cmdcheck.Parameters["@CardID"].Value = CardID;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lblErrorCardId.Text = "This ID is existing,please choose another ";

                }
                else
                {
                    lblErrorCardId.Text = "";
                }
                connection.Close();
                string StudentID = cbxStudentId.SelectedValue.ToString();
                if (error == 0)
                {
                    string insert = "insert into member_cards values  (@CardID,@MemberName,@Address,@PhoneNumber,@Email,@StudentID)";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(insert, connection);
                    cmd.Parameters.Add("@CardID", SqlDbType.NVarChar);
                    cmd.Parameters["@CardID"].Value = CardID;

                    cmd.Parameters.Add("@MemberName", SqlDbType.NVarChar);
                    cmd.Parameters["@MemberName"].Value = MemberName;

                    cmd.Parameters.Add("@Address", SqlDbType.VarChar);
                    cmd.Parameters["@Address"].Value = Address;

                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar);
                    cmd.Parameters["@PhoneNumber"].Value = PhoneNumber;

                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
                    cmd.Parameters["@Email"].Value = Email;

                    cmd.Parameters.Add("@StudentID", SqlDbType.NChar);
                    cmd.Parameters["@StudentID"].Value = StudentID;

                    cmd.ExecuteNonQuery();
                    FilldataMemberCards();
                    MessageBox.Show(this, "Insert successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void btnEditMemberCard_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                int selectStudentID = Convert.ToInt32(cbxStudentId.SelectedValue);
                string edit = "update member_cards set card_id = @CardID, member_name = @MemberName, address = @address, phone_number = @PhoneNumber, email = @Email"
                    + " where student_id = @StudentID";
                connection.Open();
                SqlCommand cmd3 = new SqlCommand(edit, connection);
                cmd3.Parameters.Add("@CardID", SqlDbType.NVarChar);
                cmd3.Parameters["@CardID"].Value = tbxCardId.Text;

                cmd3.Parameters.Add("@MemberName", SqlDbType.NVarChar);
                cmd3.Parameters["@MemberName"].Value = tbxMemberName.Text;

                cmd3.Parameters.Add("@Address", SqlDbType.VarChar);
                cmd3.Parameters["@Address"].Value = tbxAddress.Text;

                cmd3.Parameters.Add("@PhoneNumber", SqlDbType.VarChar);
                cmd3.Parameters["@PhoneNumber"].Value = tbxPhoneNumber.Text;

                cmd3.Parameters.Add("@Email", SqlDbType.NVarChar);
                cmd3.Parameters["@Email"].Value = tbxEmail.Text;

                cmd3.Parameters.Add("@StudentID", SqlDbType.NChar);
                cmd3.Parameters["@StudentID"].Value = selectStudentID;

                int i = cmd3.ExecuteNonQuery();
                if (i > 0)
                {
                    FilldataMemberCards();
                    MessageBox.Show(this, "Update successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDeleteMemberCard_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                connection.Open();
            string delete = "delete from member_cards where card_id = @CardID";
            SqlCommand cmd = new SqlCommand(delete, connection);
            cmd.Parameters.Add("@CardID", SqlDbType.NVarChar);
            cmd.Parameters["@CardID"].Value = tbxCardId.Text;
            cmd.ExecuteNonQuery();
            FilldataMemberCards();
            MessageBox.Show(this, "Delete successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCancelMemberCard_Click(object sender, EventArgs e)
        {
            tbxCardId.Text = "";
            tbxMemberName.Text = "";
            tbxAddress.Text = "";
            tbxPhoneNumber.Text = "";
            tbxEmail.Text = "";
            cbxStudentId.Text = "";
        }
        private void dgvMemberCards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMemberCards.Rows[e.RowIndex];
                tbxCardId.Text = row.Cells["card_id"].Value.ToString();
                tbxMemberName.Text = row.Cells["member_name"].Value.ToString();
                tbxAddress.Text = row.Cells["address"].Value.ToString();
                tbxPhoneNumber.Text = row.Cells["phone_number"].Value.ToString();
                tbxEmail.Text = row.Cells["email"].Value.ToString();
                cbxStudentId.SelectedValue = row.Cells["student_id"].Value.ToString();
            }
        }
        private void btnInsertDes_Click(object sender, EventArgs e)
        {
            int error = 0;
            string Description = tbxDescription.Text;
            if (Description.Equals(""))
            {
                error = error + 1;
                lblErrorDes.Text = "Description can not be blank";
            }
            else
                lblErrorDes.Text = "";

            string BookID = cbxBookIdDes.SelectedValue.ToString();
            if (error == 0)
            {
                string insert = "insert into book_descriptions values (@book_id,@description)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(insert, connection);

                cmd.Parameters.Add("@book_id", SqlDbType.NChar);
                cmd.Parameters["@book_id"].Value = BookID;

                cmd.Parameters.Add("@description", SqlDbType.Text);
                cmd.Parameters["@description"].Value = Description;

                cmd.ExecuteNonQuery();
                FilldataBookDescription();
                MessageBox.Show(this, "Insert successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEditDes_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                int selectedBookIdDes = (int)cbxBookIdDes.SelectedValue;
                string update = "update book_descriptions set description =@Description"
                    + " where book_id = @BookID";
                connection.Open();
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.Add("@Description", SqlDbType.Text);
                cmd.Parameters["@Description"].Value = tbxDescription.Text;

                cmd.Parameters.Add("@BookID", SqlDbType.NChar);
                cmd.Parameters["@BookID"].Value = selectedBookIdDes;

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FilldataBookDescription();
                    MessageBox.Show(this, "Update successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDeleteDes_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                connection.Open();
                string delete = "DELETE FROM book_descriptions WHERE description LIKE '%' + @Description + '%'";
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar, -1);
                cmd.Parameters["@Description"].Value = tbxDescription.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
                FilldataBookDescription();
                MessageBox.Show(this, "Delete successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelDes_Click(object sender, EventArgs e)
        {
            cbxBookIdDes.Text = "";
            tbxDescription.Text = "";
        }

        private void dgvBookDescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvBookDescription.Rows[e.RowIndex];
                string bookID = row.Cells["book_id"].Value.ToString();
                string description = row.Cells["description"].Value.ToString();

                cbxBookIdDes.SelectedValue = bookID;
                tbxDescription.Text = description;

            }
        }

        private void btnInsertBorrow_Click(object sender, EventArgs e)
        {
            int error = 0;
            string BorrorID = tbxBorrowId.Text;
            if (BorrorID.Equals(""))
            {
                error = error + 1;
                lblErrorBorrowId.Text = "Borrow ID can not be blank";
            }
            else
                lblErrorBorrowId.Text = "";

            string BorrowDate = tbxBorrowDate.Text;
            if (BorrowDate.Equals(""))
            {
                error = error + 1;
                lblErrorBorrowDate.Text = "Borrow date can not be blank";
            }
            else
            {
                string query = "select * from borrowings where borrow_id = @BorrowID";
                connection.Open();
                SqlCommand cmdcheck = new SqlCommand(query, connection);
                cmdcheck.Parameters.Add("@BorrowID", SqlDbType.NVarChar);
                cmdcheck.Parameters["@BorrowID"].Value = BorrorID;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lblErrorBorrowId.Text = "This ID is existing,please choose another ";

                }
                else
                {
                    lblErrorBorrowDate.Text = "";
                }
                connection.Close();

                string BookID = cbxBookId.SelectedValue.ToString();
                string CardID = cbxCardId.SelectedValue.ToString();
                if (error == 0)
                {

                    string insert = "insert into borrowings values (@BorrowID,@BookID,@CardID,@BorrowDate)";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(insert, connection);
                    cmd.Parameters.Add("@BookID", SqlDbType.NChar);
                    cmd.Parameters["@BookID"].Value = BookID;

                    cmd.Parameters.Add("@CardID", SqlDbType.NVarChar);
                    cmd.Parameters["@CardID"].Value = CardID;

                    cmd.Parameters.Add("@BorrowID", SqlDbType.NVarChar);
                    cmd.Parameters["@BorrowID"].Value = BorrorID;

                    cmd.Parameters.Add("@BorrowDate", SqlDbType.Date);
                    cmd.Parameters["@BorrowDate"].Value = BorrowDate;

                    cmd.ExecuteNonQuery();
                    FilldataBorrow();
                    MessageBox.Show(this, "Insert successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditBorrow_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                int selectBookID = Convert.ToInt32(cbxBookId.SelectedValue);
                int selectCardID = Convert.ToInt32(cbxCardId.SelectedValue);
                string edit = "UPDATE borrowings SET book_id = @BookID, borrow_date = @BorrowDate, card_id = @CardID" + " WHERE borrow_id = @BorrowID ";
                connection.Open();
                SqlCommand cmd3 = new SqlCommand(edit, connection);
                cmd3.Parameters.Add("@BookID", SqlDbType.NChar);
                cmd3.Parameters["@BookID"].Value = selectBookID;

                cmd3.Parameters.Add("@CardID", SqlDbType.NVarChar);
                cmd3.Parameters["@CardID"].Value = selectCardID;

                cmd3.Parameters.Add("@BorrowID", SqlDbType.NVarChar);
                cmd3.Parameters["@BorrowID"].Value = tbxBorrowId.Text;

                cmd3.Parameters.Add("@BorrowDate", SqlDbType.Date);
                cmd3.Parameters["@BorrowDate"].Value = tbxBorrowDate.Text;

                int i = cmd3.ExecuteNonQuery();
                if (i > 0)
                {
                    FilldataBorrow();
                    MessageBox.Show(this, "Update successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnDeleteBorrow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                string delete = "DELETE FROM borrowings WHERE borrow_id = @BorrowID";
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@BorrowID", SqlDbType.NVarChar);
                cmd.Parameters["@BorrowID"].Value = tbxBorrowId.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
                FilldataBorrow();
                MessageBox.Show(this, "Delete successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelBorrow_Click(object sender, EventArgs e)
        {
            cbxBookId.Text = "";
            cbxCardId.Text = "";
            tbxBorrowId.Text = "";
            tbxBorrowDate.Text = "";
        }

        private void dgvBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBorrow.Rows[e.RowIndex];
                tbxBorrowId.Text = row.Cells["borrow_id"].Value.ToString();
                tbxBorrowDate.Text = row.Cells["borrow_date"].Value.ToString();
                cbxBookId.SelectedValue = row.Cells["book_id"].Value.ToString();
                string cardId = row.Cells["card_id"].Value.ToString();
                cbxCardId.SelectedValue = cardId;
            }
        }



        private void btnInsertReturn_Click(object sender, EventArgs e)
        {
            int error = 0;
            string ReturnID = tbxReturnId.Text;
            if (ReturnID.Equals(""))
            {
                error = error + 1;
                lblErrorReturnId.Text = "Return ID cannot be blank";
            }
            else
            {
                lblErrorReturnId.Text = "";
            }

            string ReturnDate = tbxReturnDate.Text;
            if (ReturnDate.Equals(""))
            {
                error = error + 1;
                lblErrorReturnDate.Text = "Return date cannot be blank";
            }
            else
            {
                string query = "SELECT * FROM returns WHERE return_id = @ReturnID";
                connection.Open();
                SqlCommand cmdcheck = new SqlCommand(query, connection);
                cmdcheck.Parameters.Add("@ReturnID", SqlDbType.NChar);
                cmdcheck.Parameters["@ReturnID"].Value = ReturnID;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lblErrorReturnId.Text = "This ID already exists, please choose another";
                }
                else
                {
                    lblErrorReturnId.Text = "";
                }

                connection.Close();
            }

            string BorrowID = cbxBorrowId.SelectedValue.ToString();

            if (error == 0)
            {
                string insert = "INSERT INTO [returns] (return_id, return_date, borrow_id) VALUES (@ReturnID, @ReturnDate, @BorrowID)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(insert, connection);
                cmd.Parameters.Add("@ReturnID", SqlDbType.NChar);
                cmd.Parameters["@ReturnID"].Value = ReturnID;

                cmd.Parameters.Add("@ReturnDate", SqlDbType.Date);
                cmd.Parameters["@ReturnDate"].Value = ReturnDate;

                cmd.Parameters.Add("@BorrowID", SqlDbType.NVarChar);
                cmd.Parameters["@BorrowID"].Value = BorrowID;

                cmd.ExecuteNonQuery();
                connection.Close();

                FilldataReturn();
                MessageBox.Show(this, "Insert successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void btnEditReturn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {

                int selectBorrowID = Convert.ToInt32(cbxBorrowId.SelectedValue);
                string edit = "UPDATE returns SET borrow_id = @BorrowID, return_date = @ReturnDate" + " WHERE Return_id = @ReturnID ";
                connection.Open();
                SqlCommand cmd3 = new SqlCommand(edit, connection);
                cmd3.Parameters.Add("@BorrowID", SqlDbType.NVarChar);
                cmd3.Parameters["@BorrowID"].Value = selectBorrowID;

                cmd3.Parameters.Add("@ReturnID", SqlDbType.NChar);
                cmd3.Parameters["@ReturnID"].Value = tbxReturnId.Text;

                cmd3.Parameters.Add("@ReturnDate", SqlDbType.Date);
                cmd3.Parameters["@ReturnDate"].Value = tbxReturnDate.Text;

                int i = cmd3.ExecuteNonQuery();
                if (i > 0)
                {
                    FilldataReturn();
                    MessageBox.Show(this, "Update successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDeleteReturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                string delete = "DELETE FROM returns WHERE return_id = @ReturnID";
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@ReturnID", SqlDbType.NChar);
                cmd.Parameters["@ReturnID"].Value = tbxReturnId.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
                FilldataReturn();
                MessageBox.Show(this, "Delete successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelReturn_Click(object sender, EventArgs e)
        {
            cbxBorrowId.Text = "";
            tbxReturnId.Text = "";
            tbxReturnDate.Text = "";
        }

        private void dgvReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReturn.Rows[e.RowIndex];

                string returnID = row.Cells["return_id"].Value.ToString();
                string returnDate = row.Cells["return_date"].Value.ToString();
                string borrowID = row.Cells["borrow_id"].Value.ToString();

                tbxReturnId.Text = returnID;
                tbxReturnDate.Text = returnDate;
                cbxBorrowId.SelectedValue = borrowID;
            }
        }
    }
}
v