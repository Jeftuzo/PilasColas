namespace Desktop
{
    partial class Form1
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
            btnArreglosPilas = new Button();
            btnListas = new Button();
            btnArreglosColas = new Button();
            SuspendLayout();
            // 
            // btnArreglosPilas
            // 
            btnArreglosPilas.Location = new Point(52, 40);
            btnArreglosPilas.Margin = new Padding(3, 2, 3, 2);
            btnArreglosPilas.Name = "btnArreglosPilas";
            btnArreglosPilas.Size = new Size(92, 30);
            btnArreglosPilas.TabIndex = 0;
            btnArreglosPilas.Text = "ArreglosPilas";
            btnArreglosPilas.UseVisualStyleBackColor = true;
            btnArreglosPilas.Click += btnArreglosPilas_Click;
            // 
            // btnListas
            // 
            btnListas.Location = new Point(52, 92);
            btnListas.Margin = new Padding(3, 2, 3, 2);
            btnListas.Name = "btnListas";
            btnListas.Size = new Size(82, 22);
            btnListas.TabIndex = 0;
            btnListas.Text = "Listas";
            btnListas.UseVisualStyleBackColor = true;
            // 
            // btnArreglosColas
            // 
            btnArreglosColas.Location = new Point(171, 40);
            btnArreglosColas.Margin = new Padding(3, 2, 3, 2);
            btnArreglosColas.Name = "btnArreglosColas";
            btnArreglosColas.Size = new Size(94, 30);
            btnArreglosColas.TabIndex = 0;
            btnArreglosColas.Text = "ArreglosColas";
            btnArreglosColas.UseVisualStyleBackColor = true;
            btnArreglosColas.Click += btnArreglosColas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnListas);
            Controls.Add(btnArreglosColas);
            Controls.Add(btnArreglosPilas);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnArreglosPilas;
        private Button btnListas;
        private Button btnArreglosColas;
    }
}