namespace CapsLock_NumLock_Notifier
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
            this.CapsLockNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NumLockNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripCapsLock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStripNumLock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemToggleNumLock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemToggleCapsLock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuit1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripCapsLock.SuspendLayout();
            this.contextMenuStripNumLock.SuspendLayout();
            this.SuspendLayout();
            // 
            // CapsLockNotifyIcon
            // 
            this.CapsLockNotifyIcon.ContextMenuStrip = this.contextMenuStripCapsLock;
            this.CapsLockNotifyIcon.Text = "CapsLock Status";
            this.CapsLockNotifyIcon.Visible = true;
            this.CapsLockNotifyIcon.DoubleClick += new System.EventHandler(this.CapsLockNotifyIcon_DoubleClick);
            // 
            // NumLockNotifyIcon
            // 
            this.NumLockNotifyIcon.ContextMenuStrip = this.contextMenuStripNumLock;
            this.NumLockNotifyIcon.Text = "NumLockStatus";
            this.NumLockNotifyIcon.Visible = true;
            this.NumLockNotifyIcon.DoubleClick += new System.EventHandler(this.NumLockNotifyIcon_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStripCapsLock
            // 
            this.contextMenuStripCapsLock.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripCapsLock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemToggleCapsLock,
            this.toolStripMenuItemQuit1});
            this.contextMenuStripCapsLock.Name = "contextMenuStripCapsLock";
            this.contextMenuStripCapsLock.Size = new System.Drawing.Size(226, 68);
            // 
            // contextMenuStripNumLock
            // 
            this.contextMenuStripNumLock.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripNumLock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemToggleNumLock,
            this.toolStripMenuItemQuit});
            this.contextMenuStripNumLock.Name = "contextMenuStripNumLock";
            this.contextMenuStripNumLock.Size = new System.Drawing.Size(227, 68);
            // 
            // toolStripMenuItemToggleNumLock
            // 
            this.toolStripMenuItemToggleNumLock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemToggleNumLock.Name = "toolStripMenuItemToggleNumLock";
            this.toolStripMenuItemToggleNumLock.Size = new System.Drawing.Size(226, 32);
            this.toolStripMenuItemToggleNumLock.Text = "&Toggle NumLock";
            this.toolStripMenuItemToggleNumLock.Click += new System.EventHandler(this.toolStripMenuItemToggleNumLock_Click);
            // 
            // toolStripMenuItemQuit
            // 
            this.toolStripMenuItemQuit.Name = "toolStripMenuItemQuit";
            this.toolStripMenuItemQuit.Size = new System.Drawing.Size(240, 32);
            this.toolStripMenuItemQuit.Text = "&Quit";
            this.toolStripMenuItemQuit.Click += new System.EventHandler(this.toolStripMenuItemQuit_Click);
            // 
            // toolStripMenuItemToggleCapsLock
            // 
            this.toolStripMenuItemToggleCapsLock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemToggleCapsLock.Name = "toolStripMenuItemToggleCapsLock";
            this.toolStripMenuItemToggleCapsLock.Size = new System.Drawing.Size(240, 32);
            this.toolStripMenuItemToggleCapsLock.Text = "&Toggle CapsLock";
            this.toolStripMenuItemToggleCapsLock.Click += new System.EventHandler(this.toolStripMenuItemToggleCapsLock_Click);
            // 
            // toolStripMenuItemQuit1
            // 
            this.toolStripMenuItemQuit1.Name = "toolStripMenuItemQuit1";
            this.toolStripMenuItemQuit1.Size = new System.Drawing.Size(240, 32);
            this.toolStripMenuItemQuit1.Text = "&Quit";
            this.toolStripMenuItemQuit1.Click += new System.EventHandler(this.toolStripMenuItemQuit1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.contextMenuStripCapsLock.ResumeLayout(false);
            this.contextMenuStripNumLock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon CapsLockNotifyIcon;
        private System.Windows.Forms.NotifyIcon NumLockNotifyIcon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCapsLock;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemToggleCapsLock;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuit1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNumLock;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemToggleNumLock;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuit;
    }
}

