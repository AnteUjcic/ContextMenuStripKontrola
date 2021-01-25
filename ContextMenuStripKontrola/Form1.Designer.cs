namespace ContextMenuStripKontrola
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.desnoNaLjevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ljevoNaDesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desnoNaLjevoToolStripMenuItem,
            this.ljevoNaDesnoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(238, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox2.Location = new System.Drawing.Point(396, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // desnoNaLjevoToolStripMenuItem
            // 
            this.desnoNaLjevoToolStripMenuItem.Name = "desnoNaLjevoToolStripMenuItem";
            this.desnoNaLjevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desnoNaLjevoToolStripMenuItem.Text = "Desno na ljevo";
            this.desnoNaLjevoToolStripMenuItem.Click += new System.EventHandler(this.desnoNaLjevoToolStripMenuItem_Click);
            // 
            // ljevoNaDesnoToolStripMenuItem
            // 
            this.ljevoNaDesnoToolStripMenuItem.Name = "ljevoNaDesnoToolStripMenuItem";
            this.ljevoNaDesnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ljevoNaDesnoToolStripMenuItem.Text = "Ljevo na desno";
            this.ljevoNaDesnoToolStripMenuItem.Click += new System.EventHandler(this.ljevoNaDesnoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem desnoNaLjevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ljevoNaDesnoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

