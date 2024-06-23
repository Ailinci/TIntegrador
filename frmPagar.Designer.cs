namespace TIntegrador
{
    partial class frmPagar
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
            txtNro = new TextBox();
            groupBox1 = new GroupBox();
            btnTarjeta = new RadioButton();
            optEfvo = new RadioButton();
            cboTipo = new ComboBox();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            lblTipoD = new Label();
            label1 = new Label();
            btnPagar = new Button();
            btnVolver = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNro
            // 
            txtNro.BackColor = Color.LightSteelBlue;
            txtNro.Location = new Point(255, 90);
            txtNro.Name = "txtNro";
            txtNro.Size = new Size(100, 23);
            txtNro.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTarjeta);
            groupBox1.Controls.Add(optEfvo);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(492, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Método de pago";
            // 
            // btnTarjeta
            // 
            btnTarjeta.AutoSize = true;
            btnTarjeta.ForeColor = SystemColors.ButtonHighlight;
            btnTarjeta.Location = new Point(16, 54);
            btnTarjeta.Name = "btnTarjeta";
            btnTarjeta.Size = new Size(59, 19);
            btnTarjeta.TabIndex = 1;
            btnTarjeta.TabStop = true;
            btnTarjeta.Text = "Tarjeta";
            btnTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.ForeColor = SystemColors.ButtonFace;
            optEfvo.Location = new Point(16, 29);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new Size(67, 19);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = true;
            // 
            // cboTipo
            // 
            cboTipo.BackColor = Color.LightSteelBlue;
            cboTipo.Cursor = Cursors.Hand;
            cboTipo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "PASAPORTE", "CUIL", "LIBRETA" });
            cboTipo.Location = new Point(191, 146);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(225, 26);
            cboTipo.TabIndex = 18;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.ForeColor = SystemColors.ButtonFace;
            lblDocumento.Location = new Point(78, 217);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(101, 18);
            lblDocumento.TabIndex = 17;
            lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.BackColor = Color.LightSteelBlue;
            txtDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtDocumento.Cursor = Cursors.Hand;
            txtDocumento.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.Location = new Point(191, 217);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(225, 27);
            txtDocumento.TabIndex = 16;
            // 
            // lblTipoD
            // 
            lblTipoD.AutoSize = true;
            lblTipoD.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoD.ForeColor = SystemColors.ButtonFace;
            lblTipoD.Location = new Point(16, 149);
            lblTipoD.Name = "lblTipoD";
            lblTipoD.Size = new Size(163, 18);
            lblTipoD.TabIndex = 15;
            lblTipoD.Text = "Tipo de documento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(28, 90);
            label1.Name = "label1";
            label1.Size = new Size(190, 18);
            label1.TabIndex = 20;
            label1.Text = "Número de postulante";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.DarkSeaGreen;
            btnPagar.Cursor = Cursors.Hand;
            btnPagar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.Location = new Point(223, 300);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(163, 52);
            btnPagar.TabIndex = 21;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.LightSteelBlue;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(685, 399);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(103, 39);
            btnVolver.TabIndex = 22;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnPagar);
            Controls.Add(label1);
            Controls.Add(cboTipo);
            Controls.Add(lblDocumento);
            Controls.Add(txtDocumento);
            Controls.Add(lblTipoD);
            Controls.Add(groupBox1);
            Controls.Add(txtNro);
            Name = "frmPagar";
            Text = "frmPagar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNro;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton optEfvo;
        private ComboBox cboTipo;
        private Label lblDocumento;
        private TextBox txtDocumento;
        private Label lblTipoD;
        private RadioButton btnTarjeta;
        private Label label1;
        private Button btnPagar;
        private Button btnVolver;
    }
}