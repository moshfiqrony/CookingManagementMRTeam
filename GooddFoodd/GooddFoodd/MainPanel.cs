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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace GooddFoodd
{
    
    public partial class MainPanel : Form
    {
        string mainPL = "";
        string[] categoryForSql = { "fish", "kacha_bazaar", "shukna_bazaar", "meatbazaar", "chalbazaar"};
        int item = 0;
        public MainPanel()
        {
            InitializeComponent();
        }

        //
        //main panel load function
        //
        private void MainPanel_Load(object sender, EventArgs e)
        {

        }

        //
        // main menu item click
        //
        private void MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //
        // logout event function
        //
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Show();
        }

        private void MainPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        // //
        //New entry button click
        // //
        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hidepanels();
            NewEntryStockPanel.Visible = true;

        }

        ////
        //save button click in new entry tab
        ////
        private void button1_Click(object sender, EventArgs e)
        {
            ////
            //checking empty field
            ////
            if (nameTxt.Text != "" && stockTxt.Text != "" && categoryCombo.Text != "" && ratioTxt.Text != "" && textBoxPerKg.Text != "")
            {
                AlertNewEntryStock.Visible = false;

                ////
                //connecting database
                ////
                Connector SqlCon = new Connector();
                MySqlConnection Conn = new MySqlConnection(SqlCon.SQL);
                Conn.Open();

                // //
                //category deifne
                // //
                string catg = "";
                switch (categoryCombo.Text)
                {
                    case "Kacha Bazaar":
                        catg = "kacha_bazaar";
                        break;
                    case "Fish":
                        catg = "fish";
                        break;
                    case "Shukna Bazaar":
                        catg = "shukna_bazaar";
                        break;
                    case "Meat":
                        catg = "meatBazaar";
                        break;
                    case "Chal":
                        catg = "chalbazaar";
                        break;
                    case "Moshla":
                        catg = "moshla";
                        break;
                }

                // //
                //check value if it is exixting
                // //  
                string sql;
                sql = "SELECT * FROM `" + catg + "` WHERE `name` = '" + nameTxt.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                MySqlDataReader Reader = cmd.ExecuteReader();

                // //
                //If have value it will alert
                // //
                if (Reader.Read())
                {
                    MessageBox.Show("You Alrady Have That Entry", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTxt.ResetText();
                    stockTxt.ResetText();
                    textBoxupRate.ResetText();
                    categoryCombo.ResetText();
                    Reader.Close();
                }
                // //
                //if doesnot have value direct entry
                // //
                else
                {
                    Conn.Close();
                    Conn.Open();
                    sql = "INSERT INTO `" + catg + "` (`name`, `stock`, `ratio`, `perKg`) VALUES ('" + nameTxt.Text + "', '" + (Convert.ToDouble(stockTxt.Text)) + "', '" + (Convert.ToDouble(ratioTxt.Text)) + "', '" + (Convert.ToDouble(textBoxPerKg.Text)) + "')";
                    cmd = new MySqlCommand(sql, Conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Entry Successfully Inserted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    nameTxt.ResetText();
                    stockTxt.ResetText();
                    ratioTxt.ResetText();
                    textBoxupRate.ResetText();
                    categoryCombo.ResetText();
                    Conn.Close();
                }
            }
            else
            {
                AlertNewEntryStock.Visible = true;
            }
        }

        // //
        //hide all panels
        // //
        public void Hidepanels()
        {
            NewEntryStockPanel.Visible = false;
            UpdateStockPanel.Visible = false;
            pictureBoxMPBG.Visible = false;
            FindMealQuantityPanel.Visible = false;
        }

        // //
        //updateEntry menue button click
        // //
        private void updateEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hidepanels();
            UpdateStockPanel.Visible = true;
        }
        // //
        // Select Category
        // //
        private void textBoxUpCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string catg, sql;
            catg = SelectCat();
            sql = "SELECT `name`, `stock`, `ratio`, `perKg` FROM `" + catg + "`";
            ShowData(sql);
        }
        // // 
        // Refresh button click event
        // //
        private void buttonUpDelete_Click(object sender, EventArgs e)
        {
            string name = textBoxUpName.Text, sql;
        }
        // //
        // Mouse double click on datagrid view cell
        // //
        private void dataGridViewUpDG_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxUpName.Text = dataGridViewUpDG.CurrentRow.Cells[0].Value.ToString();
            textBoxUpStock.Text = dataGridViewUpDG.CurrentRow.Cells[1].Value.ToString();
            textBoxUpRatio.Text = dataGridViewUpDG.CurrentRow.Cells[2].Value.ToString();
            textBoxupRate.Text = dataGridViewUpDG.CurrentRow.Cells[3].Value.ToString();
        }
        // //
        // Event For Click of Update Button
        // //
        private void buttonUpUpdate_Click(object sender, EventArgs e)
        {
            Connector ConnectDb = new Connector();
            MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
            string catg = SelectCat();
            double stock = Convert.ToDouble(textBoxUpStock.Text) + Convert.ToDouble(dataGridViewUpDG.CurrentRow.Cells[1].Value.ToString());
            double ratio = Convert.ToDouble(textBoxUpRatio.Text);
            string sql;
            double perKg =  ((Convert.ToDouble(dataGridViewUpDG.CurrentRow.Cells[1].Value.ToString()) * Convert.ToDouble(dataGridViewUpDG.CurrentRow.Cells[3].Value.ToString())) + (Convert.ToDouble(textBoxUpStock.Text) * Convert.ToDouble(textBoxupRate.Text) ) )/stock;
            perKg = System.Math.Round(perKg, 2);
            sql = "UPDATE `" + catg + "` SET `stock` =  '" + stock + "', `ratio` = '" + ratio + "', `perKg` = '" + perKg + "'  WHERE `" + catg + "`.`name` = '" + textBoxUpName.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
            catg = SelectCat();
            sql = "SELECT `name`, `stock`, `ratio`,`perKg` FROM `" + catg + "`";
            ShowData(sql);
            textBoxUpName.ResetText();
            textBoxUpStock.ResetText();
            textBoxUpRatio.ResetText();
            textBoxupRate.ResetText();
        }
        // //
        // Function For selecting Category
        // //
        string SelectCat()
        {
            string catg = "";
            switch (ComboboxUpCat.Text)
            {
                case "Kacha Bazaar":
                    catg = "kacha_bazaar";
                    break;
                case "Fish":
                    catg = "fish";
                    break;
                case "Shukna Bazaar":
                    catg = "shukna_bazaar";
                    break;
                case "Meat":
                    catg = "meatBazaar";
                    break;
                case "Chal":
                    catg = "chalbazaar";
                    break;
                case "Moshla":
                    catg = "moshla";
                    break;
            }
            return catg;
        }
        // //
        // Show Data Function
        // //
        void ShowData(string sql)
        {
            try
            {
                // //
                // View Data
                // //
                Connector ConnectDb = new Connector();
                MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
                Conn.Open();
                MySqlDataAdapter Adapter = new MySqlDataAdapter(sql, Conn);
                DataSet ds = new DataSet();
                Adapter.Fill(ds, "Table");
                dataGridViewUpDG.DataSource = ds.Tables["Table"];
                dataGridViewUpDG.Font = new System.Drawing.Font("Arial", 16);
                dataGridViewUpDG.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14);
                dataGridViewUpDG.Columns[0].HeaderText = "Name";
                dataGridViewUpDG.Columns[1].HeaderText = "Stock(kg)";
                dataGridViewUpDG.Columns[2].HeaderText = "Ratio(Per 1)";
                dataGridViewUpDG.Columns[3].HeaderText = "Rate(Per Kg)";
                dataGridViewUpDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Conn.Close();
            }
            catch (Exception ex)
            {
                labelUpAlert.Text = "Please Select Valid Option";
            }
        }
        // // 
        // Search button click
        // //
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = "%"+textBoxUpSearch.Text+"%";
            string cat = SelectCat();
            string sql = "SELECT `name`, `stock`, `ratio`,`perKg` FROM `"+cat+"` WHERE `name` LIKE '" + searchText + "'";
            ShowData(sql);
            textBoxUpSearch.ResetText();
        }
        // // 
        // search auto when enter press function
        // //
        private void textBoxUpSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = buttonSearch;
        }
        // // 
        // active button for stock update field
        // //
        private void textBoxUpStock_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = buttonUpUpdate;
        }
        // //
        // Find quantity event function
        // //
        private void findQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hidepanels();
            FindMealQuantityPanel.Visible = true;

        }
        // // 
        // add meal item button click
        // //
        private void AddMealBTN_Click(object sender, EventArgs e)
        {
            item++;
            if (item <= 4)
            {
                switch (item)
                {
                    case 1:
                        FoodItem1Panle.Visible = true;
                        try
                        {
                            Connector ConnectDb = new Connector();
                            MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
                            Conn.Open();
                            string sql = "SELECT `name` FROM `ChalBazaar`";
                            MySqlCommand cmd = new MySqlCommand(sql, Conn);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                comboBoxitem1.Items.Add(reader.GetString("name"));
                            }
                            reader.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Unable To Get Data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 2:
                        if(comboBoxitem1.Text != "")
                        {
                            FoodItem2Panle.Visible = true;
                            try
                            {
                                Connector ConnectDb = new Connector();
                                MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
                                Conn.Open();
                                comboBoxitem2.Items.Add("Egg");
                                comboBoxitem2.Items.Add("");
                                comboBoxitem2.Items.Add("Fish List");
                                comboBoxitem2.Items.Add("---------------");
                                string sql = "(SELECT `name` FROM `fish`)";
                                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                                MySqlDataReader reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    comboBoxitem2.Items.Add(reader.GetString("name"));
                                }
                                reader.Close();
                                comboBoxitem2.Items.Add("");
                                comboBoxitem2.Items.Add("Meat List");
                                comboBoxitem2.Items.Add("---------------");
                                sql = "(SELECT `name` FROM `meatbazaar`)";
                                cmd = new MySqlCommand(sql, Conn);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    comboBoxitem2.Items.Add(reader.GetString("name"));
                                }
                                reader.Close();
                                Conn.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Unable To Get Data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("PLease Fill Previous Data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            item--;
                        }
                        break;
                    case 3:
                        if (comboBoxitem2.Text != "")
                        {
                            FoodItem3Panle.Visible = true;
                            try
                            {
                                Connector ConnectDb = new Connector();
                                MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
                                Conn.Open();
                                string sql = "SELECT `name` FROM `ChalBazaar`";
                                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                                MySqlDataReader reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    comboBoxitem3.Items.Add(reader.GetString("name"));
                                }
                                reader.Close();
                                comboBoxitem3.Items.Add("");
                                comboBoxitem3.Items.Add("Fish List");
                                comboBoxitem3.Items.Add("---------------");
                                sql = "(SELECT `name` FROM `fish`)";
                                cmd = new MySqlCommand(sql, Conn);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    comboBoxitem3.Items.Add(reader.GetString("name"));
                                }
                                reader.Close();
                                comboBoxitem3.Items.Add("");
                                comboBoxitem3.Items.Add("Meat List");
                                comboBoxitem3.Items.Add("---------------");
                                sql = "(SELECT `name` FROM `meatbazaar`)";
                                cmd = new MySqlCommand(sql, Conn);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    comboBoxitem3.Items.Add(reader.GetString("name"));
                                }
                                reader.Close();
                                comboBoxitem3.Items.Add("Veg Fry List");
                                comboBoxitem3.Items.Add("---------------");
                                sql = "SELECT `name` FROM `veg_fry`";
                                cmd = new MySqlCommand(sql, Conn);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    comboBoxitem3.Items.Add(reader.GetString("name"));
                                }
                                reader.Close();
                                comboBoxitem3.Items.Add("");
                                comboBoxitem3.Items.Add("Shak List");
                                comboBoxitem3.Items.Add("---------------");
                                sql = "SELECT `name` FROM `shak`";
                                cmd = new MySqlCommand(sql, Conn);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    comboBoxitem3.Items.Add(reader.GetString("name"));
                                }
                                reader.Close();
                                comboBoxitem3.Items.Add("");
                                comboBoxitem3.Items.Add("Vorta List");
                                comboBoxitem3.Items.Add("---------------");
                                sql = "SELECT `name` FROM `vorta`";
                                cmd = new MySqlCommand(sql, Conn);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    comboBoxitem3.Items.Add(reader.GetString("name"));
                                }
                                reader.Close();
                                comboBoxitem3.Items.Add("");
                                comboBoxitem3.Items.Add("Dal List");
                                comboBoxitem3.Items.Add("---------------");
                                sql = "SELECT `name` FROM `dal`";
                                cmd = new MySqlCommand(sql, Conn);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    comboBoxitem3.Items.Add(reader.GetString("name"));
                                }
                                reader.Close();
                                Conn.Close();


                            }
                            catch
                            {
                                MessageBox.Show("Unable To Get Data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("PLease Fill Previous Data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            item--;
                        }
                        break;
                    case 4:
                        if (comboBoxitem3.Text != "")
                        {
                            FoodItem4Panle.Visible = true;
                            try
                            {
                                Connector ConnectDb = new Connector();
                                MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
                                Conn.Open();
                                string sql = "SELECT `name` FROM `moshla`";
                                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                                MySqlDataReader reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    comboBoxitem4.Items.Add(reader.GetString("name"));
                                }
                                reader.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Unable To Get Data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("PLease Fill Previous Data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            item--;
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Can't Add More Item", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                item--;
            }
                
        }
        // // 
        // delete meal item button click
        // //
        private void DeleteMealBTN_Click(object sender, EventArgs e)
        {
            if (item <= 4 && item > 0)
            {
                switch (item)
                {
                    case 1:
                        FoodItem1Panle.Visible = false;
                        comboBoxitem1.Items.Clear();
                        comboBoxitem1.ResetText();
                        break;
                    case 2:
                        FoodItem2Panle.Visible = false;
                        comboBoxitem2.Items.Clear();
                        comboBoxitem2.ResetText();
                        break;
                    case 3:
                        FoodItem3Panle.Visible = false;
                        comboBoxitem3.Items.Clear();
                        comboBoxitem3.ResetText();
                        break;
                    case 4:
                        FoodItem4Panle.Visible = false;
                        comboBoxitem4.Items.Clear();
                        comboBoxitem4.ResetText();
                        break;
                }
                item--;
            }
            else
            {
                MessageBox.Show("No Item To Delete", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // //
        //generate button click event
        // //
        private void GenerateBTN_Click(object sender, EventArgs e)
        {
            double item1 = 0;
            double item2 = 0;
            double item3 = 0;
            double item4 = 0;
            double rat1 = 0;
            double rat2 = 0;
            double rat3 = 0;
            double rat4 = 0;
            double totalMeal = 0;
            if (textBoxTotalMeal.Text != "")
            {
                totalMeal = Convert.ToDouble (textBoxTotalMeal.Text);
                DataTable dtQnt = new DataTable();
                DataTable dtPrft = new DataTable();
                //
                //defining collumns for table of wuantity genearation
                //
                dtQnt.Columns.Add("Name", typeof(string));
                dtQnt.Columns.Add("Need", typeof(double));
                dtQnt.Columns.Add("Stock(kg)", typeof(double));
                //
                // definging table for profit generation
                //
                dataGridViewMeal.DataSource = dtQnt;
                dataGridViewMeal.Font = new System.Drawing.Font("Arial", 12);
                dataGridViewMeal.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
                //
                // item 1
                //
                if (comboBoxitem1.Text != "")
                {
                    string Combval1 = comboBoxitem1.Text;
                    double stockrem = 0.0;
                    double stockneed = 0.0;
                    Connector ConnectDb = new Connector();
                    MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
                    Conn.Open();
                    string sql = "SELECT * FROM `ChalBazaar` WHERE `name` = '" + Combval1 + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, Conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        try
                        {
                            stockneed = reader.GetDouble("ratio") * Convert.ToDouble(textBoxTotalMeal.Text);
                            stockrem = (reader.GetDouble("stock")) - stockneed;
                            if (stockrem < 0)
                            {
                                MessageBox.Show(comboBoxitem1.Text + " Out Of Stock", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxMealRate.ResetText();
                            }
                            else
                            {
                                dtQnt.Rows.Add(reader.GetString("name"), stockneed, stockrem);
                                item1 = reader.GetDouble("perKg");
                                rat1 = reader.GetDouble("ratio");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("No Item Found as " + comboBoxitem1.Text + " In Chal.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //
                // item 2
                //
                if (comboBoxitem2.Text != "")
                {
                    string Combval2 = comboBoxitem2.Text;
                    double stockrem = 0.0;
                    double stockneed = 0.0;
                    Connector ConnectDb = new Connector();
                    MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
                    Conn.Open();
                    string sql = "(SELECT * FROM `fish` WHERE `name` = '" + Combval2 + "') UNION (SELECT * FROM `meatbazaar` WHERE `name` = '" + Combval2 + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, Conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        stockneed = reader.GetDouble("ratio") * Convert.ToDouble(textBoxTotalMeal.Text);
                        stockrem = (reader.GetDouble("stock")) - stockneed;
                        if (stockrem < 0)
                        {
                            MessageBox.Show(comboBoxitem2.Text + " Out Of Stock", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxMealRate.ResetText();
                        }
                        else
                        {
                            dtQnt.Rows.Add(reader.GetString("name"), stockneed, stockrem);
                            item2 = reader.GetDouble("perKg");
                            rat2 = reader.GetDouble("ratio");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Item Found as " + comboBoxitem2.Text + " In Meat, Fish, Egg.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //
                // item 3
                //
                if (comboBoxitem3.Text != "")
                {
                    string Combval3 = comboBoxitem3.Text;
                    double stockrem = 0.0;
                    double stockneed = 0.0;
                    Connector ConnectDb = new Connector();
                    MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
                    Conn.Open();
                    string sql = "(SELECT * FROM `chalbazaar` WHERE `name` = '" + Combval3 + "') UNION (SELECT * FROM `meatbazaar` WHERE `name` = '" + Combval3 + "') UNION (SELECT * FROM `kacha_bazaar` WHERE `name` = '" + Combval3 + "') UNION (SELECT * FROM `fish` WHERE `name` = '" + Combval3 + "') UNION (SELECT * FROM `shukna_bazaar` WHERE `name` = '" + Combval3 + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, Conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        stockneed = reader.GetDouble("ratio") * Convert.ToDouble(textBoxTotalMeal.Text);
                        stockrem = (reader.GetDouble("stock")) - stockneed;
                        if (stockrem < 0)
                        {
                            MessageBox.Show(comboBoxitem3.Text + " Out Of Stock", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxMealRate.ResetText();
                        }
                        else
                        {
                            dtQnt.Rows.Add(reader.GetString("name"), stockneed, stockrem);
                            item3 = reader.GetDouble("perKg");
                            rat3 = reader.GetDouble("ratio");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Item Found as " + comboBoxitem3.Text + " In Kacha Bazaar.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // 
                // item 4
                // 
                if (comboBoxitem4.Text != "")
                {
                    string Combval4 = comboBoxitem4.Text;
                    double stockrem = 0.0;
                    double stockneed = 0.0;
                    Connector ConnectDb = new Connector();
                    MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
                    Conn.Open();
                    string sql = "SELECT * FROM `moshla` WHERE `name` = '" + Combval4 + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, Conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        stockneed = reader.GetDouble("ratio") * Convert.ToDouble(textBoxTotalMeal.Text);
                        stockrem = (reader.GetDouble("stock")) - stockneed;
                        if (stockrem < 0)
                        {
                            MessageBox.Show(comboBoxitem4.Text + " Out Of Stock", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxMealRate.ResetText();
                        }
                        else
                        {
                            dtQnt.Rows.Add(reader.GetString("name"), stockneed, stockrem);
                            item4 = reader.GetDouble("perKg");
                            rat4 = reader.GetDouble("ratio");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Item Found as " + comboBoxitem4.Text + " In Meat, Fish, Egg, Shukna Bazaar, Kacha Bazaar.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                label1Profit.Visible = true;
                if (textBoxMealRate.Text != "")
                {
                    double mealR = Convert.ToDouble(textBoxMealRate.Text);
                    double mealP = Convert.ToDouble(textBoxTotalMeal.Text);
                    double pro = ((mealP * rat1) * item1) +((mealP * rat2) * item2) +((mealP * rat3) * item3) +((mealP * rat4) * item4);
                    if ((mealP * mealR) > pro)
                    {
                        label1Profit.Text = "You Are In Profit Of " + Convert.ToString((mealP * mealR) - pro) + ".Tk\n" + "Total Expence : " + pro.ToString() + ".Tk\nTotal Earn : " + (mealP * mealR).ToString() + ".Tk";
                        mainPL = "Profit " + Convert.ToString((mealP * mealR) - pro) + ".Tk";
                    }
                    else
                    {
                        label1Profit.Text = "You Are In Loss Of " + Convert.ToString(pro - (mealP * mealR)) + ".Tk\n" + "Total Expence : " + pro.ToString() + ".Tk\nTotal Earn : " + (mealP * mealR).ToString() + ".Tk";
                        mainPL = "Loss " + Convert.ToString(pro - (mealP * mealR)) + ".Tk";
                    }
                }
                else
                {
                    MessageBox.Show("Please Give Meal Rate", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Give Total Meal", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }
        //
        // creating pdf here
        //
        private void buttonExportPDF_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            DateTime dt = DateTime.Now;
            string date = dt.Date.ToString();
            string name = "Gooddfoodd" + " " + dt.Day.ToString() + " " + dt.Month.ToString() + " " + dt.Minute.ToString() + "" + " " + dt.Second.ToString();
            try
            {
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream((name + ".pdf"), FileMode.Create));
            }catch(Exception ex)
            {
                MessageBox.Show("Please Rename The Old File First. \n"+ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            doc.Open();
            try
            {
                PdfPTable tbl = new PdfPTable(dataGridViewMeal.Columns.Count);
                for (int i = 0; i < dataGridViewMeal.Columns.Count; i++)
                {
                    tbl.AddCell(new Phrase(dataGridViewMeal.Columns[i].HeaderText));
                }

                tbl.HeaderRows = 1;

                for (int i = 0; i < dataGridViewMeal.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewMeal.Columns.Count; j++)
                    {
                        if (dataGridViewMeal[j, i].Value != null)
                        {
                            tbl.AddCell(new Phrase(dataGridViewMeal[j, i].Value.ToString()));
                        }
                    }
                }
                doc.AddTitle("Goodd Foodd Daily Meal Report");
                Paragraph pr = new Paragraph(dt.ToString() + "\n\n\n");
                Paragraph pr2 = new Paragraph("\n\n\t" + mainPL);
                doc.Add(pr);
                doc.Add(tbl);
                doc.Add(pr2);
                doc.Close();
                MessageBox.Show("Data Exported Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Table Is Empty\n\n" + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // //
        // save data button click event
        // //
        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            Connector ConnectDb = new Connector();
            MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
            DateTime dt = DateTime.Now;
            string item = "";
            double amount = 0;
            double stock = 0;
            int count = dataGridViewMeal.Rows.Count;
            try
            {
                for (int i = 0; i < count - 1; i++)
                {
                    Conn.Open();
                    item = Convert.ToString(dataGridViewMeal.Rows[i].Cells[0].Value);
                    amount = Convert.ToDouble(dataGridViewMeal.Rows[i].Cells[1].Value);
                    stock = Convert.ToDouble(dataGridViewMeal.Rows[i].Cells[2].Value);
                    string sql = "INSERT INTO `mealhistory` (`date`, `item`, `amount`, `PL`) VALUES ('" + dt.ToString("yyyy-MM-dd") + "', '" + item + "', '" + amount + "', '"+mainPL+"');";
                    MySqlCommand cmd = new MySqlCommand(sql, Conn);
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    Conn.Open();
                    for(int j=0; j<categoryForSql.Length; j++)
                    {
                        sql = "UPDATE `"+categoryForSql[j]+"` SET stock = '" + stock + "' WHERE name = '" + item + "'";
                        cmd = new MySqlCommand(sql, Conn);
                        cmd.ExecuteNonQuery();
                    }
                    Conn.Close();
                }
                MessageBox.Show("Data Saved Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // // 
        // Meal History Click Event
        // //
        private void mealHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Meal_History MH = new Meal_History();
            MH.Owner = this;
            MH.ShowDialog();
        }
        // // 
        // menu click event
        // //
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemList MH = new ItemList();
            MH.Owner = this;
            MH.ShowDialog();
        }
        // // 
        // home click event
        // //
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hidepanels();
            pictureBoxMPBG.Visible = true;
        }

        private void checkBoxdelete_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxdelete.Checked == true)
            {
                buttonDelete.Enabled = true;
                buttonDelete.BackColor = Color.Red;
                MessageBox.Show("Delete Button Activated", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                buttonDelete.Enabled = false;
                buttonDelete.BackColor = Color.White;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(checkBoxdelete.Checked == true)
            {
                string cat = SelectCat();
                string sql = "DELETE FROM `" + cat + "` WHERE `" + cat + "`.`name` = '" + dataGridViewUpDG.CurrentRow.Cells[0].Value.ToString() + "'";
                Connector ConnectDb = new Connector();
                MySqlConnection Conn = new MySqlConnection(ConnectDb.SQL);
                Conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();
                sql = "SELECT `name`, `stock`, `ratio`,`perKg` FROM `" + cat + "`";
                ShowData(sql);
                Conn.Close();
            }
        }

        private void MainPanel_Load_1(object sender, EventArgs e)
        {

        }
    }
}
