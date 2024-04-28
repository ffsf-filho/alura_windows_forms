namespace CursoWindowsForms
{
    partial class Frm_HelloWorld_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.btn_MotificaTextoLabel = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ConteudoLabel
            // 
            this.txt_ConteudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ConteudoLabel.Location = new System.Drawing.Point(25, 75);
            this.txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            this.txt_ConteudoLabel.Size = new System.Drawing.Size(488, 20);
            this.txt_ConteudoLabel.TabIndex = 6;
            // 
            // btn_MotificaTextoLabel
            // 
            this.btn_MotificaTextoLabel.Location = new System.Drawing.Point(25, 46);
            this.btn_MotificaTextoLabel.Name = "btn_MotificaTextoLabel";
            this.btn_MotificaTextoLabel.Size = new System.Drawing.Size(209, 23);
            this.btn_MotificaTextoLabel.TabIndex = 5;
            this.btn_MotificaTextoLabel.Text = "Modifica Texto do Label";
            this.btn_MotificaTextoLabel.UseVisualStyleBackColor = true;
            this.btn_MotificaTextoLabel.Click += new System.EventHandler(this.btn_MotificaTextoLabel_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(21, 24);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(213, 19);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Visual Studio .NET Version";
            // 
            // Frm_HelloWorld_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_ConteudoLabel);
            this.Controls.Add(this.btn_MotificaTextoLabel);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Frm_HelloWorld_UC";
            this.Size = new System.Drawing.Size(537, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ConteudoLabel;
        private System.Windows.Forms.Button btn_MotificaTextoLabel;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}
