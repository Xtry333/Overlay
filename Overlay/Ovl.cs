/*
 * Created by SharpDevelop.
 * User: Xtry333
 * Date: 2016-07-07
 * Time: 17:41
 * 
 */
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Overlay
{
	public partial class Ovl : Form
	{
		[DllImport("user32.dll", SetLastError = true)]
       	static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        public void ovlSetInvincible()
        {
            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
        }

        public Ovl()
		{
			InitializeComponent();
            ovlSetInvincible();
        }

        private void timer1Tick(object sender, EventArgs e)
        {
            //if (dateTimePicker1.Value.Hour >= 0 && dateTimePicker1.Value.Minute >= 0 && dateTimePicker1.Value.Second >= 0)
            this.dateTimePicker1.Value = this.dateTimePicker1.Value.AddSeconds(1);
        }
    }
}
