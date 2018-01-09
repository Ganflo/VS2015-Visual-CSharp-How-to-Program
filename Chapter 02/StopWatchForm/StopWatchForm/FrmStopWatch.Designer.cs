namespace StopWatchForm
{
  partial class FrmStopWatch
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sTOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.lAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rESETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.btnStart = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.btnLap = new System.Windows.Forms.Button();
      this.txtDetails = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTARTToolStripMenuItem,
            this.sTOPToolStripMenuItem,
            this.lAPToolStripMenuItem,
            this.rESETToolStripMenuItem,
            this.eXITToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(312, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // sTARTToolStripMenuItem
      // 
      this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
      this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
      this.sTARTToolStripMenuItem.Text = "START";
      // 
      // sTOPToolStripMenuItem
      // 
      this.sTOPToolStripMenuItem.Name = "sTOPToolStripMenuItem";
      this.sTOPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
      this.sTOPToolStripMenuItem.Text = "STOP";
      // 
      // lAPToolStripMenuItem
      // 
      this.lAPToolStripMenuItem.Name = "lAPToolStripMenuItem";
      this.lAPToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
      this.lAPToolStripMenuItem.Text = "LAP";
      // 
      // rESETToolStripMenuItem
      // 
      this.rESETToolStripMenuItem.Name = "rESETToolStripMenuItem";
      this.rESETToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
      this.rESETToolStripMenuItem.Text = "RESET";
      // 
      // eXITToolStripMenuItem
      // 
      this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
      this.eXITToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
      this.eXITToolStripMenuItem.Text = "EXIT";
      // 
      // btnStart
      // 
      this.btnStart.BackColor = System.Drawing.SystemColors.ButtonShadow;
      this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.btnStart.Location = new System.Drawing.Point(14, 128);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(66, 28);
      this.btnStart.TabIndex = 1;
      this.btnStart.Text = "Start";
      this.btnStart.UseVisualStyleBackColor = false;
      // 
      // btnStop
      // 
      this.btnStop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.btnStop.Location = new System.Drawing.Point(118, 128);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(66, 28);
      this.btnStop.TabIndex = 2;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = false;
      // 
      // btnLap
      // 
      this.btnLap.BackColor = System.Drawing.SystemColors.ButtonShadow;
      this.btnLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.btnLap.Location = new System.Drawing.Point(227, 128);
      this.btnLap.Name = "btnLap";
      this.btnLap.Size = new System.Drawing.Size(66, 28);
      this.btnLap.TabIndex = 3;
      this.btnLap.Text = "Lap";
      this.btnLap.UseVisualStyleBackColor = false;
      // 
      // txtDetails
      // 
      this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDetails.Location = new System.Drawing.Point(11, 173);
      this.txtDetails.Name = "txtDetails";
      this.txtDetails.Size = new System.Drawing.Size(290, 88);
      this.txtDetails.TabIndex = 4;
      this.txtDetails.Text = "Lap Details";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(29, 76);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 32);
      this.label1.TabIndex = 5;
      this.label1.Text = "00";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(76, 76);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(20, 32);
      this.label2.TabIndex = 6;
      this.label2.Text = ":";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(102, 76);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(41, 32);
      this.label4.TabIndex = 8;
      this.label4.Text = "00";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(174, 76);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(41, 32);
      this.label5.TabIndex = 9;
      this.label5.Text = "00";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(245, 76);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(28, 32);
      this.label6.TabIndex = 10;
      this.label6.Text = "0";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(148, 76);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(20, 32);
      this.label8.TabIndex = 12;
      this.label8.Text = ":";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(219, 76);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(20, 32);
      this.label9.TabIndex = 13;
      this.label9.Text = ".";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(238, 41);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(12, 20);
      this.label3.TabIndex = 20;
      this.label3.Text = ".";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(189, 41);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(12, 20);
      this.label7.TabIndex = 19;
      this.label7.Text = ":";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(256, 41);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(17, 20);
      this.label10.TabIndex = 18;
      this.label10.Text = "0";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(207, 41);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(25, 20);
      this.label11.TabIndex = 17;
      this.label11.Text = "00";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(158, 41);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(25, 20);
      this.label12.TabIndex = 16;
      this.label12.Text = "00";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(140, 41);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(12, 20);
      this.label13.TabIndex = 15;
      this.label13.Text = ":";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(104, 41);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(25, 20);
      this.label14.TabIndex = 14;
      this.label14.Text = "00";
      // 
      // FrmStopWatch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(312, 275);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtDetails);
      this.Controls.Add(this.btnLap);
      this.Controls.Add(this.btnStop);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FrmStopWatch";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Stop Watch Form";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sTOPToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem lAPToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rESETToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Button btnLap;
    private System.Windows.Forms.RichTextBox txtDetails;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
  }
}

