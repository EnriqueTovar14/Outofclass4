using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Outofclass4
{
    class TicTacToeButton : Button
    {
 
        public TicTacToeButton()
        {
            this.Width = this.Height = 100;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Text = "*";
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Consolas", 25);
        }
    }
}
