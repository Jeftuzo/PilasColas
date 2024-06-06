namespace Desktop
{
    partial class FrmArreglosColas
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
            btnIniciar = new Button();
            txtDatos = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnObtenerDatos = new Button();
            label1 = new Label();
            txtAgregar = new TextBox();
            label2 = new Label();
            txtElementos = new TextBox();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(240, 52);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtDatos
            // 
            txtDatos.BackColor = SystemColors.Control;
            txtDatos.Location = new Point(349, 14);
            txtDatos.Margin = new Padding(3, 2, 3, 2);
            txtDatos.Multiline = true;
            txtDatos.Name = "txtDatos";
            txtDatos.ReadOnly = true;
            txtDatos.ScrollBars = ScrollBars.Vertical;
            txtDatos.Size = new Size(341, 158);
            txtDatos.TabIndex = 3;
            txtDatos.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(240, 80);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(23, 136);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnObtenerDatos
            // 
            btnObtenerDatos.Location = new Point(23, 191);
            btnObtenerDatos.Name = "btnObtenerDatos";
            btnObtenerDatos.Size = new Size(75, 23);
            btnObtenerDatos.TabIndex = 5;
            btnObtenerDatos.Text = "Obtener";
            btnObtenerDatos.UseVisualStyleBackColor = true;
            btnObtenerDatos.Click += btnObtenerDatos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 84);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "Dato a agregar";
            // 
            // txtAgregar
            // 
            txtAgregar.Location = new Point(133, 81);
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(100, 23);
            txtAgregar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(189, 15);
            label2.TabIndex = 6;
            label2.Text = "Introduce el número de elementos";
            // 
            // txtElementos
            // 
            txtElementos.Location = new Point(207, 23);
            txtElementos.Name = "txtElementos";
            txtElementos.Size = new Size(133, 23);
            txtElementos.TabIndex = 0;
            // 
            // FrmArreglosColas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtElementos);
            Controls.Add(label2);
            Controls.Add(txtAgregar);
            Controls.Add(label1);
            Controls.Add(txtDatos);
            Controls.Add(btnObtenerDatos);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnIniciar);
            Name = "FrmArreglosColas";
            Text = "FrmArreglosColas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private TextBox txtDatos;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnObtenerDatos;
        private Label label1;
        private TextBox txtAgregar;
        private Label label2;
        private TextBox txtElementos;
    }
}