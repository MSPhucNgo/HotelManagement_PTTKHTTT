namespace GUI_HotelManagement
{
    partial class DetailRoom_Form
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
            Room_Label = new Label();
            roomID_Text = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Status_Text = new TextBox();
            label3 = new Label();
            Price_Text = new TextBox();
            label4 = new Label();
            roomName_Text = new TextBox();
            label5 = new Label();
            roomType_Text = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ItemList_DataGrid = new DataGridView();
            serviceList_DataGrid = new DataGridView();
            panel1 = new Panel();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel2 = new Panel();
            Identify_Text = new TextBox();
            Phone_Text = new TextBox();
            Email_Text = new TextBox();
            Birthday_Text = new TextBox();
            gender_Text = new TextBox();
            customerName_Text = new TextBox();
            panel3 = new Panel();
            button2 = new Button();
            button7 = new Button();
            label15 = new Label();
            panel4 = new Panel();
            Close_Button = new Button();
            Edit_Confirm_Button = new Button();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)ItemList_DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceList_DataGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Room_Label
            // 
            Room_Label.AutoSize = true;
            Room_Label.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Room_Label.ForeColor = Color.FromArgb(8, 48, 107);
            Room_Label.Location = new Point(131, 15);
            Room_Label.Name = "Room_Label";
            Room_Label.Size = new Size(134, 20);
            Room_Label.TabIndex = 0;
            Room_Label.Text = "Room Information";
            // 
            // roomID_Text
            // 
            roomID_Text.Enabled = false;
            roomID_Text.Location = new Point(91, 50);
            roomID_Text.Margin = new Padding(3, 2, 3, 2);
            roomID_Text.Name = "roomID_Text";
            roomID_Text.ReadOnly = true;
            roomID_Text.Size = new Size(254, 23);
            roomID_Text.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 50);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 2;
            label1.Text = "ID Room:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 152);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 3;
            label2.Text = "Status:";
            // 
            // Status_Text
            // 
            Status_Text.BorderStyle = BorderStyle.FixedSingle;
            Status_Text.Enabled = false;
            Status_Text.Location = new Point(91, 150);
            Status_Text.Margin = new Padding(3, 2, 3, 2);
            Status_Text.Name = "Status_Text";
            Status_Text.Size = new Size(254, 23);
            Status_Text.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 125);
            label3.Name = "label3";
            label3.Size = new Size(41, 19);
            label3.TabIndex = 5;
            label3.Text = "Price:";
            // 
            // Price_Text
            // 
            Price_Text.BorderStyle = BorderStyle.FixedSingle;
            Price_Text.Enabled = false;
            Price_Text.Location = new Point(91, 125);
            Price_Text.Margin = new Padding(3, 2, 3, 2);
            Price_Text.Name = "Price_Text";
            Price_Text.Size = new Size(254, 23);
            Price_Text.TabIndex = 6;
            Price_Text.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 74);
            label4.Name = "label4";
            label4.Size = new Size(48, 19);
            label4.TabIndex = 7;
            label4.Text = "Name:";
            // 
            // roomName_Text
            // 
            roomName_Text.BorderStyle = BorderStyle.FixedSingle;
            roomName_Text.Enabled = false;
            roomName_Text.Location = new Point(91, 74);
            roomName_Text.Margin = new Padding(3, 2, 3, 2);
            roomName_Text.Name = "roomName_Text";
            roomName_Text.Size = new Size(254, 23);
            roomName_Text.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 100);
            label5.Name = "label5";
            label5.Size = new Size(40, 19);
            label5.TabIndex = 9;
            label5.Text = "Type:";
            // 
            // roomType_Text
            // 
            roomType_Text.BorderStyle = BorderStyle.FixedSingle;
            roomType_Text.Enabled = false;
            roomType_Text.Location = new Point(91, 100);
            roomType_Text.Margin = new Padding(3, 2, 3, 2);
            roomType_Text.Name = "roomType_Text";
            roomType_Text.Size = new Size(254, 23);
            roomType_Text.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(8, 48, 107);
            label6.Location = new Point(117, 10);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 11;
            label6.Text = "Customer Information";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(8, 48, 107);
            label7.Location = new Point(498, 73);
            label7.Name = "label7";
            label7.Size = new Size(143, 21);
            label7.TabIndex = 12;
            label7.Text = "Services of Room:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(8, 48, 107);
            label8.Location = new Point(833, 73);
            label8.Name = "label8";
            label8.Size = new Size(123, 21);
            label8.TabIndex = 13;
            label8.Text = "Items of Room:";
            // 
            // ItemList_DataGrid
            // 
            ItemList_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemList_DataGrid.Location = new Point(833, 107);
            ItemList_DataGrid.Margin = new Padding(3, 2, 3, 2);
            ItemList_DataGrid.Name = "ItemList_DataGrid";
            ItemList_DataGrid.RowHeadersWidth = 51;
            ItemList_DataGrid.RowTemplate.Height = 29;
            ItemList_DataGrid.Size = new Size(284, 387);
            ItemList_DataGrid.TabIndex = 14;
            // 
            // serviceList_DataGrid
            // 
            serviceList_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceList_DataGrid.Location = new Point(498, 107);
            serviceList_DataGrid.Margin = new Padding(3, 2, 3, 2);
            serviceList_DataGrid.Name = "serviceList_DataGrid";
            serviceList_DataGrid.RowHeadersWidth = 51;
            serviceList_DataGrid.RowTemplate.Height = 29;
            serviceList_DataGrid.Size = new Size(288, 387);
            serviceList_DataGrid.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(212, 230, 242);
            panel1.Controls.Add(roomID_Text);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Status_Text);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(roomType_Text);
            panel1.Controls.Add(Price_Text);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(roomName_Text);
            panel1.Controls.Add(Room_Label);
            panel1.Location = new Point(46, 73);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 195);
            panel1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(15, 42);
            label9.Name = "label9";
            label9.Size = new Size(48, 19);
            label9.TabIndex = 17;
            label9.Text = "Name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(15, 69);
            label10.Name = "label10";
            label10.Size = new Size(57, 19);
            label10.TabIndex = 18;
            label10.Text = "Gender:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(15, 94);
            label11.Name = "label11";
            label11.Size = new Size(63, 19);
            label11.TabIndex = 19;
            label11.Text = "Birthday:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(15, 119);
            label12.Name = "label12";
            label12.Size = new Size(44, 19);
            label12.TabIndex = 20;
            label12.Text = "Email:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(15, 143);
            label13.Name = "label13";
            label13.Size = new Size(51, 19);
            label13.TabIndex = 21;
            label13.Text = "Phone:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(15, 168);
            label14.Name = "label14";
            label14.Size = new Size(88, 19);
            label14.TabIndex = 22;
            label14.Text = "Identify card:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 230, 242);
            panel2.Controls.Add(Identify_Text);
            panel2.Controls.Add(Phone_Text);
            panel2.Controls.Add(Email_Text);
            panel2.Controls.Add(Birthday_Text);
            panel2.Controls.Add(gender_Text);
            panel2.Controls.Add(customerName_Text);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(46, 288);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 206);
            panel2.TabIndex = 26;
            // 
            // Identify_Text
            // 
            Identify_Text.BorderStyle = BorderStyle.FixedSingle;
            Identify_Text.Enabled = false;
            Identify_Text.Location = new Point(103, 164);
            Identify_Text.Margin = new Padding(3, 2, 3, 2);
            Identify_Text.Name = "Identify_Text";
            Identify_Text.Size = new Size(128, 23);
            Identify_Text.TabIndex = 28;
            // 
            // Phone_Text
            // 
            Phone_Text.BorderStyle = BorderStyle.FixedSingle;
            Phone_Text.Enabled = false;
            Phone_Text.Location = new Point(103, 139);
            Phone_Text.Margin = new Padding(3, 2, 3, 2);
            Phone_Text.Name = "Phone_Text";
            Phone_Text.Size = new Size(128, 23);
            Phone_Text.TabIndex = 27;
            // 
            // Email_Text
            // 
            Email_Text.BorderStyle = BorderStyle.FixedSingle;
            Email_Text.Enabled = false;
            Email_Text.Location = new Point(103, 115);
            Email_Text.Margin = new Padding(3, 2, 3, 2);
            Email_Text.Name = "Email_Text";
            Email_Text.Size = new Size(242, 23);
            Email_Text.TabIndex = 26;
            // 
            // Birthday_Text
            // 
            Birthday_Text.BorderStyle = BorderStyle.FixedSingle;
            Birthday_Text.Enabled = false;
            Birthday_Text.Location = new Point(103, 90);
            Birthday_Text.Margin = new Padding(3, 2, 3, 2);
            Birthday_Text.Name = "Birthday_Text";
            Birthday_Text.Size = new Size(128, 23);
            Birthday_Text.TabIndex = 25;
            // 
            // gender_Text
            // 
            gender_Text.BorderStyle = BorderStyle.FixedSingle;
            gender_Text.Enabled = false;
            gender_Text.Location = new Point(103, 65);
            gender_Text.Margin = new Padding(3, 2, 3, 2);
            gender_Text.Name = "gender_Text";
            gender_Text.Size = new Size(128, 23);
            gender_Text.TabIndex = 24;
            // 
            // customerName_Text
            // 
            customerName_Text.BorderStyle = BorderStyle.FixedSingle;
            customerName_Text.Enabled = false;
            customerName_Text.Location = new Point(103, 41);
            customerName_Text.Margin = new Padding(3, 2, 3, 2);
            customerName_Text.Name = "customerName_Text";
            customerName_Text.Size = new Size(242, 23);
            customerName_Text.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // button7
            // 
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 0;
            // 
            // label15
            // 
            label15.Location = new Point(0, 0);
            label15.Name = "label15";
            label15.Size = new Size(100, 23);
            label15.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(Close_Button);
            panel4.Controls.Add(Edit_Confirm_Button);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(serviceList_DataGrid);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(ItemList_DataGrid);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(1153, 572);
            panel4.TabIndex = 27;
            // 
            // Close_Button
            // 
            Close_Button.FlatAppearance.BorderSize = 0;
            Close_Button.FlatStyle = FlatStyle.Flat;
            Close_Button.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Close_Button.ForeColor = Color.FromArgb(239, 59, 44);
            Close_Button.Location = new Point(1110, 3);
            Close_Button.Name = "Close_Button";
            Close_Button.Size = new Size(40, 36);
            Close_Button.TabIndex = 29;
            Close_Button.Text = "x";
            Close_Button.UseVisualStyleBackColor = true;
            Close_Button.Click += Close_Button_Click;
            // 
            // Edit_Confirm_Button
            // 
            Edit_Confirm_Button.BackColor = Color.FromArgb(222, 28, 119);
            Edit_Confirm_Button.Cursor = Cursors.Hand;
            Edit_Confirm_Button.FlatAppearance.BorderSize = 2;
            Edit_Confirm_Button.FlatStyle = FlatStyle.Flat;
            Edit_Confirm_Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Edit_Confirm_Button.ForeColor = Color.White;
            Edit_Confirm_Button.Location = new Point(167, 512);
            Edit_Confirm_Button.Name = "Edit_Confirm_Button";
            Edit_Confirm_Button.Size = new Size(144, 41);
            Edit_Confirm_Button.TabIndex = 28;
            Edit_Confirm_Button.Text = "Edit";
            Edit_Confirm_Button.UseVisualStyleBackColor = false;
            Edit_Confirm_Button.Click += Edit_Confirm_Button_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ControlLightLight;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(8, 48, 107);
            label16.Location = new Point(467, 21);
            label16.Name = "label16";
            label16.Size = new Size(167, 25);
            label16.TabIndex = 27;
            label16.Text = "DETAIL OF ROOM";
            // 
            // DetailRoom_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 193, 138);
            ClientSize = new Size(1173, 592);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "DetailRoom_Form";
            Padding = new Padding(10, 10, 10, 10);
            Text = "DetailRoom_Form";
            ((System.ComponentModel.ISupportInitialize)ItemList_DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceList_DataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Room_Label;
        private TextBox roomID_Text;
        private Label label1;
        private Label label2;
        private TextBox Status_Text;
        private Label label3;
        private TextBox Price_Text;
        private Label label4;
        private TextBox roomName_Text;
        private Label label5;
        private TextBox roomType_Text;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView ItemList_DataGrid;
        private DataGridView serviceList_DataGrid;
        private Panel panel1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Panel panel2;
        private TextBox Identify_Text;
        private TextBox Phone_Text;
        private TextBox Email_Text;
        private TextBox Birthday_Text;
        private TextBox gender_Text;
        private TextBox customerName_Text;
        private Panel panel3;
        private Label label15;
        private Button button7;
        private Button button2;
        private Panel panel4;
        private Label label16;
        private Button Edit_Confirm_Button;
        private Button Close_Button;
    }
}