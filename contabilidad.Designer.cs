
namespace El_Balcon_de_Chalita
{
    partial class contabilidad
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ingresos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.DgbIngresos = new System.Windows.Forms.DataGridView();
            this.idReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egresos = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEgresos = new System.Windows.Forms.TextBox();
            this.DgbEgresos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compañia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limpieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ganancias = new System.Windows.Forms.TabPage();
            this.txtGanancias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Ingresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbIngresos)).BeginInit();
            this.Egresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbEgresos)).BeginInit();
            this.Ganancias.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ingresos);
            this.tabControl1.Controls.Add(this.Egresos);
            this.tabControl1.Controls.Add(this.Ganancias);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // Ingresos
            // 
            this.Ingresos.Controls.Add(this.label1);
            this.Ingresos.Controls.Add(this.txtIngresos);
            this.Ingresos.Controls.Add(this.DgbIngresos);
            this.Ingresos.Location = new System.Drawing.Point(4, 22);
            this.Ingresos.Name = "Ingresos";
            this.Ingresos.Padding = new System.Windows.Forms.Padding(3);
            this.Ingresos.Size = new System.Drawing.Size(774, 411);
            this.Ingresos.TabIndex = 0;
            this.Ingresos.Text = "Ingresos";
            this.Ingresos.UseVisualStyleBackColor = true;
            this.Ingresos.Click += new System.EventHandler(this.Ingresos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresos Totales";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(296, 145);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(226, 20);
            this.txtIngresos.TabIndex = 1;
            // 
            // DgbIngresos
            // 
            this.DgbIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReservacion,
            this.Ingreso});
            this.DgbIngresos.Location = new System.Drawing.Point(15, 44);
            this.DgbIngresos.Name = "DgbIngresos";
            this.DgbIngresos.Size = new System.Drawing.Size(244, 121);
            this.DgbIngresos.TabIndex = 0;
            this.DgbIngresos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgbIngresos_CellContentClick);
            // 
            // idReservacion
            // 
            this.idReservacion.HeaderText = "IdReserva";
            this.idReservacion.Name = "idReservacion";
            // 
            // Ingreso
            // 
            this.Ingreso.HeaderText = "Ingreso de la Reserva";
            this.Ingreso.Name = "Ingreso";
            // 
            // Egresos
            // 
            this.Egresos.Controls.Add(this.label2);
            this.Egresos.Controls.Add(this.txtEgresos);
            this.Egresos.Controls.Add(this.DgbEgresos);
            this.Egresos.Location = new System.Drawing.Point(4, 22);
            this.Egresos.Name = "Egresos";
            this.Egresos.Padding = new System.Windows.Forms.Padding(3);
            this.Egresos.Size = new System.Drawing.Size(774, 411);
            this.Egresos.TabIndex = 1;
            this.Egresos.Text = "Egresos";
            this.Egresos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Egresos Totales";
            // 
            // txtEgresos
            // 
            this.txtEgresos.Location = new System.Drawing.Point(20, 280);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Size = new System.Drawing.Size(100, 20);
            this.txtEgresos.TabIndex = 1;
            // 
            // DgbEgresos
            // 
            this.DgbEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.compañia,
            this.porcentaje,
            this.Gasto,
            this.limpieza});
            this.DgbEgresos.Location = new System.Drawing.Point(20, 20);
            this.DgbEgresos.Name = "DgbEgresos";
            this.DgbEgresos.Size = new System.Drawing.Size(544, 150);
            this.DgbEgresos.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Id Reserva";
            this.id.Name = "id";
            // 
            // compañia
            // 
            this.compañia.HeaderText = "Compañia Afiliada";
            this.compañia.Name = "compañia";
            // 
            // porcentaje
            // 
            this.porcentaje.HeaderText = "Porcentaje de Ganancias de la Compañia";
            this.porcentaje.Name = "porcentaje";
            // 
            // Gasto
            // 
            this.Gasto.HeaderText = "Gasto";
            this.Gasto.Name = "Gasto";
            // 
            // limpieza
            // 
            this.limpieza.HeaderText = "Gastos de Limpieza";
            this.limpieza.Name = "limpieza";
            // 
            // Ganancias
            // 
            this.Ganancias.Controls.Add(this.txtGanancias);
            this.Ganancias.Controls.Add(this.label3);
            this.Ganancias.Location = new System.Drawing.Point(4, 22);
            this.Ganancias.Name = "Ganancias";
            this.Ganancias.Padding = new System.Windows.Forms.Padding(3);
            this.Ganancias.Size = new System.Drawing.Size(774, 411);
            this.Ganancias.TabIndex = 2;
            this.Ganancias.Text = "Ganancias";
            this.Ganancias.UseVisualStyleBackColor = true;
            // 
            // txtGanancias
            // 
            this.txtGanancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanancias.Location = new System.Drawing.Point(51, 95);
            this.txtGanancias.Name = "txtGanancias";
            this.txtGanancias.Size = new System.Drawing.Size(224, 38);
            this.txtGanancias.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ganancias Totales";
            // 
            // contabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "contabilidad";
            this.Text = "contabilidad";
            this.Load += new System.EventHandler(this.contabilidad_Load);
            this.tabControl1.ResumeLayout(false);
            this.Ingresos.ResumeLayout(false);
            this.Ingresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbIngresos)).EndInit();
            this.Egresos.ResumeLayout(false);
            this.Egresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbEgresos)).EndInit();
            this.Ganancias.ResumeLayout(false);
            this.Ganancias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ingresos;
        private System.Windows.Forms.TabPage Egresos;
        private System.Windows.Forms.TabPage Ganancias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.DataGridView DgbIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEgresos;
        private System.Windows.Forms.DataGridView DgbEgresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn compañia;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn limpieza;
        private System.Windows.Forms.TextBox txtGanancias;
        private System.Windows.Forms.Label label3;
    }
}