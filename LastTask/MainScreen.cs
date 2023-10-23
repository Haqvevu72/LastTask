using Dapper;
using Entities.Concrete;
using Microsoft.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace LastTask
{
    public partial class MainScreen : Form
    {
        static string con_str = "Data Source=STHQ0125-10;Initial Catalog=BazarDB;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        DbConnection connection = new SqlConnection(con_str);
        public MainScreen()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

            var sql = $"SELECT * FROM Products WHERE ProductName LIKE '%{search_bar.Text}%'";

            var list = connection.Query<Product>(sql).ToList();

            product_list.DataSource = list;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Sub sub = new Sub();
            sub.ShowDialog();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {

        }

        private void remove_btn_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {

        }
    }
}