namespace Prueba_For
{
    partial class PruebaFor
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
            this.btArranque = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btArranque
            // 
            this.btArranque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btArranque.Location = new System.Drawing.Point(111, 12);
            this.btArranque.Name = "btArranque";
            this.btArranque.Size = new System.Drawing.Size(103, 33);
            this.btArranque.TabIndex = 0;
            this.btArranque.Text = "arranque";
            this.btArranque.UseVisualStyleBackColor = true;
            this.btArranque.Click += new System.EventHandler(this.btArranque_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Red;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(0, 58);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(24, 17);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "tbt";
            this.lbl.Visible = false;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(5, 22);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Posición incial";
            // 
            // PruebaFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 104);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btArranque);
            this.Name = "PruebaFor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btArranque;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label1;
    }
}

