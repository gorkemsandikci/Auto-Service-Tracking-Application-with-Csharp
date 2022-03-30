using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.Views.Shared
{
    public partial class MenuItem : UserControl
    {
        public string Yazi
        {
            get {return lblText.Text;}
            set
            {
                lblText.Text = value;
            }
        }
        public MenuItem()
        {
            InitializeComponent();
            WireAllControls(this);
            
        }
        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                ctl.Click += ctl_Click;
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        private void ctl_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }

        private void lblText_MouseHover(object sender, EventArgs e)
        {
            lblText.BackColor = Color.FromArgb(105, 105, 105);

        }

        private void lblText_MouseLeave(object sender, EventArgs e)
        {

            lblText.BackColor = Color.Transparent;
        }
    }
}
