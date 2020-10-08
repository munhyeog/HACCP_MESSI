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

namespace mes.base_info
{
    public partial class InfoCompanyForm : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public InfoCompanyForm()
        {
            InitializeComponent();

            conn = new MySqlConnection(DatabaseInfo.DBConnectStr());
            dt = new DataTable();
        }

        private void InfoCompanyForm_Load(object sender, EventArgs e)
        {
            conn.Open();

            string infoCompany_SelectQuery = "SELECT * FROM info_company;";
            cmd = new MySqlCommand(infoCompany_SelectQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            gridInfoCompany.DataSource = dt;

            //cboWkOdrGubun.SelectedIndex = 0;
            //lblWkHeadCount.Text = dt.Rows.Count.ToString();


            dt.Dispose();
            conn.Close();
        }
    }
}
