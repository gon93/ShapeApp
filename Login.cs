using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using LoginLib;

namespace ShapeApp1
{
    public partial class Login : Form
    {
        private OleDbConnection _conn;
        
        public Login()
        {
            InitializeComponent();
            textBox1.Visible = false;
        }

        private void Reset()
        {
            textBox1.Select();
            logTextBox.Text = @"username";
            pwTextBox.UseSystemPasswordChar = false;
            pwTextBox.Text = @"password";
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            textBox1.Select();
            _conn = LoginAuthentication.ConnectDb();
        }

        private void username_Click(object sender, EventArgs e)
        {
            logTextBox.Select();
            if (logTextBox.Text == @"username")
            {
                logTextBox.Text = "";
            }

        }

        private void password_Click(object sender, EventArgs e)
        {
            pwTextBox.Select();
            
            if (pwTextBox.Text == @"password")
            {
                pwTextBox.Text = "";
                pwTextBox.UseSystemPasswordChar = true;
            }
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            if (_conn == null) return;
            var cred = new Credentials(logTextBox.Text, pwTextBox.Text, null);
            var accessNum = LoginAuthentication.LoginAccount(_conn,cred);
            if (accessNum < 1)
            {
                Reset();
                return;
            }

            var frm = new ShapeApp();
            frm.Show();
            Hide();
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (logTextBox.Text == "")
            {
                logTextBox.Text = @"username";
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (pwTextBox.Text == "")
            {
                pwTextBox.UseSystemPasswordChar = false;
                pwTextBox.Text = @"password";
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            _conn.Close();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginLabel_Click(this,new EventArgs());
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Select();

            var bmp = (Bitmap)pictureBox1.BackgroundImage;
            bmp = ChangeColor(bmp, false);

            pictureBox1.Image = bmp;

            pwTextBox.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
            var bmp = (Bitmap) pictureBox1.BackgroundImage;
            bmp = ChangeColor(bmp,true);

            pictureBox1.Image = bmp;
            if (pwTextBox.Text == @"password") return;

            pwTextBox.UseSystemPasswordChar = true;
        }

        //Change the backgroundImage color light or dark
        private Bitmap ChangeColor(Bitmap bmp, bool isLight)
        {
            var tmp = bmp;
            for (var x = 0; x < tmp.Width; x++)
            {
                for (var y = 0; y < tmp.Height; y++)
                {
                    if (tmp.GetPixel(x, y) != Color.FromArgb(0, 0, 0, 0))
                    {
                        tmp.SetPixel(x, y,
                            isLight ? ControlPaint.Dark(tmp.GetPixel(x, y)) : ControlPaint.Light(tmp.GetPixel(x, y)));
                    }
                }
            }
            return tmp;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoginLost frm = new LoginLost();
            Screen scr = Screen.FromPoint(Location);
            frm.Location = new Point(scr.WorkingArea.Right - Width, scr.WorkingArea.Top);
            frm.Show();

        }

        private void createLabel_Click(object sender, EventArgs e)
        {
            CreateForm frm = new CreateForm(_conn);
            frm.Show();
        }
    }
}
