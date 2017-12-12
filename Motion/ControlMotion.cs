using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace Motion
{
   // [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class ControlMotion : UserControl
    {
        private static ControlMotion _instance;
        public static ControlMotion Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new ControlMotion();        
                return _instance;
            }
        }
        public ControlMotion()
        {
            InitializeComponent();
        }

        private void _RadioButtonUnidormMotion_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
