using System.Runtime.Intrinsics.X86;

namespace GUI_HotelManagement
{
    partial class Booking_Form
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelIdentify = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.labelNumberRoom = new System.Windows.Forms.Label();
            this.labelSepcialReq = new System.Windows.Forms.Label();
            this.panelBooking = new System.Windows.Forms.Panel();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.checkBoxDeposit = new System.Windows.Forms.CheckBox();
            this.txtDepositFee = new System.Windows.Forms.TextBox();
            this.labelDepositFee = new System.Windows.Forms.Label();
            this.txtRoomFee = new System.Windows.Forms.TextBox();
            this.labelRoomFee = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtSpecialReq = new System.Windows.Forms.TextBox();
            this.txtNumberRoom = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.btnChooseRoom = new System.Windows.Forms.Button();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtIdentify = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumberStay = new System.Windows.Forms.TextBox();
            this.labelNumberStay = new System.Windows.Forms.Label();
            this.labelNameGroup = new System.Windows.Forms.Label();
            this.txtNameGroup = new System.Windows.Forms.TextBox();
            this.checkBoxGroup = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelBooking.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(24, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 28);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Full Name:";
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(24, 185);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(148, 28);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "Phone Number:";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(24, 239);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 28);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Email:";
            // 
            // labelIdentify
            // 
            this.labelIdentify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIdentify.AutoSize = true;
            this.labelIdentify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdentify.Location = new System.Drawing.Point(24, 131);
            this.labelIdentify.Name = "labelIdentify";
            this.labelIdentify.Size = new System.Drawing.Size(128, 28);
            this.labelIdentify.TabIndex = 23;
            this.labelIdentify.Text = "Identify Card:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label11.Location = new System.Drawing.Point(483, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 35);
            this.label11.TabIndex = 35;
            this.label11.Text = "Booking Room";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.btnCreateBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateBooking.ForeColor = System.Drawing.Color.White;
            this.btnCreateBooking.Location = new System.Drawing.Point(667, 501);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(327, 71);
            this.btnCreateBooking.TabIndex = 36;
            this.btnCreateBooking.Text = "Create Booking";
            this.btnCreateBooking.UseVisualStyleBackColor = false;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // labelGender
            // 
            this.labelGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGender.Location = new System.Drawing.Point(24, 292);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(80, 28);
            this.labelGender.TabIndex = 42;
            this.labelGender.Text = "Gender:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBirthday.Location = new System.Drawing.Point(24, 347);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(89, 28);
            this.labelBirthday.TabIndex = 43;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelArrivalDate.AutoSize = true;
            this.labelArrivalDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelArrivalDate.Location = new System.Drawing.Point(567, 80);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(119, 28);
            this.labelArrivalDate.TabIndex = 45;
            this.labelArrivalDate.Text = "Arrival Date:";
            // 
            // labelNumberRoom
            // 
            this.labelNumberRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberRoom.AutoSize = true;
            this.labelNumberRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberRoom.Location = new System.Drawing.Point(567, 285);
            this.labelNumberRoom.Name = "labelNumberRoom";
            this.labelNumberRoom.Size = new System.Drawing.Size(153, 28);
            this.labelNumberRoom.TabIndex = 46;
            this.labelNumberRoom.Text = "Number Rooms:";
            // 
            // labelSepcialReq
            // 
            this.labelSepcialReq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSepcialReq.AutoSize = true;
            this.labelSepcialReq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSepcialReq.Location = new System.Drawing.Point(567, 185);
            this.labelSepcialReq.Name = "labelSepcialReq";
            this.labelSepcialReq.Size = new System.Drawing.Size(185, 28);
            this.labelSepcialReq.TabIndex = 49;
            this.labelSepcialReq.Text = "Special Requiments:";
            // 
            // panelBooking
            // 
            this.panelBooking.BackColor = System.Drawing.Color.White;
            this.panelBooking.Controls.Add(this.labelPaymentMethod);
            this.panelBooking.Controls.Add(this.comboBoxPaymentMethod);
            this.panelBooking.Controls.Add(this.checkBoxDeposit);
            this.panelBooking.Controls.Add(this.txtDepositFee);
            this.panelBooking.Controls.Add(this.labelDepositFee);
            this.panelBooking.Controls.Add(this.txtRoomFee);
            this.panelBooking.Controls.Add(this.labelRoomFee);
            this.panelBooking.Controls.Add(this.btnCheck);
            this.panelBooking.Controls.Add(this.txtSpecialReq);
            this.panelBooking.Controls.Add(this.txtNumberRoom);
            this.panelBooking.Controls.Add(this.txtDepartureDate);
            this.panelBooking.Controls.Add(this.txtArrivalDate);
            this.panelBooking.Controls.Add(this.btnChooseRoom);
            this.panelBooking.Controls.Add(this.labelDepartureDate);
            this.panelBooking.Controls.Add(this.label2);
            this.panelBooking.Controls.Add(this.txtBirthday);
            this.panelBooking.Controls.Add(this.txtGender);
            this.panelBooking.Controls.Add(this.txtEmail);
            this.panelBooking.Controls.Add(this.txtPhone);
            this.panelBooking.Controls.Add(this.txtIdentify);
            this.panelBooking.Controls.Add(this.txtName);
            this.panelBooking.Controls.Add(this.labelSepcialReq);
            this.panelBooking.Controls.Add(this.labelNumberRoom);
            this.panelBooking.Controls.Add(this.labelArrivalDate);
            this.panelBooking.Controls.Add(this.labelBirthday);
            this.panelBooking.Controls.Add(this.labelGender);
            this.panelBooking.Controls.Add(this.btnCreateBooking);
            this.panelBooking.Controls.Add(this.label11);
            this.panelBooking.Controls.Add(this.labelIdentify);
            this.panelBooking.Controls.Add(this.labelEmail);
            this.panelBooking.Controls.Add(this.labelPhone);
            this.panelBooking.Controls.Add(this.labelName);
            this.panelBooking.Controls.Add(this.panel1);
            this.panelBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelBooking.Location = new System.Drawing.Point(11, 13);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(1095, 597);
            this.panelBooking.TabIndex = 8;
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPaymentMethod.Location = new System.Drawing.Point(567, 448);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(166, 28);
            this.labelPaymentMethod.TabIndex = 85;
            this.labelPaymentMethod.Text = "Payment Method:";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Traveller Cheque",
            "Traveller Agent Account"});
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(741, 441);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(172, 36);
            this.comboBoxPaymentMethod.TabIndex = 84;
            this.comboBoxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentMethod_SelectedIndexChanged);
            // 
            // checkBoxDeposit
            // 
            this.checkBoxDeposit.AutoSize = true;
            this.checkBoxDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDeposit.Location = new System.Drawing.Point(936, 448);
            this.checkBoxDeposit.Name = "checkBoxDeposit";
            this.checkBoxDeposit.Size = new System.Drawing.Size(133, 32);
            this.checkBoxDeposit.TabIndex = 83;
            this.checkBoxDeposit.Text = "Deposited?";
            this.checkBoxDeposit.UseVisualStyleBackColor = true;
            this.checkBoxDeposit.CheckedChanged += new System.EventHandler(this.checkBoxDeposit_CheckedChanged);
            // 
            // txtDepositFee
            // 
            this.txtDepositFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepositFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepositFee.Location = new System.Drawing.Point(741, 388);
            this.txtDepositFee.Name = "txtDepositFee";
            this.txtDepositFee.Size = new System.Drawing.Size(172, 34);
            this.txtDepositFee.TabIndex = 82;
            // 
            // labelDepositFee
            // 
            this.labelDepositFee.AutoSize = true;
            this.labelDepositFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDepositFee.Location = new System.Drawing.Point(567, 399);
            this.labelDepositFee.Name = "labelDepositFee";
            this.labelDepositFee.Size = new System.Drawing.Size(119, 28);
            this.labelDepositFee.TabIndex = 81;
            this.labelDepositFee.Text = "Deposit Fee:";
            // 
            // txtRoomFee
            // 
            this.txtRoomFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomFee.Location = new System.Drawing.Point(741, 336);
            this.txtRoomFee.Name = "txtRoomFee";
            this.txtRoomFee.Size = new System.Drawing.Size(172, 34);
            this.txtRoomFee.TabIndex = 80;
            // 
            // labelRoomFee
            // 
            this.labelRoomFee.AutoSize = true;
            this.labelRoomFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRoomFee.Location = new System.Drawing.Point(567, 347);
            this.labelRoomFee.Name = "labelRoomFee";
            this.labelRoomFee.Size = new System.Drawing.Size(103, 28);
            this.labelRoomFee.TabIndex = 79;
            this.labelRoomFee.Text = "Room Fee:";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(350, 123);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(114, 39);
            this.btnCheck.TabIndex = 78;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtSpecialReq
            // 
            this.txtSpecialReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecialReq.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpecialReq.Location = new System.Drawing.Point(741, 175);
            this.txtSpecialReq.Multiline = true;
            this.txtSpecialReq.Name = "txtSpecialReq";
            this.txtSpecialReq.Size = new System.Drawing.Size(316, 85);
            this.txtSpecialReq.TabIndex = 72;
            // 
            // txtNumberRoom
            // 
            this.txtNumberRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberRoom.Location = new System.Drawing.Point(741, 275);
            this.txtNumberRoom.Name = "txtNumberRoom";
            this.txtNumberRoom.Size = new System.Drawing.Size(98, 34);
            this.txtNumberRoom.TabIndex = 73;
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartureDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepartureDate.Location = new System.Drawing.Point(741, 121);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(172, 34);
            this.txtDepartureDate.TabIndex = 74;
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArrivalDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArrivalDate.Location = new System.Drawing.Point(741, 69);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(172, 34);
            this.txtArrivalDate.TabIndex = 75;
            // 
            // btnChooseRoom
            // 
            this.btnChooseRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.btnChooseRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseRoom.FlatAppearance.BorderSize = 0;
            this.btnChooseRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChooseRoom.ForeColor = System.Drawing.Color.White;
            this.btnChooseRoom.Location = new System.Drawing.Point(862, 275);
            this.btnChooseRoom.Name = "btnChooseRoom";
            this.btnChooseRoom.Size = new System.Drawing.Size(195, 39);
            this.btnChooseRoom.TabIndex = 65;
            this.btnChooseRoom.Text = "Choose Room";
            this.btnChooseRoom.UseVisualStyleBackColor = false;
            this.btnChooseRoom.Click += new System.EventHandler(this.btnChooseRoom_Click);
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDepartureDate.Location = new System.Drawing.Point(567, 133);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(150, 28);
            this.labelDepartureDate.TabIndex = 62;
            this.labelDepartureDate.Text = "Departure Date:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(567, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.TabIndex = 61;
            // 
            // txtBirthday
            // 
            this.txtBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBirthday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBirthday.Location = new System.Drawing.Point(167, 336);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(161, 34);
            this.txtBirthday.TabIndex = 56;
            // 
            // txtGender
            // 
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGender.Location = new System.Drawing.Point(167, 281);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(161, 34);
            this.txtGender.TabIndex = 55;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Location = new System.Drawing.Point(167, 228);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 34);
            this.txtEmail.TabIndex = 54;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Location = new System.Drawing.Point(167, 175);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(161, 34);
            this.txtPhone.TabIndex = 53;
            // 
            // txtIdentify
            // 
            this.txtIdentify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentify.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentify.Location = new System.Drawing.Point(167, 123);
            this.txtIdentify.Name = "txtIdentify";
            this.txtIdentify.Size = new System.Drawing.Size(161, 34);
            this.txtIdentify.TabIndex = 52;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Location = new System.Drawing.Point(167, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 34);
            this.txtName.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.txtNumberStay);
            this.panel1.Controls.Add(this.labelNumberStay);
            this.panel1.Controls.Add(this.labelNameGroup);
            this.panel1.Controls.Add(this.txtNameGroup);
            this.panel1.Controls.Add(this.checkBoxGroup);
            this.panel1.Location = new System.Drawing.Point(24, 399);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 173);
            this.panel1.TabIndex = 86;
            // 
            // txtNumberStay
            // 
            this.txtNumberStay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberStay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberStay.Location = new System.Drawing.Point(194, 60);
            this.txtNumberStay.Name = "txtNumberStay";
            this.txtNumberStay.Size = new System.Drawing.Size(195, 34);
            this.txtNumberStay.TabIndex = 71;
            this.txtNumberStay.Visible = false;
            // 
            // labelNumberStay
            // 
            this.labelNumberStay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberStay.AutoSize = true;
            this.labelNumberStay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberStay.Location = new System.Drawing.Point(40, 71);
            this.labelNumberStay.Name = "labelNumberStay";
            this.labelNumberStay.Size = new System.Drawing.Size(130, 28);
            this.labelNumberStay.TabIndex = 67;
            this.labelNumberStay.Text = "Number Stay:";
            this.labelNumberStay.Visible = false;
            // 
            // labelNameGroup
            // 
            this.labelNameGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameGroup.AutoSize = true;
            this.labelNameGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameGroup.Location = new System.Drawing.Point(40, 120);
            this.labelNameGroup.Name = "labelNameGroup";
            this.labelNameGroup.Size = new System.Drawing.Size(152, 28);
            this.labelNameGroup.TabIndex = 68;
            this.labelNameGroup.Text = "Name of Group:";
            this.labelNameGroup.Visible = false;
            // 
            // txtNameGroup
            // 
            this.txtNameGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameGroup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameGroup.Location = new System.Drawing.Point(194, 109);
            this.txtNameGroup.Name = "txtNameGroup";
            this.txtNameGroup.Size = new System.Drawing.Size(195, 34);
            this.txtNameGroup.TabIndex = 76;
            this.txtNameGroup.Visible = false;
            // 
            // checkBoxGroup
            // 
            this.checkBoxGroup.AutoSize = true;
            this.checkBoxGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxGroup.Location = new System.Drawing.Point(40, 19);
            this.checkBoxGroup.Name = "checkBoxGroup";
            this.checkBoxGroup.Size = new System.Drawing.Size(221, 32);
            this.checkBoxGroup.TabIndex = 66;
            this.checkBoxGroup.Text = "Group Inclusive Tour?";
            this.checkBoxGroup.UseVisualStyleBackColor = true;
            this.checkBoxGroup.CheckedChanged += new System.EventHandler(this.checkBoxGroup_CheckedChanged_1);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Booking_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1117, 623);
            this.Controls.Add(this.panelBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Booking_Form";
            this.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking_Form";
            this.panelBooking.ResumeLayout(false);
            this.panelBooking.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Load += Load_BookingForm;
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label labelName;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelIdentify;
        private Label label11;
        private Button btnCreateBooking;
        private Label labelGender;
        private Label labelBirthday;
        private Label labelArrivalDate;
        private Label labelNumberRoom;
        private Label labelSepcialReq;
        private Panel panelBooking;
        private Button btnChooseRoom;
        private Label labelDepartureDate;
        private Label label2;
        private TextBox txtBirthday;
        private TextBox txtGender;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtIdentify;
        private TextBox txtName;
        private TextBox txtSpecialReq;
        private TextBox txtNumberRoom;
        private TextBox txtDepartureDate;
        private TextBox txtArrivalDate;
        private TextBox txtNameGroup;
        private TextBox txtNumberStay;
        private ContextMenuStrip contextMenuStrip2;
        private Label labelNameGroup;
        private Label labelNumberStay;
        private CheckBox checkBoxGroup;
        private Button btnCheck;
        private TextBox txtDepositFee;
        private Label labelDepositFee;
        private TextBox txtRoomFee;
        private Label labelRoomFee;
        private CheckBox checkBoxDeposit;
        private ComboBox comboBoxPaymentMethod;
        private Label labelPaymentMethod;
        private Panel panel1;
    }
}