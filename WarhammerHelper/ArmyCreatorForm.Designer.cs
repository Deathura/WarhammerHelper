    namespace WarhammerHelper
{
    partial class ArmyCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArmyCreatorForm));
            this.fightButton = new System.Windows.Forms.Button();
            this.comboBoxSelectNbArmy = new System.Windows.Forms.ComboBox();
            this.groupNbArmySelection = new System.Windows.Forms.GroupBox();
            this.labelNbArmySelection = new System.Windows.Forms.Label();
            this.groupNbArmySelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // fightButton
            // 
            this.fightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fightButton.BackColor = System.Drawing.Color.Transparent;
            this.fightButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fightButton.BackgroundImage")));
            this.fightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fightButton.Location = new System.Drawing.Point(810, 426);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(200, 100);
            this.fightButton.TabIndex = 2;
            this.fightButton.TabStop = false;
            this.fightButton.UseVisualStyleBackColor = false;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // comboBoxSelectNbArmy
            // 
            this.comboBoxSelectNbArmy.FormattingEnabled = true;
            this.comboBoxSelectNbArmy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxSelectNbArmy.Location = new System.Drawing.Point(121, 18);
            this.comboBoxSelectNbArmy.Name = "comboBoxSelectNbArmy";
            this.comboBoxSelectNbArmy.Size = new System.Drawing.Size(56, 24);
            this.comboBoxSelectNbArmy.TabIndex = 3;
            this.comboBoxSelectNbArmy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectNbArmy_SelectedIndexChanged);
            // 
            // groupNbArmySelection
            // 
            this.groupNbArmySelection.Controls.Add(this.labelNbArmySelection);
            this.groupNbArmySelection.Controls.Add(this.comboBoxSelectNbArmy);
            this.groupNbArmySelection.Location = new System.Drawing.Point(12, 12);
            this.groupNbArmySelection.Name = "groupNbArmySelection";
            this.groupNbArmySelection.Size = new System.Drawing.Size(185, 55);
            this.groupNbArmySelection.TabIndex = 4;
            this.groupNbArmySelection.TabStop = false;
            // 
            // labelNbArmySelection
            // 
            this.labelNbArmySelection.AutoSize = true;
            this.labelNbArmySelection.Location = new System.Drawing.Point(6, 18);
            this.labelNbArmySelection.Name = "labelNbArmySelection";
            this.labelNbArmySelection.Size = new System.Drawing.Size(109, 17);
            this.labelNbArmySelection.TabIndex = 4;
            this.labelNbArmySelection.Text = "Number of army";
            // 
            // ArmyCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 538);
            this.Controls.Add(this.groupNbArmySelection);
            this.Controls.Add(this.fightButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1040, 585);
            this.Name = "ArmyCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarhammerHelper";
            this.groupNbArmySelection.ResumeLayout(false);
            this.groupNbArmySelection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.ComboBox comboBoxSelectNbArmy;
        private System.Windows.Forms.GroupBox groupNbArmySelection;
        private System.Windows.Forms.Label labelNbArmySelection;
    }
}