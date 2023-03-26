namespace Vistas
{
    partial class Loginform
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelabtn = new System.Windows.Forms.Button();
            this.acepbtn = new System.Windows.Forms.Button();
            this.contrasentxt = new System.Windows.Forms.TextBox();
            this.usuaritxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(438, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 30);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // cancelabtn
            // 
            this.cancelabtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelabtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelabtn.Location = new System.Drawing.Point(306, 202);
            this.cancelabtn.Name = "cancelabtn";
            this.cancelabtn.Size = new System.Drawing.Size(126, 40);
            this.cancelabtn.TabIndex = 13;
            this.cancelabtn.Text = "Cancelar";
            this.cancelabtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelabtn.UseVisualStyleBackColor = true;
            this.cancelabtn.Click += new System.EventHandler(this.cancelabtn_Click);
            // 
            // acepbtn
            // 
            this.acepbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acepbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.acepbtn.Location = new System.Drawing.Point(166, 201);
            this.acepbtn.Name = "acepbtn";
            this.acepbtn.Size = new System.Drawing.Size(134, 40);
            this.acepbtn.TabIndex = 12;
            this.acepbtn.Text = "Aceptar";
            this.acepbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acepbtn.UseVisualStyleBackColor = true;
            this.acepbtn.Click += new System.EventHandler(this.acepbtn_Click);
            // 
            // contrasentxt
            // 
            this.contrasentxt.Location = new System.Drawing.Point(166, 121);
            this.contrasentxt.Name = "contrasentxt";
            this.contrasentxt.PasswordChar = '*';
            this.contrasentxt.Size = new System.Drawing.Size(266, 22);
            this.contrasentxt.TabIndex = 11;
            // 
            // usuaritxt
            // 
            this.usuaritxt.Location = new System.Drawing.Point(166, 63);
            this.usuaritxt.Name = "usuaritxt";
            this.usuaritxt.Size = new System.Drawing.Size(266, 22);
            this.usuaritxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(656, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelabtn);
            this.Controls.Add(this.acepbtn);
            this.Controls.Add(this.contrasentxt);
            this.Controls.Add(this.usuaritxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancelabtn;
        private System.Windows.Forms.Button acepbtn;
        private System.Windows.Forms.TextBox contrasentxt;
        private System.Windows.Forms.TextBox usuaritxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

