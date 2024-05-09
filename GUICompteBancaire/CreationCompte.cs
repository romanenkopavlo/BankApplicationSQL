using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICompteBancaire
{
    public partial class CreationCompte : Form
    {
        public CreationCompte()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string proprio = textProprio.Text;
            string solde = textSolde.Text;
            //
            if ( string.IsNullOrEmpty(proprio) )
            {
                MessageBox.Show("Le nom du Propriétaire ne peut pas être vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            decimal soldeDecimal = 0;
            if ( !decimal.TryParse( solde, out soldeDecimal ) )
            {
                MessageBox.Show("Le solde n'est pas correct !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
