using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace mes
{
    public partial class OrderForm : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        // 추가 및 삭제 관련 쿼리;
        string UpdateQuery;
        public OrderForm()
        {
            InitializeComponent();

            conn = new MySqlConnection("datasource=localhost;port=3306;Database=mes;username=root;password=1234");
            dt = new DataTable();
            cboOdrGubun.SelectedIndex = 0;
            UpdateQuery = "START TRANSACTION;";

            gridOrderInfoBody.Columns[0].DataPropertyName = "DATA_ID";
            gridOrderInfoBody.Columns[1].DataPropertyName = "ORDER_NO";
            gridOrderInfoBody.Columns[2].DataPropertyName = "ITEM_NO";
            gridOrderInfoBody.Columns[3].DataPropertyName = "ITEM_NAME";
            gridOrderInfoBody.Columns[4].DataPropertyName = "ITEM_CAPACITY";
            gridOrderInfoBody.Columns[5].DataPropertyName = "ITEM_QTY";
            gridOrderInfoBody.Columns[6].DataPropertyName = "SCHEDUL_DATE";
            gridOrderInfoBody.Columns[7].DataPropertyName = "RECIPIENT";
            gridOrderInfoBody.Columns[8].DataPropertyName = "RECIPIENT_TEL";
            gridOrderInfoBody.Columns[9].DataPropertyName = "RECIPIENT_ZIP";
            gridOrderInfoBody.Columns[10].DataPropertyName = "RECIPIENT_ADDRES";
            gridOrderInfoBody.Columns[11].DataPropertyName = "MEMO";
            gridOrderInfoBody.Columns[12].DataPropertyName = "STATUS";
            gridOrderInfoBody.Columns[13].DataPropertyName = "CREATEUSER";
            gridOrderInfoBody.Columns[14].DataPropertyName = "CREATETIME";
            gridOrderInfoBody.Columns[15].DataPropertyName = "UPDATEUSER";
            gridOrderInfoBody.Columns[16].DataPropertyName = "UPDATETIME";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            UpdateQuery += "COMMIT;";
            cmd = new MySqlCommand(UpdateQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            //gridOrderInfoBody.AllowUserToAddRows = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (gridOrderInfoBody.Rows.Count != 0)
            {
                ((DataTable)gridOrderInfoBody.DataSource).Rows.Clear();
            }

            string time = dtOrderDate.Value.ToString("yyyy-MM-dd");

            conn.Open();

            //SELECT B.* FROM ORDER_INFO_HEAD A, ORDER_INFO_BODY B WHERE A.ORDER_NO = B.ORDER_NO AND A.ORDER_DATE='2020-08-25';

            string orderInfoHeadQuery = "SELECT B.* FROM ORDER_INFO_HEAD A , ORDER_INFO_BODY B WHERE ";

            if (txtCustNo.Text != "")
            {
                orderInfoHeadQuery += "A.CUST_NO=@CUST_NO AND ";
            }
            if (txtCreateUser.Text != "")
            {
                orderInfoHeadQuery += "A.CREATEUSER=@CREATEUSER AND ";
            }
            if (cboOdrGubun.SelectedItem != "전체")
            {
                orderInfoHeadQuery += "A.ORDER_GUBUN=@ORDER_GUBUN AND ";
            }
            orderInfoHeadQuery += "A.ORDER_DATE='" + time + "' AND ";
            orderInfoHeadQuery += "A.ORDER_NO = B.ORDER_NO;";
            cmd = new MySqlCommand(orderInfoHeadQuery, conn);

            cmd.Parameters.AddWithValue("@CUST_NO", txtCustNo.Text);
            cmd.Parameters.AddWithValue("@CREATEUSER", txtCreateUser.Text);
            cmd.Parameters.AddWithValue("@ORDER_GUBUN", cboOdrGubun.SelectedItem);

            adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(dt);
            gridOrderInfoBody.DataSource = dt;
            dt.Dispose();

            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dt.Rows.Add();
            //gridOrderInfoBody.AllowUserToAddRows = true;


            #region 주석처리
            /*
                DataTable dtChanges = new DataTable();
                DataTable dtStudent = (DataTable)gridOrderInfoBody.DataSource;
                dtChanges = dtStudent.GetChanges(DataRowState.Modified);

                string insertQuery = string.Empty;

                if (dtChanges != null)
                {
                    for (int i = 0; i < dtChanges.Rows.Count; i++)
                    {
                        insertQuery = "INSERT INTO ORDER_INFO_BODY VALUES(@DATAID, @ORDERINFO, @ITEMNO, @ITEMNAME, @ITEMCAPA, @ITEMQTY, @SCHEDULDATE, @RECI, @RECITEL, " +
                        "@RECIZIP, @RECIADD, @MEMO, @STAT, @CUSER, @CTIME, @UUSER, @UTIME);";
                        cmd = new MySqlCommand(insertQuery, conn);
                        cmd.Parameters.AddWithValue("@DATAID",          Int32.Parse(dtChanges.Rows[i]["DATA_ID"].ToString()));
                        cmd.Parameters.AddWithValue("@ORDERINFO",       dtChanges.Rows[i]["ORDER_NO"].ToString());
                        cmd.Parameters.AddWithValue("@ITEMNO",          dtChanges.Rows[i]["ITEM_NO"].ToString());
                        cmd.Parameters.AddWithValue("@ITEMNAME",        dtChanges.Rows[i]["ITEM_NAME"].ToString());
                        cmd.Parameters.AddWithValue("@ITEMCAPA",        dtChanges.Rows[i]["ITEM_CAPACITY"].ToString());
                        cmd.Parameters.AddWithValue("@ITEMQTY",         dtChanges.Rows[i]["ITEM_QTY"].ToString());
                        cmd.Parameters.AddWithValue("@SCHEDULDATE",     dtChanges.Rows[i]["SCHEDUL_DATE"].ToString());
                        cmd.Parameters.AddWithValue("@RECI",            dtChanges.Rows[i]["RECIPIENT"].ToString());
                        cmd.Parameters.AddWithValue("@RECITEL",         dtChanges.Rows[i]["RECIPIENT_TEL"].ToString());
                        cmd.Parameters.AddWithValue("@RECIZIP",         dtChanges.Rows[i]["RECIPIENT_ZIP"].ToString());
                        cmd.Parameters.AddWithValue("@RECIADD",         dtChanges.Rows[i]["RECIPIENT_ADDRES"].ToString());
                        cmd.Parameters.AddWithValue("@MEMO",            dtChanges.Rows[i]["MEMO"].ToString());
                        cmd.Parameters.AddWithValue("@STAT",            dtChanges.Rows[i]["STATUS"].ToString());
                        cmd.Parameters.AddWithValue("@CUSER",           dtChanges.Rows[i]["CREATEUSER"].ToString());
                        cmd.Parameters.AddWithValue("@CTIME",           DateTime.Parse(dtChanges.Rows[i]["CREATETIME"].ToString()));
                        cmd.Parameters.AddWithValue("@UUSER",           dtChanges.Rows[i]["UPDATEUSER"].ToString());
                        cmd.Parameters.AddWithValue("@UTIME",           DateTime.Parse(dtChanges.Rows[i]["UPDATETIME"].ToString()));
                        cmd.ExecuteNonQuery();
                    }
                }
                dtChanges = null;
            */
            #endregion
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            // 쿼리문에 넣어두고 save 시 commit 하도록...
            int rowIndex = gridOrderInfoBody.CurrentRow.Index;
            string temp = gridOrderInfoBody.Rows[rowIndex].Cells[0].Value.ToString();
            dt.Rows.RemoveAt(rowIndex);
            UpdateQuery += "DELETE FROM ORDER_INFO_BODY WHERE ORDER_NO='" + temp + "';";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }


    }
}
