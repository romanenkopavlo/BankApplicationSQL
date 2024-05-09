namespace GUICompteBancaire
{
    partial class CreationCompte
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
            label1 = new Label();
            label2 = new Label();
            textProprio = new TextBox();
            textSolde = new TextBox();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Propriétaire :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Solde initial :";
            // 
            // textProprio
            // 
            textProprio.Location = new Point(139, 6);
            textProprio.MaxLength = 50;
            textProprio.Name = "textProprio";
            textProprio.Size = new Size(125, 27);
            textProprio.TabIndex = 2;
            // 
            // textSolde
            // 
            textSolde.Location = new Point(139, 42);
            textSolde.MaxLength = 13;
            textSolde.Name = "textSolde";
            textSolde.Size = new Size(125, 27);
            textSolde.TabIndex = 3;
            textSolde.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(170, 90);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // CreationCompte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 131);
            Controls.Add(buttonOk);
            Controls.Add(textSolde);
            Controls.Add(textProprio);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreationCompte";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Création de Compte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonOk;
        public TextBox textProprio;
        public TextBox textSolde;
    }
}