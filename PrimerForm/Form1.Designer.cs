namespace PrimerForm
{
    partial class frmPrimerProyecto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnCuadro = new Button();
            btnTexto = new Button();
            btnDesdeTxtACuadro = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(260, 135);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(109, 31);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtNombre.Location = new Point(433, 139);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(266, 20);
            txtNombre.TabIndex = 1;
            // 
            // btnCuadro
            // 
            btnCuadro.Location = new Point(462, 219);
            btnCuadro.Name = "btnCuadro";
            btnCuadro.Size = new Size(221, 63);
            btnCuadro.TabIndex = 2;
            btnCuadro.Text = "Cuadro de Diálogo";
            btnCuadro.UseVisualStyleBackColor = true;
            btnCuadro.Click += btnCuadro_Click;
            // 
            // btnTexto
            // 
            btnTexto.Location = new Point(932, 198);
            btnTexto.Name = "btnTexto";
            btnTexto.Size = new Size(195, 62);
            btnTexto.TabIndex = 3;
            btnTexto.Text = "Cuadro Con Texto";
            btnTexto.UseVisualStyleBackColor = true;
            btnTexto.Click += btnTexto_Click;
            // 
            // btnDesdeTxtACuadro
            // 
            btnDesdeTxtACuadro.Location = new Point(716, 423);
            btnDesdeTxtACuadro.Name = "btnDesdeTxtACuadro";
            btnDesdeTxtACuadro.Size = new Size(322, 62);
            btnDesdeTxtACuadro.TabIndex = 4;
            btnDesdeTxtACuadro.Text = "Desde txt a cuadro";
            btnDesdeTxtACuadro.UseVisualStyleBackColor = true;
            btnDesdeTxtACuadro.Click += btnDesdeTxtACuadro_Click;
            // 
            // frmPrimerProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1414, 609);
            Controls.Add(btnDesdeTxtACuadro);
            Controls.Add(btnTexto);
            Controls.Add(btnCuadro);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "frmPrimerProyecto";
            Text = "Primer Proyecto";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnCuadro;
        private Button btnTexto;
        private Button btnDesdeTxtACuadro;
    }
}
