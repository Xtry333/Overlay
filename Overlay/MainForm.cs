/*
 * Created by SharpDevelop.
 * User: Xtry333
 * Date: 2016-07-07
 * Time: 14:59
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Overlay
{
	public partial class MainForm : Form
	{
   		bool checkB = false;
   		Ovl overlayForm = new Ovl();

		public MainForm()
		{
			InitializeComponent();
		}

		void CheckboxCrosshairCheckedChanged(object sender, EventArgs e)
		{
   			if (!checkB) 
   			{
    			overlayForm.Show();
    			checkB = true;
   			} else if (checkB)
   			{
    			overlayForm.Hide();
    			checkB = false;
   			}
            textBox1TextChanged(null, null);
        }

        private void textBox1TextChanged(object sender, EventArgs e)
        {
            overlayForm.infoLabel.Text = infoTextBox.Text;
        }
    }
}
