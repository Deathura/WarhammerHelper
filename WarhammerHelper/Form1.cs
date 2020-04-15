using System;
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
    public partial class Form1 : Form
    {
        public Form1()
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
            UnitTableLayout(nbRow, 2);
        }

        private void UnitTableLayout(int nbRow, int nbColumn)
        {
            this.tableLayoutPanelUnit.BackColor = System.Drawing.Color.Black;
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

        private void Form1_Resize(object sender, EventArgs e)
        {
            ChoixEquipe.Size = new Size(
                Size.Width - ChoixEquipe.Location.X - 25,
                Size.Height - ChoixEquipe.Location.Y - 95);
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
