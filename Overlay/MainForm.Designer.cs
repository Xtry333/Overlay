/*
 * Created by SharpDevelop.
 * User: Xtry333
 * Date: 2016-07-07
 * Time: 14:59
 * 
 */
namespace Overlay
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckBox checkboxCrosshair;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
            this.checkboxCrosshair = new System.Windows.Forms.CheckBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkboxCrosshair
            // 
            this.checkboxCrosshair.Location = new System.Drawing.Point(12, 12);
            this.checkboxCrosshair.Name = "checkboxCrosshair";
            this.checkboxCrosshair.Size = new System.Drawing.Size(104, 24);
            this.checkboxCrosshair.TabIndex = 0;
            this.checkboxCrosshair.Text = "Crosshair";
            this.checkboxCrosshair.UseVisualStyleBackColor = true;
            this.checkboxCrosshair.CheckStateChanged += new System.EventHandler(this.CheckboxCrosshairCheckedChanged);
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(12, 42);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(260, 20);
            this.infoTextBox.TabIndex = 1;
            this.infoTextBox.TextChanged += new System.EventHandler(this.textBox1TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.checkboxCrosshair);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Overlay Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        public System.Windows.Forms.TextBox infoTextBox;
    }
}