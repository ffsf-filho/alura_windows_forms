﻿using CursoWindowsForms.Formularios_Curso_5;

namespace CursoWindowsForms.Formularios_Curso_7
{
	partial class Frm_Agencia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Agencia));
			this.Tls_Principal = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.Tls_Principal.SuspendLayout();
			this.SuspendLayout();
			// 
			// Tls_Principal
			// 
			this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
			this.Tls_Principal.Name = "Tls_Principal";
			this.Tls_Principal.Size = new System.Drawing.Size(345, 25);
			this.Tls_Principal.TabIndex = 0;
			this.Tls_Principal.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::CursoWindowsForms.Properties.Resources.ExcluirBarra;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.ToolTipText = "Fechar";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// Frm_Agencia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 320);
			this.Controls.Add(this.Tls_Principal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Agencia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Agência";
			this.Tls_Principal.ResumeLayout(false);
			this.Tls_Principal.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip Tls_Principal;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
	}
}