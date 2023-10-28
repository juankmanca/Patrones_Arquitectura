namespace Patrones
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBaseDatos = new System.Windows.Forms.Button();
            this.btnSingleton = new System.Windows.Forms.Button();
            this.btnPrototipo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAbstractFactory = new System.Windows.Forms.Button();
            this.btnFactoryMethod = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBaseDatos);
            this.groupBox1.Controls.Add(this.btnSingleton);
            this.groupBox1.Controls.Add(this.btnPrototipo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAbstractFactory);
            this.groupBox1.Controls.Add(this.btnFactoryMethod);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patrones creacionales";
            // 
            // btnBaseDatos
            // 
            this.btnBaseDatos.BackColor = System.Drawing.Color.Navy;
            this.btnBaseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaseDatos.ForeColor = System.Drawing.Color.White;
            this.btnBaseDatos.Location = new System.Drawing.Point(519, 93);
            this.btnBaseDatos.Name = "btnBaseDatos";
            this.btnBaseDatos.Size = new System.Drawing.Size(179, 62);
            this.btnBaseDatos.TabIndex = 5;
            this.btnBaseDatos.Text = "BASE DATOS";
            this.btnBaseDatos.UseVisualStyleBackColor = false;
            this.btnBaseDatos.Click += new System.EventHandler(this.btnBaseDatos_Click);
            // 
            // btnSingleton
            // 
            this.btnSingleton.BackColor = System.Drawing.Color.Navy;
            this.btnSingleton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleton.ForeColor = System.Drawing.Color.White;
            this.btnSingleton.Location = new System.Drawing.Point(263, 93);
            this.btnSingleton.Name = "btnSingleton";
            this.btnSingleton.Size = new System.Drawing.Size(179, 62);
            this.btnSingleton.TabIndex = 4;
            this.btnSingleton.Text = "SINGLETON";
            this.btnSingleton.UseVisualStyleBackColor = false;
            // 
            // btnPrototipo
            // 
            this.btnPrototipo.BackColor = System.Drawing.Color.Navy;
            this.btnPrototipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrototipo.ForeColor = System.Drawing.Color.White;
            this.btnPrototipo.Location = new System.Drawing.Point(32, 93);
            this.btnPrototipo.Name = "btnPrototipo";
            this.btnPrototipo.Size = new System.Drawing.Size(179, 62);
            this.btnPrototipo.TabIndex = 3;
            this.btnPrototipo.Text = "PROTOTYPE";
            this.btnPrototipo.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(519, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "BUILDER";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAbstractFactory
            // 
            this.btnAbstractFactory.BackColor = System.Drawing.Color.Navy;
            this.btnAbstractFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbstractFactory.ForeColor = System.Drawing.Color.White;
            this.btnAbstractFactory.Location = new System.Drawing.Point(263, 25);
            this.btnAbstractFactory.Name = "btnAbstractFactory";
            this.btnAbstractFactory.Size = new System.Drawing.Size(179, 62);
            this.btnAbstractFactory.TabIndex = 1;
            this.btnAbstractFactory.Text = "ABSTRACT FACTORY";
            this.btnAbstractFactory.UseVisualStyleBackColor = false;
            this.btnAbstractFactory.Click += new System.EventHandler(this.btnAbstractFactory_Click);
            // 
            // btnFactoryMethod
            // 
            this.btnFactoryMethod.BackColor = System.Drawing.Color.Navy;
            this.btnFactoryMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactoryMethod.ForeColor = System.Drawing.Color.White;
            this.btnFactoryMethod.Location = new System.Drawing.Point(32, 25);
            this.btnFactoryMethod.Name = "btnFactoryMethod";
            this.btnFactoryMethod.Size = new System.Drawing.Size(179, 62);
            this.btnFactoryMethod.TabIndex = 0;
            this.btnFactoryMethod.Text = "FACTORY METHOD";
            this.btnFactoryMethod.UseVisualStyleBackColor = false;
            this.btnFactoryMethod.Click += new System.EventHandler(this.btnFactoryMethod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 478);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBaseDatos;
        private System.Windows.Forms.Button btnSingleton;
        private System.Windows.Forms.Button btnPrototipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAbstractFactory;
        private System.Windows.Forms.Button btnFactoryMethod;
    }
}

