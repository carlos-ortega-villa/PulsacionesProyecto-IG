namespace PulsacionesGUI
{
    partial class ListadoConsultaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoConsultaForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TipoCmb = new System.Windows.Forms.ComboBox();
            this.Tipotxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Resultadotxt = new System.Windows.Forms.Label();
            this.Hombrestxt = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Todostxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mujerestxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(391, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // TipoCmb
            // 
            this.TipoCmb.FormattingEnabled = true;
            this.TipoCmb.Items.AddRange(new object[] {
            "Todos",
            "Masculino",
            "Femenino"});
            this.TipoCmb.Location = new System.Drawing.Point(93, 27);
            this.TipoCmb.Name = "TipoCmb";
            this.TipoCmb.Size = new System.Drawing.Size(139, 21);
            this.TipoCmb.TabIndex = 1;
            // 
            // Tipotxt
            // 
            this.Tipotxt.AutoSize = true;
            this.Tipotxt.Location = new System.Drawing.Point(35, 30);
            this.Tipotxt.Name = "Tipotxt";
            this.Tipotxt.Size = new System.Drawing.Size(33, 13);
            this.Tipotxt.TabIndex = 2;
            this.Tipotxt.Text = "Tipos";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(288, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(12, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Resultadotxt
            // 
            this.Resultadotxt.AutoSize = true;
            this.Resultadotxt.Location = new System.Drawing.Point(129, 95);
            this.Resultadotxt.Name = "Resultadotxt";
            this.Resultadotxt.Size = new System.Drawing.Size(60, 13);
            this.Resultadotxt.TabIndex = 5;
            this.Resultadotxt.Text = "Resultados";
            // 
            // Hombrestxt
            // 
            this.Hombrestxt.Enabled = false;
            this.Hombrestxt.Location = new System.Drawing.Point(123, 118);
            this.Hombrestxt.Name = "Hombrestxt";
            this.Hombrestxt.Size = new System.Drawing.Size(100, 20);
            this.Hombrestxt.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 121);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 13);
            this.label.TabIndex = 7;
            this.label.Text = "Hombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Personas";
            // 
            // Todostxt
            // 
            this.Todostxt.Enabled = false;
            this.Todostxt.Location = new System.Drawing.Point(123, 189);
            this.Todostxt.Name = "Todostxt";
            this.Todostxt.Size = new System.Drawing.Size(100, 20);
            this.Todostxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mujeres";
            // 
            // Mujerestxt
            // 
            this.Mujerestxt.Enabled = false;
            this.Mujerestxt.Location = new System.Drawing.Point(123, 155);
            this.Mujerestxt.Name = "Mujerestxt";
            this.Mujerestxt.Size = new System.Drawing.Size(100, 20);
            this.Mujerestxt.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 123);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // ListadoConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mujerestxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Todostxt);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Hombrestxt);
            this.Controls.Add(this.Resultadotxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tipotxt);
            this.Controls.Add(this.TipoCmb);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoConsultaForm";
            this.Text = "ListadoConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox TipoCmb;
        private System.Windows.Forms.Label Tipotxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Resultadotxt;
        private System.Windows.Forms.TextBox Hombrestxt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Todostxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Mujerestxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}