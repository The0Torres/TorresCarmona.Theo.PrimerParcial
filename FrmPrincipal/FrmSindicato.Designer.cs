namespace FrmPrincipal
{
    partial class FrmSindicato
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
            lstSindicato = new ListBox();
            label1 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnOrdenar = new Button();
            SuspendLayout();
            // 
            // lstSindicato
            // 
            lstSindicato.FormattingEnabled = true;
            lstSindicato.ItemHeight = 15;
            lstSindicato.Location = new Point(46, 38);
            lstSindicato.Name = "lstSindicato";
            lstSindicato.Size = new Size(701, 334);
            lstSindicato.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 1;
            label1.Text = "Trabajadores:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ButtonFace;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(46, 402);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 36);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ButtonFace;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(247, 402);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(99, 36);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ButtonFace;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(447, 401);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 36);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = SystemColors.Desktop;
            btnOrdenar.FlatStyle = FlatStyle.Popup;
            btnOrdenar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrdenar.ForeColor = SystemColors.ControlLightLight;
            btnOrdenar.Location = new Point(645, 401);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(102, 36);
            btnOrdenar.TabIndex = 5;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // FrmSindicato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOrdenar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(lstSindicato);
            Name = "FrmSindicato";
            Text = "Sindicato";
            FormClosing += FrmSindicato_FormClosing;
            Load += FrmSindicato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSindicato;
        private Label label1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnOrdenar;
    }
}