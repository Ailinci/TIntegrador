namespace TIntegrador
{
    partial class frmFactura
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
            btnImprimir = new Button();
            lblAlumno = new Label();
            lblCurso = new Label();
            lblDia = new Label();
            lblValor = new Label();
            lblFPago = new Label();
            lblDfecha = new Label();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(193, 333);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(133, 36);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Generar ticket";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(193, 136);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(63, 15);
            lblAlumno.TabIndex = 1;
            lblAlumno.Text = "lblAlumno";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(193, 136);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(0, 15);
            lblCurso.TabIndex = 2;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(193, 174);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(37, 15);
            lblDia.TabIndex = 3;
            lblDia.Text = "lblDia";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(193, 205);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(46, 15);
            lblValor.TabIndex = 4;
            lblValor.Text = "lblValor";
            // 
            // lblFPago
            // 
            lblFPago.AutoSize = true;
            lblFPago.Location = new Point(193, 235);
            lblFPago.Name = "lblFPago";
            lblFPago.Size = new Size(53, 15);
            lblFPago.TabIndex = 5;
            lblFPago.Text = "lblFPago";
            // 
            // lblDfecha
            // 
            lblDfecha.AutoSize = true;
            lblDfecha.Location = new Point(193, 268);
            lblDfecha.Name = "lblDfecha";
            lblDfecha.Size = new Size(57, 15);
            lblDfecha.TabIndex = 6;
            lblDfecha.Text = "lblDfecha";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(645, 359);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(lblDfecha);
            Controls.Add(lblFPago);
            Controls.Add(lblValor);
            Controls.Add(lblDia);
            Controls.Add(lblCurso);
            Controls.Add(lblAlumno);
            Controls.Add(btnImprimir);
            Name = "frmFactura";
            Text = "frmFactura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimir;
        private Label lblCurso;
        private Label lblDia;
        private Label lblValor;
        private Label lblFPago;
        private Label lblDfecha;
        private Button btnVolver;
        public Label lblAlumno;
    }
}