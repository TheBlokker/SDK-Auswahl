using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDK_Auswahl
{
    public partial class Aboutbox : Form
    {
        public Aboutbox()
        {
            InitializeComponent();
        }
        public void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
