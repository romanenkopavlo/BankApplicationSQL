using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CompteBancaireEF;
using Microsoft.EntityFrameworkCore;

namespace GUICompteBancaire
{
    public partial class GestionCompteSQLite : Form
    {
        ComptesBancairesContext myDB;
        public GestionCompteSQLite()
        {
            InitializeComponent();
        }

        public string Fichier { get; internal set; }

        private void GestionCompteSQLite_Load(object sender, EventArgs e)
        {
            myDB = new ComptesBancairesContext(Fichier);
            myDB.Database.EnsureCreated();
            myDB.Comptes.Load();
            compteBindingSource.DataSource = myDB.Comptes.Local.ToBindingList();

        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            comptesGridView.Enabled = false;
            transactionsGridView.Enabled = false;
            compteGroupBox.Visible = true;
            ajouterButton.Visible = false;
            validerButton.Visible = true;
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            comptesGridView.Enabled = true;
            transactionsGridView.Enabled = true;
            compteGroupBox.Visible = false;
            ajouterButton.Visible = true;
            validerButton.Visible = false;

            if (!String.IsNullOrEmpty(proprioTextBox.Text) &&
                !String.IsNullOrEmpty(numeroTextBox.Text) &&
                !String.IsNullOrEmpty(soldeTextBox.Text))
            {
                double solde;
                long numero;
                if (double.TryParse(soldeTextBox.Text, out solde) &&
                    long.TryParse(numeroTextBox.Text, out numero))
                {
                    Compte cpt = new Compte();
                    cpt.Proprietaire = proprioTextBox.Text;
                    cpt.Numero = numero;
                    myDB.Comptes.Add(cpt);
                    myDB.SaveChanges();

                    Transaction transaction = new Transaction();
                    transaction.IdCompte = cpt.Id;
                    transaction.Date = DateTime.Now.ToString("dd/MM/yyyy");
                    transaction.Montant = solde;
                    transaction.Notes = "Solde Initial";
                    myDB.Transactions.Add(transaction);
                    myDB.SaveChanges();

                    proprioTextBox.Text = "";
                    numeroTextBox.Text = "";
                    soldeTextBox.Text = "";
                }
            }
        }

        private void comptesGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.myDB != null)
            {
                try
                {
                    var compte = (Compte)this.comptesGridView.CurrentRow.DataBoundItem;
                    if (compte != null)
                    {
                        this.myDB.Entry(compte).Collection(e => e.Transactions).Load();
                        this.transactionsGridView.DataSource = compte.Transactions;
                    }
                }
                catch
                { };
            }
        }
    }
}
