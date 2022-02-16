namespace CalcularHash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArquivo = new System.Windows.Forms.Label();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.ofdlg1 = new System.Windows.Forms.OpenFileDialog();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.btnCalcularHash = new System.Windows.Forms.Button();
            this.txtSHA256 = new System.Windows.Forms.TextBox();
            this.lblHash = new System.Windows.Forms.Label();
            this.btnCopiarHash = new System.Windows.Forms.Button();
            this.txtSHA512 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopiarSha512 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(53, 44);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(49, 15);
            this.lblArquivo.TabIndex = 0;
            this.lblArquivo.Text = "Arquivo";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(53, 62);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(416, 23);
            this.txtArquivo.TabIndex = 1;
            // 
            // ofdlg1
            // 
            this.ofdlg1.FileName = "openFileDialog1";
            // 
            // btnArquivo
            // 
            this.btnArquivo.Location = new System.Drawing.Point(475, 61);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(38, 24);
            this.btnArquivo.TabIndex = 2;
            this.btnArquivo.Text = "...";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // btnCalcularHash
            // 
            this.btnCalcularHash.Location = new System.Drawing.Point(53, 105);
            this.btnCalcularHash.Name = "btnCalcularHash";
            this.btnCalcularHash.Size = new System.Drawing.Size(93, 39);
            this.btnCalcularHash.TabIndex = 3;
            this.btnCalcularHash.Text = "Calcular Hash";
            this.btnCalcularHash.UseVisualStyleBackColor = true;
            this.btnCalcularHash.Click += new System.EventHandler(this.btnCalcularHash_Click);
            // 
            // txtSHA256
            // 
            this.txtSHA256.Location = new System.Drawing.Point(53, 189);
            this.txtSHA256.Multiline = true;
            this.txtSHA256.Name = "txtSHA256";
            this.txtSHA256.Size = new System.Drawing.Size(416, 43);
            this.txtSHA256.TabIndex = 4;
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(53, 171);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(51, 15);
            this.lblHash.TabIndex = 5;
            this.lblHash.Text = "SHA 256";
            // 
            // btnCopiarHash
            // 
            this.btnCopiarHash.Location = new System.Drawing.Point(475, 188);
            this.btnCopiarHash.Name = "btnCopiarHash";
            this.btnCopiarHash.Size = new System.Drawing.Size(110, 44);
            this.btnCopiarHash.TabIndex = 6;
            this.btnCopiarHash.Text = "Copiar SHA 256";
            this.btnCopiarHash.UseVisualStyleBackColor = true;
            this.btnCopiarHash.Click += new System.EventHandler(this.btnCopiarHash_Click);
            // 
            // txtSHA512
            // 
            this.txtSHA512.Location = new System.Drawing.Point(53, 267);
            this.txtSHA512.Multiline = true;
            this.txtSHA512.Name = "txtSHA512";
            this.txtSHA512.Size = new System.Drawing.Size(416, 46);
            this.txtSHA512.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "SHA 512";
            // 
            // btnCopiarSha512
            // 
            this.btnCopiarSha512.Location = new System.Drawing.Point(475, 267);
            this.btnCopiarSha512.Name = "btnCopiarSha512";
            this.btnCopiarSha512.Size = new System.Drawing.Size(110, 45);
            this.btnCopiarSha512.TabIndex = 9;
            this.btnCopiarSha512.Text = "Copiar SHA 512";
            this.btnCopiarSha512.UseVisualStyleBackColor = true;
            this.btnCopiarSha512.Click += new System.EventHandler(this.btnCopiarSha512_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 402);
            this.Controls.Add(this.btnCopiarSha512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSHA512);
            this.Controls.Add(this.btnCopiarHash);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.txtSHA256);
            this.Controls.Add(this.btnCalcularHash);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.lblArquivo);
            this.Name = "Form1";
            this.Text = "Calcular SHA 256 e SHA 512";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblArquivo;
        private TextBox txtArquivo;
        private OpenFileDialog ofdlg1;
        private Button btnArquivo;
        private Button btnCalcularHash;
        private TextBox txtSHA256;
        private Label lblHash;
        private Button btnCopiarHash;
        private TextBox txtSHA512;
        private Label label1;
        private Button btnCopiarSha512;
    }
}