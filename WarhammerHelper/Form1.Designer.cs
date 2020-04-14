namespace WarhammerHelper
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        struct Team
        {
            public string TeamName;
            public int NbUnit;

            public Team(string Name)
            {
                TeamName = Name;
                NbUnit = 0;
            }            
        }

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
            this.Equipe2 = new System.Windows.Forms.TabPage();
            this.Equipe1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChoixEquipe = new System.Windows.Forms.TabControl();
            this.Equipe1.SuspendLayout();
            this.ChoixEquipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // Equipe2
            // 
            this.Equipe2.Location = new System.Drawing.Point(4, 22);
            this.Equipe2.Name = "Equipe2";
            this.Equipe2.Padding = new System.Windows.Forms.Padding(3);
            this.Equipe2.Size = new System.Drawing.Size(768, 400);
            this.Equipe2.TabIndex = 1;
            this.Equipe2.Text = "Equipe2";
            this.Equipe2.UseVisualStyleBackColor = true;
            // 
            // Equipe1
            // 
            this.Equipe1.Controls.Add(this.label1);
            this.Equipe1.Controls.Add(this.tableLayoutPanel1);
            this.Equipe1.Location = new System.Drawing.Point(4, 22);
            this.Equipe1.Name = "Equipe1";
            this.Equipe1.Padding = new System.Windows.Forms.Padding(3);
            this.Equipe1.Size = new System.Drawing.Size(768, 400);
            this.Equipe1.TabIndex = 0;
            this.Equipe1.Text = "Equipe1";
            this.Equipe1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TeamName";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 358);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ChoixEquipe
            // 
            this.ChoixEquipe.Controls.Add(this.Equipe1);
            this.ChoixEquipe.Controls.Add(this.Equipe2);
            this.ChoixEquipe.Location = new System.Drawing.Point(12, 12);
            this.ChoixEquipe.Name = "ChoixEquipe";
            this.ChoixEquipe.SelectedIndex = 0;
            this.ChoixEquipe.Size = new System.Drawing.Size(776, 426);
            this.ChoixEquipe.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChoixEquipe);
            this.Name = "Form1";
            this.Text = "WarhammerHelper";
            this.Equipe1.ResumeLayout(false);
            this.Equipe1.PerformLayout();
            this.ChoixEquipe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Equipe2;
        private System.Windows.Forms.TabPage Equipe1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl ChoixEquipe;
    }
}

