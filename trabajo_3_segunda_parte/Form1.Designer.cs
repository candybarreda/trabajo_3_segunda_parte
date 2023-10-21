namespace trabajo_3_segunda_parte
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
            label1 = new Label();
            listView_1 = new ListView();
            columnHeader1 = new ColumnHeader();
            g_3_ingresar = new Button();
            g_3_eliminar = new Button();
            g_3_numeros = new TextBox();
            g_3_ascend = new Button();
            g_3_desendente = new Button();
            g_3_button_buscar = new Button();
            g_3_buscar = new TextBox();
            g_3_numelim = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 60);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Numeros:";
            // 
            // listView_1
            // 
            listView_1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView_1.Location = new Point(368, 60);
            listView_1.Name = "listView_1";
            listView_1.Size = new Size(204, 306);
            listView_1.TabIndex = 3;
            listView_1.UseCompatibleStateImageBehavior = false;
            listView_1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Numeros Ingresados";
            columnHeader1.Width = 200;
            // 
            // g_3_ingresar
            // 
            g_3_ingresar.Location = new Point(202, 123);
            g_3_ingresar.Name = "g_3_ingresar";
            g_3_ingresar.Size = new Size(125, 29);
            g_3_ingresar.TabIndex = 4;
            g_3_ingresar.Text = "Ingresar";
            g_3_ingresar.UseVisualStyleBackColor = true;
            g_3_ingresar.Click += g_3_ingresar_Click;
            // 
            // g_3_eliminar
            // 
            g_3_eliminar.Location = new Point(478, 380);
            g_3_eliminar.Name = "g_3_eliminar";
            g_3_eliminar.Size = new Size(94, 29);
            g_3_eliminar.TabIndex = 5;
            g_3_eliminar.Text = "Eliminar";
            g_3_eliminar.UseVisualStyleBackColor = true;
            g_3_eliminar.Click += g_3_eliminar_Click;
            // 
            // g_3_numeros
            // 
            g_3_numeros.Location = new Point(202, 60);
            g_3_numeros.Name = "g_3_numeros";
            g_3_numeros.Size = new Size(125, 27);
            g_3_numeros.TabIndex = 6;
            // 
            // g_3_ascend
            // 
            g_3_ascend.Location = new Point(202, 196);
            g_3_ascend.Name = "g_3_ascend";
            g_3_ascend.Size = new Size(125, 29);
            g_3_ascend.TabIndex = 7;
            g_3_ascend.Text = "Ascendente";
            g_3_ascend.UseVisualStyleBackColor = true;
            g_3_ascend.Click += g_3_ascend_Click;
            // 
            // g_3_desendente
            // 
            g_3_desendente.Location = new Point(202, 282);
            g_3_desendente.Name = "g_3_desendente";
            g_3_desendente.Size = new Size(125, 29);
            g_3_desendente.TabIndex = 8;
            g_3_desendente.Text = "Desendente";
            g_3_desendente.UseVisualStyleBackColor = true;
            g_3_desendente.Click += g_3_desendente_Click;
            // 
            // g_3_button_buscar
            // 
            g_3_button_buscar.Location = new Point(202, 378);
            g_3_button_buscar.Name = "g_3_button_buscar";
            g_3_button_buscar.Size = new Size(125, 29);
            g_3_button_buscar.TabIndex = 9;
            g_3_button_buscar.Text = "Buscar";
            g_3_button_buscar.UseVisualStyleBackColor = true;
            g_3_button_buscar.Click += g_3_button_buscar_Click;
            // 
            // g_3_buscar
            // 
            g_3_buscar.Location = new Point(31, 380);
            g_3_buscar.Name = "g_3_buscar";
            g_3_buscar.Size = new Size(159, 27);
            g_3_buscar.TabIndex = 11;
            // 
            // g_3_numelim
            // 
            g_3_numelim.Location = new Point(368, 382);
            g_3_numelim.Name = "g_3_numelim";
            g_3_numelim.Size = new Size(104, 27);
            g_3_numelim.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(g_3_numelim);
            Controls.Add(g_3_buscar);
            Controls.Add(g_3_button_buscar);
            Controls.Add(g_3_desendente);
            Controls.Add(g_3_ascend);
            Controls.Add(g_3_numeros);
            Controls.Add(g_3_eliminar);
            Controls.Add(g_3_ingresar);
            Controls.Add(listView_1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView_1;
        private Button g_3_ingresar;
        private Button g_3_eliminar;
        private TextBox g_3_numeros;
        private ColumnHeader columnHeader1;
        private Button g_3_ascend;
        private Button g_3_desendente;
        private Button g_3_button_buscar;
        private TextBox g_3_buscar;
        private TextBox g_3_numelim;
    }
}