/*
 * Created by SharpDevelop.
 * User: Xtry333
 * Date: 2016-07-07
 * Time: 17:41
 * 
 */

namespace Overlay
{
	partial class Ovl
	{
		private System.ComponentModel.IContainer components = null;
		
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ovl));
            this.infoLabel = new System.Windows.Forms.Label();
            this.ovInfoPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timerSecond = new System.Windows.Forms.Timer(this.components);
            this.ovInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            resources.ApplyResources(this.infoLabel, "infoLabel");
            this.infoLabel.BackColor = System.Drawing.Color.Silver;
            this.infoLabel.Name = "infoLabel";
            // 
            // ovInfoPanel
            // 
            resources.ApplyResources(this.ovInfoPanel, "ovInfoPanel");
            this.ovInfoPanel.Controls.Add(this.dateTimePicker1);
            this.ovInfoPanel.Controls.Add(this.infoLabel);
            this.ovInfoPanel.Name = "ovInfoPanel";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.TabStop = false;
            // 
            // timerSecond
            // 
            this.timerSecond.Enabled = true;
            this.timerSecond.Interval = 1000;
            this.timerSecond.Tick += new System.EventHandler(this.timer1Tick);
            // 
            // Ovl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.CausesValidation = false;
            this.Controls.Add(this.ovInfoPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ovl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ovInfoPanel.ResumeLayout(false);
            this.ovInfoPanel.PerformLayout();
            this.ResumeLayout(false);

		}
        public System.Windows.Forms.Panel ovInfoPanel;
        public System.Windows.Forms.Label infoLabel;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Timer timerSecond;
    }
}
