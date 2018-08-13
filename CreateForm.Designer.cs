namespace ShapeApp1
{
    partial class CreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.accountBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.pw1Box = new System.Windows.Forms.TextBox();
            this.pw2Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.createButton.Font = new System.Drawing.Font("Verdana", 9F);
            this.createButton.Location = new System.Drawing.Point(146, 236);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F);
            this.label1.Location = new System.Drawing.Point(67, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F);
            this.label2.Location = new System.Drawing.Point(67, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F);
            this.label3.Location = new System.Drawing.Point(66, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Account Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F);
            this.label4.Location = new System.Drawing.Point(67, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirm Password";
            // 
            // accountBox
            // 
            this.accountBox.Font = new System.Drawing.Font("Verdana", 9F);
            this.accountBox.ForeColor = System.Drawing.Color.DarkGray;
            this.accountBox.Location = new System.Drawing.Point(200, 76);
            this.accountBox.Name = "accountBox";
            this.accountBox.Size = new System.Drawing.Size(202, 22);
            this.accountBox.TabIndex = 5;
            this.accountBox.Text = "Account Name";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Verdana", 9F);
            this.emailBox.ForeColor = System.Drawing.Color.DarkGray;
            this.emailBox.Location = new System.Drawing.Point(200, 117);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(202, 22);
            this.emailBox.TabIndex = 6;
            this.emailBox.Text = "Email";
            // 
            // pw1Box
            // 
            this.pw1Box.Font = new System.Drawing.Font("Verdana", 9F);
            this.pw1Box.ForeColor = System.Drawing.Color.DarkGray;
            this.pw1Box.Location = new System.Drawing.Point(200, 151);
            this.pw1Box.Name = "pw1Box";
            this.pw1Box.Size = new System.Drawing.Size(202, 22);
            this.pw1Box.TabIndex = 7;
            this.pw1Box.Text = "Password";
            // 
            // pw2Box
            // 
            this.pw2Box.Font = new System.Drawing.Font("Verdana", 9F);
            this.pw2Box.ForeColor = System.Drawing.Color.DarkGray;
            this.pw2Box.Location = new System.Drawing.Point(200, 180);
            this.pw2Box.Name = "pw2Box";
            this.pw2Box.Size = new System.Drawing.Size(202, 22);
            this.pw2Box.TabIndex = 8;
            this.pw2Box.Text = "password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 25F);
            this.label5.Location = new System.Drawing.Point(62, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 41);
            this.label5.TabIndex = 9;
            this.label5.Text = "Create Account";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cancelButton.Font = new System.Drawing.Font("Verdana", 9F);
            this.cancelButton.Location = new System.Drawing.Point(227, 236);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 271);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pw2Box);
            this.Controls.Add(this.pw1Box);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.accountBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CreateForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CreateForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accountBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox pw1Box;
        private System.Windows.Forms.TextBox pw2Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelButton;
    }
}