namespace grafuri2._0
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dfs_btn = new System.Windows.Forms.Button();
            this.bfs_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_textbox = new System.Windows.Forms.TextBox();
            this.start_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1010, 523);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // dfs_btn
            // 
            this.dfs_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dfs_btn.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfs_btn.ForeColor = System.Drawing.Color.HotPink;
            this.dfs_btn.Location = new System.Drawing.Point(860, 13);
            this.dfs_btn.Name = "dfs_btn";
            this.dfs_btn.Size = new System.Drawing.Size(114, 65);
            this.dfs_btn.TabIndex = 1;
            this.dfs_btn.Text = "DFS";
            this.dfs_btn.UseVisualStyleBackColor = true;
            this.dfs_btn.Click += new System.EventHandler(this.dfs_btn_ClickAsync);
            // 
            // bfs_btn
            // 
            this.bfs_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bfs_btn.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfs_btn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.bfs_btn.Location = new System.Drawing.Point(708, 13);
            this.bfs_btn.Name = "bfs_btn";
            this.bfs_btn.Size = new System.Drawing.Size(114, 66);
            this.bfs_btn.TabIndex = 2;
            this.bfs_btn.Text = "BFS";
            this.bfs_btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.start_textbox);
            this.panel1.Controls.Add(this.start_lbl);
            this.panel1.Controls.Add(this.bfs_btn);
            this.panel1.Controls.Add(this.dfs_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 98);
            this.panel1.TabIndex = 3;
            // 
            // start_textbox
            // 
            this.start_textbox.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_textbox.Location = new System.Drawing.Point(177, 35);
            this.start_textbox.Name = "start_textbox";
            this.start_textbox.Size = new System.Drawing.Size(100, 42);
            this.start_textbox.TabIndex = 4;
            // 
            // start_lbl
            // 
            this.start_lbl.AutoSize = true;
            this.start_lbl.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_lbl.Location = new System.Drawing.Point(13, 38);
            this.start_lbl.Name = "start_lbl";
            this.start_lbl.Size = new System.Drawing.Size(158, 35);
            this.start_lbl.TabIndex = 3;
            this.start_lbl.Text = "Nod de start:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dfs_btn;
        private System.Windows.Forms.Button bfs_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox start_textbox;
        private System.Windows.Forms.Label start_lbl;
    }
}

