namespace Heladeria_Sln
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnCrema = new System.Windows.Forms.RadioButton();
            this.rbtnChocolate = new System.Windows.Forms.RadioButton();
            this.rbtnFresa = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.chkCaramelo = new System.Windows.Forms.CheckBox();
            this.chkMani = new System.Windows.Forms.CheckBox();
            this.chkOreo = new System.Windows.Forms.CheckBox();
            this.imgLista = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFresa);
            this.groupBox1.Controls.Add(this.rbtnChocolate);
            this.groupBox1.Controls.Add(this.rbtnCrema);
            this.groupBox1.Location = new System.Drawing.Point(26, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(200, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Helado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkOreo);
            this.groupBox2.Controls.Add(this.chkMani);
            this.groupBox2.Controls.Add(this.chkCaramelo);
            this.groupBox2.Location = new System.Drawing.Point(267, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(193, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Topping";
            // 
            // rbtnCrema
            // 
            this.rbtnCrema.AutoSize = true;
            this.rbtnCrema.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbtnCrema.ImageIndex = 2;
            this.rbtnCrema.ImageList = this.imgLista;
            this.rbtnCrema.Location = new System.Drawing.Point(42, 34);
            this.rbtnCrema.Name = "rbtnCrema";
            this.rbtnCrema.Size = new System.Drawing.Size(105, 32);
            this.rbtnCrema.TabIndex = 0;
            this.rbtnCrema.TabStop = true;
            this.rbtnCrema.Text = "Crema";
            this.rbtnCrema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnCrema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtnCrema.UseVisualStyleBackColor = true;
            // 
            // rbtnChocolate
            // 
            this.rbtnChocolate.AutoSize = true;
            this.rbtnChocolate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtnChocolate.ImageIndex = 1;
            this.rbtnChocolate.ImageList = this.imgLista;
            this.rbtnChocolate.Location = new System.Drawing.Point(42, 94);
            this.rbtnChocolate.Name = "rbtnChocolate";
            this.rbtnChocolate.Size = new System.Drawing.Size(126, 32);
            this.rbtnChocolate.TabIndex = 1;
            this.rbtnChocolate.TabStop = true;
            this.rbtnChocolate.Text = "Chocolate";
            this.rbtnChocolate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtnChocolate.UseVisualStyleBackColor = true;
            // 
            // rbtnFresa
            // 
            this.rbtnFresa.AutoSize = true;
            this.rbtnFresa.ImageIndex = 3;
            this.rbtnFresa.ImageList = this.imgLista;
            this.rbtnFresa.Location = new System.Drawing.Point(42, 157);
            this.rbtnFresa.Name = "rbtnFresa";
            this.rbtnFresa.Size = new System.Drawing.Size(98, 32);
            this.rbtnFresa.TabIndex = 2;
            this.rbtnFresa.TabStop = true;
            this.rbtnFresa.Text = "Fresa";
            this.rbtnFresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtnFresa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear Orden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(334, 305);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(126, 26);
            this.txtTotal.TabIndex = 4;
            // 
            // chkCaramelo
            // 
            this.chkCaramelo.AutoSize = true;
            this.chkCaramelo.ImageIndex = 0;
            this.chkCaramelo.ImageList = this.imgLista;
            this.chkCaramelo.Location = new System.Drawing.Point(38, 40);
            this.chkCaramelo.Name = "chkCaramelo";
            this.chkCaramelo.Size = new System.Drawing.Size(126, 32);
            this.chkCaramelo.TabIndex = 0;
            this.chkCaramelo.Text = "Caramelo";
            this.chkCaramelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkCaramelo.UseVisualStyleBackColor = true;
            // 
            // chkMani
            // 
            this.chkMani.AutoSize = true;
            this.chkMani.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMani.ImageIndex = 4;
            this.chkMani.ImageList = this.imgLista;
            this.chkMani.Location = new System.Drawing.Point(38, 100);
            this.chkMani.Name = "chkMani";
            this.chkMani.Size = new System.Drawing.Size(95, 32);
            this.chkMani.TabIndex = 1;
            this.chkMani.Text = "Maní";
            this.chkMani.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkMani.UseVisualStyleBackColor = true;
            // 
            // chkOreo
            // 
            this.chkOreo.AutoSize = true;
            this.chkOreo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkOreo.ImageIndex = 5;
            this.chkOreo.ImageList = this.imgLista;
            this.chkOreo.Location = new System.Drawing.Point(39, 157);
            this.chkOreo.Name = "chkOreo";
            this.chkOreo.Size = new System.Drawing.Size(94, 32);
            this.chkOreo.TabIndex = 2;
            this.chkOreo.Text = "Oreo";
            this.chkOreo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkOreo.UseVisualStyleBackColor = true;
            // 
            // imgLista
            // 
            this.imgLista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLista.ImageStream")));
            this.imgLista.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLista.Images.SetKeyName(0, "caramelo.jpg");
            this.imgLista.Images.SetKeyName(1, "choco.jpg");
            this.imgLista.Images.SetKeyName(2, "crema.jpg");
            this.imgLista.Images.SetKeyName(3, "fresa.jpg");
            this.imgLista.Images.SetKeyName(4, "mani.jpg");
            this.imgLista.Images.SetKeyName(5, "Oreo.jpg");
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 372);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heladeria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnFresa;
        private System.Windows.Forms.RadioButton rbtnChocolate;
        private System.Windows.Forms.RadioButton rbtnCrema;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.CheckBox chkOreo;
        private System.Windows.Forms.CheckBox chkMani;
        private System.Windows.Forms.CheckBox chkCaramelo;
        private System.Windows.Forms.ImageList imgLista;
    }
}

