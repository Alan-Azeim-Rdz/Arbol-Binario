namespace Arbol_Binario
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
            btnInsertar = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            txtValor = new TextBox();
            lstValores = new ListBox();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(112, 123);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(112, 198);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(112, 278);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(12, 63);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(285, 23);
            txtValor.TabIndex = 3;
            // 
            // lstValores
            // 
            lstValores.FormattingEnabled = true;
            lstValores.ItemHeight = 15;
            lstValores.Location = new Point(303, 12);
            lstValores.Name = "lstValores";
            lstValores.Size = new Size(485, 424);
            lstValores.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstValores);
            Controls.Add(txtValor);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnInsertar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertar;
        private Button btnBuscar;
        private Button btnEliminar;
        private TextBox txtValor;
        private ListBox lstValores;
    }
}
