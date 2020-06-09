namespace ClientManagementApp
{
    partial class mainMenuLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenuLayout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainNewButton = new System.Windows.Forms.Button();
            this.mainExistingButton = new System.Windows.Forms.Button();
            this.mainExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 21);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            // 
            // mainNewButton
            // 
            this.mainNewButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainNewButton.Location = new System.Drawing.Point(153, 139);
            this.mainNewButton.Name = "mainNewButton";
            this.mainNewButton.Size = new System.Drawing.Size(191, 56);
            this.mainNewButton.TabIndex = 2;
            this.mainNewButton.Text = "New Client";
            this.mainNewButton.UseVisualStyleBackColor = false;
            this.mainNewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainExistingButton
            // 
            this.mainExistingButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainExistingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainExistingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainExistingButton.Location = new System.Drawing.Point(153, 210);
            this.mainExistingButton.Name = "mainExistingButton";
            this.mainExistingButton.Size = new System.Drawing.Size(191, 56);
            this.mainExistingButton.TabIndex = 3;
            this.mainExistingButton.Text = "Existing Clients";
            this.mainExistingButton.UseVisualStyleBackColor = false;
            this.mainExistingButton.Click += new System.EventHandler(this.mainExistingButton_Click);
            // 
            // mainExitButton
            // 
            this.mainExitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainExitButton.Location = new System.Drawing.Point(153, 282);
            this.mainExitButton.Name = "mainExitButton";
            this.mainExitButton.Size = new System.Drawing.Size(191, 56);
            this.mainExitButton.TabIndex = 4;
            this.mainExitButton.Text = "Exit";
            this.mainExitButton.UseVisualStyleBackColor = false;
            this.mainExitButton.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // mainMenuLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(497, 433);
            this.Controls.Add(this.mainExitButton);
            this.Controls.Add(this.mainExistingButton);
            this.Controls.Add(this.mainNewButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainMenuLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.mainMenuLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainNewButton;
        private System.Windows.Forms.Button mainExistingButton;
        private System.Windows.Forms.Button mainExitButton;
    }
}