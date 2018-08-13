using System.Drawing;
using System.Windows.Forms;
using LoginLib;

namespace ShapeApp1
{
    public partial class LoginLost : Form
    {
        public LoginLost()
        {
            InitializeComponent();
        }

        private void LoginLost_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 3), new Point(0, 45), new Point(443, 45));
        }

        private void label3_Click(object sender, System.EventArgs e)
        {
            var mailSender = new Mail();
            mailSender.SendMail(addressBox.Text);
        }
    }
}
