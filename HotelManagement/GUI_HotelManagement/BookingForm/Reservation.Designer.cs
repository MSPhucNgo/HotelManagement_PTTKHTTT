namespace GUI_HotelManagement
{
    partial class Reservation
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            bookingFormBUSBindingSource = new BindingSource(components);
            bt_Edit_Reservation = new Button();
            label1 = new Label();
            bt_Search_Reservation = new Button();
            bt_Check_In = new Button();
            cb_BookingID = new ComboBox();
            bt_Check_Out = new Button();
            lb_List_Of_Reservation = new Label();
            dgv_Reservation = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)bookingFormBUSBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Reservation).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // bookingFormBUSBindingSource
            // 
            bookingFormBUSBindingSource.DataSource = typeof(BUS_HotelManagement.BookingForm_BUS);
            // 
            // bt_Edit_Reservation
            // 
            bt_Edit_Reservation.BackColor = Color.White;
            bt_Edit_Reservation.Cursor = Cursors.Hand;
            bt_Edit_Reservation.FlatAppearance.BorderSize = 2;
            bt_Edit_Reservation.FlatStyle = FlatStyle.Flat;
            bt_Edit_Reservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Edit_Reservation.ForeColor = Color.FromArgb(8, 48, 107);
            bt_Edit_Reservation.Image = Properties.Resources.pencil__1_;
            bt_Edit_Reservation.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Edit_Reservation.Location = new Point(765, 33);
            bt_Edit_Reservation.Margin = new Padding(3, 2, 3, 2);
            bt_Edit_Reservation.Name = "bt_Edit_Reservation";
            bt_Edit_Reservation.Size = new Size(311, 49);
            bt_Edit_Reservation.TabIndex = 2;
            bt_Edit_Reservation.Text = "     EDIT RESERVATION";
            bt_Edit_Reservation.UseVisualStyleBackColor = false;
            bt_Edit_Reservation.Click += bt_Edit_Reservation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 50);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 33;
            label1.Text = "Booking ID:";
            // 
            // bt_Search_Reservation
            // 
            bt_Search_Reservation.BackColor = Color.FromArgb(8, 48, 107);
            bt_Search_Reservation.Cursor = Cursors.Hand;
            bt_Search_Reservation.FlatAppearance.BorderSize = 0;
            bt_Search_Reservation.FlatStyle = FlatStyle.Flat;
            bt_Search_Reservation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Search_Reservation.ForeColor = Color.White;
            bt_Search_Reservation.Location = new Point(485, 43);
            bt_Search_Reservation.Name = "bt_Search_Reservation";
            bt_Search_Reservation.Size = new Size(107, 35);
            bt_Search_Reservation.TabIndex = 35;
            bt_Search_Reservation.Text = "Search";
            bt_Search_Reservation.UseVisualStyleBackColor = false;
            bt_Search_Reservation.Click += bt_Search_Reservation_Click;
            // 
            // bt_Check_In
            // 
            bt_Check_In.BackColor = Color.White;
            bt_Check_In.Cursor = Cursors.Hand;
            bt_Check_In.FlatAppearance.BorderSize = 2;
            bt_Check_In.FlatStyle = FlatStyle.Flat;
            bt_Check_In.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Check_In.ForeColor = Color.FromArgb(0, 193, 138);
            bt_Check_In.Image = Properties.Resources.front_desk__1_;
            bt_Check_In.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Check_In.Location = new Point(765, 107);
            bt_Check_In.Margin = new Padding(3, 2, 3, 2);
            bt_Check_In.Name = "bt_Check_In";
            bt_Check_In.Size = new Size(311, 49);
            bt_Check_In.TabIndex = 4;
            bt_Check_In.Text = "     CHECK-IN";
            bt_Check_In.UseVisualStyleBackColor = false;
            bt_Check_In.Click += button1_Click;
            // 
            // cb_BookingID
            // 
            cb_BookingID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_BookingID.FormattingEnabled = true;
            cb_BookingID.Location = new Point(131, 47);
            cb_BookingID.Margin = new Padding(3, 2, 3, 2);
            cb_BookingID.Name = "cb_BookingID";
            cb_BookingID.Size = new Size(329, 29);
            cb_BookingID.TabIndex = 36;
            // 
            // bt_Check_Out
            // 
            bt_Check_Out.BackColor = Color.White;
            bt_Check_Out.Cursor = Cursors.Hand;
            bt_Check_Out.FlatAppearance.BorderSize = 2;
            bt_Check_Out.FlatStyle = FlatStyle.Flat;
            bt_Check_Out.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Check_Out.ForeColor = Color.FromArgb(222, 28, 119);
            bt_Check_Out.Image = Properties.Resources.check_out;
            bt_Check_Out.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Check_Out.Location = new Point(765, 184);
            bt_Check_Out.Margin = new Padding(3, 2, 3, 2);
            bt_Check_Out.Name = "bt_Check_Out";
            bt_Check_Out.Size = new Size(311, 49);
            bt_Check_Out.TabIndex = 5;
            bt_Check_Out.Text = "     CHECK-OUT";
            bt_Check_Out.UseVisualStyleBackColor = false;
            bt_Check_Out.Click += bt_Check_Out_Click;
            // 
            // lb_List_Of_Reservation
            // 
            lb_List_Of_Reservation.AutoSize = true;
            lb_List_Of_Reservation.BackColor = Color.Transparent;
            lb_List_Of_Reservation.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_List_Of_Reservation.ForeColor = Color.FromArgb(8, 48, 107);
            lb_List_Of_Reservation.Location = new Point(44, 215);
            lb_List_Of_Reservation.Name = "lb_List_Of_Reservation";
            lb_List_Of_Reservation.Size = new Size(224, 31);
            lb_List_Of_Reservation.TabIndex = 4;
            lb_List_Of_Reservation.Text = "LIST OF RESERVATIONS";
            lb_List_Of_Reservation.UseCompatibleTextRendering = true;
            // 
            // dgv_Reservation
            // 
            dgv_Reservation.BackgroundColor = Color.DarkGray;
            dgv_Reservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_Reservation.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_Reservation.Location = new Point(44, 262);
            dgv_Reservation.Margin = new Padding(3, 2, 3, 2);
            dgv_Reservation.Name = "dgv_Reservation";
            dgv_Reservation.RowHeadersWidth = 51;
            dgv_Reservation.RowTemplate.Height = 29;
            dgv_Reservation.Size = new Size(1032, 351);
            dgv_Reservation.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgv_Reservation);
            panel1.Controls.Add(bt_Check_Out);
            panel1.Controls.Add(lb_List_Of_Reservation);
            panel1.Controls.Add(bt_Edit_Reservation);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(bt_Check_In);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 660);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 230, 242);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(bt_Search_Reservation);
            panel2.Controls.Add(cb_BookingID);
            panel2.Location = new Point(44, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(625, 123);
            panel2.TabIndex = 37;
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(1135, 670);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Reservation";
            Padding = new Padding(0, 0, 10, 10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)bookingFormBUSBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Reservation).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lb_List_Of_Reservation;
        private Button bt_Search_Reservation;
        private Label label1;
        private Label lb_List_Of_Items;
        private Button bt_Edit_Reservation;
        private DataGridView dgv_Reservation;
        private Button bt_Check_In;
        private ComboBox cb_BookingID;
        private BindingSource bookingFormBUSBindingSource;
        private Button bt_Check_Out;
        private Panel panel2;
    }
}