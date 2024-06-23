namespace TIntegrador
{
    partial class frmListarSocios
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
            dtgvSocios = new DataGridView();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).BeginInit();
            SuspendLayout();
            // 
            // dtgvSocios
            // 
            dtgvSocios.BackgroundColor = SystemColors.ButtonFace;
            dtgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSocios.Location = new Point(12, 12);
            dtgvSocios.Name = "dtgvSocios";
            dtgvSocios.RowTemplate.Height = 25;
            dtgvSocios.Size = new Size(776, 272);
            dtgvSocios.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.LightSteelBlue;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(685, 399);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(103, 39);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmListarSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(dtgvSocios);
            Name = "frmListarSocios";
            Text = "frmListarSocios";
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvSocios;
        private Button btnVolver;
    }
}