using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlisDevexpress
{
    public partial class TitleSearchControl : UserControl
    {
        public TitleSearchControl()
        {
            InitializeComponent();
        }

        private void lueTitle_EditValueChanged(object sender, EventArgs e)
        {
            OnTitleSearched(lueTitle.Text);
        }

        #region TitleSearched event things for C# 3.0
        public event EventHandler<TitleSearchedEventArgs> TitleSearched;

        protected virtual void OnTitleSearched(TitleSearchedEventArgs e)
        {
            if (TitleSearched != null)
                TitleSearched(this, e);
        }

        private TitleSearchedEventArgs OnTitleSearched(string title)
        {
            TitleSearchedEventArgs args = new TitleSearchedEventArgs(title);
            OnTitleSearched(args);

            return args;
        }

        private TitleSearchedEventArgs OnTitleSearchedForOut()
        {
            TitleSearchedEventArgs args = new TitleSearchedEventArgs();
            OnTitleSearched(args);

            return args;
        }

        public class TitleSearchedEventArgs : EventArgs
        {
            public string Title { get; set; }

            public TitleSearchedEventArgs()
            {
            }

            public TitleSearchedEventArgs(string title)
            {
                Title = title;
            }
        }
        #endregion
    }
}
