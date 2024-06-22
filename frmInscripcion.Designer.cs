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
            lblTipoD = new Label();
            lblDocumento = new Label();
            btnLimpiar = new Button();
            btnVolver = new Button();
            cboTipo = new ComboBox();
            txtDocumento = new TextBox();
            pictureBox1 = new PictureBox();
            btnHacerSocio = new Button();
            btnBuscarPos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPostular
            // 
            btnPostular.BackColor = Color.DarkSeaGreen;
            btnPostular.Cursor = Cursors.Hand;
            btnPostular.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPostular.Location = new Point(13, 385);
            btnPostular.Name = "btnPostular";
            btnPostular.Size = new Size(163, 53);
            btnPostular.TabIndex = 0;
            btnPostular.Text = "Guardar";
            btnPostular.UseVisualStyleBackColor = false;
            btnPostular.Click += btnPostular_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = SystemColors.ButtonFace;
            lblName.Location = new Point(98, 41);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 18);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = SystemColors.ButtonFace;
            lblApellido.Location = new Point(98, 127);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(72, 18);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightSteelBlue;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Cursor = Cursors.Hand;
            txtNombre.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(182, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 27);
            txtNombre.TabIndex = 3; 
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.LightSteelBlue;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Cursor = Cursors.Hand;
            txtApellido.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(182, 125);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(225, 27);
            txtApellido.TabIndex = 4;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 9;
            // 
            // lblTipoD
            // 
            lblTipoD.AutoSize = true;
            lblTipoD.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoD.ForeColor = SystemColors.ButtonFace;
            lblTipoD.Location = new Point(7, 205);
            lblTipoD.Name = "lblTipoD";
            lblTipoD.Size = new Size(163, 18);
            lblTipoD.TabIndex = 7;
            lblTipoD.Text = "Tipo de documento";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.ForeColor = SystemColors.ButtonFace;
            lblDocumento.Location = new Point(69, 273);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(101, 18);
            lblDocumento.TabIndex = 10;
            lblDocumento.Text = "Documento";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightSteelBlue;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(650, 156);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(119, 33);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.LightSteelBlue;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(634, 385);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(145, 53);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click_2;
            // 
            // cboTipo
            // 
            cboTipo.BackColor = Color.LightSteelBlue;
            cboTipo.Cursor = Cursors.Hand;
            cboTipo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "PASAPORTE", "CUIL", "LIBRETA" });
            cboTipo.Location = new Point(182, 202);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(225, 26);
            cboTipo.TabIndex = 14;
            // 
            // txtDocumento
            // 
            txtDocumento.BackColor = Color.LightSteelBlue;
            txtDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtDocumento.Cursor = Cursors.Hand;
            txtDocumento.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.Location = new Point(182, 273);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(225, 27);
            txtDocumento.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.blob_removebg_preview;
            pictureBox1.Location = new Point(634, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnHacerSocio
            // 
            btnHacerSocio.BackColor = Color.DarkSeaGreen;
            btnHacerSocio.Cursor = Cursors.Hand;
            btnHacerSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHacerSocio.Location = new Point(422, 385);
            btnHacerSocio.Name = "btnHacerSocio";
            btnHacerSocio.Size = new Size(163, 53);
            btnHacerSocio.TabIndex = 16;
            btnHacerSocio.Text = "btnHacerSocio";
            btnHacerSocio.UseVisualStyleBackColor = false;
            btnHacerSocio.Click += btnHacerSocio_Click;
            // 
            // btnBuscarPos
            // 
            btnBuscarPos.Location = new Point(466, 205);
            btnBuscarPos.Name = "btnBuscarPos";
            btnBuscarPos.Size = new Size(101, 66);
            btnBuscarPos.TabIndex = 17;
            btnBuscarPos.Text = "buscar";
            btnBuscarPos.UseVisualStyleBackColor = true;
            btnBuscarPos.Click += btnBuscarPos_Click;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscarPos);
            Controls.Add(btnHacerSocio);
            Controls.Add(pictureBox1);
            Controls.Add(cboTipo);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(lblDocumento);
            Controls.Add(txtDocumento);
            Controls.Add(lblTipoD);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblName);
            Controls.Add(btnPostular);
            Name = "frmInscripcion";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHacerSocio;
        private Label lblName;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label3;
        private Label lblTipoD;
        private Label lblDocumento;
        private Button btnPostular;
        private Button btnLimpiar;
        private Button btnVolver;
        private ComboBox cboTipo;
        private TextBox txtDocumento;
        private PictureBox pictureBox1;
        private Button btnBuscarPos;
    }
}