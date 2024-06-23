namespace TIntegrador
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
            button1 = new Button();
            btnListarSocios = new Button();
            SuspendLayout();
            // 
            // btnInscribir
            // 
            btnInscribir.Cursor = Cursors.Hand;
            btnInscribir.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.Location = new Point(65, 74);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(210, 77);
            btnInscribir.TabIndex = 0;
            btnInscribir.Text = "Inscribir alumno";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += button1_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.LightSteelBlue;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(684, 395);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(104, 43);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(470, 74);
            button1.Name = "button1";
            button1.Size = new Size(210, 77);
            button1.TabIndex = 2;
            button1.Text = "Listar cursos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnListarSocios
            // 
            btnListarSocios.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListarSocios.Location = new Point(65, 243);
            btnListarSocios.Name = "btnListarSocios";
            btnListarSocios.Size = new Size(210, 77);
            btnListarSocios.TabIndex = 3;
            btnListarSocios.Text = "Listar socios";
            btnListarSocios.UseVisualStyleBackColor = true;
            btnListarSocios.Click += btnListarSocios_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListarSocios);
            Controls.Add(button1);
            Controls.Add(btnVolver);
            Controls.Add(btnInscribir);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInscribir;
        private Button btnVolver;
        private Button button1;
        private Button btnListarSocios;
    }
}