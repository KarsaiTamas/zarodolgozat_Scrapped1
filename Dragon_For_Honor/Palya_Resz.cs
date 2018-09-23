using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dragon_For_Honor
{
    class Palya_Resz:PictureBox
    {
        
         
        public Palya_Resz (string kep_helye){

            this.Width = 100;
            this.Height = 100;
            this.Image = Image.FromFile("kepek//" + kep_helye + ".png");
            
            this.Margin = new Padding(0, 0, 0, 0);

        }
 
    }
}
