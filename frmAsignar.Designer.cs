
namespace TIntegrador
{
    partial class frmAsignar
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            conexionBindingSource = new BindingSource(components);
            dtgvCurso = new DataGridView();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCurso).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = conexionBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(944, 496);
            dataGridView1.TabIndex = 0;
            // 
            // dtgvCurso
            // 
            dtgvCurso.BackgroundColor = SystemColors.ButtonFace;
            dtgvCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCurso.Location = new Point(12, 98);
            dtgvCurso.Name = "dtgvCurso";
            dtgvCurso.RowTemplate.Height = 25;
            dtgvCurso.Size = new Size(920, 300);
            dtgvCurso.TabIndex = 1;
            dtgvCurso.CellContentClick += dtgvCurso_CellContentClick;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.LightSteelBlue;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(831, 440);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 44);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmAsignar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 496);
            Controls.Add(btnVolver);
            Controls.Add(dtgvCurso);
            Controls.Add(dataGridView1);
            Name = "frmAsignar";
            Text = "FormAsignar";
            Load += frmAsignar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCurso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource conexionBindingSource;
        private System.Windows.Forms.DataGridView dtgvCurso;
        private Button btnVolver;
    }
}
