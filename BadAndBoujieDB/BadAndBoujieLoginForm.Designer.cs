namespace BadAndBoujieMain
{
    partial class BadAndBoujieLoginForm
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
            System.Windows.Forms.PictureBox pictureBoxLoginFormBackgroundImage;
            this.textBoxLoginFormUserName = new System.Windows.Forms.TextBox();
            this.textBoxLoginFormPassword = new System.Windows.Forms.TextBox();
            this.labelLoginFormUserName = new System.Windows.Forms.Label();
            this.labelLoginFormPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            pictureBoxLoginFormBackgroundImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBoxLoginFormBackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLoginFormBackgroundImage
            // 
            pictureBoxLoginFormBackgroundImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            pictureBoxLoginFormBackgroundImage.Image = global::BadAndBoujieMain.Properties.Resources.il_570xN_1117333616_i2ep;
            pictureBoxLoginFormBackgroundImage.Location = new System.Drawing.Point(12, 27);
            pictureBoxLoginFormBackgroundImage.Name = "pictureBoxLoginFormBackgroundImage";
            pictureBoxLoginFormBackgroundImage.Size = new System.Drawing.Size(333, 282);
            pictureBoxLoginFormBackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxLoginFormBackgroundImage.TabIndex = 6;
            pictureBoxLoginFormBackgroundImage.TabStop = false;
            // 
            // textBoxLoginFormUserName
            // 
            this.textBoxLoginFormUserName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLoginFormUserName.Location = new System.Drawing.Point(155, 263);
            this.textBoxLoginFormUserName.Name = "textBoxLoginFormUserName";
            this.textBoxLoginFormUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoginFormUserName.TabIndex = 1;
            // 
            // textBoxLoginFormPassword
            // 
            this.textBoxLoginFormPassword.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLoginFormPassword.Location = new System.Drawing.Point(155, 289);
            this.textBoxLoginFormPassword.Name = "textBoxLoginFormPassword";
            this.textBoxLoginFormPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoginFormPassword.TabIndex = 2;
            // 
            // labelLoginFormUserName
            // 
            this.labelLoginFormUserName.AutoSize = true;
            this.labelLoginFormUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginFormUserName.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginFormUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLoginFormUserName.Location = new System.Drawing.Point(71, 263);
            this.labelLoginFormUserName.Name = "labelLoginFormUserName";
            this.labelLoginFormUserName.Size = new System.Drawing.Size(78, 19);
            this.labelLoginFormUserName.TabIndex = 3;
            this.labelLoginFormUserName.Text = "User Name: ";
            // 
            // labelLoginFormPassword
            // 
            this.labelLoginFormPassword.AutoSize = true;
            this.labelLoginFormPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginFormPassword.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginFormPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLoginFormPassword.Location = new System.Drawing.Point(80, 289);
            this.labelLoginFormPassword.Name = "labelLoginFormPassword";
            this.labelLoginFormPassword.Size = new System.Drawing.Size(69, 19);
            this.labelLoginFormPassword.TabIndex = 4;
            this.labelLoginFormPassword.Text = "Password: ";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogin.Location = new System.Drawing.Point(261, 285);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // badAndBoujieLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(357, 320);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelLoginFormPassword);
            this.Controls.Add(this.labelLoginFormUserName);
            this.Controls.Add(this.textBoxLoginFormPassword);
            this.Controls.Add(this.textBoxLoginFormUserName);
            this.Controls.Add(pictureBoxLoginFormBackgroundImage);
            this.Name = "badAndBoujieLoginForm";
            this.Text = "badAndBoujieLoginForm";
            this.Controls.SetChildIndex(pictureBoxLoginFormBackgroundImage, 0);
            this.Controls.SetChildIndex(this.textBoxLoginFormUserName, 0);
            this.Controls.SetChildIndex(this.textBoxLoginFormPassword, 0);
            this.Controls.SetChildIndex(this.labelLoginFormUserName, 0);
            this.Controls.SetChildIndex(this.labelLoginFormPassword, 0);
            this.Controls.SetChildIndex(this.buttonLogin, 0);
            ((System.ComponentModel.ISupportInitialize)(pictureBoxLoginFormBackgroundImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLoginFormUserName;
        private System.Windows.Forms.TextBox textBoxLoginFormPassword;
        private System.Windows.Forms.Label labelLoginFormUserName;
        private System.Windows.Forms.Label labelLoginFormPassword;
        private System.Windows.Forms.Button buttonLogin;
    }
}