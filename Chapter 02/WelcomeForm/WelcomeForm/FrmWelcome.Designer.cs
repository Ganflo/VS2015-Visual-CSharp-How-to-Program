namespace WelcomeForm
{
  partial class FrmWelcome
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome));
      this.lblWelcome = new System.Windows.Forms.Label();
      this.picWelcome = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).BeginInit();
      this.SuspendLayout();
      // 
      // lblWelcome
      // 
      this.lblWelcome.AutoSize = true;
      this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWelcome.Location = new System.Drawing.Point(36, 28);
      this.lblWelcome.Name = "lblWelcome";
      this.lblWelcome.Size = new System.Drawing.Size(208, 16);
      this.lblWelcome.TabIndex = 0;
      this.lblWelcome.Text = "Welcome to C# Programming";
      // 
      // picWelcome
      // 
      this.picWelcome.Image = ((System.Drawing.Image)(resources.GetObject("picWelcome.Image")));
      this.picWelcome.Location = new System.Drawing.Point(12, 63);
      this.picWelcome.Name = "picWelcome";
      this.picWelcome.Size = new System.Drawing.Size(260, 195);
      this.picWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picWelcome.TabIndex = 1;
      this.picWelcome.TabStop = false;
      // 
      // FrmWelcome
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 281);
      this.Controls.Add(this.picWelcome);
      this.Controls.Add(this.lblWelcome);
      this.Name = "FrmWelcome";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Welcome";
      ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblWelcome;
    private System.Windows.Forms.PictureBox picWelcome;
  }
}

