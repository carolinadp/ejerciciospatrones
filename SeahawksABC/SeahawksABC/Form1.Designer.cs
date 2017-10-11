namespace SeahawksABC
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.college = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.statusMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Universidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Posición";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Edad";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(84, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(222, 20);
            this.name.TabIndex = 6;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(84, 38);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(222, 20);
            this.lastName.TabIndex = 7;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(84, 64);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(222, 20);
            this.number.TabIndex = 8;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // college
            // 
            this.college.Location = new System.Drawing.Point(84, 90);
            this.college.Name = "college";
            this.college.Size = new System.Drawing.Size(222, 20);
            this.college.TabIndex = 9;
            this.college.TextChanged += new System.EventHandler(this.college_TextChanged);
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(84, 117);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(222, 20);
            this.position.TabIndex = 10;
            this.position.TextChanged += new System.EventHandler(this.position_TextChanged);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(84, 144);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(222, 20);
            this.age.TabIndex = 11;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(231, 170);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 12;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // statusMessage
            // 
            this.statusMessage.AutoSize = true;
            this.statusMessage.Location = new System.Drawing.Point(18, 177);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(35, 13);
            this.statusMessage.TabIndex = 13;
            this.statusMessage.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 202);
            this.Controls.Add(this.statusMessage);
            this.Controls.Add(this.save);
            this.Controls.Add(this.age);
            this.Controls.Add(this.position);
            this.Controls.Add(this.college);
            this.Controls.Add(this.number);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox college;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label statusMessage;
    }
}

