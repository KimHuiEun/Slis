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


        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            TotalLibraryForm showForm = new TotalLibraryForm();
            showForm.Show();
        }

    }
}
