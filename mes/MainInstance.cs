using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mes
{
    public sealed class MainInstance
    {
        public MainInstance() { }

        private static MainInstance _instance = null;
        private static readonly object padlock = new object();

        public static MainInstance Instance
        {
            get
            {
                lock(padlock)
                {
                    if (_instance is null)
                    {
                        _instance = new MainInstance();
                    }
                    return _instance;
                }
                
            }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private Image idPhoto;

        public Image IdPhoto
        {
            get { return idPhoto; }
            set { idPhoto = value; }
        }
    }
}
