
namespace OOOCoocker
{
    partial class Pattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pattern));
            this.tableLayoutPanelUp = new System.Windows.Forms.TableLayoutPanel();
            this.pictireBoxLogotip = new System.Windows.Forms.PictureBox();
            this.lableTitle = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelDown = new System.Windows.Forms.Panel();
            this.tableLayoutPanelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictireBoxLogotip)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelUp
            // 
            this.tableLayoutPanelUp.ColumnCount = 3;
            this.tableLayoutPanelUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanelUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.03614F));
            this.tableLayoutPanelUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.96386F));
            this.tableLayoutPanelUp.Controls.Add(this.pictireBoxLogotip, 0, 0);
            this.tableLayoutPanelUp.Controls.Add(this.lableTitle, 1, 0);
            this.tableLayoutPanelUp.Controls.Add(this.buttonExit, 2, 0);
            this.tableLayoutPanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelUp.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelUp.Name = "tableLayoutPanelUp";
            this.tableLayoutPanelUp.RowCount = 2;
            this.tableLayoutPanelUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanelUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUp.Size = new System.Drawing.Size(1079, 87);
            this.tableLayoutPanelUp.TabIndex = 0;
            // 
            // pictireBoxLogotip
            // 
            this.pictireBoxLogotip.BackgroundImage = global::OOOCoocker.Properties.Resources.ООО_Поварёнок;
            this.pictireBoxLogotip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictireBoxLogotip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictireBoxLogotip.Location = new System.Drawing.Point(4, 5);
            this.pictireBoxLogotip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictireBoxLogotip.Name = "pictireBoxLogotip";
            this.pictireBoxLogotip.Size = new System.Drawing.Size(75, 75);
            this.pictireBoxLogotip.TabIndex = 0;
            this.pictireBoxLogotip.TabStop = false;
            // 
            // lableTitle
            // 
            this.lableTitle.AutoSize = true;
            this.lableTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lableTitle.Location = new System.Drawing.Point(87, 0);
            this.lableTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableTitle.Name = "lableTitle";
            this.lableTitle.Size = new System.Drawing.Size(579, 85);
            this.lableTitle.TabIndex = 1;
            this.lableTitle.Text = "Заголовок";
            this.lableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Location = new System.Drawing.Point(690, 20);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(20);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(369, 45);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelDown
            // 
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 491);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(1079, 83);
            this.panelDown.TabIndex = 1;
            // 
            // Pattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 574);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.tableLayoutPanelUp);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Pattern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заголовок";
            this.Load += new System.EventHandler(this.Pattern_Load);
            this.tableLayoutPanelUp.ResumeLayout(false);
            this.tableLayoutPanelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictireBoxLogotip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUp;
        private System.Windows.Forms.PictureBox pictireBoxLogotip;
        private System.Windows.Forms.Label lableTitle;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelDown;
    }
}

