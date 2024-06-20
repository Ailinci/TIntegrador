namespace TIntegrador
{
    partial class frmInscripcion
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
            btnPostular = new Button();
            lblName = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label3 = new Label();
            cboTipo = new TextBox();
            lblTipoD = new Label();
            txtDocumento = new TextBox();
            lblDocumento = new Label();
            SuspendLayout();
            // 
            // btnPostular
            // 
            btnPostular.Location = new Point(202, 330);
            btnPostular.Name = "btnPostular";
            btnPostular.Size = new Size(156, 44);
            btnPostular.TabIndex = 0;
            btnPostular.Text = "button1";
            btnPostular.UseVisualStyleBackColor = true;
            btnPostular.Click += btnPostular_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(106, 79);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(106, 129);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(184, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(184, 126);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 9;
            // 
            // cboTipo
            // 
            cboTipo.Location = new Point(184, 181);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(100, 23);
            cboTipo.TabIndex = 6;
            // 
            // lblTipoD
            // 
            lblTipoD.AutoSize = true;
            lblTipoD.Location = new Point(106, 184);
            lblTipoD.Name = "lblTipoD";
            lblTipoD.Size = new Size(38, 15);
            lblTipoD.TabIndex = 7;
            lblTipoD.Text = "label4";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(184, 234);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 23);
            txtDocumento.TabIndex = 8;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(106, 242);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(38, 15);
            lblDocumento.TabIndex = 10;
            lblDocumento.Text = "label5";
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDocumento);
            Controls.Add(txtDocumento);
            Controls.Add(lblTipoD);
            Controls.Add(cboTipo);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblName);
            Controls.Add(btnPostular);
            Name = "frmInscripcion";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblName;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label3;
        private TextBox cboTipo;
        private Label lblTipoD;
        private TextBox txtDocumento;
        private Label lblDocumento;
        private Button btnPostular;
    }
}