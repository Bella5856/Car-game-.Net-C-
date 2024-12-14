using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    public partial class ChoseModeForm : Form
    {

        public Mode mode { get; set; }
        

        public ChoseModeForm()
        {
            InitializeComponent();
           
            
        }

        private void btnMode1_Click(object sender, EventArgs e)
        {
            mode = new Mode(pbMode1.Image);
            mode.modeName = "Survival";
            DialogResult = DialogResult.OK;
        }

        private void btnMode2_Click(object sender, EventArgs e)
        {
            mode = new Mode(pbMode2.Image);
            mode.modeName = "Combat";
            DialogResult = DialogResult.OK;
        }

        private void btnMode3_Click(object sender, EventArgs e)
        {
            mode = new Mode(pbMode3.Image);
            mode.modeName = "Coins";
            DialogResult = DialogResult.OK;
        }
    }
}
