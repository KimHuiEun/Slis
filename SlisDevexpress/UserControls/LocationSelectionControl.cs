using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlisDevexpress.UserControls
{
    public partial class LocationSelectionControl : UserControl
    {
        public LocationSelectionControl()
        {
            InitializeComponent();
        }


        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnLocationSelected(cbLibraryId.Text, teLibraryName.Text);
        }


        #region LocationSelected event things for C# 3.0
        public event EventHandler<LocationSelectedEventArgs> LocationSelected;

        protected virtual void OnLocationSelected(LocationSelectedEventArgs e)
        {
            if (LocationSelected != null)
                LocationSelected(this, e);
        }

        private LocationSelectedEventArgs OnLocationSelected(string libraryId, string libraryName)
        {
            LocationSelectedEventArgs args = new LocationSelectedEventArgs(libraryId, libraryName);
            OnLocationSelected(args);

            return args;
        }

        private LocationSelectedEventArgs OnLocationSelectedForOut()
        {
            LocationSelectedEventArgs args = new LocationSelectedEventArgs();
            OnLocationSelected(args);

            return args;
        }

        public class LocationSelectedEventArgs : EventArgs
        {
            public string LibraryId { get; set; }
            public string LibraryName { get; set; }

            public LocationSelectedEventArgs()
            {
            }

            public LocationSelectedEventArgs(string libraryId, string libraryName)
            {
                LibraryId = libraryId;
                LibraryName = libraryName;
            }
        }
        #endregion
    }
}
