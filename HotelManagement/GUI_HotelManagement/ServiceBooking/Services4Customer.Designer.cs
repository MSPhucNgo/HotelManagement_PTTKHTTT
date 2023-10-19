namespace HotelManagement
{
    partial class Services4Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl_services_for_customer = new TabControl();
            tabPage1 = new TabPage();
            dtgvRoomList = new DataGridView();
            panel1 = new Panel();
            btn_room_search = new Button();
            txbRoomID = new TextBox();
            lb_room_search = new Label();
            tabPage2 = new TabPage();
            dtgvTour = new DataGridView();
            panel2 = new Panel();
            cbxEnd = new CheckBox();
            cbxLea = new CheckBox();
            cbxDes = new CheckBox();
            cbxDep = new CheckBox();
            txbError = new TextBox();
            label1 = new Label();
            timepickEnd = new DateTimePicker();
            timepickLeaving = new DateTimePicker();
            cbxDestination = new ComboBox();
            btn_tour_search = new Button();
            cbxDeparture = new ComboBox();
            lb_tour_search_tour_sort = new Label();
            lb_tour_search_leaving_time = new Label();
            lb_tour_search_des = new Label();
            lb_tour_search_dep = new Label();
            tabPage3 = new TabPage();
            dtgvServiceForm = new DataGridView();
            panel3 = new Panel();
            btnSearchServiceForm = new Button();
            tbSearchPhone = new TextBox();
            label2 = new Label();
            tabPage4 = new TabPage();
            dtgvCustomerTour = new DataGridView();
            panel4 = new Panel();
            btnSearchCustomerTour = new Button();
            tbSearchPhoneTour = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            button4 = new Button();
            label4 = new Label();
            tabControl_services_for_customer.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRoomList).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTour).BeginInit();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvServiceForm).BeginInit();
            panel3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomerTour).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl_services_for_customer
            // 
            tabControl_services_for_customer.Controls.Add(tabPage1);
            tabControl_services_for_customer.Controls.Add(tabPage2);
            tabControl_services_for_customer.Controls.Add(tabPage3);
            tabControl_services_for_customer.Controls.Add(tabPage4);
            tabControl_services_for_customer.Cursor = Cursors.Hand;
            tabControl_services_for_customer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl_services_for_customer.ItemSize = new Size(100, 35);
            tabControl_services_for_customer.Location = new Point(13, 62);
            tabControl_services_for_customer.Margin = new Padding(2);
            tabControl_services_for_customer.Multiline = true;
            tabControl_services_for_customer.Name = "tabControl_services_for_customer";
            tabControl_services_for_customer.Padding = new Point(20, 3);
            tabControl_services_for_customer.SelectedIndex = 0;
            tabControl_services_for_customer.Size = new Size(1123, 493);
            tabControl_services_for_customer.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(dtgvRoomList);
            tabPage1.Controls.Add(panel1);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1115, 450);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Room Search";
            // 
            // dtgvRoomList
            // 
            dtgvRoomList.AllowUserToAddRows = false;
            dtgvRoomList.AllowUserToDeleteRows = false;
            dtgvRoomList.BackgroundColor = Color.Silver;
            dtgvRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRoomList.Location = new Point(17, 103);
            dtgvRoomList.Margin = new Padding(2);
            dtgvRoomList.Name = "dtgvRoomList";
            dtgvRoomList.ReadOnly = true;
            dtgvRoomList.RowHeadersWidth = 62;
            dtgvRoomList.RowTemplate.Height = 33;
            dtgvRoomList.Size = new Size(1084, 343);
            dtgvRoomList.TabIndex = 1;
            dtgvRoomList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(212, 230, 242);
            panel1.Controls.Add(btn_room_search);
            panel1.Controls.Add(txbRoomID);
            panel1.Controls.Add(lb_room_search);
            panel1.Location = new Point(17, 21);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 62);
            panel1.TabIndex = 0;
            // 
            // btn_room_search
            // 
            btn_room_search.BackColor = Color.FromArgb(8, 48, 107);
            btn_room_search.Cursor = Cursors.Hand;
            btn_room_search.FlatAppearance.BorderSize = 0;
            btn_room_search.FlatStyle = FlatStyle.Flat;
            btn_room_search.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_room_search.ForeColor = Color.White;
            btn_room_search.Location = new Point(715, 17);
            btn_room_search.Margin = new Padding(2);
            btn_room_search.Name = "btn_room_search";
            btn_room_search.Size = new Size(116, 29);
            btn_room_search.TabIndex = 2;
            btn_room_search.Text = "Search";
            btn_room_search.UseVisualStyleBackColor = false;
            btn_room_search.Click += btn_room_search_Click;
            // 
            // txbRoomID
            // 
            txbRoomID.BorderStyle = BorderStyle.FixedSingle;
            txbRoomID.Cursor = Cursors.IBeam;
            txbRoomID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbRoomID.Location = new Point(331, 17);
            txbRoomID.Margin = new Padding(2);
            txbRoomID.Name = "txbRoomID";
            txbRoomID.Size = new Size(360, 29);
            txbRoomID.TabIndex = 1;
            txbRoomID.TextChanged += textBox1_TextChanged;
            // 
            // lb_room_search
            // 
            lb_room_search.AutoSize = true;
            lb_room_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_room_search.Location = new Point(246, 21);
            lb_room_search.Margin = new Padding(2, 0, 2, 0);
            lb_room_search.Name = "lb_room_search";
            lb_room_search.Size = new Size(74, 21);
            lb_room_search.TabIndex = 0;
            lb_room_search.Text = "Room ID:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dtgvTour);
            tabPage2.Controls.Add(panel2);
            tabPage2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1115, 450);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tour Search";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgvTour
            // 
            dtgvTour.BackgroundColor = Color.Silver;
            dtgvTour.ColumnHeadersHeight = 34;
            dtgvTour.Location = new Point(19, 127);
            dtgvTour.Margin = new Padding(2);
            dtgvTour.Name = "dtgvTour";
            dtgvTour.RowHeadersWidth = 62;
            dtgvTour.Size = new Size(1079, 307);
            dtgvTour.TabIndex = 0;
            dtgvTour.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 230, 242);
            panel2.Controls.Add(cbxEnd);
            panel2.Controls.Add(cbxLea);
            panel2.Controls.Add(cbxDes);
            panel2.Controls.Add(cbxDep);
            panel2.Controls.Add(txbError);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(timepickEnd);
            panel2.Controls.Add(timepickLeaving);
            panel2.Controls.Add(cbxDestination);
            panel2.Controls.Add(btn_tour_search);
            panel2.Controls.Add(cbxDeparture);
            panel2.Controls.Add(lb_tour_search_tour_sort);
            panel2.Controls.Add(lb_tour_search_leaving_time);
            panel2.Controls.Add(lb_tour_search_des);
            panel2.Controls.Add(lb_tour_search_dep);
            panel2.ForeColor = Color.CadetBlue;
            panel2.Location = new Point(19, 18);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1079, 89);
            panel2.TabIndex = 0;
            // 
            // cbxEnd
            // 
            cbxEnd.AutoSize = true;
            cbxEnd.Location = new Point(751, 60);
            cbxEnd.Margin = new Padding(3, 2, 3, 2);
            cbxEnd.Name = "cbxEnd";
            cbxEnd.Size = new Size(15, 14);
            cbxEnd.TabIndex = 15;
            cbxEnd.UseVisualStyleBackColor = true;
            // 
            // cbxLea
            // 
            cbxLea.AutoSize = true;
            cbxLea.Location = new Point(360, 60);
            cbxLea.Margin = new Padding(3, 2, 3, 2);
            cbxLea.Name = "cbxLea";
            cbxLea.Size = new Size(15, 14);
            cbxLea.TabIndex = 14;
            cbxLea.UseVisualStyleBackColor = true;
            cbxLea.CheckedChanged += cbxLea_CheckedChanged;
            // 
            // cbxDes
            // 
            cbxDes.AutoSize = true;
            cbxDes.Location = new Point(751, 27);
            cbxDes.Margin = new Padding(3, 2, 3, 2);
            cbxDes.Name = "cbxDes";
            cbxDes.Size = new Size(15, 14);
            cbxDes.TabIndex = 13;
            cbxDes.UseVisualStyleBackColor = true;
            // 
            // cbxDep
            // 
            cbxDep.AutoSize = true;
            cbxDep.Location = new Point(361, 27);
            cbxDep.Margin = new Padding(3, 2, 3, 2);
            cbxDep.Name = "cbxDep";
            cbxDep.Size = new Size(15, 14);
            cbxDep.TabIndex = 12;
            cbxDep.UseVisualStyleBackColor = true;
            cbxDep.CheckedChanged += cbxDep_CheckedChanged;
            // 
            // txbError
            // 
            txbError.Location = new Point(855, 30);
            txbError.Margin = new Padding(3, 2, 3, 2);
            txbError.Name = "txbError";
            txbError.Size = new Size(48, 29);
            txbError.TabIndex = 11;
            txbError.TextChanged += txbError_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(801, 33);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 10;
            label1.Text = "Error:";
            // 
            // timepickEnd
            // 
            timepickEnd.Location = new Point(526, 45);
            timepickEnd.Margin = new Padding(3, 2, 3, 2);
            timepickEnd.Name = "timepickEnd";
            timepickEnd.Size = new Size(219, 29);
            timepickEnd.TabIndex = 9;
            timepickEnd.ValueChanged += timepickEnd_ValueChanged;
            // 
            // timepickLeaving
            // 
            timepickLeaving.Location = new Point(136, 45);
            timepickLeaving.Margin = new Padding(3, 2, 3, 2);
            timepickLeaving.Name = "timepickLeaving";
            timepickLeaving.Size = new Size(219, 29);
            timepickLeaving.TabIndex = 3;
            timepickLeaving.ValueChanged += timepickLeaving_ValueChanged;
            // 
            // cbxDestination
            // 
            cbxDestination.FormattingEnabled = true;
            cbxDestination.Location = new Point(526, 12);
            cbxDestination.Margin = new Padding(3, 2, 3, 2);
            cbxDestination.Name = "cbxDestination";
            cbxDestination.Size = new Size(219, 29);
            cbxDestination.TabIndex = 8;
            cbxDestination.SelectedIndexChanged += cbxDestination_SelectedIndexChanged;
            // 
            // btn_tour_search
            // 
            btn_tour_search.BackColor = Color.FromArgb(8, 48, 107);
            btn_tour_search.FlatAppearance.BorderSize = 0;
            btn_tour_search.FlatStyle = FlatStyle.Flat;
            btn_tour_search.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tour_search.ForeColor = Color.White;
            btn_tour_search.Location = new Point(938, 24);
            btn_tour_search.Margin = new Padding(2);
            btn_tour_search.Name = "btn_tour_search";
            btn_tour_search.Size = new Size(120, 38);
            btn_tour_search.TabIndex = 0;
            btn_tour_search.Text = "Search Tour";
            btn_tour_search.UseVisualStyleBackColor = false;
            btn_tour_search.Click += btn_tour_search_Click;
            // 
            // cbxDeparture
            // 
            cbxDeparture.FormattingEnabled = true;
            cbxDeparture.Location = new Point(136, 12);
            cbxDeparture.Margin = new Padding(3, 2, 3, 2);
            cbxDeparture.Name = "cbxDeparture";
            cbxDeparture.Size = new Size(219, 29);
            cbxDeparture.TabIndex = 1;
            cbxDeparture.SelectedIndexChanged += cbxDeparture_SelectedIndexChanged;
            // 
            // lb_tour_search_tour_sort
            // 
            lb_tour_search_tour_sort.AutoSize = true;
            lb_tour_search_tour_sort.ForeColor = Color.FromArgb(8, 48, 107);
            lb_tour_search_tour_sort.Location = new Point(432, 53);
            lb_tour_search_tour_sort.Margin = new Padding(2, 0, 2, 0);
            lb_tour_search_tour_sort.Name = "lb_tour_search_tour_sort";
            lb_tour_search_tour_sort.Size = new Size(77, 21);
            lb_tour_search_tour_sort.TabIndex = 6;
            lb_tour_search_tour_sort.Text = "End Time:";
            // 
            // lb_tour_search_leaving_time
            // 
            lb_tour_search_leaving_time.AutoSize = true;
            lb_tour_search_leaving_time.ForeColor = Color.FromArgb(8, 48, 107);
            lb_tour_search_leaving_time.Location = new Point(24, 51);
            lb_tour_search_leaving_time.Margin = new Padding(2, 0, 2, 0);
            lb_tour_search_leaving_time.Name = "lb_tour_search_leaving_time";
            lb_tour_search_leaving_time.Size = new Size(105, 21);
            lb_tour_search_leaving_time.TabIndex = 4;
            lb_tour_search_leaving_time.Text = "Leaving Time:";
            // 
            // lb_tour_search_des
            // 
            lb_tour_search_des.AutoSize = true;
            lb_tour_search_des.ForeColor = Color.FromArgb(8, 48, 107);
            lb_tour_search_des.Location = new Point(432, 16);
            lb_tour_search_des.Margin = new Padding(2, 0, 2, 0);
            lb_tour_search_des.Name = "lb_tour_search_des";
            lb_tour_search_des.Size = new Size(92, 21);
            lb_tour_search_des.TabIndex = 2;
            lb_tour_search_des.Text = "Destination:";
            // 
            // lb_tour_search_dep
            // 
            lb_tour_search_dep.AutoSize = true;
            lb_tour_search_dep.ForeColor = Color.FromArgb(8, 48, 107);
            lb_tour_search_dep.Location = new Point(24, 20);
            lb_tour_search_dep.Margin = new Padding(2, 0, 2, 0);
            lb_tour_search_dep.Name = "lb_tour_search_dep";
            lb_tour_search_dep.Size = new Size(83, 21);
            lb_tour_search_dep.TabIndex = 0;
            lb_tour_search_dep.Text = "Departure:";
            lb_tour_search_dep.Click += label2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dtgvServiceForm);
            tabPage3.Controls.Add(panel3);
            tabPage3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 39);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(1115, 450);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Service Search";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtgvServiceForm
            // 
            dtgvServiceForm.AllowUserToAddRows = false;
            dtgvServiceForm.AllowUserToDeleteRows = false;
            dtgvServiceForm.BackgroundColor = Color.Silver;
            dtgvServiceForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvServiceForm.Location = new Point(22, 108);
            dtgvServiceForm.Margin = new Padding(2);
            dtgvServiceForm.Name = "dtgvServiceForm";
            dtgvServiceForm.ReadOnly = true;
            dtgvServiceForm.RowHeadersWidth = 62;
            dtgvServiceForm.RowTemplate.Height = 33;
            dtgvServiceForm.Size = new Size(1070, 338);
            dtgvServiceForm.TabIndex = 3;
            dtgvServiceForm.CellContentClick += dtgvServiceForm_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(212, 230, 242);
            panel3.Controls.Add(btnSearchServiceForm);
            panel3.Controls.Add(tbSearchPhone);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(22, 18);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1070, 65);
            panel3.TabIndex = 2;
            // 
            // btnSearchServiceForm
            // 
            btnSearchServiceForm.BackColor = Color.FromArgb(8, 48, 107);
            btnSearchServiceForm.FlatAppearance.BorderSize = 0;
            btnSearchServiceForm.FlatStyle = FlatStyle.Flat;
            btnSearchServiceForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchServiceForm.ForeColor = Color.White;
            btnSearchServiceForm.Location = new Point(745, 19);
            btnSearchServiceForm.Margin = new Padding(2);
            btnSearchServiceForm.Name = "btnSearchServiceForm";
            btnSearchServiceForm.Size = new Size(107, 29);
            btnSearchServiceForm.TabIndex = 2;
            btnSearchServiceForm.Text = "Search";
            btnSearchServiceForm.UseVisualStyleBackColor = false;
            btnSearchServiceForm.Click += btnSearchServiceForm_Click;
            // 
            // tbSearchPhone
            // 
            tbSearchPhone.BorderStyle = BorderStyle.FixedSingle;
            tbSearchPhone.Location = new Point(390, 19);
            tbSearchPhone.Margin = new Padding(2);
            tbSearchPhone.Name = "tbSearchPhone";
            tbSearchPhone.Size = new Size(332, 29);
            tbSearchPhone.TabIndex = 1;
            tbSearchPhone.TextChanged += textBox1_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 0;
            label2.Text = "Phone number:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dtgvCustomerTour);
            tabPage4.Controls.Add(panel4);
            tabPage4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage4.Location = new Point(4, 39);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(1115, 450);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Customer Tour Search";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dtgvCustomerTour
            // 
            dtgvCustomerTour.AllowUserToAddRows = false;
            dtgvCustomerTour.AllowUserToDeleteRows = false;
            dtgvCustomerTour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCustomerTour.Location = new Point(20, 108);
            dtgvCustomerTour.Margin = new Padding(2);
            dtgvCustomerTour.Name = "dtgvCustomerTour";
            dtgvCustomerTour.ReadOnly = true;
            dtgvCustomerTour.RowHeadersWidth = 62;
            dtgvCustomerTour.RowTemplate.Height = 33;
            dtgvCustomerTour.Size = new Size(1075, 338);
            dtgvCustomerTour.TabIndex = 5;
            dtgvCustomerTour.CellContentClick += dtgvCustomerTour_CellContentClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(212, 230, 242);
            panel4.Controls.Add(btnSearchCustomerTour);
            panel4.Controls.Add(tbSearchPhoneTour);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(20, 18);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1075, 68);
            panel4.TabIndex = 4;
            // 
            // btnSearchCustomerTour
            // 
            btnSearchCustomerTour.BackColor = Color.FromArgb(8, 48, 107);
            btnSearchCustomerTour.FlatAppearance.BorderSize = 0;
            btnSearchCustomerTour.FlatStyle = FlatStyle.Flat;
            btnSearchCustomerTour.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchCustomerTour.ForeColor = Color.White;
            btnSearchCustomerTour.Location = new Point(741, 19);
            btnSearchCustomerTour.Margin = new Padding(2);
            btnSearchCustomerTour.Name = "btnSearchCustomerTour";
            btnSearchCustomerTour.Size = new Size(104, 29);
            btnSearchCustomerTour.TabIndex = 2;
            btnSearchCustomerTour.Text = "Search";
            btnSearchCustomerTour.UseVisualStyleBackColor = false;
            btnSearchCustomerTour.Click += btnSearchCustomerTour_Click;
            // 
            // tbSearchPhoneTour
            // 
            tbSearchPhoneTour.BorderStyle = BorderStyle.FixedSingle;
            tbSearchPhoneTour.Location = new Point(392, 19);
            tbSearchPhoneTour.Margin = new Padding(2);
            tbSearchPhoneTour.Name = "tbSearchPhoneTour";
            tbSearchPhoneTour.Size = new Size(326, 29);
            tbSearchPhoneTour.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 23);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 0;
            label3.Text = "Phone number:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(tabControl_services_for_customer);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(1153, 572);
            panel5.TabIndex = 1;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(239, 59, 44);
            button4.Location = new Point(1110, 3);
            button4.Name = "button4";
            button4.Size = new Size(40, 36);
            button4.TabIndex = 25;
            button4.Text = "x";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(8, 48, 107);
            label4.Location = new Point(448, 18);
            label4.Name = "label4";
            label4.Size = new Size(271, 30);
            label4.TabIndex = 26;
            label4.Text = "SERVICE FOR CUSTOMER";
            // 
            // Services4Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 193, 138);
            ClientSize = new Size(1173, 592);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Services4Customer";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Services_for_customer";
            Load += Services4Customer_Load;
            tabControl_services_for_customer.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvRoomList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTour).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvServiceForm).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCustomerTour).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl_services_for_customer;
        private TabPage tabPage1;
        private DataGridView dtgvRoomList;
        private Panel panel1;
        private Button btn_room_search;
        private TextBox txbRoomID;
        private Label lb_room_search;
        private TabPage tabPage2;
        private Label lb_tour_search_dep;
        private Panel panel2;
        private TabPage tabPage3;
        private Label lb_tour_search_tour_sort;
        private Label lb_tour_search_leaving_time;
        private Label lb_tour_search_des;
        private DataGridView dtgvTour;
        private Button btn_tour_search;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn ID_ROOM;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn STATUS;
        private DataGridViewTextBoxColumn PRICE;
        private DataGridViewTextBoxColumn TYPE;
        private ComboBox cbxTourType;
        private DateTimePicker timepickLeaving;
        private ComboBox cbxDestination;
        private ComboBox cbxDeparture;
        private DateTimePicker timepickEnd;
        private TextBox txbError;
        private Label label1;
        private DataGridView dtgvServiceForm;
        private Panel panel3;
        private Button btnSearchServiceForm;
        private TextBox tbSearchPhone;
        private Label label2;
        private TabPage tabPage4;
        private DataGridView dtgvCustomerTour;
        private Panel panel4;
        private Button btnSearchCustomerTour;
        private TextBox tbSearchPhoneTour;
        private Label label3;
        private CheckBox cbxEnd;
        private CheckBox cbxLea;
        private CheckBox cbxDes;
        private CheckBox cbxDep;
        private Panel panel5;
        private Button button4;
        private Label label4;
    }
}