namespace GUI_HotelManagement
{
    partial class NoticeCheck_inForm
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
            label2 = new Label();
            Discount_DataGrid = new DataGridView();
            label1 = new Label();
            Service_Label = new Label();
            Rules_DataGrid = new DataGridView();
            ServiceHotel_DataGid = new DataGridView();
            Confirm_Button = new Button();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)Discount_DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rules_DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServiceHotel_DataGid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(8, 48, 107);
            label2.Location = new Point(612, 88);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 13;
            label2.Text = "Hotel rule:";
            // 
            // Discount_DataGrid
            // 
            Discount_DataGrid.BackgroundColor = Color.FromArgb(212, 230, 242);
            Discount_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Discount_DataGrid.Location = new Point(59, 406);
            Discount_DataGrid.Margin = new Padding(3, 2, 3, 2);
            Discount_DataGrid.Name = "Discount_DataGrid";
            Discount_DataGrid.ReadOnly = true;
            Discount_DataGrid.RowHeadersWidth = 51;
            Discount_DataGrid.RowTemplate.Height = 29;
            Discount_DataGrid.Size = new Size(523, 180);
            Discount_DataGrid.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(49, 368);
            label1.Name = "label1";
            label1.Size = new Size(239, 21);
            label1.TabIndex = 11;
            label1.Text = "Discount promotion attached:";
            // 
            // Service_Label
            // 
            Service_Label.AutoSize = true;
            Service_Label.BackColor = Color.White;
            Service_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Service_Label.ForeColor = Color.FromArgb(8, 48, 107);
            Service_Label.Location = new Point(49, 88);
            Service_Label.Name = "Service_Label";
            Service_Label.Size = new Size(114, 21);
            Service_Label.TabIndex = 10;
            Service_Label.Text = "Hotel service:";
            // 
            // Rules_DataGrid
            // 
            Rules_DataGrid.BackgroundColor = Color.FromArgb(212, 230, 242);
            Rules_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Rules_DataGrid.Location = new Point(622, 126);
            Rules_DataGrid.Margin = new Padding(3, 2, 3, 2);
            Rules_DataGrid.Name = "Rules_DataGrid";
            Rules_DataGrid.ReadOnly = true;
            Rules_DataGrid.RowHeadersWidth = 51;
            Rules_DataGrid.RowTemplate.Height = 29;
            Rules_DataGrid.Size = new Size(534, 460);
            Rules_DataGrid.TabIndex = 8;
            // 
            // ServiceHotel_DataGid
            // 
            ServiceHotel_DataGid.BackgroundColor = Color.FromArgb(212, 230, 242);
            ServiceHotel_DataGid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceHotel_DataGid.Location = new Point(49, 116);
            ServiceHotel_DataGid.Margin = new Padding(3, 2, 3, 2);
            ServiceHotel_DataGid.Name = "ServiceHotel_DataGid";
            ServiceHotel_DataGid.ReadOnly = true;
            ServiceHotel_DataGid.RowHeadersWidth = 51;
            ServiceHotel_DataGid.RowTemplate.Height = 29;
            ServiceHotel_DataGid.Size = new Size(523, 219);
            ServiceHotel_DataGid.TabIndex = 7;
            ServiceHotel_DataGid.CellContentClick += ServiceHotel_DataGid_CellContentClick;
            // 
            // Confirm_Button
            // 
            Confirm_Button.BackColor = Color.FromArgb(8, 48, 107);
            Confirm_Button.FlatAppearance.BorderSize = 0;
            Confirm_Button.FlatStyle = FlatStyle.Flat;
            Confirm_Button.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Confirm_Button.ForeColor = Color.White;
            Confirm_Button.Location = new Point(451, 603);
            Confirm_Button.Margin = new Padding(3, 2, 3, 2);
            Confirm_Button.Name = "Confirm_Button";
            Confirm_Button.Size = new Size(280, 54);
            Confirm_Button.TabIndex = 14;
            Confirm_Button.Text = "Confirm";
            Confirm_Button.UseVisualStyleBackColor = false;
            Confirm_Button.Click += Confirm_Button_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Confirm_Button);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ServiceHotel_DataGid);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Service_Label);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 680);
            panel1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(8, 48, 107);
            label6.Location = new Point(309, 39);
            label6.Name = "label6";
            label6.Size = new Size(548, 30);
            label6.TabIndex = 91;
            label6.Text = "CHECKIN (2) - NOTICE SERVICE, PROMOTION, RULE";
            // 
            // NoticeCheck_inForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 193, 138);
            ClientSize = new Size(1209, 700);
            Controls.Add(Discount_DataGrid);
            Controls.Add(Rules_DataGrid);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "NoticeCheck_inForm";
            Padding = new Padding(10);
            Text = "NoticeCheck_inForm";
            ((System.ComponentModel.ISupportInitialize)Discount_DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rules_DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServiceHotel_DataGid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private DataGridView Discount_DataGrid;
        private Label label1;
        private Label Service_Label;
        private DataGridView Rules_DataGrid;
        private DataGridView ServiceHotel_DataGid;
        private Button Confirm_Button;
        private Panel panel1;
        private Label label6;
    }
}