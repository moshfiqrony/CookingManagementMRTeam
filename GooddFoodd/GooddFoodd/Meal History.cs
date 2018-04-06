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
    public partial class Meal_History : Form
    {
        public Meal_History()
        {
            InitializeComponent();
        }

        private void Meal_History_Load(object sender, EventArgs e)
        {
            Connector ConnectDb = new Connector();
            MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
            Conn.Open();
            string sql = "SELECT `item`, `date`, `amount`, `PL` FROM `mealhistory`";
            MySqlDataAdapter Adapter = new MySqlDataAdapter(sql, Conn);
            DataSet ds = new DataSet();
            Adapter.Fill(ds, "Table");
            dataGridView1.DataSource = ds.Tables["Table"];
            dataGridView1.Font = new System.Drawing.Font("Arial", 16);
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "Date";
            dataGridView1.Columns[2].HeaderText = "Amount(kg)";
            dataGridView1.Columns[2].HeaderText = "Profit/Loss";
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connector ConnectDb = new Connector();
            MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
            Conn.Open();
            string date = dateTimePicker1.Text;
            string sql = "SELECT `item`, `date`, `amount`, `PL` FROM `mealhistory` WHERE `date` = '"+date+"'";
            MySqlDataAdapter Adapter = new MySqlDataAdapter(sql, Conn);
            DataSet ds = new DataSet();
            Adapter.Fill(ds, "Table");
            dataGridView1.DataSource = ds.Tables["Table"];
            dataGridView1.Font = new System.Drawing.Font("Arial", 16);
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "Date";
            dataGridView1.Columns[2].HeaderText = "Amount(kg)";
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Conn.Close();
        }
    }
}
