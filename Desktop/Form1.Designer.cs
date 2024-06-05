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
            btnArreglos = new Button();
            btnListas = new Button();
            SuspendLayout();
            // 
            // btnArreglos
            // 
            btnArreglos.Location = new Point(52, 40);
            btnArreglos.Margin = new Padding(3, 2, 3, 2);
            btnArreglos.Name = "btnArreglos";
            btnArreglos.Size = new Size(82, 22);
            btnArreglos.TabIndex = 0;
            btnArreglos.Text = "Arreglos";
            btnArreglos.UseVisualStyleBackColor = true;
            btnArreglos.Click += btnArreglos_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnListas);
            Controls.Add(btnArreglos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnArreglos;
        private Button btnListas;
    }
}