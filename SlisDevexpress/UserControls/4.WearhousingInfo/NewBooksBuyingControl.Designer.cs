
namespace SlisDevexpress
{
    partial class NewBooksBuyingControl
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
            this.titleSearchControl1 = new SlisDevexpress.TitleSearchControl();
            this.SuspendLayout();
            // 
            // titleSearchControl1
            // 
            this.titleSearchControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleSearchControl1.Location = new System.Drawing.Point(0, 0);
            this.titleSearchControl1.Name = "titleSearchControl1";
            this.titleSearchControl1.Size = new System.Drawing.Size(810, 54);
            this.titleSearchControl1.TabIndex = 0;
            // 
            // NewBooksBuyingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleSearchControl1);
            this.Name = "NewBooksBuyingControl";
            this.Size = new System.Drawing.Size(810, 554);
            this.ResumeLayout(false);

        }

        #endregion

        private TitleSearchControl titleSearchControl1;
    }
}
