namespace mes.base_info
{
    partial class InfoCompanyForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLookup = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtWorkOrderNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboWkOdrGubun = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWkHeadCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridInfoCompany = new System.Windows.Forms.DataGridView();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.com_chkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.com_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_licenseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_phoneno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_rep_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInfoCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.Image = global::mes.Properties.Resources.loop_circular_2x;
            this.btnRefresh.Location = new System.Drawing.Point(760, 29);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 23);
            this.btnRefresh.TabIndex = 106;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnLookup
            // 
            this.btnLookup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLookup.ForeColor = System.Drawing.Color.Transparent;
            this.btnLookup.Image = global::mes.Properties.Resources.magnifying_glass_2x;
            this.btnLookup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLookup.Location = new System.Drawing.Point(833, 29);
            this.btnLookup.Margin = new System.Windows.Forms.Padding(0);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(56, 23);
            this.btnLookup.TabIndex = 105;
            this.btnLookup.Text = "조회";
            this.btnLookup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLookup.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Green;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.ForeColor = System.Drawing.Color.Transparent;
            this.btnExcel.Location = new System.Drawing.Point(791, 29);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(42, 23);
            this.btnExcel.TabIndex = 104;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::mes.Properties.Resources.list_2x;
            this.pictureBox2.Location = new System.Drawing.Point(29, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mes.Properties.Resources.browser_4x;
            this.pictureBox1.Location = new System.Drawing.Point(38, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(76, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 37);
            this.label5.TabIndex = 98;
            this.label5.Text = "거래처 정보";
            // 
            // btnAlter
            // 
            this.btnAlter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAlter.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlter.Location = new System.Drawing.Point(931, 29);
            this.btnAlter.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(42, 23);
            this.btnAlter.TabIndex = 97;
            this.btnAlter.Text = "수정";
            this.btnAlter.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreate.ForeColor = System.Drawing.Color.Transparent;
            this.btnCreate.Location = new System.Drawing.Point(889, 29);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(42, 23);
            this.btnCreate.TabIndex = 96;
            this.btnCreate.Text = "신규";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // txtWorkOrderNo
            // 
            this.txtWorkOrderNo.Location = new System.Drawing.Point(307, 96);
            this.txtWorkOrderNo.Name = "txtWorkOrderNo";
            this.txtWorkOrderNo.Size = new System.Drawing.Size(100, 21);
            this.txtWorkOrderNo.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 94;
            this.label12.Text = "거래처명";
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(694, 96);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(97, 21);
            this.txtCreateUser.TabIndex = 93;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(623, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 92;
            this.label10.Text = "거래처코드";
            // 
            // cboWkOdrGubun
            // 
            this.cboWkOdrGubun.FormattingEnabled = true;
            this.cboWkOdrGubun.Items.AddRange(new object[] {
            "전체",
            "작업준비",
            "작업중",
            "작업완료"});
            this.cboWkOdrGubun.Location = new System.Drawing.Point(504, 96);
            this.cboWkOdrGubun.Name = "cboWkOdrGubun";
            this.cboWkOdrGubun.Size = new System.Drawing.Size(84, 20);
            this.cboWkOdrGubun.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 90;
            this.label9.Text = "거래처유형";
            // 
            // lblWkHeadCount
            // 
            this.lblWkHeadCount.AutoSize = true;
            this.lblWkHeadCount.Location = new System.Drawing.Point(954, 565);
            this.lblWkHeadCount.Name = "lblWkHeadCount";
            this.lblWkHeadCount.Size = new System.Drawing.Size(12, 12);
            this.lblWkHeadCount.TabIndex = 84;
            this.lblWkHeadCount.Text = "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(899, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 82;
            this.label3.Text = "총건수 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(51, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 80;
            this.label1.Text = "거래처 목록";
            // 
            // gridInfoCompany
            // 
            this.gridInfoCompany.AllowUserToAddRows = false;
            this.gridInfoCompany.AllowUserToDeleteRows = false;
            this.gridInfoCompany.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInfoCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridInfoCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInfoCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.com_chkbox,
            this.com_no,
            this.com_type,
            this.com_name,
            this.com_licenseno,
            this.com_phoneno,
            this.com_rep_name});
            this.gridInfoCompany.Location = new System.Drawing.Point(29, 159);
            this.gridInfoCompany.Name = "gridInfoCompany";
            this.gridInfoCompany.ReadOnly = true;
            this.gridInfoCompany.RowTemplate.Height = 23;
            this.gridInfoCompany.Size = new System.Drawing.Size(944, 392);
            this.gridInfoCompany.TabIndex = 78;
            // 
            // com_chkbox
            // 
            this.com_chkbox.HeaderText = "";
            this.com_chkbox.Name = "com_chkbox";
            this.com_chkbox.ReadOnly = true;
            this.com_chkbox.Width = 20;
            // 
            // com_no
            // 
            this.com_no.DataPropertyName = "com_no";
            this.com_no.HeaderText = "거래처코드";
            this.com_no.Name = "com_no";
            this.com_no.ReadOnly = true;
            // 
            // com_type
            // 
            this.com_type.DataPropertyName = "com_type";
            this.com_type.HeaderText = "거래처유형";
            this.com_type.Name = "com_type";
            this.com_type.ReadOnly = true;
            // 
            // com_name
            // 
            this.com_name.DataPropertyName = "com_name";
            this.com_name.HeaderText = "거래처명";
            this.com_name.Name = "com_name";
            this.com_name.ReadOnly = true;
            // 
            // com_licenseno
            // 
            this.com_licenseno.DataPropertyName = "com_licenseno";
            this.com_licenseno.HeaderText = "사업자번호";
            this.com_licenseno.Name = "com_licenseno";
            this.com_licenseno.ReadOnly = true;
            // 
            // com_phoneno
            // 
            this.com_phoneno.DataPropertyName = "com_phoneno";
            this.com_phoneno.HeaderText = "전화번호";
            this.com_phoneno.Name = "com_phoneno";
            this.com_phoneno.ReadOnly = true;
            // 
            // com_rep_name
            // 
            this.com_rep_name.DataPropertyName = "com_rep_name";
            this.com_rep_name.HeaderText = "대표자명";
            this.com_rep_name.Name = "com_rep_name";
            this.com_rep_name.ReadOnly = true;
            // 
            // InfoCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 647);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.btnExcel);
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
            this.Controls.Add(this.lblWkHeadCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridInfoCompany);
            this.Name = "InfoCompanyForm";
            this.Text = "InfoCompanyForm";
            this.Load += new System.EventHandler(this.InfoCompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInfoCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Button btnExcel;
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
        private System.Windows.Forms.Label lblWkHeadCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridInfoCompany;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn com_chkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_licenseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_phoneno;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_rep_name;
    }
}