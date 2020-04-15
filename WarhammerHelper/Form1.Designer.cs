namespace WarhammerHelper
{
    partial class ArmyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArmyForm));
            this.Equipe2 = new System.Windows.Forms.TabPage();
            this.Equipe1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelUnit = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.ChoixEquipe = new System.Windows.Forms.TabControl();
            this.Equipe1.SuspendLayout();
            this.tableLayoutPanelUnit.SuspendLayout();
            this.ChoixEquipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // Equipe2
            // 
            this.Equipe2.Location = new System.Drawing.Point(4, 25);
            this.Equipe2.Margin = new System.Windows.Forms.Padding(4);
            this.Equipe2.Name = "Equipe2";
            this.Equipe2.Padding = new System.Windows.Forms.Padding(4);
            this.Equipe2.Size = new System.Drawing.Size(1027, 495);
            this.Equipe2.TabIndex = 1;
            this.Equipe2.Text = "Equipe2";
            this.Equipe2.UseVisualStyleBackColor = true;
            // 
            // Equipe1
            // 
            this.Equipe1.Controls.Add(this.label1);
            this.Equipe1.Controls.Add(this.tableLayoutPanelUnit);
            this.Equipe1.Location = new System.Drawing.Point(4, 25);
            this.Equipe1.Margin = new System.Windows.Forms.Padding(4);
            this.Equipe1.Name = "Equipe1";
            this.Equipe1.Padding = new System.Windows.Forms.Padding(4);
            this.Equipe1.Size = new System.Drawing.Size(1027, 495);
            this.Equipe1.TabIndex = 0;
            this.Equipe1.Text = "Equipe1";
            this.Equipe1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TeamName";
            // 
            // tableLayoutPanelUnit
            // 
            this.tableLayoutPanelUnit.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelUnit.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelUnit.ColumnCount = 2;
            this.tableLayoutPanelUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUnit.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanelUnit.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanelUnit.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelUnit.Name = "tableLayoutPanelUnit";
            this.tableLayoutPanelUnit.RowCount = 2;
            this.tableLayoutPanelUnit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUnit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUnit.Size = new System.Drawing.Size(1023, 441);
            this.tableLayoutPanelUnit.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 161);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ChoixEquipe
            // 
            this.ChoixEquipe.Controls.Add(this.Equipe1);
            this.ChoixEquipe.Controls.Add(this.Equipe2);
            this.ChoixEquipe.Location = new System.Drawing.Point(16, 15);
            this.ChoixEquipe.Margin = new System.Windows.Forms.Padding(4);
            this.ChoixEquipe.Name = "ChoixEquipe";
            this.ChoixEquipe.SelectedIndex = 0;
            this.ChoixEquipe.Size = new System.Drawing.Size(1035, 524);
            this.ChoixEquipe.TabIndex = 0;
            // 
            // ArmyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ChoixEquipe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "ArmyForm";
            this.Text = "WarhammerHelper";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Equipe1.ResumeLayout(false);
            this.Equipe1.PerformLayout();
            this.tableLayoutPanelUnit.ResumeLayout(false);
            this.ChoixEquipe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Equipe2;
        private System.Windows.Forms.TabPage Equipe1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUnit;
        private System.Windows.Forms.TabControl ChoixEquipe;
        private System.Windows.Forms.Button button1;
    }

    
}

