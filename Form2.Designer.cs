﻿namespace TIntegrador
{
    partial class Form2
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
            btnInscribir = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnInscribir
            // 
            btnInscribir.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.Location = new Point(81, 77);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(131, 77);
            btnInscribir.TabIndex = 0;
            btnInscribir.Text = "Inscribir postulante";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += button1_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.LightSteelBlue;
            btnVolver.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(643, 385);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(145, 53);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnInscribir);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInscribir;
        private Button btnVolver;
    }
}