namespace mes
{
    partial class OrderInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridOrderInfoHead = new System.Windows.Forms.DataGridView();
            this.ORDER_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_GUBUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridOrderInfoBody = new System.Windows.Forms.DataGridView();
            this.DATA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_CAPACITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCHEDUL_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECIPIENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECIPIENT_TEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECIPIENT_ZIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECIPIENT_ADDRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEUSER2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATETIME2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATEUSER2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATETIME2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHeadCount = new System.Windows.Forms.Label();
            this.lblBodyCount = new System.Windows.Forms.Label();
            this.dtOrderDate1 = new System.Windows.Forms.DateTimePicker();
            this.dtOrderDate2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboOdrGubun = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.txtCustNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLookup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderInfoHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderInfoBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOrderInfoHead
            // 
            this.gridOrderInfoHead.AllowUserToAddRows = false;
            this.gridOrderInfoHead.AllowUserToDeleteRows = false;
            this.gridOrderInfoHead.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOrderInfoHead.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridOrderInfoHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderInfoHead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORDER_NO,
            this.ORDER_GUBUN,
            this.ORDER_DATE,
            this.CUST_NO,
            this.MEMO,
            this.CREATEUSER,
            this.CREATETIME,
            this.UPDATEUSER,
            this.UPDATETIME});
            this.gridOrderInfoHead.Location = new System.Drawing.Point(23, 156);
            this.gridOrderInfoHead.Name = "gridOrderInfoHead";
            this.gridOrderInfoHead.ReadOnly = true;
            this.gridOrderInfoHead.RowTemplate.Height = 23;
            this.gridOrderInfoHead.Size = new System.Drawing.Size(944, 198);
            this.gridOrderInfoHead.TabIndex = 0;
            this.gridOrderInfoHead.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOrderInfoHead_CellContentClick);
            // 
            // ORDER_NO
            // 
            this.ORDER_NO.DataPropertyName = "ORDER_NO";
            this.ORDER_NO.HeaderText = "수주번호";
            this.ORDER_NO.Name = "ORDER_NO";
            this.ORDER_NO.ReadOnly = true;
            // 
            // ORDER_GUBUN
            // 
            this.ORDER_GUBUN.DataPropertyName = "ORDER_GUBUN";
            this.ORDER_GUBUN.HeaderText = "수주구분";
            this.ORDER_GUBUN.Name = "ORDER_GUBUN";
            this.ORDER_GUBUN.ReadOnly = true;
            // 
            // ORDER_DATE
            // 
            this.ORDER_DATE.DataPropertyName = "ORDER_DATE";
            this.ORDER_DATE.HeaderText = "수주일자";
            this.ORDER_DATE.Name = "ORDER_DATE";
            this.ORDER_DATE.ReadOnly = true;
            // 
            // CUST_NO
            // 
            this.CUST_NO.DataPropertyName = "CUST_NO";
            this.CUST_NO.HeaderText = "발주처번호";
            this.CUST_NO.Name = "CUST_NO";
            this.CUST_NO.ReadOnly = true;
            // 
            // MEMO
            // 
            this.MEMO.DataPropertyName = "MEMO";
            this.MEMO.HeaderText = "비고";
            this.MEMO.Name = "MEMO";
            this.MEMO.ReadOnly = true;
            // 
            // CREATEUSER
            // 
            this.CREATEUSER.DataPropertyName = "CREATEUSER";
            this.CREATEUSER.HeaderText = "작성자";
            this.CREATEUSER.Name = "CREATEUSER";
            this.CREATEUSER.ReadOnly = true;
            // 
            // CREATETIME
            // 
            this.CREATETIME.DataPropertyName = "CREATETIME";
            this.CREATETIME.HeaderText = "작성시간";
            this.CREATETIME.Name = "CREATETIME";
            this.CREATETIME.ReadOnly = true;
            // 
            // UPDATEUSER
            // 
            this.UPDATEUSER.DataPropertyName = "UPDATEUSER";
            this.UPDATEUSER.HeaderText = "수정자";
            this.UPDATEUSER.Name = "UPDATEUSER";
            this.UPDATEUSER.ReadOnly = true;
            // 
            // UPDATETIME
            // 
            this.UPDATETIME.DataPropertyName = "UPDATETIME";
            this.UPDATETIME.HeaderText = "수정시간";
            this.UPDATETIME.Name = "UPDATETIME";
            this.UPDATETIME.ReadOnly = true;
            // 
            // gridOrderInfoBody
            // 
            this.gridOrderInfoBody.AllowUserToAddRows = false;
            this.gridOrderInfoBody.AllowUserToDeleteRows = false;
            this.gridOrderInfoBody.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOrderInfoBody.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridOrderInfoBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderInfoBody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATA_ID,
            this.dataGridViewTextBoxColumn1,
            this.ITEM_NO,
            this.ITEM_NAME,
            this.ITEM_CAPACITY,
            this.ITEM_QTY,
            this.SCHEDUL_DATE,
            this.RECIPIENT,
            this.RECIPIENT_TEL,
            this.RECIPIENT_ZIP,
            this.RECIPIENT_ADDRES,
            this.dataGridViewTextBoxColumn2,
            this.STATUS,
            this.CREATEUSER2,
            this.CREATETIME2,
            this.UPDATEUSER2,
            this.UPDATETIME2});
            this.gridOrderInfoBody.Location = new System.Drawing.Point(23, 402);
            this.gridOrderInfoBody.Name = "gridOrderInfoBody";
            this.gridOrderInfoBody.ReadOnly = true;
            this.gridOrderInfoBody.RowTemplate.Height = 23;
            this.gridOrderInfoBody.Size = new System.Drawing.Size(944, 195);
            this.gridOrderInfoBody.TabIndex = 1;
            // 
            // DATA_ID
            // 
            this.DATA_ID.DataPropertyName = "DATA_ID";
            this.DATA_ID.HeaderText = "데이터아이디";
            this.DATA_ID.Name = "DATA_ID";
            this.DATA_ID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ORDER_NO";
            this.dataGridViewTextBoxColumn1.HeaderText = "수주번호";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ITEM_NO
            // 
            this.ITEM_NO.DataPropertyName = "ITEM_NO";
            this.ITEM_NO.HeaderText = "제품코드";
            this.ITEM_NO.Name = "ITEM_NO";
            this.ITEM_NO.ReadOnly = true;
            // 
            // ITEM_NAME
            // 
            this.ITEM_NAME.DataPropertyName = "ITEM_NAME";
            this.ITEM_NAME.HeaderText = "제품명";
            this.ITEM_NAME.Name = "ITEM_NAME";
            this.ITEM_NAME.ReadOnly = true;
            // 
            // ITEM_CAPACITY
            // 
            this.ITEM_CAPACITY.DataPropertyName = "ITEM_CAPACITY";
            this.ITEM_CAPACITY.HeaderText = "용량";
            this.ITEM_CAPACITY.Name = "ITEM_CAPACITY";
            this.ITEM_CAPACITY.ReadOnly = true;
            // 
            // ITEM_QTY
            // 
            this.ITEM_QTY.DataPropertyName = "ITEM_QTY";
            this.ITEM_QTY.HeaderText = "수량";
            this.ITEM_QTY.Name = "ITEM_QTY";
            this.ITEM_QTY.ReadOnly = true;
            // 
            // SCHEDUL_DATE
            // 
            this.SCHEDUL_DATE.DataPropertyName = "SCHEDUL_DATE";
            this.SCHEDUL_DATE.HeaderText = "납품예정일";
            this.SCHEDUL_DATE.Name = "SCHEDUL_DATE";
            this.SCHEDUL_DATE.ReadOnly = true;
            // 
            // RECIPIENT
            // 
            this.RECIPIENT.DataPropertyName = "RECIPIENT";
            this.RECIPIENT.HeaderText = "수취인명";
            this.RECIPIENT.Name = "RECIPIENT";
            this.RECIPIENT.ReadOnly = true;
            // 
            // RECIPIENT_TEL
            // 
            this.RECIPIENT_TEL.DataPropertyName = "RECIPIENT_TEL";
            this.RECIPIENT_TEL.HeaderText = "수취인연락처";
            this.RECIPIENT_TEL.Name = "RECIPIENT_TEL";
            this.RECIPIENT_TEL.ReadOnly = true;
            // 
            // RECIPIENT_ZIP
            // 
            this.RECIPIENT_ZIP.DataPropertyName = "RECIPIENT_ZIP";
            this.RECIPIENT_ZIP.HeaderText = "수취인우편번호";
            this.RECIPIENT_ZIP.Name = "RECIPIENT_ZIP";
            this.RECIPIENT_ZIP.ReadOnly = true;
            // 
            // RECIPIENT_ADDRES
            // 
            this.RECIPIENT_ADDRES.DataPropertyName = "RECIPIENT_ADDRES";
            this.RECIPIENT_ADDRES.HeaderText = "수취인주소";
            this.RECIPIENT_ADDRES.Name = "RECIPIENT_ADDRES";
            this.RECIPIENT_ADDRES.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MEMO";
            this.dataGridViewTextBoxColumn2.HeaderText = "비고";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "상태";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // CREATEUSER2
            // 
            this.CREATEUSER2.DataPropertyName = "CREATEUSER";
            this.CREATEUSER2.HeaderText = "작성자";
            this.CREATEUSER2.Name = "CREATEUSER2";
            this.CREATEUSER2.ReadOnly = true;
            // 
            // CREATETIME2
            // 
            this.CREATETIME2.DataPropertyName = "CREATETIME";
            this.CREATETIME2.HeaderText = "작성일자";
            this.CREATETIME2.Name = "CREATETIME2";
            this.CREATETIME2.ReadOnly = true;
            // 
            // UPDATEUSER2
            // 
            this.UPDATEUSER2.DataPropertyName = "UPDATEUSER";
            this.UPDATEUSER2.HeaderText = "수정자";
            this.UPDATEUSER2.Name = "UPDATEUSER2";
            this.UPDATEUSER2.ReadOnly = true;
            // 
            // UPDATETIME2
            // 
            this.UPDATETIME2.DataPropertyName = "UPDATETIME";
            this.UPDATETIME2.HeaderText = "수정일자";
            this.UPDATETIME2.Name = "UPDATETIME2";
            this.UPDATETIME2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("문체부 돋음체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(45, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("문체부 돋음체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(45, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "상세";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(883, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "총건수 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(883, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "총건수 :";
            // 
            // lblHeadCount
            // 
            this.lblHeadCount.AutoSize = true;
            this.lblHeadCount.Location = new System.Drawing.Point(938, 357);
            this.lblHeadCount.Name = "lblHeadCount";
            this.lblHeadCount.Size = new System.Drawing.Size(12, 12);
            this.lblHeadCount.TabIndex = 6;
            this.lblHeadCount.Text = "n";
            // 
            // lblBodyCount
            // 
            this.lblBodyCount.AutoSize = true;
            this.lblBodyCount.Location = new System.Drawing.Point(938, 600);
            this.lblBodyCount.Name = "lblBodyCount";
            this.lblBodyCount.Size = new System.Drawing.Size(12, 12);
            this.lblBodyCount.TabIndex = 7;
            this.lblBodyCount.Text = "n";
            // 
            // dtOrderDate1
            // 
            this.dtOrderDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOrderDate1.Location = new System.Drawing.Point(495, 64);
            this.dtOrderDate1.Name = "dtOrderDate1";
            this.dtOrderDate1.Size = new System.Drawing.Size(98, 21);
            this.dtOrderDate1.TabIndex = 8;
            this.dtOrderDate1.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // dtOrderDate2
            // 
            this.dtOrderDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOrderDate2.Location = new System.Drawing.Point(619, 64);
            this.dtOrderDate2.Name = "dtOrderDate2";
            this.dtOrderDate2.Size = new System.Drawing.Size(98, 21);
            this.dtOrderDate2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(599, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "~";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "수주일자";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "수주구분";
            // 
            // cboOdrGubun
            // 
            this.cboOdrGubun.FormattingEnabled = true;
            this.cboOdrGubun.Items.AddRange(new object[] {
            "전체",
            "수주대기",
            "수주확정"});
            this.cboOdrGubun.Location = new System.Drawing.Point(677, 102);
            this.cboOdrGubun.Name = "cboOdrGubun";
            this.cboOdrGubun.Size = new System.Drawing.Size(121, 20);
            this.cboOdrGubun.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "작성자";
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(496, 102);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(97, 21);
            this.txtCreateUser.TabIndex = 15;
            // 
            // txtCustNo
            // 
            this.txtCustNo.Location = new System.Drawing.Point(305, 102);
            this.txtCustNo.Name = "txtCustNo";
            this.txtCustNo.Size = new System.Drawing.Size(100, 21);
            this.txtCustNo.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(234, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "발주처번호";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(305, 67);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(100, 21);
            this.txtOrderNo.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(246, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "수주번호";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCreate.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreate.ForeColor = System.Drawing.Color.Transparent;
            this.btnCreate.Location = new System.Drawing.Point(883, 20);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(42, 23);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "신규";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlter.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAlter.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlter.Location = new System.Drawing.Point(925, 20);
            this.btnAlter.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(42, 23);
            this.btnAlter.TabIndex = 22;
            this.btnAlter.Text = "수정";
            this.btnAlter.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("문체부 돋음체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(62, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "수주관리";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Green;
            this.btnExcel.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.ForeColor = System.Drawing.Color.Transparent;
            this.btnExcel.Location = new System.Drawing.Point(785, 20);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(42, 23);
            this.btnExcel.TabIndex = 45;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::mes.Properties.Resources.list_2x;
            this.pictureBox3.Location = new System.Drawing.Point(23, 379);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::mes.Properties.Resources.list_2x;
            this.pictureBox2.Location = new System.Drawing.Point(23, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mes.Properties.Resources.browser_4x;
            this.pictureBox1.Location = new System.Drawing.Point(32, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.Image = global::mes.Properties.Resources.loop_circular_2x;
            this.btnRefresh.Location = new System.Drawing.Point(754, 20);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 23);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLookup
            // 
            this.btnLookup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLookup.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLookup.ForeColor = System.Drawing.Color.Transparent;
            this.btnLookup.Image = global::mes.Properties.Resources.magnifying_glass_2x;
            this.btnLookup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLookup.Location = new System.Drawing.Point(827, 20);
            this.btnLookup.Margin = new System.Windows.Forms.Padding(0);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(56, 23);
            this.btnLookup.TabIndex = 20;
            this.btnLookup.Text = "조회";
            this.btnLookup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLookup.UseVisualStyleBackColor = false;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // OrderInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(994, 621);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCustNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCreateUser);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboOdrGubun);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtOrderDate2);
            this.Controls.Add(this.dtOrderDate1);
            this.Controls.Add(this.lblBodyCount);
            this.Controls.Add(this.lblHeadCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridOrderInfoBody);
            this.Controls.Add(this.gridOrderInfoHead);
            this.Name = "OrderInfoForm";
            this.Text = "수주관리";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderInfoHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderInfoBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOrderInfoHead;
        private System.Windows.Forms.DataGridView gridOrderInfoBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHeadCount;
        private System.Windows.Forms.Label lblBodyCount;
        private System.Windows.Forms.DateTimePicker dtOrderDate1;
        private System.Windows.Forms.DateTimePicker dtOrderDate2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboOdrGubun;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.TextBox txtCustNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_GUBUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATEUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_CAPACITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCHEDUL_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECIPIENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECIPIENT_TEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECIPIENT_ZIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECIPIENT_ADDRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEUSER2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATETIME2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATEUSER2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATETIME2;
        private System.Windows.Forms.Button btnExcel;
    }
}