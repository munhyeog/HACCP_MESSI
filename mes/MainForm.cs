using System;
using System.Windows.Forms;

namespace mes
{
    public partial class MainForm : Form
    {
        LoginForm loginForm;
        OrderInfoForm orderInfoForm;
        WorkOrderForm workOrderForm;
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



        private void 주문내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != orderInfoForm)
                {
                    ActiveMdiChild.Close();
                }
                orderInfoForm = ShowActivityForm(orderInfoForm, typeof(OrderInfoForm)) as OrderInfoForm;
            }
            else
            {
                orderInfoForm = ShowActivityForm(orderInfoForm, typeof(OrderInfoForm)) as OrderInfoForm;
            }
        }

      
        private void 발주등록ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //github test
        }

        private void 작업지시등록ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != workOrderForm)
                {
                    ActiveMdiChild.Close();
                }
                workOrderForm = ShowActivityForm(workOrderForm, typeof(WorkOrderForm)) as WorkOrderForm;
            }
            else
            {
                workOrderForm = ShowActivityForm(workOrderForm, typeof(WorkOrderForm)) as WorkOrderForm;
            }
        }

    }
}
