namespace AutochessNet
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
            this.show_champions = new System.Windows.Forms.Button();
            this.show_heroes = new System.Windows.Forms.Button();
            this.show_classe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show_champions
            // 
            this.show_champions.Location = new System.Drawing.Point(613, 382);
            this.show_champions.Name = "show_champions";
            this.show_champions.Size = new System.Drawing.Size(166, 56);
            this.show_champions.TabIndex = 0;
            this.show_champions.Text = "Champions";
            this.show_champions.UseVisualStyleBackColor = true;
            this.show_champions.Click += new System.EventHandler(this.show_champions_Click);
            // 
            // show_heroes
            // 
            this.show_heroes.Location = new System.Drawing.Point(305, 382);
            this.show_heroes.Name = "show_heroes";
            this.show_heroes.Size = new System.Drawing.Size(166, 56);
            this.show_heroes.TabIndex = 1;
            this.show_heroes.Text = "Héros";
            this.show_heroes.UseVisualStyleBackColor = true;
            this.show_heroes.Click += new System.EventHandler(this.show_heroes_Click);
            // 
            // show_classe
            // 
            this.show_classe.Location = new System.Drawing.Point(12, 382);
            this.show_classe.Name = "show_classe";
            this.show_classe.Size = new System.Drawing.Size(166, 56);
            this.show_classe.TabIndex = 2;
            this.show_classe.Text = "Classe";
            this.show_classe.UseVisualStyleBackColor = true;
            this.show_classe.Click += new System.EventHandler(this.show_classe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_classe);
            this.Controls.Add(this.show_heroes);
            this.Controls.Add(this.show_champions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_champions;
        private System.Windows.Forms.Button show_heroes;
        private System.Windows.Forms.Button show_classe;
    }
}

