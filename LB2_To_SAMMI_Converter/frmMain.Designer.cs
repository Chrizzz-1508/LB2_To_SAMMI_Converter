namespace LB2_To_SAMMI_Converter
{
    partial class ExtensionConverter
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtensionConverter));
            this.rtbLB2 = new System.Windows.Forms.RichTextBox();
            this.rtbSEF = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbLB2
            // 
            this.rtbLB2.Location = new System.Drawing.Point(12, 136);
            this.rtbLB2.Name = "rtbLB2";
            this.rtbLB2.Size = new System.Drawing.Size(529, 398);
            this.rtbLB2.TabIndex = 2;
            this.rtbLB2.Text = "";
            // 
            // rtbSEF
            // 
            this.rtbSEF.Location = new System.Drawing.Point(643, 136);
            this.rtbSEF.Name = "rtbSEF";
            this.rtbSEF.Size = new System.Drawing.Size(529, 398);
            this.rtbSEF.TabIndex = 4;
            this.rtbSEF.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "LB2 Extension (.lb2)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label2.Location = new System.Drawing.Point(712, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "SAMMI Extension (.sef)";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.btnSave.Location = new System.Drawing.Point(643, 551);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(529, 74);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save SEF file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.btnLoad.Location = new System.Drawing.Point(12, 551);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(529, 74);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load LB2 file";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(552, 136);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(76, 397);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = ">\r\n>\r\n>\r\n>\r\n>\r\n";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.txtFileName.Location = new System.Drawing.Point(293, 28);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(879, 47);
            this.txtFileName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Extension Name:";
            // 
            // ExtensionConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbSEF);
            this.Controls.Add(this.rtbLB2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExtensionConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extension Converter LB2 => SAMMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLB2;
        private System.Windows.Forms.RichTextBox rtbSEF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label3;
    }
}

