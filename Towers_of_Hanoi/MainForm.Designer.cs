namespace Towers_of_Hanoi
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.lblPeg1 = new System.Windows.Forms.Label();
            this.lblPeg2 = new System.Windows.Forms.Label();
            this.lblPeg3 = new System.Windows.Forms.Label();
            this.lblDisk4 = new System.Windows.Forms.Label();
            this.lblDisk3 = new System.Windows.Forms.Label();
            this.lblDisk2 = new System.Windows.Forms.Label();
            this.lblDisk1 = new System.Windows.Forms.Label();
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblAnimation = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlBase.Location = new System.Drawing.Point(120, 240);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(584, 48);
            this.pnlBase.TabIndex = 0;
            // 
            // lblPeg1
            // 
            this.lblPeg1.AllowDrop = true;
            this.lblPeg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg1.Location = new System.Drawing.Point(220, 112);
            this.lblPeg1.Name = "lblPeg1";
            this.lblPeg1.Size = new System.Drawing.Size(24, 144);
            this.lblPeg1.TabIndex = 1;
            this.lblPeg1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPeg2_DragDrop);
            this.lblPeg1.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPeg2_DragEnter);
            // 
            // lblPeg2
            // 
            this.lblPeg2.AllowDrop = true;
            this.lblPeg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg2.Location = new System.Drawing.Point(400, 112);
            this.lblPeg2.Name = "lblPeg2";
            this.lblPeg2.Size = new System.Drawing.Size(24, 144);
            this.lblPeg2.TabIndex = 2;
            this.lblPeg2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPeg2_DragDrop);
            this.lblPeg2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPeg2_DragEnter);
            // 
            // lblPeg3
            // 
            this.lblPeg3.AllowDrop = true;
            this.lblPeg3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg3.Location = new System.Drawing.Point(580, 112);
            this.lblPeg3.Name = "lblPeg3";
            this.lblPeg3.Size = new System.Drawing.Size(24, 144);
            this.lblPeg3.TabIndex = 3;
            this.lblPeg3.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPeg2_DragDrop);
            this.lblPeg3.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPeg2_DragEnter);
            // 
            // lblDisk4
            // 
            this.lblDisk4.BackColor = System.Drawing.Color.Lime;
            this.lblDisk4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk4.Location = new System.Drawing.Point(160, 216);
            this.lblDisk4.Name = "lblDisk4";
            this.lblDisk4.Size = new System.Drawing.Size(140, 24);
            this.lblDisk4.TabIndex = 4;
            this.lblDisk4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDisk1_MouseDown);
            // 
            // lblDisk3
            // 
            this.lblDisk3.BackColor = System.Drawing.Color.Lime;
            this.lblDisk3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk3.Location = new System.Drawing.Point(175, 192);
            this.lblDisk3.Name = "lblDisk3";
            this.lblDisk3.Size = new System.Drawing.Size(110, 24);
            this.lblDisk3.TabIndex = 5;
            this.lblDisk3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDisk1_MouseDown);
            // 
            // lblDisk2
            // 
            this.lblDisk2.BackColor = System.Drawing.Color.Lime;
            this.lblDisk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk2.Location = new System.Drawing.Point(190, 168);
            this.lblDisk2.Name = "lblDisk2";
            this.lblDisk2.Size = new System.Drawing.Size(80, 24);
            this.lblDisk2.TabIndex = 6;
            this.lblDisk2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDisk1_MouseDown);
            // 
            // lblDisk1
            // 
            this.lblDisk1.BackColor = System.Drawing.Color.Lime;
            this.lblDisk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk1.Location = new System.Drawing.Point(205, 144);
            this.lblDisk1.Name = "lblDisk1";
            this.lblDisk1.Size = new System.Drawing.Size(50, 24);
            this.lblDisk1.TabIndex = 7;
            this.lblDisk1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDisk1_MouseDown);
            // 
            // txtMoves
            // 
            this.txtMoves.Location = new System.Drawing.Point(740, 27);
            this.txtMoves.Multiline = true;
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoves.Size = new System.Drawing.Size(162, 261);
            this.txtMoves.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(13, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(115, 20);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total Moves :";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(740, 294);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 29);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(834, 294);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(88, 29);
            this.btnPlay.TabIndex = 13;
            this.btnPlay.Text = "Replay";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblAnimation
            // 
            this.lblAnimation.AutoSize = true;
            this.lblAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAnimation.Location = new System.Drawing.Point(13, 47);
            this.lblAnimation.Name = "lblAnimation";
            this.lblAnimation.Size = new System.Drawing.Size(155, 20);
            this.lblAnimation.TabIndex = 15;
            this.lblAnimation.Text = "Animation Moves :";
            this.lblAnimation.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 336);
            this.Controls.Add(this.lblAnimation);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtMoves);
            this.Controls.Add(this.lblDisk1);
            this.Controls.Add(this.lblDisk2);
            this.Controls.Add(this.lblDisk3);
            this.Controls.Add(this.lblDisk4);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.lblPeg1);
            this.Controls.Add(this.lblPeg2);
            this.Controls.Add(this.lblPeg3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "The Towers of Hanoi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Label lblPeg1;
        private System.Windows.Forms.Label lblPeg2;
        private System.Windows.Forms.Label lblPeg3;
        private System.Windows.Forms.Label lblDisk4;
        private System.Windows.Forms.Label lblDisk3;
        private System.Windows.Forms.Label lblDisk2;
        private System.Windows.Forms.Label lblDisk1;
        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblAnimation;

    }
}

