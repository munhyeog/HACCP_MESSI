namespace mes
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboOdrGubun = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderInfoBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("문체부 돋음체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(134, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(147, 32);
            this.label19.TabIndex = 36;
            this.label19.Text = "수주등록";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSave.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(755, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "작성완료";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(836, 81);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 23);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("문체부 돋음체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(108, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "상세정보";
            // 
            // gridOrderInfoBody
            // 
            this.gridOrderInfoBody.AllowUserToAddRows = false;
            this.gridOrderInfoBody.AllowUserToDeleteRows = false;
            this.gridOrderInfoBody.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOrderInfoBody.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gridOrderInfoBody.Location = new System.Drawing.Point(86, 371);
            this.gridOrderInfoBody.Name = "gridOrderInfoBody";
            this.gridOrderInfoBody.ReadOnly = true;
            this.gridOrderInfoBody.RowTemplate.Height = 23;
            this.gridOrderInfoBody.Size = new System.Drawing.Size(795, 180);
            this.gridOrderInfoBody.TabIndex = 40;
            // 
            // DATA_ID
            // 
            this.DATA_ID.HeaderText = "데이터아이디";
            this.DATA_ID.Name = "DATA_ID";
            this.DATA_ID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "수주번호";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ITEM_NO
            // 
            this.ITEM_NO.HeaderText = "제품코드";
            this.ITEM_NO.Name = "ITEM_NO";
            this.ITEM_NO.ReadOnly = true;
            // 
            // ITEM_NAME
            // 
            this.ITEM_NAME.HeaderText = "제품명";
            this.ITEM_NAME.Name = "ITEM_NAME";
            this.ITEM_NAME.ReadOnly = true;
            // 
            // ITEM_CAPACITY
            // 
            this.ITEM_CAPACITY.HeaderText = "용량";
            this.ITEM_CAPACITY.Name = "ITEM_CAPACITY";
            this.ITEM_CAPACITY.ReadOnly = true;
            // 
            // ITEM_QTY
            // 
            this.ITEM_QTY.HeaderText = "수량";
            this.ITEM_QTY.Name = "ITEM_QTY";
            this.ITEM_QTY.ReadOnly = true;
            // 
            // SCHEDUL_DATE
            // 
            this.SCHEDUL_DATE.HeaderText = "납품예정일";
            this.SCHEDUL_DATE.Name = "SCHEDUL_DATE";
            this.SCHEDUL_DATE.ReadOnly = true;
            // 
            // RECIPIENT
            // 
            this.RECIPIENT.HeaderText = "수취인명";
            this.RECIPIENT.Name = "RECIPIENT";
            this.RECIPIENT.ReadOnly = true;
            // 
            // RECIPIENT_TEL
            // 
            this.RECIPIENT_TEL.HeaderText = "수취인연락처";
            this.RECIPIENT_TEL.Name = "RECIPIENT_TEL";
            this.RECIPIENT_TEL.ReadOnly = true;
            // 
            // RECIPIENT_ZIP
            // 
            this.RECIPIENT_ZIP.HeaderText = "수취인우편번호";
            this.RECIPIENT_ZIP.Name = "RECIPIENT_ZIP";
            this.RECIPIENT_ZIP.ReadOnly = true;
            // 
            // RECIPIENT_ADDRES
            // 
            this.RECIPIENT_ADDRES.HeaderText = "수취인주소";
            this.RECIPIENT_ADDRES.Name = "RECIPIENT_ADDRES";
            this.RECIPIENT_ADDRES.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "비고";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "상태";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "작성자";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "작성일자";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "수정자";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "수정일자";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // txtCustNo
            // 
            this.txtCustNo.Location = new System.Drawing.Point(211, 149);
            this.txtCustNo.Name = "txtCustNo";
            this.txtCustNo.Size = new System.Drawing.Size(209, 21);
            this.txtCustNo.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 51;
            this.label11.Text = "발주처번호";
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(211, 261);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(100, 21);
            this.txtCreateUser.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 49;
            this.label10.Text = "작성자";
            // 
            // cboOdrGubun
            // 
            this.cboOdrGubun.FormattingEnabled = true;
            this.cboOdrGubun.Items.AddRange(new object[] {
            "전체",
            "수주대기",
            "수주확정"});
            this.cboOdrGubun.Location = new System.Drawing.Point(211, 187);
            this.cboOdrGubun.Name = "cboOdrGubun";
            this.cboOdrGubun.Size = new System.Drawing.Size(100, 20);
            this.cboOdrGubun.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 47;
            this.label9.Text = "수주구분";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 46;
            this.label8.Text = "수주일자";
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(211, 223);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(171, 21);
            this.dtOrderDate.TabIndex = 43;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel.Image = global::mes.Properties.Resources.minus;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(832, 315);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(49, 23);
            this.btnDel.TabIndex = 57;
            this.btnDel.Text = "삭제";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Image = global::mes.Properties.Resources.plus;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(777, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 23);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "추가";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoad.Font = new System.Drawing.Font("문체부 돋음체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLoad.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoad.Image = global::mes.Properties.Resources.magnifying_glass_2x;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(638, 315);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(133, 23);
            this.btnLoad.TabIndex = 55;
            this.btnLoad.Text = "견적서 불러오기";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::mes.Properties.Resources.list_2x;
            this.pictureBox2.Location = new System.Drawing.Point(86, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mes.Properties.Resources.browser_4x;
            this.pictureBox1.Location = new System.Drawing.Point(104, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 621);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtCustNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCreateUser);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboOdrGubun);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtOrderDate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridOrderInfoBody);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label19);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderInfoBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridOrderInfoBody;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCustNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboOdrGubun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
    }
}