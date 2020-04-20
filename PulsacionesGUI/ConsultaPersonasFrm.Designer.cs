namespace PulsacionesGUI
{
    partial class ConsultaPersonasFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPersonasFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.Edadtxt = new System.Windows.Forms.TextBox();
            this.sexotxt = new System.Windows.Forms.TextBox();
            this.Pulsacionestxt = new System.Windows.Forms.TextBox();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pulsaciones";
            // 
            // Idtxt
            // 
            this.Idtxt.Location = new System.Drawing.Point(131, 31);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(100, 20);
            this.Idtxt.TabIndex = 5;
            // 
            // Nombretxt
            // 
            this.Nombretxt.Enabled = false;
            this.Nombretxt.Location = new System.Drawing.Point(131, 67);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(100, 20);
            this.Nombretxt.TabIndex = 6;
            // 
            // Edadtxt
            // 
            this.Edadtxt.Enabled = false;
            this.Edadtxt.Location = new System.Drawing.Point(131, 103);
            this.Edadtxt.Name = "Edadtxt";
            this.Edadtxt.Size = new System.Drawing.Size(100, 20);
            this.Edadtxt.TabIndex = 7;
            // 
            // sexotxt
            // 
            this.sexotxt.Enabled = false;
            this.sexotxt.Location = new System.Drawing.Point(131, 139);
            this.sexotxt.Name = "sexotxt";
            this.sexotxt.Size = new System.Drawing.Size(100, 20);
            this.sexotxt.TabIndex = 8;
            // 
            // Pulsacionestxt
            // 
            this.Pulsacionestxt.Enabled = false;
            this.Pulsacionestxt.Location = new System.Drawing.Point(131, 175);
            this.Pulsacionestxt.Name = "Pulsacionestxt";
            this.Pulsacionestxt.Size = new System.Drawing.Size(100, 20);
            this.Pulsacionestxt.TabIndex = 9;
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.Image = ((System.Drawing.Image)(resources.GetObject("ConsultarBtn.Image")));
            this.ConsultarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConsultarBtn.Location = new System.Drawing.Point(27, 232);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(75, 53);
            this.ConsultarBtn.TabIndex = 10;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            this.ConsultarBtn.Click += new System.EventHandler(this.ConsultarBtn_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(156, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaPersonasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConsultarBtn);
            this.Controls.Add(this.Pulsacionestxt);
            this.Controls.Add(this.sexotxt);
            this.Controls.Add(this.Edadtxt);
            this.Controls.Add(this.Nombretxt);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaPersonasFrm";
            this.Text = "ConsultaPersonasFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.TextBox Edadtxt;
        private System.Windows.Forms.TextBox sexotxt;
        private System.Windows.Forms.TextBox Pulsacionestxt;
        private System.Windows.Forms.Button ConsultarBtn;
        private System.Windows.Forms.Button button1;
    }
}