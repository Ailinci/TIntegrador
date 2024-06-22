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
            btnComprobante = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            optEfvo = new RadioButton();
            btnVolver = new Button();
            cboTipo = new ComboBox();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            lblTipoD = new Label();
            btnPagar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNro
            // 
            txtNro.Location = new Point(191, 87);
            txtNro.Name = "txtNro";
            txtNro.Size = new Size(100, 23);
            txtNro.TabIndex = 0;
            // 
            // btnComprobante
            // 
            btnComprobante.Location = new Point(310, 301);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(75, 23);
            btnComprobante.TabIndex = 1;
            btnComprobante.Text = "btnComprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(optEfvo);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(492, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(16, 54);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.ForeColor = SystemColors.ButtonFace;
            optEfvo.Location = new Point(16, 29);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new Size(94, 19);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "radioButton1";
            optEfvo.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(609, 342);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "button1";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
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
            // btnPagar
            // 
            btnPagar.Location = new Point(153, 301);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 23);
            btnPagar.TabIndex = 19;
            btnPagar.Text = "btnPagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPagar);
            Controls.Add(cboTipo);
            Controls.Add(lblDocumento);
            Controls.Add(txtDocumento);
            Controls.Add(lblTipoD);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            Controls.Add(btnComprobante);
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
        private Button btnComprobante;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton optEfvo;
        private Button btnVolver;
        private ComboBox cboTipo;
        private Label lblDocumento;
        private TextBox txtDocumento;
        private Label lblTipoD;
        private Button btnPagar;
    }
}