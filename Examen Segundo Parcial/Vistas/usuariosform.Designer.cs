namespace Vistas
{
    partial class usuariosform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuariosform));
            this.modificarbtn = new System.Windows.Forms.Button();
            this.guardarbtn = new System.Windows.Forms.Button();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.cancelrabtn = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.adjuntarimagensbtn = new System.Windows.Forms.Button();
            this.fotopictureBox2 = new System.Windows.Forms.PictureBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.contrasenatxt = new System.Windows.Forms.TextBox();
            this.correotxt = new System.Windows.Forms.TextBox();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fotopictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // modificarbtn
            // 
            this.modificarbtn.Location = new System.Drawing.Point(233, 267);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(75, 23);
            this.modificarbtn.TabIndex = 33;
            this.modificarbtn.Text = "Modificar";
            this.modificarbtn.UseVisualStyleBackColor = true;
            this.modificarbtn.Click += new System.EventHandler(this.modificarbtn_Click_1);
            // 
            // guardarbtn
            // 
            this.guardarbtn.Location = new System.Drawing.Point(326, 267);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(75, 23);
            this.guardarbtn.TabIndex = 34;
            this.guardarbtn.Text = "Guardar";
            this.guardarbtn.UseVisualStyleBackColor = true;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click_1);
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.Location = new System.Drawing.Point(411, 267);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarbtn.TabIndex = 35;
            this.eliminarbtn.Text = "Eliminar";
            this.eliminarbtn.UseVisualStyleBackColor = true;
            this.eliminarbtn.Click += new System.EventHandler(this.eliminarbtn_Click);
            // 
            // cancelrabtn
            // 
            this.cancelrabtn.Enabled = false;
            this.cancelrabtn.Location = new System.Drawing.Point(503, 267);
            this.cancelrabtn.Name = "cancelrabtn";
            this.cancelrabtn.Size = new System.Drawing.Size(75, 23);
            this.cancelrabtn.TabIndex = 36;
            this.cancelrabtn.Text = "Cancelar";
            this.cancelrabtn.UseVisualStyleBackColor = true;
            this.cancelrabtn.Click += new System.EventHandler(this.cancelrabtn_Click_1);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(139, 267);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 31;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // adjuntarimagensbtn
            // 
            this.adjuntarimagensbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adjuntarimagensbtn.Enabled = false;
            this.adjuntarimagensbtn.Image = ((System.Drawing.Image)(resources.GetObject("adjuntarimagensbtn.Image")));
            this.adjuntarimagensbtn.Location = new System.Drawing.Point(610, 123);
            this.adjuntarimagensbtn.Name = "adjuntarimagensbtn";
            this.adjuntarimagensbtn.Size = new System.Drawing.Size(45, 53);
            this.adjuntarimagensbtn.TabIndex = 30;
            this.adjuntarimagensbtn.Text = "...";
            this.adjuntarimagensbtn.UseVisualStyleBackColor = true;
            // 
            // fotopictureBox2
            // 
            this.fotopictureBox2.BackColor = System.Drawing.Color.White;
            this.fotopictureBox2.Location = new System.Drawing.Point(453, 36);
            this.fotopictureBox2.Name = "fotopictureBox2";
            this.fotopictureBox2.Size = new System.Drawing.Size(161, 140);
            this.fotopictureBox2.TabIndex = 32;
            this.fotopictureBox2.TabStop = false;
            // 
            // nombretxt
            // 
            this.nombretxt.Enabled = false;
            this.nombretxt.Location = new System.Drawing.Point(180, 70);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(221, 22);
            this.nombretxt.TabIndex = 21;
            // 
            // contrasenatxt
            // 
            this.contrasenatxt.Enabled = false;
            this.contrasenatxt.Location = new System.Drawing.Point(180, 105);
            this.contrasenatxt.Name = "contrasenatxt";
            this.contrasenatxt.Size = new System.Drawing.Size(221, 22);
            this.contrasenatxt.TabIndex = 23;
            // 
            // correotxt
            // 
            this.correotxt.Enabled = false;
            this.correotxt.Location = new System.Drawing.Point(180, 142);
            this.correotxt.Name = "correotxt";
            this.correotxt.Size = new System.Drawing.Size(221, 22);
            this.correotxt.TabIndex = 25;
            // 
            // codigotxt
            // 
            this.codigotxt.Enabled = false;
            this.codigotxt.Location = new System.Drawing.Point(180, 36);
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(221, 22);
            this.codigotxt.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Contrasena";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "codigo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-11, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 150);
            this.dataGridView1.TabIndex = 37;
            // 
            // usuariosform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.modificarbtn);
            this.Controls.Add(this.guardarbtn);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.cancelrabtn);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.adjuntarimagensbtn);
            this.Controls.Add(this.fotopictureBox2);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.contrasenatxt);
            this.Controls.Add(this.correotxt);
            this.Controls.Add(this.codigotxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "usuariosform";
            this.Text = "usuariosform";
            ((System.ComponentModel.ISupportInitialize)(this.fotopictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modificarbtn;
        private System.Windows.Forms.Button guardarbtn;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.Button cancelrabtn;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button adjuntarimagensbtn;
        private System.Windows.Forms.PictureBox fotopictureBox2;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox contrasenatxt;
        private System.Windows.Forms.TextBox correotxt;
        private System.Windows.Forms.TextBox codigotxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}