namespace Desktop
{
    partial class FrmArreglosPilas
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
            label1 = new Label();
            txtElementos = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnObtenerDatos = new Button();
            txtAgregar = new TextBox();
            txtDatos = new TextBox();
            btnIniciar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(189, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduce el numero de elementos";
            // 
            // txtElementos
            // 
            txtElementos.Location = new Point(223, 14);
            txtElementos.Margin = new Padding(3, 2, 3, 2);
            txtElementos.Name = "txtElementos";
            txtElementos.Size = new Size(110, 23);
            txtElementos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(236, 74);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(24, 106);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnObtenerDatos
            // 
            btnObtenerDatos.Location = new Point(24, 140);
            btnObtenerDatos.Margin = new Padding(3, 2, 3, 2);
            btnObtenerDatos.Name = "btnObtenerDatos";
            btnObtenerDatos.Size = new Size(82, 22);
            btnObtenerDatos.TabIndex = 5;
            btnObtenerDatos.Text = "Obtener datos";
            btnObtenerDatos.UseVisualStyleBackColor = true;
            // 
            // txtAgregar
            // 
            txtAgregar.Location = new Point(122, 74);
            txtAgregar.Margin = new Padding(3, 2, 3, 2);
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(110, 23);
            txtAgregar.TabIndex = 2;
            // 
            // txtDatos
            // 
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
            // btnIniciar
            // 
            btnIniciar.Location = new Point(234, 38);
            btnIniciar.Margin = new Padding(3, 2, 3, 2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(82, 22);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 76);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 0;
            label2.Text = "Dato a agregar";
            // 
            // FrmArreglosPilas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtDatos);
            Controls.Add(btnObtenerDatos);
            Controls.Add(btnEliminar);
            Controls.Add(btnIniciar);
            Controls.Add(btnAgregar);
            Controls.Add(txtAgregar);
            Controls.Add(txtElementos);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmArreglosPilas";
            Text = "1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtElementos;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnObtenerDatos;
        private TextBox txtAgregar;
        private TextBox txtDatos;
        private Button btnIniciar;
        private Label label2;
    }
}