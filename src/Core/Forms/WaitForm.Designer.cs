﻿namespace WordParser.Core.Forms;

internal partial class WaitForm
{
    private System.ComponentModel.IContainer components = null;

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
        this.loadingBar = new System.Windows.Forms.ProgressBar();
        this.label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // loadingBar
        // 
        this.loadingBar.Location = new System.Drawing.Point(12, 50);
        this.loadingBar.Name = "loadingBar";
        this.loadingBar.Size = new System.Drawing.Size(295, 41);
        this.loadingBar.Step = 5;
        this.loadingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
        this.loadingBar.TabIndex = 0;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.label1.Location = new System.Drawing.Point(112, 26);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(93, 21);
        this.label1.TabIndex = 1;
        this.label1.Text = "Ожидайте...";
        // 
        // WaitForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.WhiteSmoke;
        this.ClientSize = new System.Drawing.Size(319, 103);
        this.ControlBox = false;
        this.Controls.Add(this.label1);
        this.Controls.Add(this.loadingBar);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "WaitForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "LoadBar";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ProgressBar loadingBar;
    private System.Windows.Forms.Label label1;
}