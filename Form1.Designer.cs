namespace Sklad_Database
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.filter_tab = new System.Windows.Forms.TabPage();
            this.boxNumber_check = new System.Windows.Forms.CheckBox();
            this.elementType_check = new System.Windows.Forms.CheckBox();
            this.quantity_check = new System.Windows.Forms.CheckBox();
            this.posName_check = new System.Windows.Forms.CheckBox();
            this.box_number = new System.Windows.Forms.TextBox();
            this.boxNumber_label = new System.Windows.Forms.Label();
            this.elementType_label = new System.Windows.Forms.Label();
            this.quantity_label = new System.Windows.Forms.Label();
            this.posName_label = new System.Windows.Forms.Label();
            this.findSelected_button = new System.Windows.Forms.Button();
            this.element_type = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.pos_name = new System.Windows.Forms.TextBox();
            this.data_changing_tab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_number_add = new System.Windows.Forms.TextBox();
            this.quantity_add = new System.Windows.Forms.TextBox();
            this.element_type_add = new System.Windows.Forms.TextBox();
            this.pos_name_add = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.change_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.change_data = new System.Windows.Forms.TextBox();
            this.current_data = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.open_base = new System.Windows.Forms.Button();
            this.login_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.data_mode_switch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.filter_tab.SuspendLayout();
            this.data_changing_tab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.filter_tab);
            this.tabControl1.Controls.Add(this.data_changing_tab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1517, 108);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 749);
            this.tabControl1.TabIndex = 0;
            // 
            // filter_tab
            // 
            this.filter_tab.Controls.Add(this.boxNumber_check);
            this.filter_tab.Controls.Add(this.elementType_check);
            this.filter_tab.Controls.Add(this.quantity_check);
            this.filter_tab.Controls.Add(this.posName_check);
            this.filter_tab.Controls.Add(this.box_number);
            this.filter_tab.Controls.Add(this.boxNumber_label);
            this.filter_tab.Controls.Add(this.elementType_label);
            this.filter_tab.Controls.Add(this.quantity_label);
            this.filter_tab.Controls.Add(this.posName_label);
            this.filter_tab.Controls.Add(this.findSelected_button);
            this.filter_tab.Controls.Add(this.element_type);
            this.filter_tab.Controls.Add(this.quantity);
            this.filter_tab.Controls.Add(this.pos_name);
            this.filter_tab.Location = new System.Drawing.Point(12, 58);
            this.filter_tab.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.filter_tab.Name = "filter_tab";
            this.filter_tab.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.filter_tab.Size = new System.Drawing.Size(682, 679);
            this.filter_tab.TabIndex = 0;
            this.filter_tab.Text = "Search";
            this.filter_tab.UseVisualStyleBackColor = true;
            // 
            // boxNumber_check
            // 
            this.boxNumber_check.AutoSize = true;
            this.boxNumber_check.Location = new System.Drawing.Point(19, 342);
            this.boxNumber_check.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.boxNumber_check.Name = "boxNumber_check";
            this.boxNumber_check.Size = new System.Drawing.Size(42, 41);
            this.boxNumber_check.TabIndex = 12;
            this.boxNumber_check.UseVisualStyleBackColor = true;
            this.boxNumber_check.CheckedChanged += new System.EventHandler(this.boxNumber_check_CheckedChanged);
            // 
            // elementType_check
            // 
            this.elementType_check.AutoSize = true;
            this.elementType_check.Location = new System.Drawing.Point(19, 228);
            this.elementType_check.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.elementType_check.Name = "elementType_check";
            this.elementType_check.Size = new System.Drawing.Size(42, 41);
            this.elementType_check.TabIndex = 11;
            this.elementType_check.UseVisualStyleBackColor = true;
            this.elementType_check.CheckedChanged += new System.EventHandler(this.elementType_check_CheckedChanged);
            // 
            // quantity_check
            // 
            this.quantity_check.AutoSize = true;
            this.quantity_check.Location = new System.Drawing.Point(19, 120);
            this.quantity_check.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.quantity_check.Name = "quantity_check";
            this.quantity_check.Size = new System.Drawing.Size(42, 41);
            this.quantity_check.TabIndex = 10;
            this.quantity_check.UseVisualStyleBackColor = true;
            this.quantity_check.CheckedChanged += new System.EventHandler(this.quantity_check_CheckedChanged);
            // 
            // posName_check
            // 
            this.posName_check.AutoSize = true;
            this.posName_check.Location = new System.Drawing.Point(19, 9);
            this.posName_check.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.posName_check.Name = "posName_check";
            this.posName_check.Size = new System.Drawing.Size(42, 41);
            this.posName_check.TabIndex = 9;
            this.posName_check.UseVisualStyleBackColor = true;
            this.posName_check.CheckedChanged += new System.EventHandler(this.posName_check_CheckedChanged);
            // 
            // box_number
            // 
            this.box_number.Location = new System.Drawing.Point(19, 387);
            this.box_number.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.box_number.Name = "box_number";
            this.box_number.Size = new System.Drawing.Size(602, 44);
            this.box_number.TabIndex = 8;
            // 
            // boxNumber_label
            // 
            this.boxNumber_label.AutoSize = true;
            this.boxNumber_label.Location = new System.Drawing.Point(73, 342);
            this.boxNumber_label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.boxNumber_label.Name = "boxNumber_label";
            this.boxNumber_label.Size = new System.Drawing.Size(189, 37);
            this.boxNumber_label.TabIndex = 7;
            this.boxNumber_label.Text = "Box number";
            // 
            // elementType_label
            // 
            this.elementType_label.AutoSize = true;
            this.elementType_label.Location = new System.Drawing.Point(82, 231);
            this.elementType_label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.elementType_label.Name = "elementType_label";
            this.elementType_label.Size = new System.Drawing.Size(201, 37);
            this.elementType_label.TabIndex = 6;
            this.elementType_label.Text = "Element type";
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Location = new System.Drawing.Point(73, 120);
            this.quantity_label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(136, 37);
            this.quantity_label.TabIndex = 5;
            this.quantity_label.Text = "Quantity";
            // 
            // posName_label
            // 
            this.posName_label.AutoSize = true;
            this.posName_label.Location = new System.Drawing.Point(73, 9);
            this.posName_label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.posName_label.Name = "posName_label";
            this.posName_label.Size = new System.Drawing.Size(222, 37);
            this.posName_label.TabIndex = 4;
            this.posName_label.Text = "Element name";
            // 
            // findSelected_button
            // 
            this.findSelected_button.Location = new System.Drawing.Point(19, 461);
            this.findSelected_button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.findSelected_button.Name = "findSelected_button";
            this.findSelected_button.Size = new System.Drawing.Size(611, 196);
            this.findSelected_button.TabIndex = 3;
            this.findSelected_button.Text = "Search";
            this.findSelected_button.UseVisualStyleBackColor = true;
            this.findSelected_button.Click += new System.EventHandler(this.findSelected_button_Click);
            // 
            // element_type
            // 
            this.element_type.Location = new System.Drawing.Point(19, 276);
            this.element_type.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.element_type.Name = "element_type";
            this.element_type.Size = new System.Drawing.Size(602, 44);
            this.element_type.TabIndex = 2;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(19, 165);
            this.quantity.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(602, 44);
            this.quantity.TabIndex = 1;
            // 
            // pos_name
            // 
            this.pos_name.Location = new System.Drawing.Point(19, 54);
            this.pos_name.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pos_name.Name = "pos_name";
            this.pos_name.Size = new System.Drawing.Size(602, 44);
            this.pos_name.TabIndex = 0;
            // 
            // data_changing_tab
            // 
            this.data_changing_tab.Controls.Add(this.panel1);
            this.data_changing_tab.Controls.Add(this.delete_button);
            this.data_changing_tab.Location = new System.Drawing.Point(12, 58);
            this.data_changing_tab.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.data_changing_tab.Name = "data_changing_tab";
            this.data_changing_tab.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.data_changing_tab.Size = new System.Drawing.Size(682, 679);
            this.data_changing_tab.TabIndex = 1;
            this.data_changing_tab.Text = "Add/Delete";
            this.data_changing_tab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.box_number_add);
            this.panel1.Controls.Add(this.quantity_add);
            this.panel1.Controls.Add(this.element_type_add);
            this.panel1.Controls.Add(this.pos_name_add);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Location = new System.Drawing.Point(19, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 537);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "element_type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "quantity_number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "box_name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "position_name";
            // 
            // box_number_add
            // 
            this.box_number_add.Location = new System.Drawing.Point(19, 376);
            this.box_number_add.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.box_number_add.Name = "box_number_add";
            this.box_number_add.Size = new System.Drawing.Size(549, 44);
            this.box_number_add.TabIndex = 4;
            // 
            // quantity_add
            // 
            this.quantity_add.Location = new System.Drawing.Point(19, 265);
            this.quantity_add.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.quantity_add.Name = "quantity_add";
            this.quantity_add.Size = new System.Drawing.Size(549, 44);
            this.quantity_add.TabIndex = 3;
            // 
            // element_type_add
            // 
            this.element_type_add.Location = new System.Drawing.Point(19, 157);
            this.element_type_add.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.element_type_add.Name = "element_type_add";
            this.element_type_add.Size = new System.Drawing.Size(549, 44);
            this.element_type_add.TabIndex = 2;
            // 
            // pos_name_add
            // 
            this.pos_name_add.Location = new System.Drawing.Point(19, 46);
            this.pos_name_add.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pos_name_add.Name = "pos_name_add";
            this.pos_name_add.Size = new System.Drawing.Size(549, 44);
            this.pos_name_add.TabIndex = 1;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(3, 447);
            this.add_button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(586, 80);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add a new item";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(19, 581);
            this.delete_button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(605, 77);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "Delete selected item";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.change_button);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(12, 58);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(682, 679);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Change";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(16, 430);
            this.change_button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(633, 205);
            this.change_button.TabIndex = 7;
            this.change_button.Text = "Apply changes";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.change_data);
            this.panel3.Controls.Add(this.current_data);
            this.panel3.Location = new System.Drawing.Point(19, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 370);
            this.panel3.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "new data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 37);
            this.label7.TabIndex = 2;
            this.label7.Text = "current data";
            // 
            // change_data
            // 
            this.change_data.Location = new System.Drawing.Point(10, 239);
            this.change_data.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.change_data.Name = "change_data";
            this.change_data.Size = new System.Drawing.Size(571, 44);
            this.change_data.TabIndex = 1;
            // 
            // current_data
            // 
            this.current_data.Location = new System.Drawing.Point(10, 88);
            this.current_data.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.current_data.Name = "current_data";
            this.current_data.ReadOnly = true;
            this.current_data.Size = new System.Drawing.Size(571, 44);
            this.current_data.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(38, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.Size = new System.Drawing.Size(1460, 1691);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // open_base
            // 
            this.open_base.Location = new System.Drawing.Point(22, 285);
            this.open_base.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.open_base.Name = "open_base";
            this.open_base.Size = new System.Drawing.Size(621, 102);
            this.open_base.TabIndex = 2;
            this.open_base.Text = "Open database";
            this.open_base.UseVisualStyleBackColor = true;
            this.open_base.Click += new System.EventHandler(this.open_base_Click);
            // 
            // login_text
            // 
            this.login_text.Location = new System.Drawing.Point(32, 71);
            this.login_text.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(606, 44);
            this.login_text.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "User login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.password_text);
            this.panel2.Controls.Add(this.login_text);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.open_base);
            this.panel2.Location = new System.Drawing.Point(1517, 1304);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 421);
            this.panel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "User password";
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(28, 211);
            this.password_text.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(606, 44);
            this.password_text.TabIndex = 6;
            // 
            // data_mode_switch
            // 
            this.data_mode_switch.Location = new System.Drawing.Point(32, 40);
            this.data_mode_switch.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.data_mode_switch.Name = "data_mode_switch";
            this.data_mode_switch.Size = new System.Drawing.Size(611, 111);
            this.data_mode_switch.TabIndex = 6;
            this.data_mode_switch.Text = "Show events";
            this.data_mode_switch.UseVisualStyleBackColor = true;
            this.data_mode_switch.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.data_mode_switch);
            this.panel4.Location = new System.Drawing.Point(1517, 996);
            this.panel4.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 185);
            this.panel4.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1539, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(365, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "Operations with the data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1523, 951);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(379, 37);
            this.label10.TabIndex = 9;
            this.label10.Text = "Servise information mode";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1530, 1255);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(268, 37);
            this.label11.TabIndex = 10;
            this.label11.Text = "Enter in database";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2218, 1733);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "LTU database";
            this.tabControl1.ResumeLayout(false);
            this.filter_tab.ResumeLayout(false);
            this.filter_tab.PerformLayout();
            this.data_changing_tab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage filter_tab;
        private System.Windows.Forms.Label elementType_label;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Label posName_label;
        private System.Windows.Forms.Button findSelected_button;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox pos_name;
        private System.Windows.Forms.TabPage data_changing_tab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox box_number;
        private System.Windows.Forms.Label boxNumber_label;
        private System.Windows.Forms.TextBox element_type;
        private System.Windows.Forms.CheckBox boxNumber_check;
        private System.Windows.Forms.CheckBox elementType_check;
        private System.Windows.Forms.CheckBox quantity_check;
        private System.Windows.Forms.CheckBox posName_check;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_number_add;
        private System.Windows.Forms.TextBox quantity_add;
        private System.Windows.Forms.TextBox element_type_add;
        private System.Windows.Forms.TextBox pos_name_add;
        private System.Windows.Forms.Button open_base;
        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox change_data;
        private System.Windows.Forms.TextBox current_data;
        private System.Windows.Forms.Button data_mode_switch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

