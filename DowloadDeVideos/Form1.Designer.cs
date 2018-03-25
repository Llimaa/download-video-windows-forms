namespace DowloadDeVideos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btndownload = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.ltbArquivos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUrl.Location = new System.Drawing.Point(12, 9);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(33, 20);
            this.LblUrl.TabIndex = 0;
            this.LblUrl.Text = "Url:";
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(12, 29);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(598, 26);
            this.txtUrl.TabIndex = 1;
            // 
            // btndownload
            // 
            this.btndownload.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btndownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndownload.Location = new System.Drawing.Point(464, 61);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(146, 46);
            this.btndownload.TabIndex = 2;
            this.btndownload.Text = "Download";
            this.btndownload.UseVisualStyleBackColor = false;
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(79, 94);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 20);
            this.LblStatus.TabIndex = 3;
            // 
            // ltbArquivos
            // 
            this.ltbArquivos.FormattingEnabled = true;
            this.ltbArquivos.Location = new System.Drawing.Point(12, 133);
            this.ltbArquivos.Name = "ltbArquivos";
            this.ltbArquivos.Size = new System.Drawing.Size(598, 95);
            this.ltbArquivos.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(622, 251);
            this.Controls.Add(this.ltbArquivos);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.LblUrl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Baixar Videos do youtube";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.ListBox ltbArquivos;
    }
}

