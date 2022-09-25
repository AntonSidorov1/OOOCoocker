using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOOCoocker
{
    public partial class Pattern : Form
    {
        public Pattern()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pattern_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 255);
            tableLayoutPanelUp.BackColor = Color.FromArgb(255, 204, 151);
            panelDown.BackColor = Color.FromArgb(255, 204, 151);
        }

        /// <summary>
        /// Нажатие на кнопку закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
