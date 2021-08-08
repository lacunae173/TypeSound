namespace TypeSound
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
            System.Windows.Forms.ContextMenuStrip notifymenu;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.type_sound = new System.Windows.Forms.NotifyIcon(this.components);
            notifymenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            notifymenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifymenu
            // 
            notifymenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            notifymenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            notifymenu.Name = "contextMenuStrip1";
            notifymenu.Size = new System.Drawing.Size(105, 28);
            notifymenu.Text = "Menu";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(104, 24);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // type_sound
            // 
            this.type_sound.ContextMenuStrip = notifymenu;
            this.type_sound.Icon = ((System.Drawing.Icon)(resources.GetObject("type_sound.Icon")));
            this.type_sound.Text = "Type sound";
            this.type_sound.Visible = true;
            this.type_sound.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            notifymenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon type_sound;
        private System.Windows.Forms.ToolStripMenuItem Exit;
    }
}