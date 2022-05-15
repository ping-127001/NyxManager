using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NyxManager.Handler;

namespace NyxManager.GUI
{
    public partial class MessageCatcher : Form
    {

        public MessageCatcher()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MessageCatcher_Load(object sender, EventArgs e)
        {
            msgLbl.Text = Data.msg;
        }

        private void msgLbl_SizeChanged(object sender, EventArgs e)             //since the label changes, this keeps it centered
        {
            msgLbl.Left = (this.ClientSize.Width - msgLbl.Size.Width) / 2;
        }
    }
}
