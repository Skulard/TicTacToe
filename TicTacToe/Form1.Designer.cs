namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpbxTicTacToe = new GroupBox();
            btn33 = new Button();
            btn23 = new Button();
            btn13 = new Button();
            btn32 = new Button();
            btn22 = new Button();
            btn12 = new Button();
            btn31 = new Button();
            btn21 = new Button();
            btn11 = new Button();
            groupBox1 = new GroupBox();
            btnRestart = new Button();
            lblP2Points = new Label();
            lblP1Points = new Label();
            lblplayer2 = new Label();
            lblplayer1 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpbxTicTacToe.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpbxTicTacToe
            // 
            grpbxTicTacToe.Controls.Add(btn33);
            grpbxTicTacToe.Controls.Add(btn23);
            grpbxTicTacToe.Controls.Add(btn13);
            grpbxTicTacToe.Controls.Add(btn32);
            grpbxTicTacToe.Controls.Add(btn22);
            grpbxTicTacToe.Controls.Add(btn12);
            grpbxTicTacToe.Controls.Add(btn31);
            grpbxTicTacToe.Controls.Add(btn21);
            grpbxTicTacToe.Controls.Add(btn11);
            grpbxTicTacToe.Location = new Point(12, 12);
            grpbxTicTacToe.Name = "grpbxTicTacToe";
            grpbxTicTacToe.Size = new Size(257, 272);
            grpbxTicTacToe.TabIndex = 0;
            grpbxTicTacToe.TabStop = false;
            grpbxTicTacToe.Text = "Tic Tac Toe";
            // 
            // btn33
            // 
            btn33.Location = new Point(168, 184);
            btn33.Name = "btn33";
            btn33.Size = new Size(75, 75);
            btn33.TabIndex = 8;
            btn33.UseVisualStyleBackColor = true;
            btn33.Click += Clicked;
            // 
            // btn23
            // 
            btn23.Location = new Point(87, 184);
            btn23.Name = "btn23";
            btn23.Size = new Size(75, 75);
            btn23.TabIndex = 7;
            btn23.UseVisualStyleBackColor = true;
            btn23.Click += Clicked;
            // 
            // btn13
            // 
            btn13.Location = new Point(6, 184);
            btn13.Name = "btn13";
            btn13.Size = new Size(75, 75);
            btn13.TabIndex = 6;
            btn13.UseVisualStyleBackColor = true;
            btn13.Click += Clicked;
            // 
            // btn32
            // 
            btn32.Location = new Point(168, 103);
            btn32.Name = "btn32";
            btn32.Size = new Size(75, 75);
            btn32.TabIndex = 5;
            btn32.UseVisualStyleBackColor = true;
            btn32.Click += Clicked;
            // 
            // btn22
            // 
            btn22.Location = new Point(87, 103);
            btn22.Name = "btn22";
            btn22.Size = new Size(75, 75);
            btn22.TabIndex = 4;
            btn22.UseVisualStyleBackColor = true;
            btn22.Click += Clicked;
            // 
            // btn12
            // 
            btn12.Location = new Point(6, 103);
            btn12.Name = "btn12";
            btn12.Size = new Size(75, 75);
            btn12.TabIndex = 3;
            btn12.UseVisualStyleBackColor = true;
            btn12.Click += Clicked;
            // 
            // btn31
            // 
            btn31.Location = new Point(168, 22);
            btn31.Name = "btn31";
            btn31.Size = new Size(75, 75);
            btn31.TabIndex = 2;
            btn31.UseVisualStyleBackColor = true;
            btn31.Click += Clicked;
            // 
            // btn21
            // 
            btn21.Location = new Point(87, 22);
            btn21.Name = "btn21";
            btn21.Size = new Size(75, 75);
            btn21.TabIndex = 1;
            btn21.UseVisualStyleBackColor = true;
            btn21.Click += Clicked;
            // 
            // btn11
            // 
            btn11.Location = new Point(6, 22);
            btn11.Name = "btn11";
            btn11.Size = new Size(75, 75);
            btn11.TabIndex = 0;
            btn11.UseVisualStyleBackColor = true;
            btn11.Click += Clicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRestart);
            groupBox1.Controls.Add(lblP2Points);
            groupBox1.Controls.Add(lblP1Points);
            groupBox1.Controls.Add(lblplayer2);
            groupBox1.Controls.Add(lblplayer1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(275, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 272);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Spieler Informationen";
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(6, 85);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(245, 69);
            btnRestart.TabIndex = 6;
            btnRestart.Text = "Neustart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // lblP2Points
            // 
            lblP2Points.AutoSize = true;
            lblP2Points.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblP2Points.Location = new Point(138, 236);
            lblP2Points.Name = "lblP2Points";
            lblP2Points.Size = new Size(114, 32);
            lblP2Points.TabIndex = 5;
            lblP2Points.Text = "x Punkte";
            // 
            // lblP1Points
            // 
            lblP1Points.AutoSize = true;
            lblP1Points.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblP1Points.Location = new Point(138, 184);
            lblP1Points.Name = "lblP1Points";
            lblP1Points.Size = new Size(114, 32);
            lblP1Points.TabIndex = 4;
            lblP1Points.Text = "x Punkte";
            // 
            // lblplayer2
            // 
            lblplayer2.AutoSize = true;
            lblplayer2.BackColor = Color.Orange;
            lblplayer2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblplayer2.Location = new Point(6, 232);
            lblplayer2.Name = "lblplayer2";
            lblplayer2.Size = new Size(120, 37);
            lblplayer2.TabIndex = 3;
            lblplayer2.Text = "Spieler 2";
            // 
            // lblplayer1
            // 
            lblplayer1.AutoSize = true;
            lblplayer1.BackColor = Color.Orange;
            lblplayer1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblplayer1.Location = new Point(6, 180);
            lblplayer1.Name = "lblplayer1";
            lblplayer1.Size = new Size(120, 37);
            lblplayer1.TabIndex = 2;
            lblplayer1.Text = "Spieler 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 19);
            label2.Name = "label2";
            label2.Size = new Size(124, 47);
            label2.TabIndex = 1;
            label2.Text = "Spieler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 0);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(103, 47);
            label1.TabIndex = 0;
            label1.Text = "Zug: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 300);
            Controls.Add(groupBox1);
            Controls.Add(grpbxTicTacToe);
            Name = "Form1";
            Text = "Form1";
            grpbxTicTacToe.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbxTicTacToe;
        private Button btn33;
        private Button btn23;
        private Button btn13;
        private Button btn32;
        private Button btn22;
        private Button btn12;
        private Button btn31;
        private Button btn21;
        private Button btn11;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label lblP2Points;
        private Label lblP1Points;
        private Label lblplayer2;
        private Label lblplayer1;
        private Button btnRestart;
    }
}
