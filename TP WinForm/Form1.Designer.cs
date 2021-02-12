
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel1 = new WindowsFormsApp2.cancel();
            this.merci1 = new WindowsFormsApp2.merci();
            this.retirercarte1 = new WindowsFormsApp2.retirercarte();
            this.ticket1 = new WindowsFormsApp2.ticket();
            this.code1 = new WindowsFormsApp2.code();
            this.fuelChoice1 = new WindowsFormsApp2.fuelChoice();
            this.userControl11 = new WindowsFormsApp2.UserControl1();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Montant transaction 70.24 EUR";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(177, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 31);
            this.label3.TabIndex = 50;
            this.label3.Text = "Fuel choisie";
            this.label3.Visible = false;
            // 
            // cancel1
            // 
            this.cancel1.Location = new System.Drawing.Point(106, 214);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(261, 56);
            this.cancel1.TabIndex = 51;
            this.cancel1.Visible = false;
            // 
            // merci1
            // 
            this.merci1.BackColor = System.Drawing.Color.Transparent;
            this.merci1.Location = new System.Drawing.Point(-9, 12);
            this.merci1.Name = "merci1";
            this.merci1.Size = new System.Drawing.Size(506, 327);
            this.merci1.TabIndex = 8;
            this.merci1.Visible = false;
            // 
            // retirercarte1
            // 
            this.retirercarte1.BackColor = System.Drawing.Color.Transparent;
            this.retirercarte1.Location = new System.Drawing.Point(-9, 12);
            this.retirercarte1.Name = "retirercarte1";
            this.retirercarte1.Size = new System.Drawing.Size(472, 457);
            this.retirercarte1.TabIndex = 5;
            this.retirercarte1.Visible = false;
            // 
            // ticket1
            // 
            this.ticket1.BackColor = System.Drawing.Color.Transparent;
            this.ticket1.Location = new System.Drawing.Point(-35, -2);
            this.ticket1.Name = "ticket1";
            this.ticket1.Size = new System.Drawing.Size(499, 517);
            this.ticket1.TabIndex = 4;
            this.ticket1.Visible = false;
            // 
            // code1
            // 
            this.code1.BackColor = System.Drawing.Color.Transparent;
            this.code1.Location = new System.Drawing.Point(24, 130);
            this.code1.Name = "code1";
            this.code1.Size = new System.Drawing.Size(398, 259);
            this.code1.TabIndex = 2;
            this.code1.Visible = false;
            // 
            // fuelChoice1
            // 
            this.fuelChoice1.BackColor = System.Drawing.Color.Transparent;
            this.fuelChoice1.Location = new System.Drawing.Point(78, 50);
            this.fuelChoice1.Name = "fuelChoice1";
            this.fuelChoice1.Size = new System.Drawing.Size(287, 389);
            this.fuelChoice1.TabIndex = 1;
            this.fuelChoice1.Visible = false;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(-9, -2);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(473, 499);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 505);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.merci1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.retirercarte1);
            this.Controls.Add(this.ticket1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.code1);
            this.Controls.Add(this.fuelChoice1);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl1 userControl11;
        internal fuelChoice fuelChoice1;
        private code code1;
        private System.Windows.Forms.TextBox textBox1;
        private ticket ticket1;
        private retirercarte retirercarte1;
        private System.Windows.Forms.Label label2;
        private merci merci1;
        private System.Windows.Forms.Label label3;
        private cancel cancel1;
    }
}

