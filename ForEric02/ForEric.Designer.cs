namespace ForEric02
{
  partial class ForEric
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForEric));
      this.ibOriginal = new Emgu.CV.UI.ImageBox();
      this.ibMask = new Emgu.CV.UI.ImageBox();
      this.sbMin = new System.Windows.Forms.HScrollBar();
      this.sbMax = new System.Windows.Forms.HScrollBar();
      this.tbMin = new System.Windows.Forms.TextBox();
      this.tbMax = new System.Windows.Forms.TextBox();
      this.msMain = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveInverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ibMask)).BeginInit();
      this.msMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // ibOriginal
      // 
      this.ibOriginal.Location = new System.Drawing.Point(28, 123);
      this.ibOriginal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.ibOriginal.Name = "ibOriginal";
      this.ibOriginal.Size = new System.Drawing.Size(770, 552);
      this.ibOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.ibOriginal.TabIndex = 2;
      this.ibOriginal.TabStop = false;
      // 
      // ibMask
      // 
      this.ibMask.Location = new System.Drawing.Point(818, 123);
      this.ibMask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.ibMask.Name = "ibMask";
      this.ibMask.Size = new System.Drawing.Size(770, 552);
      this.ibMask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.ibMask.TabIndex = 3;
      this.ibMask.TabStop = false;
      // 
      // sbMin
      // 
      this.sbMin.LargeChange = 5;
      this.sbMin.Location = new System.Drawing.Point(174, 39);
      this.sbMin.Maximum = 255;
      this.sbMin.Name = "sbMin";
      this.sbMin.Size = new System.Drawing.Size(1428, 32);
      this.sbMin.TabIndex = 4;
      this.sbMin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbMin_Scroll);
      // 
      // sbMax
      // 
      this.sbMax.LargeChange = 5;
      this.sbMax.Location = new System.Drawing.Point(174, 82);
      this.sbMax.Maximum = 255;
      this.sbMax.Name = "sbMax";
      this.sbMax.Size = new System.Drawing.Size(1428, 32);
      this.sbMax.TabIndex = 5;
      this.sbMax.Value = 255;
      this.sbMax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbMax_Scroll);
      // 
      // tbMin
      // 
      this.tbMin.Location = new System.Drawing.Point(60, 39);
      this.tbMin.Name = "tbMin";
      this.tbMin.Size = new System.Drawing.Size(100, 26);
      this.tbMin.TabIndex = 6;
      this.tbMin.Text = "0";
      this.tbMin.Leave += new System.EventHandler(this.tbMin_Leave);
      // 
      // tbMax
      // 
      this.tbMax.Location = new System.Drawing.Point(60, 82);
      this.tbMax.Name = "tbMax";
      this.tbMax.Size = new System.Drawing.Size(100, 26);
      this.tbMax.TabIndex = 7;
      this.tbMax.Text = "255";
      this.tbMax.Leave += new System.EventHandler(this.tbMax_Leave);
      // 
      // msMain
      // 
      this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.msMain.Location = new System.Drawing.Point(0, 0);
      this.msMain.Name = "msMain";
      this.msMain.Size = new System.Drawing.Size(1620, 24);
      this.msMain.TabIndex = 8;
      this.msMain.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveInverseToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
      this.openToolStripMenuItem.Text = "open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
      this.saveToolStripMenuItem.Text = "save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // saveInverseToolStripMenuItem
      // 
      this.saveInverseToolStripMenuItem.Name = "saveInverseToolStripMenuItem";
      this.saveInverseToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
      this.saveInverseToolStripMenuItem.Text = "save inverse";
      this.saveInverseToolStripMenuItem.Click += new System.EventHandler(this.saveInverseToolStripMenuItem_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(134, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
      this.exitToolStripMenuItem.Text = "exit";
      // 
      // ForEric
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.ClientSize = new System.Drawing.Size(1620, 694);
      this.Controls.Add(this.tbMax);
      this.Controls.Add(this.tbMin);
      this.Controls.Add(this.sbMax);
      this.Controls.Add(this.sbMin);
      this.Controls.Add(this.ibMask);
      this.Controls.Add(this.ibOriginal);
      this.Controls.Add(this.msMain);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.msMain;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "ForEric";
      this.Text = "For Eric";
      ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ibMask)).EndInit();
      this.msMain.ResumeLayout(false);
      this.msMain.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private Emgu.CV.UI.ImageBox ibOriginal;
    private Emgu.CV.UI.ImageBox ibMask;
    private System.Windows.Forms.HScrollBar sbMin;
    private System.Windows.Forms.HScrollBar sbMax;
    private System.Windows.Forms.TextBox tbMin;
    private System.Windows.Forms.TextBox tbMax;
    private System.Windows.Forms.MenuStrip msMain;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveInverseToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
  }
}

