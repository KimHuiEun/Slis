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
            fluentDesignFormContainer1.Controls.Clear();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
            
            //서울시 도서관 조회
            _userControls.Add(libraryListControl1);

            //구립 도서관 관련 정보
            _userControls.Add(libraryDetailsControl1);
            _userControls.Add(populationInfoControl1);
            _userControls.Add(booksInfoControl1);
            _userControls.Add(populationGenreControl1);
            _userControls.Add(bestRentalControl1);

            //구립 도서관 통계 자료
            _userControls.Add(genreChartControl1);
            _userControls.Add(ageGenderChartControl1);
            _userControls.Add(genreGenderChartControl1);
            
            //도서관 신간 입고 정보
            _userControls.Add(newBooksBuyingControl1);

            //지역선택컨트롤

            //신간도서검색컨트롤

        }

        private List<UserControl> _userControls = new List<UserControl>();


        private void ace1_Click(object sender, EventArgs e)
        {
            CreateUserControl(new LibraryListControl());
        }

        private void ace2_Click(object sender, EventArgs e)
        {
            CreateUserControl(new LibraryDetailsControl());
        }
        
        private void ace3_Click(object sender, EventArgs e)
        {
            CreateUserControl(new PopulationInfoControl());
        }

        private void ace4_Click(object sender, EventArgs e)
        {
            CreateUserControl(new BooksInfoControl());
        }

        private void ace5_Click(object sender, EventArgs e)
        {
            CreateUserControl(new PopulationGenreControl());
        }

        private void ace6_Click(object sender, EventArgs e)
        {
            CreateUserControl(new BestRentalControl());
        }

        private void ace7_Click(object sender, EventArgs e)
        {
            CreateUserControl(new GenreChartControl());
        }

        private void ace8_Click(object sender, EventArgs e)
        {
            CreateUserControl(new AgeGenderChartControl());
        }

        private void ace9_Click(object sender, EventArgs e)
        {
            CreateUserControl(new GenreGenderChartControl());
        }

        private void ace10_Click(object sender, EventArgs e)
        {
            CreateUserControl(new NewBooksBuyingControl());
        }

        private void CreateUserControl(UserControl control)
        {
            fluentDesignFormContainer1.Controls.Clear();

            control.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Add(control);
        }

        /*
        //동적컨트롤사용
        private void ToggleVisibilities(UserControl visibleControl)
        {
            visibleControl.Visible = true;
            foreach (UserControl control in _userControls)
                if (control != visibleControl)
                    control.Visible = false;
        }*/
    }
}
