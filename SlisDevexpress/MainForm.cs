using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SlisDevexpress
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            _userControls.Add(libraryListControl1);
            //_userControls.Add
            _userControls.Add(populationInfoControl1);
            //_userControls.Add
            //_userControls.Add
            //_userControls.Add
            //_userControls.Add
            //_userControls.Add
            //_userControls.Add
            //_userControls.Add
            //_userControls.Add
            //_userControls.Add

        }

        private List<UserControl> _userControls = new List<UserControl>();

    }
}
