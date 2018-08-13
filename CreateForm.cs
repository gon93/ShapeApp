using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using LoginLib;

namespace ShapeApp1
{
    public partial class CreateForm : Form
    {
        private readonly OleDbConnection _conn;
        public CreateForm(OleDbConnection conn)
        {
            InitializeComponent();
            accountBox.Select();
            _conn = conn;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DeepSkyBlue, 3),
                DisplayRectangle); 
        }

        //Drag the form without border
        private bool _dragging;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        private void CreateForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = Location;
        }

        private void CreateForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                Location = Point.Add(_dragFormPoint, new Size(dif));
            }
        }

        private void CreateForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //insert into the db
            var cred = new Credentials(accountBox.Text, pw1Box.Text, emailBox.Text);
            var isSuccess = LoginAuthentication.IsInsertDb(_conn, cred);

            if (isSuccess)
            {
                this.Close();
                
            }
        }
    }
}
