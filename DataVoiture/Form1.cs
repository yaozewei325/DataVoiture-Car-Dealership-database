using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.Entity.Infrastructure;
using System.Net.Sockets;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace DataVoiture
{
    public partial class Form1 : Form
    {
        private Model1 context;
        public Form1()
        {
            InitializeComponent();
            context = new Model1();

            //indiquer les dates par défaut lors du chargement de la page
            dateAchatDebut.Value = new DateTime(2010, 8, 8);
            dateAchatFin.Value = DateTime.Today;
            dateFactureVenteDebut.Value = new DateTime(2010, 8, 8);
            dateFactureVenteFin.Value = DateTime.Today;

        }


        private void btnAjoutClient_Click(object sender, EventArgs e)
        {
            //Attraper l'exception du nom, du prénom et du téléphone.

            try
            {
                var client = new Client
                {
                    Nom = txtNonClient.Text.Trim(),
                    Prenom = txtPrenonClient.Text.Trim(),
                    Telephone = txtTelephoneClient.Text.Trim(),
                    Email = txtEmailClient.Text.Trim(),
                    Adresse = txtAdresseClient.Text.Trim(),
                    Ville = txtVilleClient.Text.Trim(),
                    Province = txtProvinceClient.Text.Trim(),
                    CodePostal = txtCodepostalclient.Text.Trim()
                };

                //Ajoutez - le à la liste des clients
                context.Clients.Add(client);

                //Enregistrez - le dans la base de données
                context.SaveChanges();
                FormClientReset();
                MessageBox.Show("Ajouter avec succes!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        //définir une méthode de réinitialisation pour effacer tous les champs saisis.
        private void FormClientReset()
        {
            txtNumClient.Text = txtNonClient.Text = txtPrenonClient.Text = txtTelephoneClient.Text = txtEmailClient.Text
                   = txtAdresseClient.Text = txtVilleClient.Text = txtProvinceClient.Text = txtCodepostalclient.Text = String.Empty;
        }


        private void btnClientDelete(object sender, EventArgs e)
        {
            //définir une condition pour s'assurer de sélectionner une ligne qui n'est pas la ligne d'en-tête, puis supprimer la ligne sélectionnée.
            if (dataGridViewListeClient.CurrentRow.Index != -1)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    var toDelete = (int)dataGridViewListeClient.CurrentRow.Cells[0].Value;
                    var client = context.Clients.First(c => c.Id == toDelete);
                    context.Clients.Remove(client);
                    context.SaveChanges();
                    dataGridViewListeClient.DataSource = context.Clients.ToList();
                }
            }
        }

        private void btnClientModifier_Click(object sender, EventArgs e)
        {
            //définir une condition pour s'assurer de sélectionner une ligne qui n'est pas la ligne d'en-tête, puis modifier la ligne sélectionnée.
            if (dataGridViewListeClient.CurrentRow.Index != -1)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to modify?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        var toUpdate = (int)dataGridViewListeClient.CurrentRow.Cells[0].Value;
                        var client = context.Clients.Single(c => c.Id == toUpdate);

                        client.Nom = this.txtNonClient.Text.Trim();
                        client.Prenom = this.txtPrenonClient.Text.Trim();
                        client.Telephone = this.txtTelephoneClient.Text.Trim();
                        client.Email = this.txtEmailClient.Text.Trim();
                        client.Adresse = this.txtAdresseClient.Text.Trim();
                        client.Ville = this.txtVilleClient.Text.Trim();
                        client.Province = this.txtProvinceClient.Text.Trim();
                        client.CodePostal = this.txtCodepostalclient.Text.Trim();

                        context.SaveChanges();
                        dataGridViewListeClient.DataSource = context.Clients.Where(c => c.Id == toUpdate).ToList();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }

            }

        }


        //définir une chaîne de conditions de recherche avec une condition après l'autre afin d'affiner les résultats de la recherche
        private bool ClientCondition(Client client)
        {
            bool reponse = true;
            reponse = this.txtNumClient.Text.Trim() != "" ? reponse && client.Id == Convert.ToInt32(this.txtNumClient.Text.Trim()) : reponse && true;

            reponse = this.txtNonClient.Text.Trim() != "" ? reponse && client.Nom.ToLower() == this.txtNonClient.Text.Trim().ToLower().ToLower() : reponse && true;
            reponse = this.txtPrenonClient.Text.Trim() != "" ? reponse && client.Prenom.ToLower() == this.txtPrenonClient.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtTelephoneClient.Text.Trim() != "" ? reponse && client.Telephone.ToLower() == this.txtTelephoneClient.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtEmailClient.Text.Trim() != "" ? reponse && client.Email.ToLower() == this.txtEmailClient.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtAdresseClient.Text.Trim() != "" ? reponse && client.Adresse.ToLower() == txtAdresseClient.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtVilleClient.Text.Trim() != "" ? reponse && client.Ville.ToLower() == this.txtVilleClient.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtProvinceClient.Text.Trim() != "" ? reponse && client.Province.ToLower() == this.txtProvinceClient.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtCodepostalclient.Text.Trim() != "" ? reponse && client.CodePostal.ToLower() == txtCodepostalclient.Text.Trim().ToLower() : reponse && true;


            return reponse;

        }
        private void btnClientRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                //introduire la méthode de la condition de recherche dans la clause Where.

                var clients = context.Clients.Where(ClientCondition).ToList();

                this.dataGridViewListeClient.DataSource = clients;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        //définir une méthode qui nous permette de sélectionner une ligne en cliquant et de remplir automatiquement tous les champs avec les données de cette ligne.
        private void dataGridViewListeClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListeClient.CurrentRow.Index != -1)
            {
                try
                {

                    var toSelect = (int)dataGridViewListeClient.CurrentRow.Cells[0].Value;
                    var clientSelected = context.Clients.First(c => c.Id == toSelect);

                    this.txtNumClient.Text = clientSelected.Id.ToString();
                    this.txtNonClient.Text = clientSelected.Nom;
                    this.txtPrenonClient.Text = clientSelected.Prenom;
                    this.txtTelephoneClient.Text = clientSelected.Telephone;
                    this.txtEmailClient.Text = clientSelected.Email;
                    this.txtAdresseClient.Text = clientSelected.Adresse;
                    this.txtVilleClient.Text = clientSelected.Ville;
                    this.txtProvinceClient.Text = clientSelected.Province;
                    this.txtCodepostalclient.Text = clientSelected.CodePostal;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormVendeurReset()
        {
            txtNumeVendeur.Text = txtNomVendeur.Text = txtTelephonevendeur.Text = txtEmailVendeur.Text
                = txtAddresseVendeur.Text = txtVilleVendeur.Text = txtProvincevendeur.Text = string.Empty;

        }
        private void btnAjoutVendeur_Click(object sender, EventArgs e)
        {
            //Attraper l'exception du téléphone
            try
            {
                var vendeur = new Vendeur
                {
                    Nom = txtNomVendeur.Text.Trim(),
                    Telephone = txtTelephonevendeur.Text.Trim(),
                    Email = txtEmailClient.Text.Trim(),
                    Adresse = txtAddresseVendeur.Text.Trim(),
                    Ville = txtVilleVendeur.Text.Trim(),
                    Province = txtProvincevendeur.Text.Trim(),
                };
                context.Vendeurs.Add(vendeur);
                context.SaveChanges();
                FormVendeurReset();
                MessageBox.Show("Ajouter avec succes!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifVendeur_Click(object sender, EventArgs e)
        {
            if (dataGridViewListeVendeur.CurrentRow.Index != -1)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to modify?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    try
                    {

                        var toUpdate = (int)dataGridViewListeVendeur.CurrentRow.Cells[0].Value;
                        var vendeur = context.Vendeurs.Single(c => c.Id == toUpdate);

                        vendeur.Nom = this.txtNomVendeur.Text.Trim();
                        vendeur.Telephone = this.txtTelephonevendeur.Text.Trim();
                        vendeur.Email = this.txtEmailVendeur.Text.Trim();
                        vendeur.Adresse = this.txtAddresseVendeur.Text.Trim();
                        vendeur.Ville = this.txtVilleVendeur.Text.Trim();
                        vendeur.Province = this.txtProvincevendeur.Text.Trim();

                        context.SaveChanges();
                        dataGridViewListeVendeur.DataSource = context.Vendeurs.Where(v => v.Id == toUpdate).ToList();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void btnSupprimeVendeur_Click(object sender, EventArgs e)
        {
            if (dataGridViewListeVendeur.CurrentRow.Index != -1)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    var toDelete = (int)dataGridViewListeVendeur.CurrentRow.Cells[0].Value;
                    var vendeur = context.Vendeurs.First(v => v.Id == toDelete);
                    context.Vendeurs.Remove(vendeur);
                    context.SaveChanges();
                    dataGridViewListeVendeur.DataSource = context.Vendeurs.ToList();
                }
            }
        }

        private bool VendeurCondition(Vendeur vendeur)
        {
            bool reponse = true;
            reponse = this.txtNumeVendeur.Text.Trim() != "" ? reponse && vendeur.Id == Convert.ToInt32(this.txtNumeVendeur.Text.Trim()) : reponse && true;
            reponse = this.txtNomVendeur.Text.Trim() != "" ? reponse && vendeur.Telephone.ToLower() == this.txtNomVendeur.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtTelephonevendeur.Text.Trim() != "" ? reponse && vendeur.Telephone.ToLower() == this.txtTelephonevendeur.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtEmailVendeur.Text.Trim() != "" ? reponse && vendeur.Email.ToLower() == this.txtEmailVendeur.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtAddresseVendeur.Text.Trim() != "" ? reponse && vendeur.Adresse.ToLower() == txtAddresseVendeur.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtVilleVendeur.Text.Trim() != "" ? reponse && vendeur.Ville.ToLower() == this.txtVilleVendeur.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtProvincevendeur.Text.Trim() != "" ? reponse && vendeur.Province.ToLower() == this.txtProvincevendeur.Text.Trim().ToLower() : reponse && true;

            return reponse;

        }
        private void btnrecherchevendeur_Click(object sender, EventArgs e)
        {
            try
            {
                var vendeurs = context.Vendeurs.Where(VendeurCondition).ToList();

                this.dataGridViewListeVendeur.DataSource = vendeurs;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



        private void dataGridViewListeVendeur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListeVendeur.CurrentRow.Index != -1)
            {
                try
                {

                    var toSelect = (int)dataGridViewListeVendeur.CurrentRow.Cells[0].Value;
                    var vendeurSelected = context.Vendeurs.First(c => c.Id == toSelect);

                    this.txtNumeVendeur.Text = vendeurSelected.Id.ToString();
                    this.txtNomVendeur.Text = vendeurSelected.Nom;
                    this.txtTelephonevendeur.Text = vendeurSelected.Telephone;
                    this.txtEmailVendeur.Text = vendeurSelected.Email;
                    this.txtAddresseVendeur.Text = vendeurSelected.Adresse;
                    this.txtVilleVendeur.Text = vendeurSelected.Ville;
                    this.txtProvincevendeur.Text = vendeurSelected.Province;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormVoitureReset()
        {

            txtIdVoiture.Text = txtMarque.Text = txtModele.Text = txtAnnee.Text = numericHP.Text = txtCouleurVoiture.Text
                    = txtNivVoitire.Text = String.Empty;
            numericPortes.Value = 0;
            chxboxToit_Ouvrant.Checked = false;
            chxboxDemarrage_distance.Checked = false;
            chxboxSieges_Cuire.Checked = false;

        }

        private void btnAjoutVoiture_Click(object sender, EventArgs e)
        {

            var voiture = new VoitureVente
            {
                Marque = txtMarque.Text.Trim(),
                Modele = txtModele.Text.Trim(),
                Annee = txtAnnee.Text.Trim(),
                Chevaux_vapeur = (int)numericHP.Value,
                Couleur = txtCouleurVoiture.Text.Trim(),
                NIV = txtNivVoitire.Text.Trim(),
                Numero_portes = (int)numericPortes.Value,
                Toit_ouvrant = chxboxToit_Ouvrant.Checked,
                Demarrage_a_distance = chxboxDemarrage_distance.Checked,
                Sieges_en_cuir = chxboxSieges_Cuire.Checked


            };

            try
            {
                context.VoitureVentes.Add(voiture);
                context.SaveChanges();
                MessageBox.Show("Ajouter avec succes!");
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            FormVoitureReset();

        }

        private void btnModifierVoiture_Click(object sender, EventArgs e)
        {
            if (dataGridViewListeVoiture.CurrentRow.Index != -1)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to modify?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {

                    var toUpdate = (int)dataGridViewListeVoiture.CurrentRow.Cells[0].Value;
                    var voiture = context.VoitureVentes.Single(c => c.Id_voiture == toUpdate);

                    voiture.Marque = this.txtMarque.Text.Trim();
                    voiture.Modele = this.txtModele.Text.Trim();
                    voiture.Annee = this.txtAnnee.Text.Trim();
                    voiture.Chevaux_vapeur = (int)numericHP.Value;
                    voiture.Couleur = this.txtCouleurVoiture.Text.Trim();
                    voiture.NIV = this.txtNivVoitire.Text.Trim();
                    voiture.Numero_portes = (int)numericPortes.Value;
                    voiture.Toit_ouvrant = chxboxToit_Ouvrant.Checked;
                    voiture.Demarrage_a_distance = chxboxDemarrage_distance.Checked;
                    voiture.Sieges_en_cuir = chxboxSieges_Cuire.Checked;

                    try
                    {
                        context.SaveChanges();
                        dataGridViewListeVoiture.DataSource = context.VoitureVentes.Where(v => v.Id_voiture == toUpdate).ToList();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                FormVoitureReset();
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewListeVoiture.CurrentRow.Index != -1)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    var toDelete = (int)dataGridViewListeVoiture.CurrentRow.Cells[0].Value;
                    var voiture = context.VoitureVentes.First(c => c.Id_voiture == toDelete);
                    context.VoitureVentes.Remove(voiture);
                    context.SaveChanges();
                    dataGridViewListeVoiture.DataSource = context.VoitureVentes.ToList();
                }
            }
        }
        private bool VoitureCondition(VoitureVente voiture)
        {
            bool reponse = true;
            reponse = this.txtNumVoiture.Text.Trim() != "" ? reponse && voiture.Id_voiture == Convert.ToInt32(this.txtNumVoiture.Text.Trim()) : reponse && true;

            reponse = this.txtMarque.Text.Trim() != "" ? reponse && voiture.Marque.ToLower() == this.txtMarque.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtModele.Text.Trim() != "" ? reponse && voiture.Modele.ToLower() == this.txtModele.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtCouleurVoiture.Text.Trim() != "" ? reponse && voiture.Couleur.ToLower() == this.txtCouleurVoiture.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtNivVoitire.Text.Trim() != "" ? reponse && voiture.NIV.ToLower() == this.txtNivVoitire.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtAnnee.Text.Trim() != "" ? reponse && Convert.ToInt32(voiture.Annee) >= Convert.ToInt32(txtAnnee.Text.Trim()) : reponse && true;

            reponse = this.numericHP.Value != 0 ? reponse && voiture.Chevaux_vapeur >= this.numericHP.Value : reponse && true;
            reponse = this.numericPortes.Value != 0 ? reponse && voiture.Numero_portes >= this.numericPortes.Value : reponse && true;
            reponse = this.chxboxToit_Ouvrant.Checked ? reponse && voiture.Toit_ouvrant == true : reponse && true;
            reponse = this.chxboxDemarrage_distance.Checked ? reponse && voiture.Demarrage_a_distance == true : reponse && true;
            reponse = this.chxboxSieges_Cuire.Checked ? reponse && voiture.Sieges_en_cuir == true : reponse && true;

            return reponse;

        }

        private void btnVoitureRechercher_Click(object sender, EventArgs e)
        {
            var voitures = context.VoitureVentes.Where(VoitureCondition);
            this.dataGridViewListeVoiture.DataSource = voitures.ToList();

        }


        private void dataGridViewListeVoiture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListeVoiture.CurrentRow.Index != -1)
            {
                var toSelect = (int)dataGridViewListeVoiture.CurrentRow.Cells[0].Value;
                var voitureSelected = context.VoitureVentes.First(c => c.Id_voiture == toSelect);

                this.txtNumVoiture.Text = voitureSelected.Id_voiture.ToString();
                this.txtMarque.Text = voitureSelected.Marque;
                this.txtModele.Text = voitureSelected.Modele;
                this.txtAnnee.Text = voitureSelected.Annee;
                this.numericHP.Value = (decimal)voitureSelected.Chevaux_vapeur;
                this.txtCouleurVoiture.Text = voitureSelected.Couleur;
                this.txtNivVoitire.Text = voitureSelected.NIV;
                this.numericPortes.Value = (decimal)voitureSelected.Numero_portes;
                this.chxboxToit_Ouvrant.Checked = (bool)voitureSelected.Toit_ouvrant;
                this.chxboxDemarrage_distance.Checked = (bool)voitureSelected.Demarrage_a_distance;
                this.chxboxSieges_Cuire.Checked = (bool)voitureSelected.Sieges_en_cuir;

            }


        }

        //Méthode de réinitialisation des champs pour la facture.
        public void FormFacVenteReset()
        {
            txtIdFacture.Text = txtIdClient.Text = txtNumFacture.Text = txtIdVoiture.Text = String.Empty;
            numericPrixVente.Value = 0;
            dateFactureVenteDebut.Value = new DateTime(2010, 8, 8);
            dateFactureVenteFin.Value = DateTime.Today;


        }
        private void btnAjouterFactureVente_Click(object sender, EventArgs e)
        {
            var factureVente = new FactureVente
            {
                NumFacture = txtNumFacture.Text.Trim(),
                Id_client = Convert.ToInt32(txtIdClient.Text.Trim()),
                Id_voiture = Convert.ToInt32(txtIdVoiture.Text.Trim()),
                Prix = numericPrixVente.Value,
                Date = dateFactureVenteDebut.Value,
            };

            //attraper les exceptions du numéro de facture unique et les violations des clés étrangères du client ou de la voiture
            try
            {

                context.FactureVentes.Add(factureVente);
                context.SaveChanges();
                MessageBox.Show("Ajouter avec succes!");
            }
            catch (Exception)
            {
                MessageBox.Show("Numéro de facture dupliqué ou Id_client ou Id_voiture hors limites.");
            }
            dataGridViewFactureVente.DataSource = context.FactureVentes.ToList();
            FormFacVenteReset();
        }

        private void btnModifierFactureVente_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactureVente.CurrentRow.Index != -1)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to modify?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {

                    var toUpdate = (int)dataGridViewFactureVente.CurrentRow.Cells[0].Value;
                    var facture = context.FactureVentes.Single(f => f.Id == toUpdate);

                    facture.Id = Convert.ToInt32(this.txtIdFacture.Text.Trim());
                    facture.Id_client = Convert.ToInt32(this.txtIdClient.Text.Trim());
                    facture.Id_voiture = Convert.ToInt32(this.txtIdVoiture.Text.Trim());
                    facture.NumFacture = this.txtNumFacture.Text.Trim();
                    facture.Prix = this.numericPrixVente.Value;
                    facture.Date = this.dateFactureVenteDebut.Value;

                    try
                    {
                        context.SaveChanges();

                    }

                    catch (Exception)
                    {

                        MessageBox.Show("Numéro de facture dupliqué ou Id_client ou Id_voiture hors limites.");
                    }
                    dataGridViewFactureVente.DataSource = context.FactureVentes.Where(f => f.Id == toUpdate).ToList();
                }
            }
        }

        private bool FactureVenteCondition(FactureVente factureVente)
        {
            bool reponse = true;
            reponse = this.txtIdFacture.Text.Trim() != "" ? reponse && factureVente.Id == Convert.ToInt32(this.txtIdFacture.Text.Trim()) : reponse && true;

            reponse = this.txtIdClient.Text.Trim() != "" ? reponse && factureVente.Id_client == Convert.ToInt32(this.txtIdClient.Text.Trim()) : reponse && true;
            reponse = this.txtNumFacture.Text.Trim() != "" ? reponse && factureVente.NumFacture.ToLower() == this.txtNumFacture.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtIdVoiture.Text.Trim() != "" ? reponse && factureVente.Id_voiture == Convert.ToInt32(this.txtIdVoiture.Text.Trim()) : reponse && true;

            reponse = this.numericPrixVente.Value != 0 ? reponse && factureVente.Prix <= this.numericPrixVente.Value : reponse && true;
            reponse = this.trackBarPrix.Value != 0 ? reponse && factureVente.Prix <= this.trackBarPrix.Value : reponse && true;

            reponse = this.dateFactureVenteDebut.Value != DateTime.Today ? reponse && factureVente.Date >= this.dateFactureVenteDebut.Value : reponse && true;
            reponse = this.dateFactureVenteFin.Value != DateTime.Today ? reponse && factureVente.Date <= this.dateFactureVenteFin.Value : reponse && true;

            return reponse;

        }
        private void btnrechercherFactureVente_Click(object sender, EventArgs e)
        {
            var factures = context.FactureVentes.Where(FactureVenteCondition).OrderByDescending(f => f.Prix).ToList();
            this.dataGridViewFactureVente.DataSource = factures;
        }

        //réaliser un textbox pour afficher la valeur en temps réel du trackbar.
        private void trackBarPrix_Scroll(object sender, EventArgs e)
        {
            this.labelPrix.Text = trackBarPrix.Value.ToString();
        }

        private void dataGridViewFactureVente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var toSelect = (int)dataGridViewFactureVente.CurrentRow.Cells[0].Value;
            var factureSelected = context.FactureVentes.First(f => f.Id == toSelect);

            this.txtIdFacture.Text = factureSelected.Id.ToString();
            this.txtIdClient.Text = factureSelected.Id_client.ToString();
            this.txtNumFacture.Text = factureSelected.NumFacture;
            this.txtIdVoiture.Text = factureSelected.Id_voiture.ToString();
            this.numericPrixVente.Value = factureSelected.Prix;
            this.dateFactureVenteDebut.Value = (DateTime)factureSelected.Date;
        }

        private void btnSupprimFactureVente_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactureVente.CurrentRow.Index != -1)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    var toDelete = (int)dataGridViewFactureVente.CurrentRow.Cells[0].Value;
                    var facture = context.FactureVentes.First(f => f.Id == toDelete);
                    context.FactureVentes.Remove(facture);
                    context.SaveChanges();
                    dataGridViewFactureVente.DataSource = context.FactureVentes.ToList();
                }
            }
        }

        private void BtnTrinitialiserFacture_Vente_Click(object sender, EventArgs e)
        {
            FormFacVenteReset();
        }


        //définir les valeurs de réinitialisation de tous les champs affichés sur le formulaire.
        public void FormFacAchatReset()
        {
            txtIdFactureAchat.Text = txtIdVendeur.Text = txtNumFactureAchat.Text = txtIdVoitureAchat.Text = String.Empty;
            numericPrixAchat.Value = 0;
            dateAchatDebut.Value = new DateTime(2010, 8, 8);
            dateAchatFin.Value = DateTime.Today;


        }

        private void btnAjouterFactAchat_Click(object sender, EventArgs e)
        {

            var factureAchat = new FactureAchat
            {
                NumFacture = txtNumFactureAchat.Text.Trim(),
                Id_vendeur = Convert.ToInt32(txtIdVendeur.Text.Trim()),
                Id_voiture = Convert.ToInt32(txtIdVoitureAchat.Text.Trim()),
                Prix = numericPrixAchat.Value,
                Date = dateAchatDebut.Value,

            };

            //attraper les exceptions du numéro de facture unique et les violations des clés étrangères du vendeur ou de la voiture

            try
            {
                context.FactureAchats.Add(factureAchat);
                context.SaveChanges();
                MessageBox.Show("Ajouter avec succes!");
            }
            catch (Exception)
            {

                MessageBox.Show("Numéro de facture dupliqué ou Id_client ou Id_voiture hors limites.");
            }

            dataGridViewFactureAchat.DataSource = context.FactureAchats.ToList();
            FormFacAchatReset();

        }

        private void btnModifieFactureAchat_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactureAchat.CurrentRow.Index != -1)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to modify?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    var toUpdate = (int)dataGridViewFactureAchat.CurrentRow.Cells[0].Value;
                    var facture = context.FactureAchats.Single(f => f.Id == toUpdate);

                    facture.Id = Convert.ToInt32(this.txtIdFactureAchat.Text.Trim());
                    facture.Id_vendeur = Convert.ToInt32(this.txtIdVendeur.Text.Trim());
                    facture.Id_voiture = Convert.ToInt32(this.txtIdVoitureAchat.Text.Trim());
                    facture.NumFacture = this.txtNumFactureAchat.Text.Trim();
                    facture.Prix = this.numericPrixAchat.Value;
                    facture.Date = this.dateAchatDebut.Value;
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Numéro de facture dupliqué ou Id_client ou Id_voiture hors limites.");
                    }

                    dataGridViewFactureAchat.DataSource = context.FactureAchats.ToList();
                }
            }


        }

        private void btnSupprimFactureAchat_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactureAchat.CurrentRow.Index != -1)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    var toDelete = (int)dataGridViewFactureAchat.CurrentRow.Cells[0].Value;
                    var facture = context.FactureAchats.First(f => f.Id == toDelete);
                    context.FactureAchats.Remove(facture);
                    context.SaveChanges();
                    dataGridViewFactureAchat.DataSource = context.FactureAchats.ToList();
                }
            }


        }

        private bool FactureAchatCondition(FactureAchat factureAchat)
        {
            bool reponse = true;
            reponse = this.txtIdFactureAchat.Text.Trim() != "" ? reponse && factureAchat.Id == Convert.ToInt32(this.txtIdFactureAchat.Text.Trim()) : reponse && true;

            reponse = this.txtIdVendeur.Text.Trim() != "" ? reponse && factureAchat.Id_vendeur == Convert.ToInt32(this.txtIdVendeur.Text.Trim()) : reponse && true;
            reponse = this.txtNumFactureAchat.Text.Trim() != "" ? reponse && factureAchat.NumFacture.ToLower() == this.txtNumFactureAchat.Text.Trim().ToLower() : reponse && true;
            reponse = this.txtIdVoitureAchat.Text.Trim() != "" ? reponse && factureAchat.Id_voiture == Convert.ToInt32(this.txtIdVoitureAchat.Text.Trim()) : reponse && true;
            reponse = this.numericPrixAchat.Value != 0 ? reponse && factureAchat.Prix <= this.numericPrixAchat.Value : reponse && true;
            reponse = this.trackBarPrixAchat.Value != 0 ? reponse && factureAchat.Prix <= this.trackBarPrixAchat.Value : reponse && true;

            reponse = this.dateAchatDebut.Value != DateTime.Today ? reponse && factureAchat.Date >= this.dateAchatDebut.Value : reponse && true;
            reponse = this.dateAchatFin.Value != DateTime.Today ? reponse && factureAchat.Date <= this.dateAchatFin.Value : reponse && true;

            return reponse;

        }
        private void btnRecherche_Click(object sender, EventArgs e)
        {

            var factures = context.FactureAchats.Where(FactureAchatCondition).OrderByDescending(f => f.Prix).ToList();
            this.dataGridViewFactureAchat.DataSource = factures;

        }

        private void trackBarPrixAchat_Scroll(object sender, EventArgs e)
        {
            this.label41.Text = trackBarPrixAchat.Value.ToString();

        }

        private void dataGridViewFactureAchat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var toSelect = (int)dataGridViewFactureAchat.CurrentRow.Cells[0].Value;
            var factureSelected = context.FactureAchats.First(f => f.Id == toSelect);

            this.txtIdFactureAchat.Text = factureSelected.Id.ToString();
            this.txtIdVendeur.Text = factureSelected.Id_vendeur.ToString();
            this.txtNumFactureAchat.Text = factureSelected.NumFacture;
            this.txtIdVoitureAchat.Text = factureSelected.Id_voiture.ToString();
            this.numericPrixAchat.Value = factureSelected.Prix;
            this.dateAchatDebut.Value = (DateTime)factureSelected.Date;
        }

        //définir un événement de bouton de réinitialisation pour appeler les méthodes de réinitialisation.
        private void BtnTrinitialiserFactureAchat_Click(object sender, EventArgs e)
        {
            FormFacAchatReset();
        }

        private void BtnTrinitialiserClient_Click(object sender, EventArgs e)
        {
            FormClientReset();
        }

        private void BtnTrinitialiserVendeur_Click(object sender, EventArgs e)
        {
            FormVendeurReset();
        }

        private void BtnTrinitialiserVenteVoiture_Click(object sender, EventArgs e)
        {
            FormVoitureReset();
        }

    }
}