namespace xin_chao
{
    partial class frmxinchao
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
            this.lblxinchao = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblxinchao
            // 
            this.lblxinchao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblxinchao.AutoSize = true;
            this.lblxinchao.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxinchao.ForeColor = System.Drawing.Color.Red;
            this.lblxinchao.Location = new System.Drawing.Point(65, 98);
            this.lblxinchao.Name = "lblxinchao";
            this.lblxinchao.Size = new System.Drawing.Size(0, 80);
            this.lblxinchao.TabIndex = 0;
            this.lblxinchao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblxinchao.Click += new System.EventHandler(this.lblxinchao_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.Location = new System.Drawing.Point(136, 283);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(105, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show xin chao";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmxinchao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 339);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblxinchao);
            this.MinimumSize = new System.Drawing.Size(390, 350);
            this.Name = "frmxinchao";
            this.Text = "xin chao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblxinchao;
        private System.Windows.Forms.Button btnShow;
    }
}

