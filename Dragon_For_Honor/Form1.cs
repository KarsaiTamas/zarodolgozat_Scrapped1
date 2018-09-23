using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dragon_For_Honor
{
    public partial class Form1 : Form
    {
         
        static Palya_Resz Fu = new Palya_Resz("fu2");
        static Palya_Resz Fu1 = new Palya_Resz("fu1");
        
        public Form1()
        {

            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                Panel.Controls.Add(new Palya_Resz("fu2"));
               
            }
            Panel.Width = this.Width;
              
            
          

            
             

        }
    }
}
