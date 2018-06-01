namespace T_Delegate
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_MakeSubForm = new System.Windows.Forms.Button();
            this.txt_CallMonitor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_MakeSubForm
            // 
            this.btn_MakeSubForm.Location = new System.Drawing.Point(1, 29);
            this.btn_MakeSubForm.Name = "btn_MakeSubForm";
            this.btn_MakeSubForm.Size = new System.Drawing.Size(282, 232);
            this.btn_MakeSubForm.TabIndex = 0;
            this.btn_MakeSubForm.Text = "자식 폼 생성";
            this.btn_MakeSubForm.UseVisualStyleBackColor = true;
            this.btn_MakeSubForm.Click += new System.EventHandler(this.btn_MakeSubForm_Click);
            // 
            // txt_CallMonitor
            // 
            this.txt_CallMonitor.Location = new System.Drawing.Point(1, 2);
            this.txt_CallMonitor.Name = "txt_CallMonitor";
            this.txt_CallMonitor.Size = new System.Drawing.Size(282, 21);
            this.txt_CallMonitor.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_CallMonitor);
            this.Controls.Add(this.btn_MakeSubForm);
            this.Name = "MainForm";
            this.Text = "엄마 폼";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MakeSubForm;
        private System.Windows.Forms.TextBox txt_CallMonitor;
    }
}

