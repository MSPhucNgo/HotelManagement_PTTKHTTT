namespace GUI_HotelManagement
{
    partial class Edit_Resevation
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel4 = new Panel();
            cb_BookingID_Edit = new ComboBox();
            label6 = new Label();
            cb_RoomType = new ComboBox();
            date_Departure = new DateTimePicker();
            label1 = new Label();
            date_Arrive = new DateTimePicker();
            label8 = new Label();
            tb_Special_Re = new TextBox();
            label9 = new Label();
            tb_Amount = new TextBox();
            label10 = new Label();
            label5 = new Label();
            tb_Customer_Name = new TextBox();
            label4 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            dgv_Reservation = new DataGridView();
            lb_List_Of_Reservation = new Label();
            panel2 = new Panel();
            button1 = new Button();
            cb_BookingID = new ComboBox();
            bt_Search_Reservation = new Button();
            label2 = new Label();
            bt_Cancel = new Button();
            bt_Edit_Reservation = new Button();
            panel7 = new Panel();
            label7 = new Label();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Reservation).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(212, 230, 242);
            panel4.Controls.Add(cb_BookingID_Edit);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(cb_RoomType);
            panel4.Controls.Add(date_Departure);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(date_Arrive);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(tb_Special_Re);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(tb_Amount);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(tb_Customer_Name);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(0, 41);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(502, 356);
            panel4.TabIndex = 54;
            // 
            // cb_BookingID_Edit
            // 
            cb_BookingID_Edit.FormattingEnabled = true;
            cb_BookingID_Edit.Location = new Point(204, 29);
            cb_BookingID_Edit.Margin = new Padding(3, 2, 3, 2);
            cb_BookingID_Edit.Name = "cb_BookingID_Edit";
            cb_BookingID_Edit.Size = new Size(219, 23);
            cb_BookingID_Edit.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(8, 48, 107);
            label6.Location = new Point(44, 31);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 50;
            label6.Text = "BOOKING ID:";
            // 
            // cb_RoomType
            // 
            cb_RoomType.FormattingEnabled = true;
            cb_RoomType.Location = new Point(204, 292);
            cb_RoomType.Margin = new Padding(3, 2, 3, 2);
            cb_RoomType.Name = "cb_RoomType";
            cb_RoomType.Size = new Size(219, 23);
            cb_RoomType.TabIndex = 49;
            // 
            // date_Departure
            // 
            date_Departure.Location = new Point(204, 154);
            date_Departure.Margin = new Padding(3, 2, 3, 2);
            date_Departure.Name = "date_Departure";
            date_Departure.Size = new Size(219, 23);
            date_Departure.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(44, 157);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 47;
            label1.Text = "DAY OF LEAVING:";
            // 
            // date_Arrive
            // 
            date_Arrive.Location = new Point(204, 112);
            date_Arrive.Margin = new Padding(3, 2, 3, 2);
            date_Arrive.Name = "date_Arrive";
            date_Arrive.Size = new Size(219, 23);
            date_Arrive.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(8, 48, 107);
            label8.Location = new Point(44, 295);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 44;
            label8.Text = "ROOM TYPE:";
            // 
            // tb_Special_Re
            // 
            tb_Special_Re.BorderStyle = BorderStyle.FixedSingle;
            tb_Special_Re.Location = new Point(204, 248);
            tb_Special_Re.Name = "tb_Special_Re";
            tb_Special_Re.Size = new Size(219, 23);
            tb_Special_Re.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(8, 48, 107);
            label9.Location = new Point(44, 250);
            label9.Name = "label9";
            label9.Size = new Size(141, 15);
            label9.TabIndex = 42;
            label9.Text = "SPECIAL REQUIREMENTS:";
            // 
            // tb_Amount
            // 
            tb_Amount.BorderStyle = BorderStyle.FixedSingle;
            tb_Amount.Location = new Point(204, 200);
            tb_Amount.Name = "tb_Amount";
            tb_Amount.Size = new Size(219, 23);
            tb_Amount.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(8, 48, 107);
            label10.Location = new Point(44, 202);
            label10.Name = "label10";
            label10.Size = new Size(120, 15);
            label10.TabIndex = 40;
            label10.Text = "NUMBER OF PEOPLE:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(8, 48, 107);
            label5.Location = new Point(44, 116);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 38;
            label5.Text = "DATE OF ARRIVE:";
            // 
            // tb_Customer_Name
            // 
            tb_Customer_Name.BorderStyle = BorderStyle.FixedSingle;
            tb_Customer_Name.Location = new Point(204, 69);
            tb_Customer_Name.Name = "tb_Customer_Name";
            tb_Customer_Name.Size = new Size(219, 23);
            tb_Customer_Name.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(8, 48, 107);
            label4.Location = new Point(44, 71);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 36;
            label4.Text = "CUSTOMER NAME:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(212, 230, 242);
            panel6.Controls.Add(panel4);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(39, 83);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(502, 398);
            panel6.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(8, 48, 107);
            label3.Location = new Point(202, 8);
            label3.Name = "label3";
            label3.Size = new Size(105, 31);
            label3.TabIndex = 52;
            label3.Text = "Infomation";
            label3.UseCompatibleTextRendering = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(dgv_Reservation);
            panel5.Controls.Add(lb_List_Of_Reservation);
            panel5.ForeColor = Color.Silver;
            panel5.Location = new Point(598, 165);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(510, 316);
            panel5.TabIndex = 8;
            // 
            // dgv_Reservation
            // 
            dgv_Reservation.BackgroundColor = Color.Silver;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Reservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Reservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Reservation.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Reservation.GridColor = SystemColors.ControlText;
            dgv_Reservation.Location = new Point(0, 36);
            dgv_Reservation.Margin = new Padding(3, 2, 3, 2);
            dgv_Reservation.Name = "dgv_Reservation";
            dgv_Reservation.RowHeadersWidth = 51;
            dgv_Reservation.RowTemplate.Height = 29;
            dgv_Reservation.Size = new Size(510, 280);
            dgv_Reservation.TabIndex = 7;
            // 
            // lb_List_Of_Reservation
            // 
            lb_List_Of_Reservation.AutoSize = true;
            lb_List_Of_Reservation.BackColor = Color.Transparent;
            lb_List_Of_Reservation.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_List_Of_Reservation.ForeColor = Color.Black;
            lb_List_Of_Reservation.Location = new Point(167, 4);
            lb_List_Of_Reservation.Name = "lb_List_Of_Reservation";
            lb_List_Of_Reservation.Size = new Size(194, 30);
            lb_List_Of_Reservation.TabIndex = 4;
            lb_List_Of_Reservation.Text = "LIST OF RESERVATION";
            lb_List_Of_Reservation.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 230, 242);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(cb_BookingID);
            panel2.Controls.Add(bt_Search_Reservation);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(598, 83);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(510, 63);
            panel2.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 48, 107);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(420, 21);
            button1.Name = "button1";
            button1.Size = new Size(76, 22);
            button1.TabIndex = 37;
            button1.Text = "ALL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cb_BookingID
            // 
            cb_BookingID.FormattingEnabled = true;
            cb_BookingID.Location = new Point(114, 20);
            cb_BookingID.Margin = new Padding(3, 2, 3, 2);
            cb_BookingID.Name = "cb_BookingID";
            cb_BookingID.Size = new Size(175, 23);
            cb_BookingID.TabIndex = 36;
            // 
            // bt_Search_Reservation
            // 
            bt_Search_Reservation.BackColor = Color.FromArgb(8, 48, 107);
            bt_Search_Reservation.FlatAppearance.BorderSize = 0;
            bt_Search_Reservation.FlatStyle = FlatStyle.Flat;
            bt_Search_Reservation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Search_Reservation.ForeColor = Color.White;
            bt_Search_Reservation.Location = new Point(316, 20);
            bt_Search_Reservation.Name = "bt_Search_Reservation";
            bt_Search_Reservation.Size = new Size(82, 22);
            bt_Search_Reservation.TabIndex = 35;
            bt_Search_Reservation.Text = "SEARCH";
            bt_Search_Reservation.UseVisualStyleBackColor = false;
            bt_Search_Reservation.Click += bt_Search_Reservation_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(8, 48, 107);
            label2.Location = new Point(17, 23);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 33;
            label2.Text = "BOOKING ID:";
            // 
            // bt_Cancel
            // 
            bt_Cancel.Cursor = Cursors.Hand;
            bt_Cancel.FlatAppearance.BorderSize = 2;
            bt_Cancel.FlatStyle = FlatStyle.Flat;
            bt_Cancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Cancel.ForeColor = Color.FromArgb(222, 28, 119);
            bt_Cancel.Location = new Point(337, 505);
            bt_Cancel.Margin = new Padding(3, 2, 3, 2);
            bt_Cancel.Name = "bt_Cancel";
            bt_Cancel.Size = new Size(204, 40);
            bt_Cancel.TabIndex = 5;
            bt_Cancel.Text = "CANCEL";
            bt_Cancel.UseVisualStyleBackColor = true;
            bt_Cancel.Click += bt_Cancel_Click_1;
            // 
            // bt_Edit_Reservation
            // 
            bt_Edit_Reservation.BackColor = Color.FromArgb(0, 193, 138);
            bt_Edit_Reservation.Cursor = Cursors.Hand;
            bt_Edit_Reservation.FlatAppearance.BorderSize = 0;
            bt_Edit_Reservation.FlatStyle = FlatStyle.Flat;
            bt_Edit_Reservation.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Edit_Reservation.ForeColor = Color.White;
            bt_Edit_Reservation.Location = new Point(598, 505);
            bt_Edit_Reservation.Margin = new Padding(3, 2, 3, 2);
            bt_Edit_Reservation.Name = "bt_Edit_Reservation";
            bt_Edit_Reservation.Size = new Size(225, 40);
            bt_Edit_Reservation.TabIndex = 4;
            bt_Edit_Reservation.Text = "EDIT";
            bt_Edit_Reservation.UseVisualStyleBackColor = false;
            bt_Edit_Reservation.Click += bt_Edit_Reservation_Click_1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label7);
            panel7.Controls.Add(panel6);
            panel7.Controls.Add(bt_Cancel);
            panel7.Controls.Add(panel5);
            panel7.Controls.Add(panel2);
            panel7.Controls.Add(bt_Edit_Reservation);
            panel7.Cursor = Cursors.Hand;
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(10, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(1153, 572);
            panel7.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(8, 48, 107);
            label7.Location = new Point(443, 14);
            label7.Name = "label7";
            label7.Size = new Size(262, 37);
            label7.TabIndex = 52;
            label7.Text = "EDIT RESERVATION";
            // 
            // Edit_Resevation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 193, 138);
            ClientSize = new Size(1173, 592);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Edit_Resevation";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit_Resevation";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Reservation).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button bt_Cancel;
        private Button bt_Edit_Reservation;
        private Panel panel2;
        private ComboBox cb_BookingID;
        private Button bt_Search_Reservation;
        private Label label2;
        private Panel panel5;
        private DataGridView dgv_Reservation;
        private Label lb_List_Of_Reservation;
        private Button button1;
        private Panel panel4;
        private ComboBox cb_RoomType;
        private DateTimePicker date_Departure;
        private Label label1;
        private DateTimePicker date_Arrive;
        private Label label8;
        private TextBox tb_Special_Re;
        private Label label9;
        private TextBox tb_Amount;
        private Label label10;
        private Label label5;
        private TextBox tb_Customer_Name;
        private Label label4;
        private Panel panel6;
        private Label label3;
        private ComboBox cb_BookingID_Edit;
        private Label label6;
        private Panel panel7;
        private Label label7;
    }
}