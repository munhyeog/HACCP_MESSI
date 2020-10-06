namespace mes
{
    partial class WorkOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtWorkOrderNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboWkOdrGubun = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtWkOrderDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtWkOrderDate1 = new System.Windows.Forms.DateTimePicker();
            this.lblWkBodyCount = new System.Windows.Forms.Label();
            this.lblWkHeadCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridWorkOrderBody = new System.Windows.Forms.DataGridView();
            this.gridWorkOrderHead = new System.Windows.Forms.DataGridView();
            this.WORK_ORDER_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORK_ORDER_GUBUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORK_ORDER_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORK_ORDER_PRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_NO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_NAME2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_CAPACITY2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_QTY2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORK_ORDER_DATE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORK_ORDER_NO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_ITEM_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_ITEM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_ITEM_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_ITEM_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_ITEM_RQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEUSER2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATETIME2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATEUSER2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATETIME2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLookup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridWorkOrderBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWorkOrderHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("문체부 돋음체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(62, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 32);
            this.label5.TabIndex = 69;
            this.label5.Text = "작업지시등록";
            // 
            // btnAlter
            // 
            this.btnAlter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlter.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAlter.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlter.Location = new System.Drawing.Point(927, 20);
            this.btnAlter.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(42, 23);
            this.btnAlter.TabIndex = 67;
            this.btnAlter.Text = "수정";
            this.btnAlter.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCreate.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreate.ForeColor = System.Drawing.Color.Transparent;
            this.btnCreate.Location = new System.Drawing.Point(885, 20);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(42, 23);
            this.btnCreate.TabIndex = 66;
            this.btnCreate.Text = "신규";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // txtWorkOrderNo
            // 
            this.txtWorkOrderNo.Location = new System.Drawing.Point(408, 80);
            this.txtWorkOrderNo.Name = "txtWorkOrderNo";
            this.txtWorkOrderNo.Size = new System.Drawing.Size(100, 21);
            this.txtWorkOrderNo.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(325, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 63;
            this.label12.Text = "작업지시번호";
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(633, 81);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(97, 21);
            this.txtCreateUser.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(538, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 59;
            this.label10.Text = "작업지시담당자";
            // 
            // cboWkOdrGubun
            // 
            this.cboWkOdrGubun.FormattingEnabled = true;
            this.cboWkOdrGubun.Items.AddRange(new object[] {
            "전체",
            "작업준비",
            "작업중",
            "작업완료"});
            this.cboWkOdrGubun.Location = new System.Drawing.Point(408, 110);
            this.cboWkOdrGubun.Name = "cboWkOdrGubun";
            this.cboWkOdrGubun.Size = new System.Drawing.Size(121, 20);
            this.cboWkOdrGubun.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 57;
            this.label9.Text = "작업지시구분";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 56;
            this.label8.Text = "작업지시일자";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 12);
            this.label7.TabIndex = 55;
            this.label7.Text = "~";
            // 
            // dtWkOrderDate2
            // 
            this.dtWkOrderDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtWkOrderDate2.Location = new System.Drawing.Point(532, 46);
            this.dtWkOrderDate2.Name = "dtWkOrderDate2";
            this.dtWkOrderDate2.Size = new System.Drawing.Size(98, 21);
            this.dtWkOrderDate2.TabIndex = 54;
            // 
            // dtWkOrderDate1
            // 
            this.dtWkOrderDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtWkOrderDate1.Location = new System.Drawing.Point(408, 46);
            this.dtWkOrderDate1.Name = "dtWkOrderDate1";
            this.dtWkOrderDate1.Size = new System.Drawing.Size(98, 21);
            this.dtWkOrderDate1.TabIndex = 53;
            this.dtWkOrderDate1.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // lblWkBodyCount
            // 
            this.lblWkBodyCount.AutoSize = true;
            this.lblWkBodyCount.Location = new System.Drawing.Point(940, 594);
            this.lblWkBodyCount.Name = "lblWkBodyCount";
            this.lblWkBodyCount.Size = new System.Drawing.Size(12, 12);
            this.lblWkBodyCount.TabIndex = 52;
            this.lblWkBodyCount.Text = "n";
            // 
            // lblWkHeadCount
            // 
            this.lblWkHeadCount.AutoSize = true;
            this.lblWkHeadCount.Location = new System.Drawing.Point(940, 351);
            this.lblWkHeadCount.Name = "lblWkHeadCount";
            this.lblWkHeadCount.Size = new System.Drawing.Size(12, 12);
            this.lblWkHeadCount.TabIndex = 51;
            this.lblWkHeadCount.Text = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(885, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 50;
            this.label4.Text = "총건수 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(885, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 49;
            this.label3.Text = "총건수 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("문체부 돋음체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(47, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "상세";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("문체부 돋음체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(47, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "목록";
            // 
            // gridWorkOrderBody
            // 
            this.gridWorkOrderBody.AllowUserToAddRows = false;
            this.gridWorkOrderBody.AllowUserToDeleteRows = false;
            this.gridWorkOrderBody.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridWorkOrderBody.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridWorkOrderBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWorkOrderBody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATA_ID,
            this.WORK_ORDER_NO2,
            this.MAT_ITEM_CODE,
            this.MAT_ITEM_NAME,
            this.MAT_ITEM_UNIT,
            this.MAT_ITEM_QTY,
            this.MAT_ITEM_RQTY,
            this.STATUS,
            this.CREATEUSER2,
            this.CREATETIME2,
            this.UPDATEUSER2,
            this.UPDATETIME2});
            this.gridWorkOrderBody.Location = new System.Drawing.Point(25, 396);
            this.gridWorkOrderBody.Name = "gridWorkOrderBody";
            this.gridWorkOrderBody.ReadOnly = true;
            this.gridWorkOrderBody.RowTemplate.Height = 23;
            this.gridWorkOrderBody.Size = new System.Drawing.Size(944, 195);
            this.gridWorkOrderBody.TabIndex = 46;
            // 
            // gridWorkOrderHead
            // 
            this.gridWorkOrderHead.AllowUserToAddRows = false;
            this.gridWorkOrderHead.AllowUserToDeleteRows = false;
            this.gridWorkOrderHead.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridWorkOrderHead.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridWorkOrderHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWorkOrderHead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WORK_ORDER_NO,
            this.WORK_ORDER_GUBUN,
            this.WORK_ORDER_DATE,
            this.WORK_ORDER_PRE,
            this.ITEM_NO2,
            this.ITEM_NAME2,
            this.ITEM_CAPACITY2,
            this.ITEM_QTY2,
            this.WORK_ORDER_DATE2,
            this.MEMO,
            this.STATUS2,
            this.CREATEUSER,
            this.CREATETIME,
            this.UPDATEUSER,
            this.UPDATETIME});
            this.gridWorkOrderHead.Location = new System.Drawing.Point(25, 150);
            this.gridWorkOrderHead.Name = "gridWorkOrderHead";
            this.gridWorkOrderHead.ReadOnly = true;
            this.gridWorkOrderHead.RowTemplate.Height = 23;
            this.gridWorkOrderHead.Size = new System.Drawing.Size(944, 198);
            this.gridWorkOrderHead.TabIndex = 45;
            this.gridWorkOrderHead.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridWorkOrderHead_CellContentClick);
            // 
            // WORK_ORDER_NO
            // 
            this.WORK_ORDER_NO.DataPropertyName = "WORK_ORDER_NO";
            this.WORK_ORDER_NO.HeaderText = "작업지시번호";
            this.WORK_ORDER_NO.Name = "WORK_ORDER_NO";
            this.WORK_ORDER_NO.ReadOnly = true;
            // 
            // WORK_ORDER_GUBUN
            // 
            this.WORK_ORDER_GUBUN.DataPropertyName = "WORK_ORDER_GUBUN";
            this.WORK_ORDER_GUBUN.HeaderText = "작업지시구분";
            this.WORK_ORDER_GUBUN.Name = "WORK_ORDER_GUBUN";
            this.WORK_ORDER_GUBUN.ReadOnly = true;
            // 
            // WORK_ORDER_DATE
            // 
            this.WORK_ORDER_DATE.DataPropertyName = "WORK_ORDER_DATE";
            this.WORK_ORDER_DATE.HeaderText = "작업지시일자";
            this.WORK_ORDER_DATE.Name = "WORK_ORDER_DATE";
            this.WORK_ORDER_DATE.ReadOnly = true;
            // 
            // WORK_ORDER_PRE
            // 
            this.WORK_ORDER_PRE.DataPropertyName = "WORK_ORDER_PRE";
            this.WORK_ORDER_PRE.HeaderText = "작업지시담당자";
            this.WORK_ORDER_PRE.Name = "WORK_ORDER_PRE";
            this.WORK_ORDER_PRE.ReadOnly = true;
            // 
            // ITEM_NO2
            // 
            this.ITEM_NO2.DataPropertyName = "ITEM_NO";
            this.ITEM_NO2.HeaderText = "제품코드";
            this.ITEM_NO2.Name = "ITEM_NO2";
            this.ITEM_NO2.ReadOnly = true;
            // 
            // ITEM_NAME2
            // 
            this.ITEM_NAME2.DataPropertyName = "ITEM_NAME";
            this.ITEM_NAME2.HeaderText = "제품명";
            this.ITEM_NAME2.Name = "ITEM_NAME2";
            this.ITEM_NAME2.ReadOnly = true;
            // 
            // ITEM_CAPACITY2
            // 
            this.ITEM_CAPACITY2.DataPropertyName = "ITEM_CAPACITY";
            this.ITEM_CAPACITY2.HeaderText = "용량";
            this.ITEM_CAPACITY2.Name = "ITEM_CAPACITY2";
            this.ITEM_CAPACITY2.ReadOnly = true;
            // 
            // ITEM_QTY2
            // 
            this.ITEM_QTY2.DataPropertyName = "ITEM_QTY";
            this.ITEM_QTY2.HeaderText = "수량";
            this.ITEM_QTY2.Name = "ITEM_QTY2";
            this.ITEM_QTY2.ReadOnly = true;
            // 
            // WORK_ORDER_DATE2
            // 
            this.WORK_ORDER_DATE2.DataPropertyName = "WORK_ORDER_DATE2";
            this.WORK_ORDER_DATE2.HeaderText = "완료예정일자";
            this.WORK_ORDER_DATE2.Name = "WORK_ORDER_DATE2";
            this.WORK_ORDER_DATE2.ReadOnly = true;
            // 
            // MEMO
            // 
            this.MEMO.DataPropertyName = "MEMO";
            this.MEMO.HeaderText = "비고";
            this.MEMO.Name = "MEMO";
            this.MEMO.ReadOnly = true;
            // 
            // STATUS2
            // 
            this.STATUS2.DataPropertyName = "STATUS";
            this.STATUS2.HeaderText = "상태";
            this.STATUS2.Name = "STATUS2";
            this.STATUS2.ReadOnly = true;
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
            // DATA_ID
            // 
            this.DATA_ID.DataPropertyName = "DATA_ID";
            this.DATA_ID.HeaderText = "데이터아이디";
            this.DATA_ID.Name = "DATA_ID";
            this.DATA_ID.ReadOnly = true;
            // 
            // WORK_ORDER_NO2
            // 
            this.WORK_ORDER_NO2.DataPropertyName = "WORK_ORDER_NO";
            this.WORK_ORDER_NO2.HeaderText = "작업지시번호";
            this.WORK_ORDER_NO2.Name = "WORK_ORDER_NO2";
            this.WORK_ORDER_NO2.ReadOnly = true;
            // 
            // MAT_ITEM_CODE
            // 
            this.MAT_ITEM_CODE.DataPropertyName = "MAT_ITEM_CODE";
            this.MAT_ITEM_CODE.HeaderText = "자재코드";
            this.MAT_ITEM_CODE.Name = "MAT_ITEM_CODE";
            this.MAT_ITEM_CODE.ReadOnly = true;
            // 
            // MAT_ITEM_NAME
            // 
            this.MAT_ITEM_NAME.DataPropertyName = "MAT_ITEM_NAME";
            this.MAT_ITEM_NAME.HeaderText = "자재명";
            this.MAT_ITEM_NAME.Name = "MAT_ITEM_NAME";
            this.MAT_ITEM_NAME.ReadOnly = true;
            // 
            // MAT_ITEM_UNIT
            // 
            this.MAT_ITEM_UNIT.DataPropertyName = "MAT_ITEM_UNIT";
            this.MAT_ITEM_UNIT.HeaderText = "단위";
            this.MAT_ITEM_UNIT.Name = "MAT_ITEM_UNIT";
            this.MAT_ITEM_UNIT.ReadOnly = true;
            // 
            // MAT_ITEM_QTY
            // 
            this.MAT_ITEM_QTY.DataPropertyName = "MAT_ITEM_QTY";
            this.MAT_ITEM_QTY.HeaderText = "기준수량";
            this.MAT_ITEM_QTY.Name = "MAT_ITEM_QTY";
            this.MAT_ITEM_QTY.ReadOnly = true;
            // 
            // MAT_ITEM_RQTY
            // 
            this.MAT_ITEM_RQTY.DataPropertyName = "MAT_ITEM_RQTY";
            this.MAT_ITEM_RQTY.HeaderText = "소요수량";
            this.MAT_ITEM_RQTY.Name = "MAT_ITEM_RQTY";
            this.MAT_ITEM_RQTY.ReadOnly = true;
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
            this.CREATETIME2.HeaderText = "작성시간";
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
            this.UPDATETIME2.HeaderText = "수정시간";
            this.UPDATETIME2.Name = "UPDATETIME2";
            this.UPDATETIME2.ReadOnly = true;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(633, 108);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 21);
            this.txtItemName.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 73;
            this.label6.Text = "제품명";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Green;
            this.btnExcel.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.ForeColor = System.Drawing.Color.Transparent;
            this.btnExcel.Location = new System.Drawing.Point(787, 20);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(42, 23);
            this.btnExcel.TabIndex = 75;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::mes.Properties.Resources.list_2x;
            this.pictureBox3.Location = new System.Drawing.Point(25, 373);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 72;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::mes.Properties.Resources.list_2x;
            this.pictureBox2.Location = new System.Drawing.Point(25, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mes.Properties.Resources.browser_4x;
            this.pictureBox1.Location = new System.Drawing.Point(32, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.Image = global::mes.Properties.Resources.loop_circular_2x;
            this.btnRefresh.Location = new System.Drawing.Point(756, 20);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 23);
            this.btnRefresh.TabIndex = 77;
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
            this.btnLookup.Location = new System.Drawing.Point(829, 20);
            this.btnLookup.Margin = new System.Windows.Forms.Padding(0);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(56, 23);
            this.btnLookup.TabIndex = 76;
            this.btnLookup.Text = "조회";
            this.btnLookup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLookup.UseVisualStyleBackColor = false;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // WorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 621);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtWorkOrderNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCreateUser);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboWkOdrGubun);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtWkOrderDate2);
            this.Controls.Add(this.dtWkOrderDate1);
            this.Controls.Add(this.lblWkBodyCount);
            this.Controls.Add(this.lblWkHeadCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridWorkOrderBody);
            this.Controls.Add(this.gridWorkOrderHead);
            this.Name = "WorkOrderForm";
            this.Text = "작업지시등록";
            this.Load += new System.EventHandler(this.WorkOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridWorkOrderBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWorkOrderHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtWorkOrderNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboWkOdrGubun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtWkOrderDate2;
        private System.Windows.Forms.DateTimePicker dtWkOrderDate1;
        private System.Windows.Forms.Label lblWkBodyCount;
        private System.Windows.Forms.Label lblWkHeadCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridWorkOrderBody;
        private System.Windows.Forms.DataGridView gridWorkOrderHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORK_ORDER_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORK_ORDER_GUBUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORK_ORDER_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORK_ORDER_PRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_NO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_NAME2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_CAPACITY2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_QTY2;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORK_ORDER_DATE2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATEUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORK_ORDER_NO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_ITEM_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_ITEM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_ITEM_UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_ITEM_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_ITEM_RQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEUSER2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATETIME2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATEUSER2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATETIME2;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLookup;
    }
}