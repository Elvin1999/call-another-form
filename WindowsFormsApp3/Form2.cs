using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp3
{
    public partial class Login : Form
    {
        Form1 form1;
        public Login(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            okeybutton.BackColor = Color.Red;
        }
        private void okeybutton_Click(object sender, EventArgs e)
        {
            form1.BackColor = Color.Yellow;
            Close();
        }
    }
}
