namespace WindowsFormsAppliContact
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.ListNomContact = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.txtBoxIdUpdateDetails = new System.Windows.Forms.TextBox();
            this.txtBoxNameUpdateDetails = new System.Windows.Forms.TextBox();
            this.txtBoxNumberUpdateDetails = new System.Windows.Forms.TextBox();
            this.labelId1 = new System.Windows.Forms.Label();
            this.labelName1 = new System.Windows.Forms.Label();
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.labelDetailsContact = new System.Windows.Forms.Label();
            this.txtBoxIdAdd = new System.Windows.Forms.TextBox();
            this.txtBoxNameAdd = new System.Windows.Forms.TextBox();
            this.txtBoxNumberAdd = new System.Windows.Forms.TextBox();
            this.labelId2 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelAddContact = new System.Windows.Forms.Label();
            this.labelErreurDetails = new System.Windows.Forms.Label();
            this.labelErreurAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            // 
            // ListNomContact
            // 
            this.ListNomContact.FormattingEnabled = true;
            this.ListNomContact.ItemHeight = 20;
            this.ListNomContact.Location = new System.Drawing.Point(42, 35);
            this.ListNomContact.Name = "ListNomContact";
            this.ListNomContact.Size = new System.Drawing.Size(249, 704);
            this.ListNomContact.TabIndex = 2;
            this.ListNomContact.SelectedIndexChanged += new System.EventHandler(this.ListNomContact_SelectedIndexChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(376, 203);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(118, 49);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Modifier";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(42, 762);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(249, 49);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonSupp_Click);
            // 
            // txtBoxIdUpdateDetails
            // 
            this.txtBoxIdUpdateDetails.Location = new System.Drawing.Point(376, 136);
            this.txtBoxIdUpdateDetails.Name = "txtBoxIdUpdateDetails";
            this.txtBoxIdUpdateDetails.Size = new System.Drawing.Size(203, 26);
            this.txtBoxIdUpdateDetails.TabIndex = 6;
            // 
            // txtBoxNameUpdateDetails
            // 
            this.txtBoxNameUpdateDetails.Location = new System.Drawing.Point(685, 136);
            this.txtBoxNameUpdateDetails.Name = "txtBoxNameUpdateDetails";
            this.txtBoxNameUpdateDetails.Size = new System.Drawing.Size(203, 26);
            this.txtBoxNameUpdateDetails.TabIndex = 7;
            // 
            // txtBoxNumberUpdateDetails
            // 
            this.txtBoxNumberUpdateDetails.Location = new System.Drawing.Point(1002, 136);
            this.txtBoxNumberUpdateDetails.Name = "txtBoxNumberUpdateDetails";
            this.txtBoxNumberUpdateDetails.Size = new System.Drawing.Size(203, 26);
            this.txtBoxNumberUpdateDetails.TabIndex = 8;
            // 
            // labelId1
            // 
            this.labelId1.AutoSize = true;
            this.labelId1.Location = new System.Drawing.Point(372, 113);
            this.labelId1.Name = "labelId1";
            this.labelId1.Size = new System.Drawing.Size(34, 20);
            this.labelId1.TabIndex = 9;
            this.labelId1.Text = "ID :";
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Location = new System.Drawing.Point(681, 113);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(50, 20);
            this.labelName1.TabIndex = 10;
            this.labelName1.Text = "Nom :";
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.Location = new System.Drawing.Point(998, 113);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(170, 20);
            this.labelNumber1.TabIndex = 11;
            this.labelNumber1.Text = "Numéro de téléphone :";
            // 
            // labelDetailsContact
            // 
            this.labelDetailsContact.AutoSize = true;
            this.labelDetailsContact.Location = new System.Drawing.Point(372, 71);
            this.labelDetailsContact.Name = "labelDetailsContact";
            this.labelDetailsContact.Size = new System.Drawing.Size(137, 20);
            this.labelDetailsContact.TabIndex = 12;
            this.labelDetailsContact.Text = "Détail du contact :";
            // 
            // txtBoxIdAdd
            // 
            this.txtBoxIdAdd.Location = new System.Drawing.Point(380, 534);
            this.txtBoxIdAdd.Name = "txtBoxIdAdd";
            this.txtBoxIdAdd.Size = new System.Drawing.Size(203, 26);
            this.txtBoxIdAdd.TabIndex = 13;
            // 
            // txtBoxNameAdd
            // 
            this.txtBoxNameAdd.Location = new System.Drawing.Point(685, 534);
            this.txtBoxNameAdd.Name = "txtBoxNameAdd";
            this.txtBoxNameAdd.Size = new System.Drawing.Size(203, 26);
            this.txtBoxNameAdd.TabIndex = 14;
            // 
            // txtBoxNumberAdd
            // 
            this.txtBoxNumberAdd.Location = new System.Drawing.Point(1002, 534);
            this.txtBoxNumberAdd.Name = "txtBoxNumberAdd";
            this.txtBoxNumberAdd.Size = new System.Drawing.Size(203, 26);
            this.txtBoxNumberAdd.TabIndex = 15;
            // 
            // labelId2
            // 
            this.labelId2.AutoSize = true;
            this.labelId2.Location = new System.Drawing.Point(376, 511);
            this.labelId2.Name = "labelId2";
            this.labelId2.Size = new System.Drawing.Size(34, 20);
            this.labelId2.TabIndex = 16;
            this.labelId2.Text = "ID :";
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Location = new System.Drawing.Point(685, 508);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(50, 20);
            this.labelName2.TabIndex = 17;
            this.labelName2.Text = "Nom :";
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.Location = new System.Drawing.Point(1002, 508);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(170, 20);
            this.labelNumber2.TabIndex = 18;
            this.labelNumber2.Text = "Numéro de téléphone :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(380, 596);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(124, 49);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelAddContact
            // 
            this.labelAddContact.AutoSize = true;
            this.labelAddContact.Location = new System.Drawing.Point(376, 472);
            this.labelAddContact.Name = "labelAddContact";
            this.labelAddContact.Size = new System.Drawing.Size(133, 20);
            this.labelAddContact.TabIndex = 20;
            this.labelAddContact.Text = "Ajout de contact :";
            // 
            // labelErreurDetails
            // 
            this.labelErreurDetails.AutoSize = true;
            this.labelErreurDetails.Location = new System.Drawing.Point(528, 217);
            this.labelErreurDetails.Name = "labelErreurDetails";
            this.labelErreurDetails.Size = new System.Drawing.Size(0, 20);
            this.labelErreurDetails.TabIndex = 21;
            // 
            // labelErreurAdd
            // 
            this.labelErreurAdd.AutoSize = true;
            this.labelErreurAdd.Location = new System.Drawing.Point(532, 609);
            this.labelErreurAdd.Name = "labelErreurAdd";
            this.labelErreurAdd.Size = new System.Drawing.Size(0, 20);
            this.labelErreurAdd.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 833);
            this.Controls.Add(this.labelErreurAdd);
            this.Controls.Add(this.labelErreurDetails);
            this.Controls.Add(this.labelAddContact);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.labelId2);
            this.Controls.Add(this.txtBoxNumberAdd);
            this.Controls.Add(this.txtBoxNameAdd);
            this.Controls.Add(this.txtBoxIdAdd);
            this.Controls.Add(this.labelDetailsContact);
            this.Controls.Add(this.labelNumber1);
            this.Controls.Add(this.labelName1);
            this.Controls.Add(this.labelId1);
            this.Controls.Add(this.txtBoxNumberUpdateDetails);
            this.Controls.Add(this.txtBoxNameUpdateDetails);
            this.Controls.Add(this.txtBoxIdUpdateDetails);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.ListNomContact);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Interface AppliContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListNomContact;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox txtBoxIdUpdateDetails;
        private System.Windows.Forms.TextBox txtBoxNameUpdateDetails;
        private System.Windows.Forms.TextBox txtBoxNumberUpdateDetails;
        private System.Windows.Forms.Label labelId1;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.Label labelDetailsContact;
        private System.Windows.Forms.TextBox txtBoxIdAdd;
        private System.Windows.Forms.TextBox txtBoxNameAdd;
        private System.Windows.Forms.TextBox txtBoxNumberAdd;
        private System.Windows.Forms.Label labelId2;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelAddContact;
        private System.Windows.Forms.Label labelErreurDetails;
        private System.Windows.Forms.Label labelErreurAdd;
    }
}

