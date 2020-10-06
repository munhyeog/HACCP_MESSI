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
    public partial class WorkOrderForm : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public WorkOrderForm()
        {
            InitializeComponent();

            conn = new MySqlConnection("datasource=localhost;port=3306;Database=mes;username=root;password=1234");
            dt = new DataTable();
        }

        private void WorkOrderForm_Load(object sender, EventArgs e)
        {
            conn.Open();

            string workOrderHeadQuery = "SELECT * FROM WORK_ORDER_HEAD;";
            cmd = new MySqlCommand(workOrderHeadQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            gridWorkOrderHead.DataSource = dt;

            cboWkOdrGubun.SelectedIndex = 0;
            lblWkHeadCount.Text = dt.Rows.Count.ToString();


            dt.Dispose();
            conn.Close();
        }

        private void gridWorkOrderHead_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tempTable = new DataTable();
            try
            {
                conn.Open();

                int rowIndex = gridWorkOrderHead.CurrentRow.Index;
                string temp = gridWorkOrderHead.Rows[rowIndex].Cells[0].Value.ToString();

                string workOrderBodyQuery = "SELECT * FROM WORK_ORDER_BODY WHERE WORK_ORDER_NO=@WORK_ORDER_NO";
                cmd = new MySqlCommand(workOrderBodyQuery, conn);
                cmd.Parameters.AddWithValue("@WORK_ORDER_NO", temp);

                tempTable.Load(cmd.ExecuteReader());

                lblWkBodyCount.Text = tempTable.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            gridWorkOrderBody.DataSource = tempTable;

            conn.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Excel 
            Microsoft.Office.Interop.Excel.Application excelApp
                = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);

            // Header Text
            for (int i = 1; i < gridWorkOrderHead.Columns.Count + 1; i++)
            {
                excelApp.Cells[1, i] = gridWorkOrderHead.Columns[i - 1].HeaderText;
            }
            // Data Setting
            for (int i = 0; i < gridWorkOrderHead.Rows.Count; i++)
            {
                for (int j = 0; j < gridWorkOrderHead.Columns.Count; j++)
                {
                    excelApp.Cells[i + 2, j + 1] = gridWorkOrderHead.Rows[i].Cells[j].Value.ToString();
                }
            }

            excelApp.Columns.AutoFit();
            excelApp.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            WorkOrderForm_Load(sender, e);
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            ((DataTable)gridWorkOrderHead.DataSource).Rows.Clear();

            string t1 = dtWkOrderDate1.Value.ToString("yyyy-MM-dd");
            string t2 = dtWkOrderDate2.Value.ToString("yyyy-MM-dd");


            conn.Open();

            string orderInfoHeadQuery = "SELECT * FROM WORK_ORDER_HEAD WHERE ";

            if (txtWorkOrderNo.Text != "")
            {
                orderInfoHeadQuery += "WORK_ORDER_NO=@WORK_ORDER_NO AND ";
            }
            if (txtItemName.Text != "")
            {
                orderInfoHeadQuery += "ITEM_NAME=@ITEM_NAME AND ";
            }
            if (txtCreateUser.Text != "")
            {
                orderInfoHeadQuery += "CREATEUSER=@CREATEUSER AND ";
            }
            if (cboWkOdrGubun.SelectedItem != "전체")
            {
                orderInfoHeadQuery += "WORK_ORDER_GUBUN=@WORK_ORDER_GUBUN AND ";
            }
            orderInfoHeadQuery += "ORDER_DATE BETWEEN @TIME1 AND @TIME2;";

            cmd = new MySqlCommand(orderInfoHeadQuery, conn);

            cmd.Parameters.AddWithValue("@WORK_ORDER_NO", txtWorkOrderNo.Text);
            cmd.Parameters.AddWithValue("@ITEM_NAME", txtItemName.Text);
            cmd.Parameters.AddWithValue("@CREATEUSER", txtCreateUser.Text);
            cmd.Parameters.AddWithValue("@WORK_ORDER_GUBUN", cboWkOdrGubun.SelectedItem);
            cmd.Parameters.AddWithValue("@TIME1", t1);
            cmd.Parameters.AddWithValue("@TIME2", t2);

            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            gridWorkOrderBody.DataSource = dt;
            dt.Dispose();

            lblWkHeadCount.Text = dt.Rows.Count.ToString();

            conn.Close();
        }
    }
}
