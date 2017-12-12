using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Motion
{
    public partial class UniformlyUserControl : UserControl
    {
        private static UniformlyUserControl _instance;
        public static UniformlyUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UniformlyUserControl();
                return _instance;
            }
        }
        public UniformlyUserControl()
        {
            InitializeComponent();
        }
    }
}
