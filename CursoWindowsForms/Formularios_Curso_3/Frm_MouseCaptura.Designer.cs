﻿namespace CursoWindowsForms.Formularios_Curso_3
{
    partial class Frm_MouseCaptura
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
            this.Btn_Mouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Mouse
            // 
            this.Btn_Mouse.Location = new System.Drawing.Point(100, 46);
            this.Btn_Mouse.Name = "Btn_Mouse";
            this.Btn_Mouse.Size = new System.Drawing.Size(304, 132);
            this.Btn_Mouse.TabIndex = 0;
            this.Btn_Mouse.UseVisualStyleBackColor = true;
            this.Btn_Mouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Mouse_MouseDown);
            // 
            // Frm_MouseCaptura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 242);
            this.Controls.Add(this.Btn_Mouse);
            this.Name = "Frm_MouseCaptura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Captura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Mouse;
    }
}