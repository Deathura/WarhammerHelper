﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarhammerHelper
{
    public partial class ArmyForm : Form
    {
        public ArmyForm()
        {
            InitializeComponent();
            SetVariable();
        }

        private void SetVariable()
        {
            int nbTeam = 2;
            int nbUnit = 7;
            int nbRow = 0;
            if (nbUnit % 2 == 0)
            {
                nbRow = nbUnit / 2;
            }
            else
            {
                nbRow = nbUnit / 2 + 1;
            }
            UnitTableLayout(4, 4);
            //UnitTableLayout(1, nbUnit);
        }

        private void UnitTableLayout(int nbRow, int nbColumn)
        {
            this.tableLayoutPanelUnit.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanelUnit.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelUnit.ColumnCount = nbColumn;
            this.tableLayoutPanelUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUnit.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanelUnit.Name = "tableLayoutPanelUnit";
            this.tableLayoutPanelUnit.RowCount = nbRow;
            this.tableLayoutPanelUnit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUnit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUnit.Size = new System.Drawing.Size(768, 358);
            this.tableLayoutPanelUnit.TabIndex = 0;
        }

        private void AddTab()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArmyForm));
            this.Equipe1 = new System.Windows.Forms.TabPage();
            this.TeamName = new System.Windows.Forms.Label();
            this.tableLayoutPanelUnit = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.ChoixEquipe = new System.Windows.Forms.TabControl();
            this.Equipe1.SuspendLayout();
            this.tableLayoutPanelUnit.SuspendLayout();
            this.ChoixEquipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // Equipe1
            // 
            this.Equipe1.Controls.Add(this.TeamName);
            this.Equipe1.Controls.Add(this.tableLayoutPanelUnit);
            this.Equipe1.Location = new System.Drawing.Point(4, 25);
            this.Equipe1.Margin = new System.Windows.Forms.Padding(4);
            this.Equipe1.Name = "Equipe1";
            this.Equipe1.Padding = new System.Windows.Forms.Padding(4);
            this.Equipe1.Size = new System.Drawing.Size(1027, 495);
            this.Equipe1.TabIndex = 0;
            this.Equipe1.Text = "Equipe1";
            this.Equipe1.UseVisualStyleBackColor = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ChoixEquipe.Size = new Size(
                Size.Width - ChoixEquipe.Location.X - 30,
                Size.Height - ChoixEquipe.Location.Y - 50);
            tableLayoutPanelUnit.Size = new System.Drawing.Size(ChoixEquipe.Size.Width, ChoixEquipe.Size.Height);
            


            //groupBoxSendText.Location = new Point(groupBoxSendText.Location.X, Size.Height - 95);
            //groupBoxSendText.Size = new Size(richTextBoxTerminal.Size.Width, groupBoxSendText.Size.Height);
            //textBoxSendText.Size = new Size(
            //    groupBoxSendText.Size.Width - 174,
            //    textBoxSendText.Size.Height);
            //buttonSendText.Location = new Point(
            //    textBoxSendText.Size.Width + textBoxSendText.Location.X + 6,
            //    buttonSendText.Location.Y);
            //buttonClearTerminal.Location = new Point(
            //    textBoxSendText.Size.Width + textBoxSendText.Location.X + 87,
            //    buttonClearTerminal.Location.Y);
        }
    }
}
