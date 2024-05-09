namespace GUICompteBancaire
{
    partial class GestionCompte
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
            listeTransactions = new ListView();
            columnDate = new ColumnHeader();
            columnMontant = new ColumnHeader();
            columnNotes = new ColumnHeader();
            label1 = new Label();
            pickerDate = new DateTimePicker();
            label2 = new Label();
            textMontant = new TextBox();
            label3 = new Label();
            textNotes = new TextBox();
            statusStrip1 = new StatusStrip();
            labelSolde = new ToolStripStatusLabel();
            labelErreur = new ToolStripStatusLabel();
            panelZoom = new Panel();
            buttonSupprimer = new Button();
            buttonAjouter = new Button();
            buttonValider = new Button();
            statusStrip1.SuspendLayout();
            panelZoom.SuspendLayout();
            SuspendLayout();
            // 
            // listeTransactions
            // 
            listeTransactions.Columns.AddRange(new ColumnHeader[] { columnDate, columnMontant, columnNotes });
            listeTransactions.FullRowSelect = true;
            listeTransactions.GridLines = true;
            listeTransactions.Location = new Point(21, 30);
            listeTransactions.MultiSelect = false;
            listeTransactions.Name = "listeTransactions";
            listeTransactions.Size = new Size(392, 361);
            listeTransactions.TabIndex = 0;
            listeTransactions.UseCompatibleStateImageBehavior = false;
            listeTransactions.View = View.Details;
            listeTransactions.SelectedIndexChanged += listeTransactions_SelectedIndexChanged;
            // 
            // columnDate
            // 
            columnDate.Text = "Date";
            columnDate.Width = 120;
            // 
            // columnMontant
            // 
            columnMontant.Text = "Montant";
            columnMontant.TextAlign = HorizontalAlignment.Right;
            columnMontant.Width = 160;
            // 
            // columnNotes
            // 
            columnNotes.Text = "Notes";
            columnNotes.Width = 250;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 1;
            label1.Text = "Date";
            // 
            // pickerDate
            // 
            pickerDate.Location = new Point(3, 25);
            pickerDate.Name = "pickerDate";
            pickerDate.Size = new Size(242, 27);
            pickerDate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 69);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 3;
            label2.Text = "Montant";
            // 
            // textMontant
            // 
            textMontant.Location = new Point(3, 92);
            textMontant.Name = "textMontant";
            textMontant.Size = new Size(242, 27);
            textMontant.TabIndex = 4;
            textMontant.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 132);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 5;
            label3.Text = "Notes";
            // 
            // textNotes
            // 
            textNotes.Location = new Point(3, 155);
            textNotes.Multiline = true;
            textNotes.Name = "textNotes";
            textNotes.ScrollBars = ScrollBars.Both;
            textNotes.Size = new Size(242, 112);
            textNotes.TabIndex = 6;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelSolde, labelErreur });
            statusStrip1.Location = new Point(0, 409);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(719, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelSolde
            // 
            labelSolde.Name = "labelSolde";
            labelSolde.Size = new Size(0, 16);
            // 
            // labelErreur
            // 
            labelErreur.ForeColor = Color.Red;
            labelErreur.Name = "labelErreur";
            labelErreur.Size = new Size(0, 16);
            // 
            // panelZoom
            // 
            panelZoom.Controls.Add(textMontant);
            panelZoom.Controls.Add(label1);
            panelZoom.Controls.Add(textNotes);
            panelZoom.Controls.Add(pickerDate);
            panelZoom.Controls.Add(label3);
            panelZoom.Controls.Add(label2);
            panelZoom.Enabled = false;
            panelZoom.Location = new Point(430, 30);
            panelZoom.Name = "panelZoom";
            panelZoom.Size = new Size(263, 287);
            panelZoom.TabIndex = 8;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Location = new Point(433, 362);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(94, 29);
            buttonSupprimer.TabIndex = 9;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.Location = new Point(599, 362);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(94, 29);
            buttonAjouter.TabIndex = 10;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(599, 362);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(94, 29);
            buttonValider.TabIndex = 11;
            buttonValider.Text = "Ajouter";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Visible = false;
            buttonValider.Click += buttonValider_Click;
            // 
            // GestionCompte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 431);
            Controls.Add(buttonValider);
            Controls.Add(buttonAjouter);
            Controls.Add(buttonSupprimer);
            Controls.Add(panelZoom);
            Controls.Add(statusStrip1);
            Controls.Add(listeTransactions);
            Name = "GestionCompte";
            Text = "GestionCompte";
            FormClosed += GestionCompte_FormClosed;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panelZoom.ResumeLayout(false);
            panelZoom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listeTransactions;
        private ColumnHeader columnDate;
        private ColumnHeader columnMontant;
        private ColumnHeader columnNotes;
        private Label label1;
        private DateTimePicker pickerDate;
        private Label label2;
        private TextBox textMontant;
        private Label label3;
        private TextBox textNotes;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelSolde;
        private Panel panelZoom;
        private Button buttonSupprimer;
        private Button buttonAjouter;
        private Button buttonValider;
        private ToolStripStatusLabel labelErreur;
    }
}