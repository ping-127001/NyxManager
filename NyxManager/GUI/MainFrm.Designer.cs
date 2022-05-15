namespace NyxManager.GUI
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.exitBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.topPnl = new System.Windows.Forms.Panel();
            this.miniBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.dragCtrl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.topPnlElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.topPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderRadius = 4;
            this.exitBtn.BorderThickness = 2;
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoveredState.Parent = this.exitBtn;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.exitBtn.Location = new System.Drawing.Point(593, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.PressedColor = System.Drawing.Color.White;
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(45, 27);
            this.exitBtn.TabIndex = 26;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // topPnl
            // 
            this.topPnl.Controls.Add(this.label1);
            this.topPnl.Controls.Add(this.miniBtn);
            this.topPnl.Controls.Add(this.exitBtn);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(641, 33);
            this.topPnl.TabIndex = 27;
            // 
            // miniBtn
            // 
            this.miniBtn.BackColor = System.Drawing.Color.Transparent;
            this.miniBtn.BorderColor = System.Drawing.Color.Transparent;
            this.miniBtn.BorderRadius = 4;
            this.miniBtn.BorderThickness = 2;
            this.miniBtn.CheckedState.Parent = this.miniBtn;
            this.miniBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.miniBtn.CustomImages.Parent = this.miniBtn;
            this.miniBtn.FillColor = System.Drawing.Color.Transparent;
            this.miniBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.miniBtn.ForeColor = System.Drawing.Color.White;
            this.miniBtn.HoveredState.Parent = this.miniBtn;
            this.miniBtn.Image = ((System.Drawing.Image)(resources.GetObject("miniBtn.Image")));
            this.miniBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.miniBtn.Location = new System.Drawing.Point(542, 3);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.PressedColor = System.Drawing.Color.White;
            this.miniBtn.ShadowDecoration.Parent = this.miniBtn;
            this.miniBtn.Size = new System.Drawing.Size(45, 27);
            this.miniBtn.TabIndex = 28;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // dragCtrl
            // 
            this.dragCtrl.TargetControl = this.topPnl;
            // 
            // topPnlElipse
            // 
            this.topPnlElipse.TargetControl = this.topPnl;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nyx Manager";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(641, 454);
            this.Controls.Add(this.topPnl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nyx Manager";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Siticone.UI.WinForms.SiticoneButton exitBtn;
        private System.Windows.Forms.Panel topPnl;
        public Siticone.UI.WinForms.SiticoneButton miniBtn;
        private Siticone.UI.WinForms.SiticoneDragControl dragCtrl;
        private Siticone.UI.WinForms.SiticoneElipse topPnlElipse;
        private System.Windows.Forms.Label label1;
    }
}