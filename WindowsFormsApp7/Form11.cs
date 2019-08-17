using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form11 : Form
    {
        int scored;
        public Form11(int score)
        {
            InitializeComponent();
            scored = score;
            label1.Text = "Your Score is" + scored;
        }

      
    }
}
