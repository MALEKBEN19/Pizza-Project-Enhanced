using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProjectEnhanced
{
    public partial class frmContact : Form
    {
        public frmContact()
        {
            InitializeComponent();
        }

        private void lkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lkGitHub.LinkVisited=true;
            System.Diagnostics.Process.Start(@"https://github.com/MALEKBEN19");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lkLinkedIn.LinkVisited=true;
            System.Diagnostics.Process.Start(@"https://www.linkedin.com/in/abdelmalek-b-b5b323240/");
        }

        private void lkProgrammingAdvices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lkProgrammingAdvices.LinkVisited = true;
            System.Diagnostics.Process.Start(@"https://programmingadvices.com");
        }
    }
}
