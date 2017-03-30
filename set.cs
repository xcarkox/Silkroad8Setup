using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public partial class set : Component
    {
        public set()
        {
            InitializeComponent();
        }

        public set(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
