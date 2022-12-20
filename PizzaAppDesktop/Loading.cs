using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PizzaAppDesktop
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            MyLoading.Load("loading-4.gif");
            MyLoading.Location = new Point(this.Width/2 - MyLoading.Width/2, this.Height/2 - MyLoading.Height/2);
        }
    }
}
