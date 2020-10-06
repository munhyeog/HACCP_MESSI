using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class RegisterForm : Form
    {
        MySqlConnection conn;

        public RegisterForm()
        {
            InitializeComponent();
            conn = new MySqlConnection("datasource=localhost;port=3306;Database=mes;username=root;password=1234");
        }
        public bool inputCheck()
        {
            if (String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("아이디를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();

                return false;
            }
            if (String.IsNullOrEmpty(txtPW.Text))
            {
                MessageBox.Show("비밀번호를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPW.Focus();

                return false;
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (inputCheck())
            {
                MemoryStream ms = new MemoryStream();
                picImage.Image.Save(ms, picImage.Image.RawFormat);
                byte[] image = ms.ToArray();

                conn.Open();
                string loginQuery = "INSERT INTO users(username, password, image) VALUES(@username, @passsword, @image)";
                MySqlCommand cmd = new MySqlCommand(loginQuery, conn);

                cmd.Parameters.Add("@username", MySqlDbType.VarChar, 50);
                cmd.Parameters.Add("@passsword", MySqlDbType.VarChar, 50);
                cmd.Parameters.Add("@image", MySqlDbType.Blob);

                cmd.Parameters["@username"].Value = txtID.Text;
                cmd.Parameters["@passsword"].Value = txtPW.Text;
                cmd.Parameters["@image"].Value = image;

                if (cmd.ExecuteNonQuery() == 1) {
                    MessageBox.Show("회원가입이 완료되었습니다");
                }

                conn.Close();
            }
            Dispose();
        }

        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Filter = "이미지 선택(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif ";

            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("이미지가 선택되었습니다.");
                picImage.Image = Image.FromFile(ofDialog.FileName);
            }
        }
    }
}
