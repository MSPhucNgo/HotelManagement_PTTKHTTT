namespace GUI_HotelManagement
{
    partial class List_Of_Items
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
            dgv_List_Of_Items = new DataGridView();
            panel5 = new Panel();
            label3 = new Label();
            dgv_List_Of_Items_Room = new DataGridView();
            label1 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            Search_Button = new Button();
            cb_RoomID = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_List_Of_Items).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_List_Of_Items_Room).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_List_Of_Items
            // 
            dgv_List_Of_Items.BackgroundColor = Color.DarkGray;
            dgv_List_Of_Items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_List_Of_Items.GridColor = Color.Black;
            dgv_List_Of_Items.Location = new Point(633, 189);
            dgv_List_Of_Items.Margin = new Padding(3, 2, 3, 2);
            dgv_List_Of_Items.Name = "dgv_List_Of_Items";
            dgv_List_Of_Items.RowHeadersWidth = 51;
            dgv_List_Of_Items.RowTemplate.Height = 29;
            dgv_List_Of_Items.Size = new Size(432, 425);
            dgv_List_Of_Items.TabIndex = 34;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(212, 230, 242);
            panel5.Controls.Add(dgv_List_Of_Items_Room);
            panel5.Controls.Add(label3);
            panel5.ForeColor = Color.Silver;
            panel5.Location = new Point(51, 140);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(492, 474);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(8, 48, 107);
            label3.Location = new Point(200, 13);
            label3.Name = "label3";
            label3.Size = new Size(89, 27);
            label3.TabIndex = 8;
            label3.Text = "Infomation";
            label3.UseCompatibleTextRendering = true;
            // 
            // dgv_List_Of_Items_Room
            // 
            dgv_List_Of_Items_Room.BackgroundColor = Color.DarkGray;
            dgv_List_Of_Items_Room.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_List_Of_Items_Room.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_List_Of_Items_Room.GridColor = Color.Black;
            dgv_List_Of_Items_Room.Location = new Point(0, 49);
            dgv_List_Of_Items_Room.Margin = new Padding(3, 2, 3, 2);
            dgv_List_Of_Items_Room.Name = "dgv_List_Of_Items_Room";
            dgv_List_Of_Items_Room.RowHeadersWidth = 51;
            dgv_List_Of_Items_Room.RowTemplate.Height = 29;
            dgv_List_Of_Items_Room.Size = new Size(492, 423);
            dgv_List_Of_Items_Room.TabIndex = 35;
            dgv_List_Of_Items_Room.CellContentClick += dgv_List_Of_Items_Room_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(633, 153);
            label1.Name = "label1";
            label1.Size = new Size(101, 27);
            label1.TabIndex = 35;
            label1.Text = "All off Items:";
            label1.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(212, 230, 242);
            panel4.Controls.Add(cb_RoomID);
            panel4.Controls.Add(Search_Button);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(51, 28);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1014, 80);
            panel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(8, 48, 107);
            label2.Location = new Point(215, 30);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 30;
            label2.Text = "Room ID:";
            // 
            // Search_Button
            // 
            Search_Button.BackColor = Color.FromArgb(8, 48, 107);
            Search_Button.FlatAppearance.BorderSize = 0;
            Search_Button.FlatStyle = FlatStyle.Flat;
            Search_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Search_Button.ForeColor = Color.White;
            Search_Button.Location = new Point(660, 26);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(142, 29);
            Search_Button.TabIndex = 32;
            Search_Button.Text = "Search";
            Search_Button.UseVisualStyleBackColor = false;
            Search_Button.Click += Search_Button_Click;
            // 
            // cb_RoomID
            // 
            cb_RoomID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_RoomID.FormattingEnabled = true;
            cb_RoomID.Location = new Point(300, 25);
            cb_RoomID.Margin = new Padding(3, 2, 3, 2);
            cb_RoomID.Name = "cb_RoomID";
            cb_RoomID.Size = new Size(327, 29);
            cb_RoomID.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgv_List_Of_Items);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 660);
            panel1.TabIndex = 36;
            // 
            // List_Of_Items
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(1135, 670);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "List_Of_Items";
            Padding = new Padding(0, 0, 10, 10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List_Of_Items";
            ((System.ComponentModel.ISupportInitialize)dgv_List_Of_Items).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_List_Of_Items_Room).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private readonly DataGridViewCellEventHandler dgv_List_Of_Items_CellContentClick;
        private DataGridView dgv_List_Of_Items;
        private Panel panel5;
        private DataGridView dgv_List_Of_Items_Room;
        private Label label3;
        private Label label1;
        private Panel panel4;
        private ComboBox cb_RoomID;
        private Button Search_Button;
        private Label label2;
        private Panel panel1;
    }
}