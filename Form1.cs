using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace Sklad_Database
{
    public partial class Form1 : Form
    {
        public OleDbConnection database;
        string position_data = null;
        string quantity_data = null;
        string element_data = null;
        string box_number_data = null;

        int columnIndex_grid = 0;

        bool show_data_mode = false;

        public Form1()
        {
            InitializeComponent();
            pos_name.Enabled = false;
            quantity.Enabled = false;
            element_type.Enabled = false;
            box_number.Enabled = false;

            tabControl1.Enabled = true;
            dataGridView1.Enabled = false;
            dataGridView1.Visible = false;

            dataGridView1.AllowUserToAddRows = false; // remove the null line
            dataGridView1.ReadOnly = true;

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sklad.mdb; Jet OLEDB:Database Password=s2152;";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public void loadDataGrid(string sqlQueryString, Boolean allign_table, short number_of_columns)
        {
            try
            {
                dataGridView1.Columns.Clear(); 
                OleDbCommand SQLQuery = new OleDbCommand();
                SQLQuery.CommandText = sqlQueryString;
                SQLQuery.Connection = database;
                DataTable data = new DataTable();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLQuery);
                dataAdapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (allign_table)
            {
                for (int i = 0; i < number_of_columns; i++)
                    dataGridView1.Columns[i].Width = dataGridView1.Width / number_of_columns;
            }
        }

        private void posName_check_CheckedChanged(object sender, EventArgs e)
        {
            if (posName_check.Checked == true)
                pos_name.Enabled = true;
            else
            {
                pos_name.Enabled = false;
                pos_name.Text = "";
            }      
        }

        private void quantity_check_CheckedChanged(object sender, EventArgs e)
        {
            if (quantity_check.Checked == true)
               quantity.Enabled = true;
            else
            {
                quantity.Enabled = false;
                quantity.Text = "";
            }    
        }

        private void elementType_check_CheckedChanged(object sender, EventArgs e)
        {
            if (elementType_check.Checked == true)
                element_type.Enabled = true;
            else
            {
                element_type.Enabled = false;
                element_type.Text = "";
            }    
        }

        private void boxNumber_check_CheckedChanged(object sender, EventArgs e)
        {
            if (boxNumber_check.Checked == true)
                box_number.Enabled = true;
            else
            {
                box_number.Enabled = false;
                box_number.Text = "";
            }
        }

        private void findSelected_button_Click(object sender, EventArgs e)
        {
            string queryString = "select position_name, element_type, quantity_number, box_number from component_base where ";
            if (posName_check.Checked == true)
                queryString += "position_name like '%" + pos_name.Text + "%' AND ";
            if (elementType_check.Checked == true)
                queryString += "element_type like '%" + element_type.Text + "%' AND ";
            if (quantity_check.Checked == true && quantity.TextLength != 0)
                queryString += "quantity_number = " + quantity.Text + " AND ";
            if (boxNumber_check.Checked == true)
                queryString += "box_number = '" + box_number.Text + "' AND ";
            queryString = queryString.Substring(0, queryString.Length - 5);
            queryString += ";";
            loadDataGrid(queryString, true, 4);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (pos_name_add.Text == "" || element_type_add.Text == "" || quantity_add.Text == "" || box_number_add.Text == "")
                MessageBox.Show("You need to fullfill all data boxes", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    OleDbCommand SQLCommand = new OleDbCommand();
                    SQLCommand.CommandText = "INSERT INTO component_base(position_name, element_type, quantity_number, box_number) VALUES('"+pos_name_add.Text+"','"+element_type_add.Text+"','"+quantity_add.Text+"','"+box_number_add.Text+"');";
                    SQLCommand.Connection = database;
                    SQLCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                loadDataGrid("select position_name, element_type, quantity_number, box_number from component_base order by box_number ASC", true, 4);
            }
            pos_name_add.Clear();
            element_type_add.Clear();
            quantity_add.Clear();
            box_number_add.Clear();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            columnIndex_grid = int.Parse(e.ColumnIndex.ToString());

            if (tabControl1.Enabled != false)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                position_data = dataGridView1[0, int.Parse(e.RowIndex.ToString())].Value.ToString();
                element_data = dataGridView1[1, int.Parse(e.RowIndex.ToString())].Value.ToString();
                quantity_data = dataGridView1[2, int.Parse(e.RowIndex.ToString())].Value.ToString();
                box_number_data = dataGridView1[3, int.Parse(e.RowIndex.ToString())].Value.ToString();

                current_data.Text = dataGridView1[int.Parse(e.ColumnIndex.ToString()), int.Parse(e.RowIndex.ToString())].Value.ToString();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want delete the position: "+ position_data
                + " (" + element_data + "), in amaunt of " + quantity_data + " pc, underthe label " + box_number_data+"?", "Are you sure?", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                loadDataGrid("delete from component_base where position_name = '" + position_data + "' and element_type= '" + element_data + "' and quantity_number= " + quantity_data + " and box_number= '" + box_number_data + "'", false, 0);
                loadDataGrid("INSERT INTO history_data VALUES ('"+login_text.Text+"','"+DateTime.Now.ToShortTimeString()+" "+DateTime.Now.ToLongDateString()+"','удалена позиция "+position_data+" в количестве "+quantity_data+" штук из ящика "+box_number_data+"');", false, 0);
                loadDataGrid("select position_name, element_type, quantity_number, box_number from component_base order by box_number ASC", true, 4);
            }
        }

        private void open_base_Click(object sender, EventArgs e)
        {
            
            bool flag = true;

            loadDataGrid("select name_data, login, password from personal_data where login ='" + login_text.Text + "'", true, 3);

            if (dataGridView1.Rows.Count != 0)
            {
                //Get initial data
                string user_key = password_text.Text;
                char[] user_key_mask = new char[user_key.Length];
                for (int i = 0; i < user_key.Length; i++)
                {
                    user_key_mask[i] = user_key[i];
                }

                //Get data to compare with
                string password = dataGridView1[2, 0].Value.ToString();
                char[] pass_mask = new char[password.Length];
                for (int i = 0; i < password.Length; i++)
                {
                    pass_mask[i] = password[i];
                }
                string login_name = dataGridView1[1, 0].Value.ToString();
                char[] login_mask = new char[login_name.Length];
                for (int i = 0; i < login_name.Length; i++)
                {
                    login_mask[i] = login_name[i];
                }
                /for (int i = 0; i < password.Length; i++)
                {
                    if (pass_mask[i] > login_mask[i])
                        pass_mask[i] = login_mask[i];
                    //MessageBox.Show(pass_mask[i].ToString());
                }
                //check that password is correct
                if (pass_mask.Length == user_key_mask.Length)
                    for (int i = 0; i < pass_mask.Length; i++)
                    {
                        if (pass_mask[i] != user_key_mask[i])
                        {
                            flag = false;
                            i = pass_mask.Length;
                        }
                    }
                else
                    flag = false;
                if (flag == true)
                {
                    dataGridView1.Enabled = true;
                    dataGridView1.Visible = true;
                    tabControl1.Enabled = true;
                    //loadDataGrid("INSERT INTO history_data VALUES ('"+login_text.Text+"','"+DateTime.Now.ToShortTimeString()+ " "+DateTime.Now.ToLongDateString()+"','вход в систему');", false, 0);
                    loadDataGrid("select position_name, element_type, quantity_number, box_number from component_base order by box_number ASC", true, 4);

                    password_text.Clear();
                    password_text.Enabled = false;
                    login_text.Enabled = false;
                }
                else
                {
                    dataGridView1.Enabled = false;
                    dataGridView1.Visible = false;
                    MessageBox.Show("Your login/password is incorrect!");
                }     
            }
            else
            {
                MessageBox.Show("Your login/password is incorrect!");
            }
                
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You are about to chage the recording with attributes: " + position_data
     + ", " + element_data + ", " + quantity_data + ", " + box_number_data + ".", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                switch (columnIndex_grid)
                {
                    case 0:
                        loadDataGrid("update component_base set position_name = '" + change_data.Text + "' where position_name = '" + current_data.Text + "' and element_type = '" + element_data + "' and quantity_number= " + quantity_data + " and box_number= '" + box_number_data + "'", false, 0);
                        break;
                    case 1:
                        loadDataGrid("update component_base set element_type = '" + change_data.Text + "' where element_type = '" + current_data.Text + "' and position_name= '" + position_data + "' and quantity_number= " + quantity_data + " and box_number= '" + box_number_data + "'", false, 0);
                        break;
                    case 2:
                        loadDataGrid("update component_base set quantity_number = " + change_data.Text + " where quantity_number = " + current_data.Text + " and position_name= '" + position_data + "' and element_type = '" + element_data + "' and box_number= '" + box_number_data + "'", false, 0);
                        break;
                    case 3:
                        loadDataGrid("update component_base set box_number = '" + change_data.Text + "' where box_number = '"+ current_data.Text + "' and position_name= '" + position_data + "' and quantity_number= " + quantity_data + " and element_type= '" + element_data + "'", false, 0);
                        break;
                }
                loadDataGrid("select position_name, element_type, quantity_number, box_number from component_base order by box_number ASC", true, 4);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (show_data_mode == false)
            {
                data_mode_switch.Text = "Go back to the component database mode";
                show_data_mode = true;

                loadDataGrid("select user, data_and_time_of_event, action from history_data order by data_and_time_of_event ASC", true, 3);
                tabControl1.Enabled = false;
            }
            else
            {
                data_mode_switch.Text = "Show main events";
                show_data_mode = false;

                loadDataGrid("select position_name, element_type, quantity_number, box_number from component_base order by box_number ASC", true, 4);
                tabControl1.Enabled = true;
            }
                
        }
    }
}
