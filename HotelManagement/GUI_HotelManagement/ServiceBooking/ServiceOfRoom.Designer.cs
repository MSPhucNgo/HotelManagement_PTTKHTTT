namespace HotelManagement
{
    partial class Service_Of_Room
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
            components = new System.ComponentModel.Container();
            dtgvServiceList = new DataGridView();
            panel1 = new Panel();
            btnSearchAll = new Button();
            btnSearch = new Button();
            txbServiceName = new TextBox();
            lb_room_service = new Label();
            bindingSource1 = new BindingSource(components);
            panel2 = new Panel();
            txbOffer = new TextBox();
            txbStatus = new TextBox();
            label1 = new Label();
            label7 = new Label();
            txtPrice = new TextBox();
            label6 = new Label();
            txtUnit = new TextBox();
            label5 = new Label();
            txtDesc = new TextBox();
            label4 = new Label();
            txbName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dtgvOffer = new DataGridView();
            btnOrder = new Button();
            dtgvAllServices = new DataGridView();
            panel3 = new Panel();
            button4 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvServiceList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOffer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvAllServices).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvServiceList
            // 
            dtgvServiceList.BackgroundColor = Color.Silver;
            dtgvServiceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvServiceList.Location = new Point(24, 118);
            dtgvServiceList.Margin = new Padding(2);
            dtgvServiceList.Name = "dtgvServiceList";
            dtgvServiceList.RowHeadersWidth = 62;
            dtgvServiceList.RowTemplate.Height = 33;
            dtgvServiceList.Size = new Size(715, 263);
            dtgvServiceList.TabIndex = 0;
            dtgvServiceList.CellContentClick += dtgvServiceList_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(212, 230, 242);
            panel1.Controls.Add(btnSearchAll);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txbServiceName);
            panel1.Controls.Add(lb_room_service);
            panel1.Location = new Point(24, 58);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 47);
            panel1.TabIndex = 1;
            // 
            // btnSearchAll
            // 
            btnSearchAll.BackColor = Color.FromArgb(8, 48, 107);
            btnSearchAll.Cursor = Cursors.Hand;
            btnSearchAll.FlatStyle = FlatStyle.Flat;
            btnSearchAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchAll.ForeColor = Color.White;
            btnSearchAll.Location = new Point(747, 8);
            btnSearchAll.Margin = new Padding(2);
            btnSearchAll.Name = "btnSearchAll";
            btnSearchAll.Size = new Size(157, 30);
            btnSearchAll.TabIndex = 3;
            btnSearchAll.Text = "Search All Services";
            btnSearchAll.UseVisualStyleBackColor = false;
            btnSearchAll.Click += btnSearchAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(8, 48, 107);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(570, 8);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(157, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search Service ";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button1_Click;
            // 
            // txbServiceName
            // 
            txbServiceName.BorderStyle = BorderStyle.FixedSingle;
            txbServiceName.Location = new Point(299, 12);
            txbServiceName.Margin = new Padding(2);
            txbServiceName.Name = "txbServiceName";
            txbServiceName.Size = new Size(248, 23);
            txbServiceName.TabIndex = 1;
            // 
            // lb_room_service
            // 
            lb_room_service.AutoSize = true;
            lb_room_service.Location = new Point(209, 16);
            lb_room_service.Margin = new Padding(2, 0, 2, 0);
            lb_room_service.Name = "lb_room_service";
            lb_room_service.Size = new Size(80, 15);
            lb_room_service.TabIndex = 0;
            lb_room_service.Text = "Service name:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 230, 242);
            panel2.Controls.Add(txbOffer);
            panel2.Controls.Add(txbStatus);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtUnit);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtDesc);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txbName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(768, 118);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 263);
            panel2.TabIndex = 2;
            // 
            // txbOffer
            // 
            txbOffer.BorderStyle = BorderStyle.FixedSingle;
            txbOffer.Cursor = Cursors.IBeam;
            txbOffer.Location = new Point(106, 221);
            txbOffer.Margin = new Padding(2);
            txbOffer.Name = "txbOffer";
            txbOffer.Size = new Size(237, 23);
            txbOffer.TabIndex = 18;
            // 
            // txbStatus
            // 
            txbStatus.BorderStyle = BorderStyle.FixedSingle;
            txbStatus.Cursor = Cursors.IBeam;
            txbStatus.Location = new Point(84, 62);
            txbStatus.Margin = new Padding(2);
            txbStatus.Name = "txbStatus";
            txbStatus.Size = new Size(259, 23);
            txbStatus.TabIndex = 16;
            txbStatus.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(8, 62);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 15;
            label1.Text = "Status:";
            label1.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(8, 48, 107);
            label7.Location = new Point(10, 223);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 12;
            label7.Text = "Offer for room:";
            label7.Click += label7_Click;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Cursor = Cursors.IBeam;
            txtPrice.Location = new Point(84, 128);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(259, 23);
            txtPrice.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(8, 48, 107);
            label6.Location = new Point(10, 130);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 10;
            label6.Text = "Price/unit:";
            // 
            // txtUnit
            // 
            txtUnit.BorderStyle = BorderStyle.FixedSingle;
            txtUnit.Cursor = Cursors.IBeam;
            txtUnit.Location = new Point(84, 94);
            txtUnit.Margin = new Padding(2);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(259, 23);
            txtUnit.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(8, 48, 107);
            label5.Location = new Point(8, 96);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 8;
            label5.Text = "Unit:";
            // 
            // txtDesc
            // 
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Cursor = Cursors.IBeam;
            txtDesc.Location = new Point(84, 163);
            txtDesc.Margin = new Padding(2);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(259, 46);
            txtDesc.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(8, 48, 107);
            label4.Location = new Point(10, 165);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Description:";
            // 
            // txbName
            // 
            txbName.BorderStyle = BorderStyle.FixedSingle;
            txbName.Cursor = Cursors.IBeam;
            txbName.Location = new Point(84, 31);
            txbName.Margin = new Padding(2);
            txbName.Name = "txbName";
            txbName.Size = new Size(259, 23);
            txbName.TabIndex = 5;
            txbName.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(8, 48, 107);
            label3.Location = new Point(8, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 1;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(8, 48, 107);
            label2.Location = new Point(113, 3);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 0;
            label2.Text = "Service Information";
            label2.Click += label2_Click;
            // 
            // dtgvOffer
            // 
            dtgvOffer.BackgroundColor = Color.Silver;
            dtgvOffer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOffer.Location = new Point(24, 397);
            dtgvOffer.Margin = new Padding(2);
            dtgvOffer.Name = "dtgvOffer";
            dtgvOffer.RowHeadersWidth = 62;
            dtgvOffer.RowTemplate.Height = 33;
            dtgvOffer.Size = new Size(1103, 182);
            dtgvOffer.TabIndex = 17;
            dtgvOffer.CellContentClick += dtgvOffer_CellContentClick;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(0, 193, 138);
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(426, 592);
            btnOrder.Margin = new Padding(2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(313, 47);
            btnOrder.TabIndex = 14;
            btnOrder.Text = "ORDER SERVICE NOW!";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // dtgvAllServices
            // 
            dtgvAllServices.BackgroundColor = Color.FromArgb(224, 224, 224);
            dtgvAllServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAllServices.Location = new Point(24, 118);
            dtgvAllServices.Margin = new Padding(2);
            dtgvAllServices.Name = "dtgvAllServices";
            dtgvAllServices.RowHeadersWidth = 62;
            dtgvAllServices.RowTemplate.Height = 33;
            dtgvAllServices.Size = new Size(715, 263);
            dtgvAllServices.TabIndex = 3;
            dtgvAllServices.CellContentClick += dtgvAllServices_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(btnOrder);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dtgvAllServices);
            panel3.Controls.Add(dtgvServiceList);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(dtgvOffer);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(1153, 654);
            panel3.TabIndex = 18;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(8, 48, 107);
            label8.Location = new Point(478, 15);
            label8.Name = "label8";
            label8.Size = new Size(208, 30);
            label8.TabIndex = 18;
            label8.Text = "SERVICE OF ROOM";
            // 
            // Service_Of_Room
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 193, 138);
            ClientSize = new Size(1173, 674);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Service_Of_Room";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service_Of_Room";
            ((System.ComponentModel.ISupportInitialize)dtgvServiceList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOffer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvAllServices).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvServiceList;
        private Panel panel1;
        private Button btnSearch;
        private TextBox txbServiceName;
        private Label lb_room_service;
        private BindingSource bindingSource1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TextBox txbName;
        private Button btnOrder;
        private TextBox txbDiscount;
        private Label label7;
        private TextBox txtPrice;
        private Label label6;
        private TextBox txtUnit;
        private Label label5;
        private TextBox txtDesc;
        private Label label4;
        private TextBox txbStatus;
        private Label label1;
        private CheckedListBox checklistOffer;
        private DataGridView dtgvOffer;
        private TextBox txbOffer;
        private DataGridView dtgvAllServices;
        private Button btnSearchAll;
        private Panel panel3;
        private Label label8;
        private Button button4;
    }
}