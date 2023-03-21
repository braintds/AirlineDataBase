using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineDataBase
{
    public partial class TextForm : Form
    {
        public TextForm(string text)
        {

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            richTextBox1.Text = text;
        }
    }
}
