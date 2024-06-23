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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = SystemColors.ActiveCaption;
            btnImprimir.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.Location = new Point(305, 306);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(133, 36);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Generar ticket";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlumno.ForeColor = SystemColors.ButtonHighlight;
            lblAlumno.Location = new Point(375, 108);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(72, 14);
            lblAlumno.TabIndex = 1;
            lblAlumno.Text = "lblAlumno";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurso.ForeColor = SystemColors.ButtonHighlight;
            lblCurso.Location = new Point(375, 108);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(0, 14);
            lblCurso.TabIndex = 2;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDia.ForeColor = SystemColors.ButtonHighlight;
            lblDia.Location = new Point(375, 139);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(45, 14);
            lblDia.TabIndex = 3;
            lblDia.Text = "lblDia";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = SystemColors.ButtonHighlight;
            lblValor.Location = new Point(375, 171);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(58, 14);
            lblValor.TabIndex = 4;
            lblValor.Text = "lblValor";
            // 
            // lblFPago
            // 
            lblFPago.AutoSize = true;
            lblFPago.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFPago.ForeColor = SystemColors.ButtonHighlight;
            lblFPago.Location = new Point(375, 207);
            lblFPago.Name = "lblFPago";
            lblFPago.Size = new Size(64, 14);
            lblFPago.TabIndex = 5;
            lblFPago.Text = "lblFPago";
            // 
            // lblDfecha
            // 
            lblDfecha.AutoSize = true;
            lblDfecha.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDfecha.ForeColor = SystemColors.ButtonHighlight;
            lblDfecha.Location = new Point(375, 240);
            lblDfecha.Name = "lblDfecha";
            lblDfecha.Size = new Size(69, 14);
            lblDfecha.TabIndex = 6;
            lblDfecha.Text = "lblDfecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(291, 108);
            label1.Name = "label1";
            label1.Size = new Size(64, 14);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(291, 139);
            label2.Name = "label2";
            label2.Size = new Size(51, 14);
            label2.TabIndex = 9;
            label2.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(291, 171);
            label3.Name = "label3";
            label3.Size = new Size(52, 14);
            label3.TabIndex = 10;
            label3.Text = "Monto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(291, 207);
            label4.Name = "label4";
            label4.Size = new Size(48, 14);
            label4.TabIndex = 11;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(280, 240);
            label5.Name = "label5";
            label5.Size = new Size(87, 14);
            label5.TabIndex = 12;
            label5.Text = "Fecha pago:";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.LightSteelBlue;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(689, 400);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 41);
            btnVolver.TabIndex = 21;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDfecha);
            Controls.Add(lblFPago);
            Controls.Add(lblValor);
            Controls.Add(lblDia);
            Controls.Add(lblCurso);
            Controls.Add(lblAlumno);
            Controls.Add(btnImprimir);
            Name = "frmFactura";
            Text = "frmFactura";
            Load += frmFactura_Load;
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
        public Label lblAlumno;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        private Button btnVolver;
    }
}