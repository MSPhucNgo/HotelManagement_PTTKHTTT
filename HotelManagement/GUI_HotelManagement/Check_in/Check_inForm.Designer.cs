namespace GUI_HotelManagement
{
    partial class Check_inForm
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
            panel1 = new Panel();
            label1 = new Label();
            button3 = new Button();
            Refresh_Button = new Button();
            Confirm_Button = new Button();
            Name_Text = new TextBox();
            label6 = new Label();
            Booking_Grid = new DataGridView();
            panel3 = new Panel();
            group_CheckBox = new CheckBox();
            label16 = new Label();
            amountGroup_Text = new TextBox();
            label14 = new Label();
            gName_Text = new TextBox();
            label11 = new Label();
            Search_Button = new Button();
            panel2 = new Panel();
            Agent_CheckBox = new CheckBox();
            Own_CheckList = new CheckedListBox();
            label13 = new Label();
            label7 = new Label();
            BookID_Text = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            NoRooms_Text = new TextBox();
            label8 = new Label();
            Edit_Button = new Button();
            IdentityNo_Text = new TextBox();
            label9 = new Label();
            SPRequiments_Text = new TextBox();
            label10 = new Label();
            In_Datatime = new DateTimePicker();
            Price_Text = new TextBox();
            Out_Datetime = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Booking_Grid).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(Refresh_Button);
            panel1.Controls.Add(Confirm_Button);
            panel1.Controls.Add(Name_Text);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Booking_Grid);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(Search_Button);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(BookID_Text);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 680);
            panel1.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 96);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 0;
            label1.Text = "Guest name:";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(239, 59, 44);
            button3.Location = new Point(1146, 3);
            button3.Name = "button3";
            button3.Size = new Size(40, 36);
            button3.TabIndex = 93;
            button3.Text = "x";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Refresh_Button
            // 
            Refresh_Button.FlatAppearance.BorderSize = 2;
            Refresh_Button.FlatStyle = FlatStyle.Flat;
            Refresh_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Refresh_Button.ForeColor = Color.FromArgb(8, 48, 107);
            Refresh_Button.Location = new Point(401, 614);
            Refresh_Button.Name = "Refresh_Button";
            Refresh_Button.Size = new Size(157, 44);
            Refresh_Button.TabIndex = 92;
            Refresh_Button.Text = "Refresh";
            Refresh_Button.UseVisualStyleBackColor = true;
            Refresh_Button.Click += Refresh_Button_Click;
            // 
            // Confirm_Button
            // 
            Confirm_Button.FlatAppearance.BorderSize = 2;
            Confirm_Button.FlatStyle = FlatStyle.Flat;
            Confirm_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Confirm_Button.ForeColor = Color.FromArgb(0, 193, 138);
            Confirm_Button.Location = new Point(627, 614);
            Confirm_Button.Name = "Confirm_Button";
            Confirm_Button.Size = new Size(157, 44);
            Confirm_Button.TabIndex = 91;
            Confirm_Button.Text = "Confirm";
            Confirm_Button.UseVisualStyleBackColor = true;
            Confirm_Button.Click += Confirm_Button_Click;
            // 
            // Name_Text
            // 
            Name_Text.BorderStyle = BorderStyle.FixedSingle;
            Name_Text.Location = new Point(131, 92);
            Name_Text.Name = "Name_Text";
            Name_Text.Size = new Size(255, 23);
            Name_Text.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(8, 48, 107);
            label6.Location = new Point(432, 17);
            label6.Name = "label6";
            label6.Size = new Size(391, 30);
            label6.TabIndex = 90;
            label6.Text = "CHECKIN (1) - INPUT INFORMATION";
            // 
            // Booking_Grid
            // 
            Booking_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Booking_Grid.Location = new Point(39, 431);
            Booking_Grid.Margin = new Padding(3, 2, 3, 2);
            Booking_Grid.Name = "Booking_Grid";
            Booking_Grid.ReadOnly = true;
            Booking_Grid.RowHeadersWidth = 51;
            Booking_Grid.RowTemplate.Height = 29;
            Booking_Grid.Size = new Size(1113, 165);
            Booking_Grid.TabIndex = 34;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(212, 230, 242);
            panel3.Controls.Add(group_CheckBox);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(amountGroup_Text);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(gName_Text);
            panel3.Location = new Point(796, 255);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 130);
            panel3.TabIndex = 89;
            // 
            // group_CheckBox
            // 
            group_CheckBox.AutoSize = true;
            group_CheckBox.Enabled = false;
            group_CheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            group_CheckBox.Location = new Point(98, 14);
            group_CheckBox.Margin = new Padding(3, 2, 3, 2);
            group_CheckBox.Name = "group_CheckBox";
            group_CheckBox.Size = new Size(180, 23);
            group_CheckBox.TabIndex = 88;
            group_CheckBox.Text = "Tick for group customers";
            group_CheckBox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(22, 88);
            label16.Name = "label16";
            label16.Size = new Size(145, 19);
            label16.TabIndex = 85;
            label16.Text = "Number of customers:";
            // 
            // amountGroup_Text
            // 
            amountGroup_Text.BorderStyle = BorderStyle.FixedSingle;
            amountGroup_Text.Enabled = false;
            amountGroup_Text.Location = new Point(178, 84);
            amountGroup_Text.Name = "amountGroup_Text";
            amountGroup_Text.Size = new Size(157, 23);
            amountGroup_Text.TabIndex = 87;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(22, 50);
            label14.Name = "label14";
            label14.Size = new Size(89, 19);
            label14.TabIndex = 83;
            label14.Text = "Group name:";
            // 
            // gName_Text
            // 
            gName_Text.BorderStyle = BorderStyle.FixedSingle;
            gName_Text.Enabled = false;
            gName_Text.Location = new Point(121, 48);
            gName_Text.Name = "gName_Text";
            gName_Text.Size = new Size(214, 23);
            gName_Text.TabIndex = 86;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(8, 48, 107);
            label11.Location = new Point(39, 402);
            label11.Name = "label11";
            label11.Size = new Size(114, 21);
            label11.TabIndex = 35;
            label11.Text = "List of Rooms:";
            // 
            // Search_Button
            // 
            Search_Button.BackColor = Color.FromArgb(8, 48, 107);
            Search_Button.Cursor = Cursors.Hand;
            Search_Button.FlatAppearance.BorderSize = 0;
            Search_Button.FlatStyle = FlatStyle.Flat;
            Search_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Search_Button.ForeColor = Color.White;
            Search_Button.Location = new Point(414, 65);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(129, 51);
            Search_Button.TabIndex = 29;
            Search_Button.Text = "Search";
            Search_Button.UseVisualStyleBackColor = false;
            Search_Button.Click += Search_Button_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 230, 242);
            panel2.Controls.Add(Agent_CheckBox);
            panel2.Controls.Add(Own_CheckList);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(796, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 94);
            panel2.TabIndex = 34;
            // 
            // Agent_CheckBox
            // 
            Agent_CheckBox.AutoSize = true;
            Agent_CheckBox.Enabled = false;
            Agent_CheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            Agent_CheckBox.Location = new Point(22, 65);
            Agent_CheckBox.Name = "Agent_CheckBox";
            Agent_CheckBox.Size = new Size(144, 21);
            Agent_CheckBox.TabIndex = 27;
            Agent_CheckBox.Text = "Travel agent account";
            Agent_CheckBox.UseVisualStyleBackColor = true;
            Agent_CheckBox.CheckedChanged += Agent_CheckBox_CheckedChanged_1;
            // 
            // Own_CheckList
            // 
            Own_CheckList.Enabled = false;
            Own_CheckList.FormattingEnabled = true;
            Own_CheckList.Items.AddRange(new object[] { "Cash", "Credit Card", "Traveller Cheque" });
            Own_CheckList.Location = new Point(121, 37);
            Own_CheckList.Name = "Own_CheckList";
            Own_CheckList.Size = new Size(214, 22);
            Own_CheckList.TabIndex = 24;
            Own_CheckList.SelectedIndexChanged += Own_CheckList_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(22, 37);
            label13.Name = "label13";
            label13.Size = new Size(93, 19);
            label13.TabIndex = 23;
            label13.Text = "Own account:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(8, 48, 107);
            label7.Location = new Point(118, 8);
            label7.Name = "label7";
            label7.Size = new Size(142, 21);
            label7.TabIndex = 6;
            label7.Text = "Payment methods";
            // 
            // BookID_Text
            // 
            BookID_Text.BorderStyle = BorderStyle.FixedSingle;
            BookID_Text.Location = new Point(131, 65);
            BookID_Text.Name = "BookID_Text";
            BookID_Text.Size = new Size(255, 23);
            BookID_Text.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 69);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 1;
            label2.Text = "Booking ID:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(212, 230, 242);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(NoRooms_Text);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(Edit_Button);
            panel4.Controls.Add(IdentityNo_Text);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(SPRequiments_Text);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(In_Datatime);
            panel4.Controls.Add(Price_Text);
            panel4.Controls.Add(Out_Datetime);
            panel4.Location = new Point(39, 148);
            panel4.Name = "panel4";
            panel4.Size = new Size(709, 237);
            panel4.TabIndex = 94;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 128);
            label4.Name = "label4";
            label4.Size = new Size(107, 19);
            label4.TabIndex = 3;
            label4.Text = "Check-out date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 90);
            label3.Name = "label3";
            label3.Size = new Size(97, 19);
            label3.TabIndex = 2;
            label3.Text = "Check-in date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 18);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 4;
            label5.Text = "Total room:";
            // 
            // NoRooms_Text
            // 
            NoRooms_Text.BorderStyle = BorderStyle.FixedSingle;
            NoRooms_Text.Enabled = false;
            NoRooms_Text.Location = new Point(139, 14);
            NoRooms_Text.Name = "NoRooms_Text";
            NoRooms_Text.ReadOnly = true;
            NoRooms_Text.Size = new Size(96, 23);
            NoRooms_Text.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(28, 52);
            label8.Name = "label8";
            label8.Size = new Size(84, 19);
            label8.TabIndex = 7;
            label8.Text = "Identity NO:";
            // 
            // Edit_Button
            // 
            Edit_Button.BackColor = Color.FromArgb(0, 193, 138);
            Edit_Button.FlatAppearance.BorderSize = 0;
            Edit_Button.FlatStyle = FlatStyle.Flat;
            Edit_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Edit_Button.ForeColor = Color.White;
            Edit_Button.Location = new Point(608, 198);
            Edit_Button.Margin = new Padding(3, 2, 3, 2);
            Edit_Button.Name = "Edit_Button";
            Edit_Button.Size = new Size(82, 26);
            Edit_Button.TabIndex = 35;
            Edit_Button.Text = "Edit";
            Edit_Button.UseVisualStyleBackColor = false;
            Edit_Button.Click += Edit_Button_Click_1;
            // 
            // IdentityNo_Text
            // 
            IdentityNo_Text.BorderStyle = BorderStyle.FixedSingle;
            IdentityNo_Text.Enabled = false;
            IdentityNo_Text.Location = new Point(139, 48);
            IdentityNo_Text.Name = "IdentityNo_Text";
            IdentityNo_Text.ReadOnly = true;
            IdentityNo_Text.Size = new Size(97, 23);
            IdentityNo_Text.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(375, 18);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 8;
            label9.Text = "Special requirements:";
            // 
            // SPRequiments_Text
            // 
            SPRequiments_Text.BorderStyle = BorderStyle.FixedSingle;
            SPRequiments_Text.Enabled = false;
            SPRequiments_Text.Location = new Point(375, 48);
            SPRequiments_Text.Multiline = true;
            SPRequiments_Text.Name = "SPRequiments_Text";
            SPRequiments_Text.ReadOnly = true;
            SPRequiments_Text.Size = new Size(315, 137);
            SPRequiments_Text.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(28, 166);
            label10.Name = "label10";
            label10.Size = new Size(41, 19);
            label10.TabIndex = 9;
            label10.Text = "Price:";
            // 
            // In_Datatime
            // 
            In_Datatime.Enabled = false;
            In_Datatime.Location = new Point(139, 86);
            In_Datatime.Name = "In_Datatime";
            In_Datatime.Size = new Size(209, 23);
            In_Datatime.TabIndex = 16;
            // 
            // Price_Text
            // 
            Price_Text.BorderStyle = BorderStyle.FixedSingle;
            Price_Text.Enabled = false;
            Price_Text.Location = new Point(138, 162);
            Price_Text.Name = "Price_Text";
            Price_Text.ReadOnly = true;
            Price_Text.Size = new Size(209, 23);
            Price_Text.TabIndex = 15;
            // 
            // Out_Datetime
            // 
            Out_Datetime.Enabled = false;
            Out_Datetime.Location = new Point(138, 124);
            Out_Datetime.Name = "Out_Datetime";
            Out_Datetime.Size = new Size(209, 23);
            Out_Datetime.TabIndex = 17;
            // 
            // Check_inForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 193, 138);
            ClientSize = new Size(1209, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Check_inForm";
            Padding = new Padding(10);
            Text = "Check-in";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Booking_Grid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Panel panel1;
        private Button Edit_Button;
        private Button Search_Button;
        private Panel panel2;
        private CheckBox Agent_CheckBox;
        private CheckedListBox Own_CheckList;
        private Label label13;
        private Label label7;
        private TextBox BookID_Text;
        private DateTimePicker In_Datatime;
        private DateTimePicker Out_Datetime;
        private TextBox Price_Text;
        private Label label10;
        private TextBox SPRequiments_Text;
        private Label label9;
        private TextBox IdentityNo_Text;
        private Label label8;
        private Label label1;
        private TextBox NoRooms_Text;
        private Label label5;
        private TextBox Name_Text;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView Booking_Grid;
        private Label label11;
        private Panel panel3;
        private CheckBox group_CheckBox;
        private Label label16;
        private TextBox amountGroup_Text;
        private Label label14;
        private TextBox gName_Text;
        private Label label6;
        private Button Refresh_Button;
        private Button Confirm_Button;
        private Button button3;
        private Panel panel4;
    }
}