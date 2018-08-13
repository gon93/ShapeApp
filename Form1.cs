using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShapeLib;

namespace ShapeApp1
{
    public partial class ShapeApp : Form
    {
        private readonly DataTable _table = new DataTable();
        private readonly List<IShape> _shapeList;
        private readonly UnRedoManager _manager;

        public ShapeApp()
        {
            _shapeList = new List<IShape>();
            _manager = new UnRedoManager();
            InitializeComponent();
            CenterToScreen();
        }

        //Load
        private void Form1_Load(object sender, EventArgs e)
        {
            _table.Columns.Add("Key", typeof(string));
            _table.Columns.Add("Value", typeof(string));

            dataGridView1.DataSource = _table;
            undoButton.Enabled = false;
            redoButton.Enabled = false;
        }

        //Event : Update DataGridView
        private void updateButton_Click(object sender, EventArgs e)
        {
            _table.Rows.Add(_table.Rows.Count, "1");
            _table.Rows.Add(_table.Rows.Count, "2");
            _table.Rows.Add(_table.Rows.Count, "3");
            _table.Rows.Add(_table.Rows.Count, "4");
            _table.Rows.Add(_table.Rows.Count, "5");
        }

        //Event : Reset DataGridView
        private void resetButton_ClickEvent(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            _table.Rows.Clear();
            if (MessageBox.Show(@"Are you sure you want to exit?",
                    @"Shape App",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) != DialogResult.Yes) return;
            this.Close();
        }

        //Event : Mouse Click on DrwaingPanel
        private void drawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            foreach (IShape shape in _shapeList)
            {
                if (!shape.HitTest(e.Location)) continue;

                MessageBox.Show(shape.ToString());
                return;
            }

            IShape polygon = null;
            if (rectangleBox.Checked)
            {
                polygon = new RectangleShape(e.Location);
                
            }
            else if (triangleBox.Checked)
            {
                polygon = new TriangleShape(e.Location);
            }

            //HitTest

            //Add to DataGridView
            var coordinate = string.Format("{0} , {1}", e.X, e.Y);
            _table.Rows.Add(_table.Rows.Count + 1, coordinate);
            _shapeList.Add(polygon);

            //Insert/Enable Undo Button
            _manager.InsertUndoStack(polygon);
            undoButton.Enabled = true;

            drawingPanel.Refresh();
        }

        //Event: Input graphics in DrawingPanel
        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                foreach (IShape shape in _shapeList)
                {
                    if (shape.IsVisible)
                        shape.Draw(g);
                }
            }
        }   

        private void undoButton_MouseClick(object sender, MouseEventArgs e)
        {
            _manager.Undo();

            redoButton.Enabled = true;

            //check if undoStack is empty
            if (!_manager.IsUndoPossible())
            {
                undoButton.Enabled = false;
            }

            drawingPanel.Refresh();
        }

        private void redoButton_MouseClick(object sender, MouseEventArgs e)
        {
            _manager.Redo();

            undoButton.Enabled = true;

            if (!_manager.IsRedoPossible())
            {
                redoButton.Enabled = false;
            }

            drawingPanel.Refresh();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void ShapeApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
