using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_library_management_database
{
    public partial class ViewBook : Form
    {
        SqlConnection connection;

        public ViewBook(string username)
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-NB4LK8U\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
          
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
            FilldataBorrow();
            FilldataReturn();
            FilldataMemberCards();
        }
        public void FilldataBorrow()
        {
            foreach (DataGridViewColumn column in dgvBorrow.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            dgvBorrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string queryBorrow = "select *from borrowings";
            DataTable tblBorrow = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(queryBorrow, connection);
            ad.Fill(tblBorrow);
            dgvBorrow.DataSource = tblBorrow;
            connection.Close();
        }
        public void FilldataReturn()
        {
            foreach (DataGridViewColumn column in dgvReturn.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            dgvReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string queryReturn = "select *from returns";
            DataTable tblReturn = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(queryReturn, connection);
            ad.Fill(tblReturn);
            dgvReturn.DataSource = tblReturn;
            connection.Close();
        }
        public void FillData()
        {
            foreach(DataGridViewColumn column in dgvViewBook.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            dgvViewBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string query = "select * from books";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dgvViewBook.DataSource = tbl;
            connection.Close();
        }
        public void FilldataMemberCards()
        {
            foreach (DataGridViewColumn column in dgvMemberCards.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            dgvMemberCards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string queryMemberCards = "select * from member_cards";
            DataTable tblMemberCards = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(queryMemberCards, connection);
            ad.Fill(tblMemberCards);
            dgvMemberCards.DataSource = tblMemberCards;
            connection.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Dispose();
        }

        private void dgvViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMemberCards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
