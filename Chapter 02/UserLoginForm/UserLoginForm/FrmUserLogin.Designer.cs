namespace UserLoginForm
{
  partial class FrmUserLogin
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
      this.lblHeader = new System.Windows.Forms.Label();
      this.lblUserID = new System.Windows.Forms.Label();
      this.lblPassword = new System.Windows.Forms.Label();
      this.txtUserID = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.btnForgot = new System.Windows.Forms.Button();
      this.btnNewUser = new System.Windows.Forms.Button();
      this.btnLogin = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblHeader
      // 
      this.lblHeader.AutoSize = true;
      this.lblHeader.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHeader.Location = new System.Drawing.Point(42, 21);
      this.lblHeader.Name = "lblHeader";
      this.lblHeader.Size = new System.Drawing.Size(172, 22);
      this.lblHeader.TabIndex = 0;
      this.lblHeader.Text = "User Login Form";
      // 
      // lblUserID
      // 
      this.lblUserID.AutoSize = true;
      this.lblUserID.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUserID.Location = new System.Drawing.Point(16, 75);
      this.lblUserID.Name = "lblUserID";
      this.lblUserID.Size = new System.Drawing.Size(81, 21);
      this.lblUserID.TabIndex = 1;
      this.lblUserID.Text = "User ID";
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPassword.Location = new System.Drawing.Point(16, 124);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(99, 21);
      this.lblPassword.TabIndex = 2;
      this.lblPassword.Text = "Password";
      // 
      // txtUserID
      // 
      this.txtUserID.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUserID.Location = new System.Drawing.Point(169, 75);
      this.txtUserID.Name = "txtUserID";
      this.txtUserID.Size = new System.Drawing.Size(149, 30);
      this.txtUserID.TabIndex = 3;
      // 
      // txtPassword
      // 
      this.txtPassword.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPassword.Location = new System.Drawing.Point(169, 115);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(149, 30);
      this.txtPassword.TabIndex = 4;
      // 
      // btnForgot
      // 
      this.btnForgot.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnForgot.Location = new System.Drawing.Point(183, 164);
      this.btnForgot.Name = "btnForgot";
      this.btnForgot.Size = new System.Drawing.Size(135, 25);
      this.btnForgot.TabIndex = 5;
      this.btnForgot.Text = "Forgot Password ?";
      this.btnForgot.UseVisualStyleBackColor = true;
      // 
      // btnNewUser
      // 
      this.btnNewUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnNewUser.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNewUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.btnNewUser.Location = new System.Drawing.Point(12, 205);
      this.btnNewUser.Name = "btnNewUser";
      this.btnNewUser.Size = new System.Drawing.Size(123, 44);
      this.btnNewUser.TabIndex = 6;
      this.btnNewUser.Text = "New User";
      this.btnNewUser.UseVisualStyleBackColor = false;
      // 
      // btnLogin
      // 
      this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnLogin.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.btnLogin.Location = new System.Drawing.Point(207, 205);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(123, 44);
      this.btnLogin.TabIndex = 7;
      this.btnLogin.Text = "Login";
      this.btnLogin.UseVisualStyleBackColor = false;
      // 
      // FrmUserLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlLight;
      this.ClientSize = new System.Drawing.Size(342, 261);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.btnNewUser);
      this.Controls.Add(this.btnForgot);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtUserID);
      this.Controls.Add(this.lblPassword);
      this.Controls.Add(this.lblUserID);
      this.Controls.Add(this.lblHeader);
      this.Name = "FrmUserLogin";
      this.Text = "User Login Form";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.Label lblUserID;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtUserID;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnForgot;
    private System.Windows.Forms.Button btnNewUser;
    private System.Windows.Forms.Button btnLogin;
  }
}

