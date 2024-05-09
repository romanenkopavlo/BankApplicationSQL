using CompteBancaireLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICompteBancaire
{
    public partial class GestionCompte : Form
    {
        private CompteAvecSauvegarde _compte;
        public CompteAvecSauvegarde Compte
        {
            set
            {
                _compte = value;
                Text = _compte.Proprietaire + " : " + _compte.Numero;
                RemplirLaListe(true);
            }
        }

        private void RemplirLaListe(bool debut)
        {
            listeTransactions.Items.Clear();
            foreach (Transaction t in _compte.Transactions)
            {
                ListViewItem unElement = new ListViewItem();
                unElement.Text = t.Date.ToString("dd/MM/yyyy");
                unElement.SubItems.Add(t.Montant.ToString("N2"));
                unElement.SubItems.Add(t.Notes);
                unElement.Tag = t;
                //
                listeTransactions.Items.Add(unElement);
            }
            if (listeTransactions.Items.Count > 0)
            {
                if (debut)
                {
                    listeTransactions.Items[0].Selected = true;
                }
                else
                {
                    listeTransactions.Items[listeTransactions.Items.Count - 1].Selected = true;
                }
            }
            labelSolde.Text = "Solde actuel : " + _compte.Solde.ToString("N2");
        }

        public String Fichier { get; set; }



        public GestionCompte()
        {
            InitializeComponent();
        }

        private void listeTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listeTransactions.SelectedItems.Count > 0)
            {
                ListViewItem unElement = listeTransactions.SelectedItems[0];
                Transaction t = (Transaction)unElement.Tag;
                textMontant.Text = t.Montant.ToString("N2");
                textNotes.Text = t.Notes;
                pickerDate.Value = t.Date;
            }
            else
            {
                textMontant.Text = "";
                textNotes.Text = "";
                pickerDate.Value = DateTime.Now;
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (listeTransactions.SelectedItems.Count > 0)
            {
                ListViewItem unElement = listeTransactions.SelectedItems[0];
                if (unElement.Index > 0)
                {
                    //
                    DialogResult dr = MessageBox.Show("Etes vous sûr ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        listeTransactions.Items.Remove(unElement);
                        if (listeTransactions.Items.Count > 0)
                        {
                            listeTransactions.Items[0].Selected = true;
                        }
                    }
                }
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            listeTransactions.Enabled = false;
            buttonSupprimer.Enabled = false;
            //
            pickerDate.Value = DateTime.Now;
            textMontant.Text = "";
            textNotes.Text = "";
            //
            pickerDate.Focus();
            //
            panelZoom.Enabled = true;
            buttonValider.Visible = true;
            buttonAjouter.Visible = false;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            //
            bool correct = true;
            labelErreur.Text = "";
            decimal montant;
            if (!decimal.TryParse(textMontant.Text, out montant))
            {
                // Erreur
                labelErreur.Text = "Le montant n'est pas correct.";
                correct = false;
            }

            Transaction t = (Transaction)listeTransactions.Items[0].Tag;
            if (pickerDate.Value < t.Date)
            {
                // Erreur
                labelErreur.Text += " - La date est avant le solde initial.";
                correct = false;
            }
            if (correct)
            {
                if (montant >= 0)
                {
                    _compte.FaireDepot(montant, pickerDate.Value, textNotes.Text);
                }
                else
                {
                    _compte.FaireRetrait(-1 * montant, pickerDate.Value, textNotes.Text);
                }
                RemplirLaListe(false);
            }
            else
            {
                return;
            }
            //
            labelErreur.Text = "";
            panelZoom.Enabled = false;
            buttonValider.Visible = false;
            buttonAjouter.Visible = true;
            listeTransactions.Enabled = true;
            buttonSupprimer.Enabled = true;
        }

        private void GestionCompte_FormClosed(object sender, FormClosedEventArgs e)
        {
            string ext = Path.GetExtension(this.Fichier).ToLower();
            if (ext == ".csv")
            {
                _compte.EcrireCSV();
            }
            else if (ext == ".json")
            {
                _compte.EcrireJSON();
            }
        }
    }


}
