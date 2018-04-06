using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GooddFoodd
{
    public partial class ItemList : Form
    {
        public ItemList()
        {
            InitializeComponent();
        }

        private void MealHistory_Load(object sender, EventArgs e)
        {
            Connector ConnectDb = new Connector();
            MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
            Conn.Open();
            string sql = "SELECT `name` FROM `rice`";
            MySqlDataAdapter Adapter = new MySqlDataAdapter(sql, Conn);
            DataSet ds = new DataSet();
            Adapter.Fill(ds, "Table");
            dataGridView1.DataSource = ds.Tables["Table"];
            dataGridView1.Font = new System.Drawing.Font("Arial", 16);
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14);
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Conn.Close();
            Conn.Open();
            sql = "(SELECT `name` FROM `fish`) UNION SELECT `name` FROM `meat`";
            Adapter = new MySqlDataAdapter(sql, Conn);
            ds = new DataSet();
            Adapter.Fill(ds, "Table");
            dataGridView2.DataSource = ds.Tables["Table"];
            dataGridView2.Font = new System.Drawing.Font("Arial", 16);
            dataGridView2.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14);
            dataGridView2.Columns[0].HeaderText = "Name";
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Conn.Close();
            Conn.Open();
            sql = "(SELECT `name` FROM `veg_fry`) UNION (SELECT `name` FROM `vorta`) UNION (SELECT `name` FROM `shak`) UNION (SELECT `name` FROM `dal`)";
            Adapter = new MySqlDataAdapter(sql, Conn);
            ds = new DataSet();
            Adapter.Fill(ds, "Table");
            dataGridView3.DataSource = ds.Tables["Table"];
            dataGridView3.Font = new System.Drawing.Font("Arial", 16);
            dataGridView3.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14);
            dataGridView3.Columns[0].HeaderText = "Name";
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Conn.Close();
        }
    }
}
