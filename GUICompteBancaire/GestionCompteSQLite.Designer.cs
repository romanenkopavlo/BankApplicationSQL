namespace GUICompteBancaire
{
    partial class GestionCompteSQLite
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
            components = new System.ComponentModel.Container();
            comptesGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proprietaireDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            compteBindingSource = new BindingSource(components);
            transactionsGridView = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            idCompteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            montantDataGridViewImageColumn = new DataGridViewTextBoxColumn();
            notesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idCompteNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionBindingSource = new BindingSource(components);
            ajouterButton = new Button();
            compteGroupBox = new GroupBox();
            proprioTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numeroTextBox = new TextBox();
            soldeTextBox = new TextBox();
            validerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)comptesGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            compteGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // comptesGridView
            // 
            comptesGridView.AllowUserToAddRows = false;
            comptesGridView.AllowUserToDeleteRows = false;
            comptesGridView.AllowUserToResizeColumns = false;
            comptesGridView.AllowUserToResizeRows = false;
            comptesGridView.AutoGenerateColumns = false;
            comptesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            comptesGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, proprietaireDataGridViewTextBoxColumn, numeroDataGridViewTextBoxColumn });
            comptesGridView.DataSource = compteBindingSource;
            comptesGridView.Location = new Point(12, 12);
            comptesGridView.Name = "comptesGridView";
            comptesGridView.RowHeadersWidth = 51;
            comptesGridView.RowTemplate.Height = 29;
            comptesGridView.Size = new Size(300, 188);
            comptesGridView.TabIndex = 0;
            comptesGridView.SelectionChanged += comptesGridView_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // proprietaireDataGridViewTextBoxColumn
            // 
            proprietaireDataGridViewTextBoxColumn.DataPropertyName = "Proprietaire";
            proprietaireDataGridViewTextBoxColumn.HeaderText = "Proprietaire";
            proprietaireDataGridViewTextBoxColumn.MinimumWidth = 6;
            proprietaireDataGridViewTextBoxColumn.Name = "proprietaireDataGridViewTextBoxColumn";
            proprietaireDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            numeroDataGridViewTextBoxColumn.MinimumWidth = 6;
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.Width = 125;
            // 
            // compteBindingSource
            // 
            compteBindingSource.DataSource = typeof(CompteBancaireEF.Compte);
            // 
            // transactionsGridView
            // 
            transactionsGridView.AutoGenerateColumns = false;
            transactionsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionsGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, idCompteDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, montantDataGridViewImageColumn, notesDataGridViewTextBoxColumn, idCompteNavigationDataGridViewTextBoxColumn });
            transactionsGridView.DataSource = transactionBindingSource;
            transactionsGridView.Location = new Point(330, 12);
            transactionsGridView.Name = "transactionsGridView";
            transactionsGridView.RowHeadersWidth = 51;
            transactionsGridView.RowTemplate.Height = 29;
            transactionsGridView.Size = new Size(426, 188);
            transactionsGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.Visible = false;
            idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idCompteDataGridViewTextBoxColumn
            // 
            idCompteDataGridViewTextBoxColumn.DataPropertyName = "IdCompte";
            idCompteDataGridViewTextBoxColumn.HeaderText = "IdCompte";
            idCompteDataGridViewTextBoxColumn.MinimumWidth = 6;
            idCompteDataGridViewTextBoxColumn.Name = "idCompteDataGridViewTextBoxColumn";
            idCompteDataGridViewTextBoxColumn.Visible = false;
            idCompteDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // montantDataGridViewImageColumn
            // 
            montantDataGridViewImageColumn.DataPropertyName = "Montant";
            montantDataGridViewImageColumn.HeaderText = "Montant";
            montantDataGridViewImageColumn.MinimumWidth = 6;
            montantDataGridViewImageColumn.Name = "montantDataGridViewImageColumn";
            montantDataGridViewImageColumn.Resizable = DataGridViewTriState.True;
            montantDataGridViewImageColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            montantDataGridViewImageColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // idCompteNavigationDataGridViewTextBoxColumn
            // 
            idCompteNavigationDataGridViewTextBoxColumn.DataPropertyName = "IdCompteNavigation";
            idCompteNavigationDataGridViewTextBoxColumn.HeaderText = "IdCompteNavigation";
            idCompteNavigationDataGridViewTextBoxColumn.MinimumWidth = 6;
            idCompteNavigationDataGridViewTextBoxColumn.Name = "idCompteNavigationDataGridViewTextBoxColumn";
            idCompteNavigationDataGridViewTextBoxColumn.Visible = false;
            idCompteNavigationDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(CompteBancaireEF.Transaction);
            // 
            // ajouterButton
            // 
            ajouterButton.Location = new Point(12, 216);
            ajouterButton.Name = "ajouterButton";
            ajouterButton.Size = new Size(94, 29);
            ajouterButton.TabIndex = 2;
            ajouterButton.Text = "Ajouter";
            ajouterButton.UseVisualStyleBackColor = true;
            ajouterButton.Click += ajouterButton_Click;
            // 
            // compteGroupBox
            // 
            compteGroupBox.Controls.Add(proprioTextBox);
            compteGroupBox.Controls.Add(label3);
            compteGroupBox.Controls.Add(label2);
            compteGroupBox.Controls.Add(label1);
            compteGroupBox.Controls.Add(numeroTextBox);
            compteGroupBox.Controls.Add(soldeTextBox);
            compteGroupBox.Location = new Point(12, 272);
            compteGroupBox.Name = "compteGroupBox";
            compteGroupBox.Size = new Size(250, 145);
            compteGroupBox.TabIndex = 3;
            compteGroupBox.TabStop = false;
            compteGroupBox.Text = "Info Compte";
            compteGroupBox.Visible = false;
            // 
            // proprioTextBox
            // 
            proprioTextBox.Location = new Point(119, 19);
            proprioTextBox.Name = "proprioTextBox";
            proprioTextBox.Size = new Size(125, 27);
            proprioTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 119);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 6;
            label3.Text = "Solde intial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 74);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 6;
            label2.Text = "Numero:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 4;
            label1.Text = "Proprietaire:";
            // 
            // numeroTextBox
            // 
            numeroTextBox.Location = new Point(119, 67);
            numeroTextBox.Name = "numeroTextBox";
            numeroTextBox.Size = new Size(125, 27);
            numeroTextBox.TabIndex = 5;
            // 
            // soldeTextBox
            // 
            soldeTextBox.Location = new Point(119, 112);
            soldeTextBox.Name = "soldeTextBox";
            soldeTextBox.Size = new Size(125, 27);
            soldeTextBox.TabIndex = 4;
            // 
            // validerButton
            // 
            validerButton.Location = new Point(14, 216);
            validerButton.Name = "validerButton";
            validerButton.Size = new Size(94, 29);
            validerButton.TabIndex = 4;
            validerButton.Text = "Valider";
            validerButton.UseVisualStyleBackColor = true;
            validerButton.Visible = false;
            validerButton.Click += validerButton_Click;
            // 
            // GestionCompteSQLite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 450);
            Controls.Add(validerButton);
            Controls.Add(compteGroupBox);
            Controls.Add(ajouterButton);
            Controls.Add(transactionsGridView);
            Controls.Add(comptesGridView);
            Name = "GestionCompteSQLite";
            Text = "GestionCompteSQLite";
            Load += GestionCompteSQLite_Load;
            ((System.ComponentModel.ISupportInitialize)comptesGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)compteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            compteGroupBox.ResumeLayout(false);
            compteGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView comptesGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proprietaireDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private BindingSource compteBindingSource;
        private DataGridView transactionsGridView;
        private BindingSource transactionBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idCompteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montantDataGridViewImageColumn;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCompteNavigationDataGridViewTextBoxColumn;
        private Button ajouterButton;
        private GroupBox compteGroupBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox soldeTextBox;
        private TextBox numeroTextBox;
        private Button validerButton;
        private TextBox proprioTextBox;
    }
}