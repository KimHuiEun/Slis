
namespace SlisDevexpress
{
    partial class LibraryListControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.grcLibrary = new DevExpress.XtraGrid.GridControl();
            this.grvLibrary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLibraryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpecializedin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRents = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // grcLibrary
            // 
            this.grcLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcLibrary.Location = new System.Drawing.Point(0, 0);
            this.grcLibrary.MainView = this.grvLibrary;
            this.grcLibrary.Name = "grcLibrary";
            this.grcLibrary.Size = new System.Drawing.Size(934, 561);
            this.grcLibrary.TabIndex = 0;
            this.grcLibrary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLibrary});
            // 
            // grvLibrary
            // 
            this.grvLibrary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLibraryId,
            this.colName,
            this.colSpecializedin,
            this.colLocation,
            this.colOwns,
            this.colRents});
            this.grvLibrary.GridControl = this.grcLibrary;
            this.grvLibrary.Name = "grvLibrary";
            // 
            // colLibraryId
            // 
            this.colLibraryId.FieldName = "LibraryId";
            this.colLibraryId.MinWidth = 25;
            this.colLibraryId.Name = "colLibraryId";
            this.colLibraryId.Visible = true;
            this.colLibraryId.VisibleIndex = 0;
            this.colLibraryId.Width = 94;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 94;
            // 
            // colSpecializedin
            // 
            this.colSpecializedin.FieldName = "Specializedin";
            this.colSpecializedin.MinWidth = 25;
            this.colSpecializedin.Name = "colSpecializedin";
            this.colSpecializedin.Visible = true;
            this.colSpecializedin.VisibleIndex = 2;
            this.colSpecializedin.Width = 94;
            // 
            // colLocation
            // 
            this.colLocation.FieldName = "Location";
            this.colLocation.MinWidth = 25;
            this.colLocation.Name = "colLocation";
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 3;
            this.colLocation.Width = 94;
            // 
            // colOwns
            // 
            this.colOwns.FieldName = "Owns";
            this.colOwns.MinWidth = 25;
            this.colOwns.Name = "colOwns";
            this.colOwns.Visible = true;
            this.colOwns.VisibleIndex = 4;
            this.colOwns.Width = 94;
            // 
            // colRents
            // 
            this.colRents.FieldName = "Rents";
            this.colRents.MinWidth = 25;
            this.colRents.Name = "colRents";
            this.colRents.Visible = true;
            this.colRents.VisibleIndex = 5;
            this.colRents.Width = 94;
            // 
            // LibraryListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcLibrary);
            this.Name = "LibraryListControl";
            this.Size = new System.Drawing.Size(934, 561);
            ((System.ComponentModel.ISupportInitialize)(this.grcLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLibrary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcLibrary;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLibrary;
        private DevExpress.XtraGrid.Columns.GridColumn colLibraryId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSpecializedin;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colOwns;
        private DevExpress.XtraGrid.Columns.GridColumn colRents;
    }
}
