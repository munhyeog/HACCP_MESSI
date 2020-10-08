using mes.base_info;
using System;
using System.Windows.Forms;

namespace mes
{
    public partial class MainForm : Form
    {
        LoginForm loginForm;                // 로그인 폼
        InfoCompanyForm infoCompanyForm;    // 거래처정보 폼

        public MainForm()
        {
            InitializeComponent();
        }
        private void LoginSuccess(string userName)
        {
            MessageBox.Show(userName + "님 환영합니다.");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loginForm = new LoginForm();
            loginForm.loginHandler += new EventHandler(LoginSuccess);
            //loginForm.MdiParent = this;
            //loginForm.ShowDialog();

            switch (loginForm.ShowDialog())
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    Dispose();
                    break;
                default:
                    break;
            }
        }

        private Form ShowActivityForm(Form form, Type type)
        {
            if (form == null)
            {
                form = (Form)Activator.CreateInstance(type);
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(type);
                    form.MdiParent = this;
                    form.WindowState = FormWindowState.Maximized;
                    form.Show();
                }
                else
                {
                    form.Activate();
                }
            }

            return form;
        }
        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void 거래처관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != infoCompanyForm)
                {
                    ActiveMdiChild.Close();
                }
                infoCompanyForm = ShowActivityForm(infoCompanyForm, typeof(InfoCompanyForm)) as InfoCompanyForm;
            }
            else
            {
                infoCompanyForm = ShowActivityForm(infoCompanyForm, typeof(InfoCompanyForm)) as InfoCompanyForm;
            }
        }
    }
}
