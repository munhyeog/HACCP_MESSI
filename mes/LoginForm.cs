using LoginForm;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace mes
{
    // EventHandler는 밖에다가...
    public delegate void EventHandler(string userName);

    public partial class LoginForm : Form
    {
        MySqlConnection conn;
        //MySqlDataAdapter adapter;
        DataTable dt;

        RegisterForm rgForm;

        public event EventHandler loginHandler;

        public LoginForm()
        {
            InitializeComponent();

            
            conn = new MySqlConnection(DatabaseInfo.DBConnectStr());
            dt = new DataTable();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            string loginQuery = "SELECT user_id, user_pw FROM info_user WHERE user_id=@username AND user_pw=@password";
            MySqlCommand cmd = new MySqlCommand(loginQuery, conn);

            if (inputCheck())
            {   
                //cmd.CommandText = loginQuery;
                //cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@username", txtID.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                dt.Load(cmd.ExecuteReader());

                //// ' or 1=1 or ' 일 때 sql injection
                //string loginQuery = "SELECT username, password FROM users WHERE username='" + txtID.Text + "' AND password='" + txtPassword.Text + "'";
                //adapter = new MySqlDataAdapter(loginQuery, conn);
                //adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("로그인 성공.");
                    loginHandler(txtID.Text);
                    DialogResult = DialogResult.OK;


                    MainInstance.Instance.Username = (string)dt.Rows[0].ItemArray[0];
                    MainInstance.Instance.Password = (string)dt.Rows[0].ItemArray[1];

                    //byte[] image = (byte[])dt.Rows[0].ItemArray[2];
                    //MemoryStream memoryStream = new MemoryStream(image);
                    //MainInstance.Instance.IdPhoto = Image.FromStream(memoryStream);
                }
                else
                {
                    MessageBox.Show("로그인 정보가 명확하지 않습니다.");
                }
            }
            conn.Close();
        }

        public bool inputCheck()
        {
            if (String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("아이디를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();

                return false;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("비밀번호를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();

                return false;
            }


            return true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Dispose();
            DialogResult = DialogResult.Cancel;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            rgForm = new RegisterForm();
            rgForm.ShowDialog();
        }
    }
}
