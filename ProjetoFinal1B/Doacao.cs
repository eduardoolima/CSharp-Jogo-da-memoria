using System.Windows.Forms;
using System.Diagnostics;

namespace ProjetoFinal1B
{
    public partial class frmDoacao : Form
    {
        public frmDoacao()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://picpay.me/eduardo.lima810");
        }
    }
}
