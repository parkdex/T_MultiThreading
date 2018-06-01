namespace T_Delegate
{
    partial class SubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CallMom = new System.Windows.Forms.Button();
            this.btm_MakeSubForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CallMom
            // 
            this.btn_CallMom.BackColor = System.Drawing.Color.Lime;
            this.btn_CallMom.Location = new System.Drawing.Point(1, 2);
            this.btn_CallMom.Name = "btn_CallMom";
            this.btn_CallMom.Size = new System.Drawing.Size(233, 90);
            this.btn_CallMom.TabIndex = 0;
            this.btn_CallMom.Tag = "CALL";
            this.btn_CallMom.Text = "엄마 호출";
            this.btn_CallMom.UseVisualStyleBackColor = false;
            this.btn_CallMom.Click += new System.EventHandler(buttonEvents[(int)FormType.Mon]);
            // 
            // btm_MakeSubForm
            // 
            this.btm_MakeSubForm.Location = new System.Drawing.Point(2, 94);
            this.btm_MakeSubForm.Name = "btm_MakeSubForm";
            this.btm_MakeSubForm.Size = new System.Drawing.Size(232, 116);
            this.btm_MakeSubForm.TabIndex = 1;
            this.btm_MakeSubForm.Tag = "MAKE";
            this.btm_MakeSubForm.Text = "자식폼 생성";
            this.btm_MakeSubForm.UseVisualStyleBackColor = true;
            this.btm_MakeSubForm.Click += new System.EventHandler(buttonEvents[(int)FormType.Son]);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.btm_MakeSubForm);
            this.Controls.Add(this.btn_CallMom);
            this.Name = "SubForm";
            this.Text = "SubForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CallMom;
        private System.Windows.Forms.Button btm_MakeSubForm;
    }
}