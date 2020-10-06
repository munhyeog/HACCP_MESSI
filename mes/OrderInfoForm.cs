using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mes
{
    public partial class OrderInfoForm : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        OrderForm orderForm;
        public OrderInfoForm()
        {
            InitializeComponent();

            conn = new MySqlConnection("datasource=localhost;port=3306;Database=mes;username=root;password=1234");
            dt = new DataTable();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            conn.Open();

            string orderInfoHeadQuery = "SELECT * FROM ORDER_INFO_HEAD;";
            cmd = new MySqlCommand(orderInfoHeadQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            gridOrderInfoHead.DataSource = dt;

            //gridOrderInfoHead.Columns[0].HeaderText = "수주번호";
            //gridOrderInfoHead.Columns["ORDER_NO"].HeaderText = "수주번호";
            gridOrderInfoHead.Columns["ORDER_NO"].Frozen = true;

            cboOdrGubun.SelectedIndex = 0;
            lblHeadCount.Text = dt.Rows.Count.ToString();
            

            dt.Dispose();
            conn.Close();
        }

        private void gridOrderInfoHead_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tempTable = new DataTable();
            try
            {
                conn.Open();

                int rowIndex = gridOrderInfoHead.CurrentRow.Index;
                string temp = gridOrderInfoHead.Rows[rowIndex].Cells[0].Value.ToString();

                string orderInfoBodyQuery = "SELECT * FROM ORDER_INFO_BODY WHERE ORDER_NO=@order_no";
                cmd = new MySqlCommand(orderInfoBodyQuery, conn);
                cmd.Parameters.AddWithValue("@order_no", temp);

                tempTable.Load(cmd.ExecuteReader());

                lblBodyCount.Text = tempTable.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            gridOrderInfoBody.DataSource = tempTable;

            conn.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            orderForm = new OrderForm();
            orderForm.MdiParent = this.MdiParent;
            orderForm.WindowState = FormWindowState.Normal;
            orderForm.StartPosition = FormStartPosition.CenterParent;
            orderForm.Show();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            ((DataTable)gridOrderInfoHead.DataSource).Rows.Clear();

            string t1 = dtOrderDate1.Value.ToString("yyyy-MM-dd");
            string t2 = dtOrderDate2.Value.ToString("yyyy-MM-dd");


            conn.Open();

            string orderInfoHeadQuery = "SELECT * FROM ORDER_INFO_HEAD WHERE ";

            if (txtOrderNo.Text != "")
            {
                orderInfoHeadQuery += "ORDER_NO=@ORDER_NO AND ";
            }
            if (txtCustNo.Text != "")
            {
                orderInfoHeadQuery += "CUST_NO=@CUST_NO AND ";
            }
            if (txtCreateUser.Text != "")
            {
                orderInfoHeadQuery += "CREATEUSER=@CREATEUSER AND ";
            }
            if (cboOdrGubun.SelectedItem != "전체")
            {
                orderInfoHeadQuery += "ORDER_GUBUN=@ORDER_GUBUN AND ";
            }
            orderInfoHeadQuery += "ORDER_DATE BETWEEN @TIME1 AND @TIME2;";

            cmd = new MySqlCommand(orderInfoHeadQuery, conn);

            cmd.Parameters.AddWithValue("@ORDER_NO", txtOrderNo.Text);
            cmd.Parameters.AddWithValue("@CUST_NO", txtCustNo.Text);
            cmd.Parameters.AddWithValue("@CREATEUSER", txtCreateUser.Text);
            cmd.Parameters.AddWithValue("@ORDER_GUBUN", cboOdrGubun.SelectedItem);
            cmd.Parameters.AddWithValue("@TIME1", t1);
            cmd.Parameters.AddWithValue("@TIME2", t2);

            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            gridOrderInfoHead.DataSource = dt;
            dt.Dispose();

            lblHeadCount.Text = dt.Rows.Count.ToString();
            
            conn.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Excel 
            Microsoft.Office.Interop.Excel.Application excelApp 
                = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);


            string rangeStr = "A2:A" + (dt.Rows.Count + 1).ToString();
            Microsoft.Office.Interop.Excel.Range range = excelApp.get_Range(rangeStr, Type.Missing);
            range.NumberFormat = "0";
            // 소수점 0.0
            // 문자열 @
            // 날짜 yy-MM-dd


            // Header Text
            for (int i = 1; i < gridOrderInfoHead.Columns.Count + 1; i++)
            {
                excelApp.Cells[1, i] = gridOrderInfoHead.Columns[i - 1].HeaderText;
            }
            // Data Setting
            for (int i = 0; i < gridOrderInfoHead.Rows.Count; i++)
            {
                for (int j = 0; j < gridOrderInfoHead.Columns.Count; j++)
                {
                    excelApp.Cells[i + 2, j + 1] = gridOrderInfoHead.Rows[i].Cells[j].Value.ToString();
                }
            }

            excelApp.Columns.AutoFit();
            excelApp.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ((DataTable)gridOrderInfoHead.DataSource).Rows.Clear();
            ((DataTable)gridOrderInfoBody.DataSource).Rows.Clear();
            OrderForm_Load(sender, e);
        }
    }
}
