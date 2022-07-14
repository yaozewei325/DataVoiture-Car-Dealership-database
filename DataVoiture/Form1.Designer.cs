
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DataVoiture
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnTrinitialiserClient = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.dataGridViewListeClient = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodepostalclient = new System.Windows.Forms.TextBox();
            this.txtProvinceClient = new System.Windows.Forms.TextBox();
            this.txtVilleClient = new System.Windows.Forms.TextBox();
            this.txtAdresseClient = new System.Windows.Forms.TextBox();
            this.txtEmailClient = new System.Windows.Forms.TextBox();
            this.txtTelephoneClient = new System.Windows.Forms.TextBox();
            this.txtPrenonClient = new System.Windows.Forms.TextBox();
            this.txtNonClient = new System.Windows.Forms.TextBox();
            this.txtNumClient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnTrinitialiserVendeur = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dataGridViewListeVendeur = new System.Windows.Forms.DataGridView();
            this.btnrecherchevendeur = new System.Windows.Forms.Button();
            this.btnSupprimeVendeur = new System.Windows.Forms.Button();
            this.btnModifVendeur = new System.Windows.Forms.Button();
            this.btnAjoutVendeur = new System.Windows.Forms.Button();
            this.txtProvincevendeur = new System.Windows.Forms.TextBox();
            this.txtVilleVendeur = new System.Windows.Forms.TextBox();
            this.txtAddresseVendeur = new System.Windows.Forms.TextBox();
            this.txtEmailVendeur = new System.Windows.Forms.TextBox();
            this.txtTelephonevendeur = new System.Windows.Forms.TextBox();
            this.txtNomVendeur = new System.Windows.Forms.TextBox();
            this.txtNumeVendeur = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericHP = new System.Windows.Forms.NumericUpDown();
            this.numericPortes = new System.Windows.Forms.NumericUpDown();
            this.BtnTrinitialiserVenteVoiture = new System.Windows.Forms.Button();
            this.chxboxSieges_Cuire = new System.Windows.Forms.CheckBox();
            this.chxboxDemarrage_distance = new System.Windows.Forms.CheckBox();
            this.chxboxToit_Ouvrant = new System.Windows.Forms.CheckBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dataGridViewListeVoiture = new System.Windows.Forms.DataGridView();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtNivVoitire = new System.Windows.Forms.TextBox();
            this.txtCouleurVoiture = new System.Windows.Forms.TextBox();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.txtModele = new System.Windows.Forms.TextBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.txtNumVoiture = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.dateFactureVenteFin = new System.Windows.Forms.DateTimePicker();
            this.dateFactureVenteDebut = new System.Windows.Forms.DateTimePicker();
            this.numericPrixVente = new System.Windows.Forms.NumericUpDown();
            this.labelPrix = new System.Windows.Forms.Label();
            this.trackBarPrix = new System.Windows.Forms.TrackBar();
            this.BtnTrinitialiserFacture_Vente = new System.Windows.Forms.Button();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.btnrechercherFactureVente = new System.Windows.Forms.Button();
            this.dataGridViewFactureVente = new System.Windows.Forms.DataGridView();
            this.label34 = new System.Windows.Forms.Label();
            this.txtIdFacture = new System.Windows.Forms.TextBox();
            this.btnSupprimFactureVente = new System.Windows.Forms.Button();
            this.btnModifierFactureVente = new System.Windows.Forms.Button();
            this.btnAjouterFactureVente = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.txtIdVoiture = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtNumFacture = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.numericPrixAchat = new System.Windows.Forms.NumericUpDown();
            this.trackBarPrixAchat = new System.Windows.Forms.TrackBar();
            this.label39 = new System.Windows.Forms.Label();
            this.txtNumFactureAchat = new System.Windows.Forms.TextBox();
            this.txtIdVendeur = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.txtIdFactureAchat = new System.Windows.Forms.TextBox();
            this.txtIdVoitureAchat = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dateAchatFin = new System.Windows.Forms.DateTimePicker();
            this.dateAchatDebut = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.BtnTrinitialiserFactureAchat = new System.Windows.Forms.Button();
            this.dataGridViewFactureAchat = new System.Windows.Forms.DataGridView();
            this.btnSupprimFactureAchat = new System.Windows.Forms.Button();
            this.btnModifieFactureAchat = new System.Windows.Forms.Button();
            this.btnAjouterFactAchat = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeClient)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeVendeur)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPortes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeVoiture)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrixVente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactureVente)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrixAchat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrixAchat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactureAchat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 636);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Client";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.BtnTrinitialiserClient);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.dataGridViewListeClient);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtCodepostalclient);
            this.panel1.Controls.Add(this.txtProvinceClient);
            this.panel1.Controls.Add(this.txtVilleClient);
            this.panel1.Controls.Add(this.txtAdresseClient);
            this.panel1.Controls.Add(this.txtEmailClient);
            this.panel1.Controls.Add(this.txtTelephoneClient);
            this.panel1.Controls.Add(this.txtPrenonClient);
            this.panel1.Controls.Add(this.txtNonClient);
            this.panel1.Controls.Add(this.txtNumClient);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 611);
            this.panel1.TabIndex = 0;
            // 
            // BtnTrinitialiserClient
            // 
            this.BtnTrinitialiserClient.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrinitialiserClient.Location = new System.Drawing.Point(729, 260);
            this.BtnTrinitialiserClient.Name = "BtnTrinitialiserClient";
            this.BtnTrinitialiserClient.Size = new System.Drawing.Size(139, 40);
            this.BtnTrinitialiserClient.TabIndex = 25;
            this.BtnTrinitialiserClient.Text = "Reinitialiser";
            this.BtnTrinitialiserClient.UseVisualStyleBackColor = true;
            this.BtnTrinitialiserClient.Click += new System.EventHandler(this.BtnTrinitialiserClient_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(286, 13);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(303, 30);
            this.label43.TabIndex = 24;
            this.label43.Text = "INFORMATIONS DES  CLIENT";
            // 
            // dataGridViewListeClient
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewListeClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewListeClient.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListeClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListeClient.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewListeClient.Location = new System.Drawing.Point(3, 306);
            this.dataGridViewListeClient.Name = "dataGridViewListeClient";
            this.dataGridViewListeClient.RowTemplate.Height = 25;
            this.dataGridViewListeClient.Size = new System.Drawing.Size(997, 294);
            this.dataGridViewListeClient.TabIndex = 23;
            this.dataGridViewListeClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListeClient_CellContentClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(514, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 56);
            this.button4.TabIndex = 21;
            this.button4.Text = "Rechercher";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnClientRecherche_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(729, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 39);
            this.button3.TabIndex = 20;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnClientDelete);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(729, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClientModifier_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(729, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAjoutClient_Click);
            // 
            // txtCodepostalclient
            // 
            this.txtCodepostalclient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCodepostalclient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodepostalclient.Location = new System.Drawing.Point(514, 202);
            this.txtCodepostalclient.Name = "txtCodepostalclient";
            this.txtCodepostalclient.Size = new System.Drawing.Size(169, 25);
            this.txtCodepostalclient.TabIndex = 17;
            // 
            // txtProvinceClient
            // 
            this.txtProvinceClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtProvinceClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvinceClient.Location = new System.Drawing.Point(514, 157);
            this.txtProvinceClient.Name = "txtProvinceClient";
            this.txtProvinceClient.Size = new System.Drawing.Size(169, 25);
            this.txtProvinceClient.TabIndex = 16;
            // 
            // txtVilleClient
            // 
            this.txtVilleClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtVilleClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVilleClient.Location = new System.Drawing.Point(514, 116);
            this.txtVilleClient.Name = "txtVilleClient";
            this.txtVilleClient.Size = new System.Drawing.Size(169, 25);
            this.txtVilleClient.TabIndex = 15;
            // 
            // txtAdresseClient
            // 
            this.txtAdresseClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAdresseClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresseClient.Location = new System.Drawing.Point(514, 78);
            this.txtAdresseClient.Name = "txtAdresseClient";
            this.txtAdresseClient.Size = new System.Drawing.Size(169, 25);
            this.txtAdresseClient.TabIndex = 14;
            // 
            // txtEmailClient
            // 
            this.txtEmailClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtEmailClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailClient.Location = new System.Drawing.Point(173, 243);
            this.txtEmailClient.Name = "txtEmailClient";
            this.txtEmailClient.Size = new System.Drawing.Size(165, 25);
            this.txtEmailClient.TabIndex = 13;
            // 
            // txtTelephoneClient
            // 
            this.txtTelephoneClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTelephoneClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephoneClient.Location = new System.Drawing.Point(173, 199);
            this.txtTelephoneClient.Name = "txtTelephoneClient";
            this.txtTelephoneClient.Size = new System.Drawing.Size(165, 25);
            this.txtTelephoneClient.TabIndex = 12;
            // 
            // txtPrenonClient
            // 
            this.txtPrenonClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrenonClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenonClient.Location = new System.Drawing.Point(173, 153);
            this.txtPrenonClient.Name = "txtPrenonClient";
            this.txtPrenonClient.Size = new System.Drawing.Size(165, 25);
            this.txtPrenonClient.TabIndex = 11;
            // 
            // txtNonClient
            // 
            this.txtNonClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNonClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNonClient.Location = new System.Drawing.Point(173, 115);
            this.txtNonClient.Name = "txtNonClient";
            this.txtNonClient.Size = new System.Drawing.Size(165, 25);
            this.txtNonClient.TabIndex = 10;
            // 
            // txtNumClient
            // 
            this.txtNumClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNumClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumClient.Location = new System.Drawing.Point(173, 77);
            this.txtNumClient.Name = "txtNumClient";
            this.txtNumClient.Size = new System.Drawing.Size(165, 25);
            this.txtNumClient.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(394, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Code postal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(394, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Province :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ville :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Téléphone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénoms :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro client :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vendeur";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.BtnTrinitialiserVendeur);
            this.panel2.Controls.Add(this.label44);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.dataGridViewListeVendeur);
            this.panel2.Controls.Add(this.btnrecherchevendeur);
            this.panel2.Controls.Add(this.btnSupprimeVendeur);
            this.panel2.Controls.Add(this.btnModifVendeur);
            this.panel2.Controls.Add(this.btnAjoutVendeur);
            this.panel2.Controls.Add(this.txtProvincevendeur);
            this.panel2.Controls.Add(this.txtVilleVendeur);
            this.panel2.Controls.Add(this.txtAddresseVendeur);
            this.panel2.Controls.Add(this.txtEmailVendeur);
            this.panel2.Controls.Add(this.txtTelephonevendeur);
            this.panel2.Controls.Add(this.txtNomVendeur);
            this.panel2.Controls.Add(this.txtNumeVendeur);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 599);
            this.panel2.TabIndex = 0;
            // 
            // BtnTrinitialiserVendeur
            // 
            this.BtnTrinitialiserVendeur.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrinitialiserVendeur.Location = new System.Drawing.Point(720, 230);
            this.BtnTrinitialiserVendeur.Name = "BtnTrinitialiserVendeur";
            this.BtnTrinitialiserVendeur.Size = new System.Drawing.Size(141, 39);
            this.BtnTrinitialiserVendeur.TabIndex = 48;
            this.BtnTrinitialiserVendeur.Text = "Reinitialiser";
            this.BtnTrinitialiserVendeur.UseVisualStyleBackColor = true;
            this.BtnTrinitialiserVendeur.Click += new System.EventHandler(this.BtnTrinitialiserVendeur_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(271, 19);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(323, 30);
            this.label44.TabIndex = 47;
            this.label44.Text = "INFORMATIONS DES VENDEUR";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(24, 209);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 21);
            this.label24.TabIndex = 46;
            this.label24.Text = "Email :";
            // 
            // dataGridViewListeVendeur
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewListeVendeur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewListeVendeur.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListeVendeur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewListeVendeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeVendeur.Location = new System.Drawing.Point(3, 288);
            this.dataGridViewListeVendeur.Name = "dataGridViewListeVendeur";
            this.dataGridViewListeVendeur.RowTemplate.Height = 25;
            this.dataGridViewListeVendeur.Size = new System.Drawing.Size(991, 308);
            this.dataGridViewListeVendeur.TabIndex = 45;
            this.dataGridViewListeVendeur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListeVendeur_CellContentClick);
            // 
            // btnrecherchevendeur
            // 
            this.btnrecherchevendeur.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecherchevendeur.Location = new System.Drawing.Point(482, 219);
            this.btnrecherchevendeur.Name = "btnrecherchevendeur";
            this.btnrecherchevendeur.Size = new System.Drawing.Size(196, 50);
            this.btnrecherchevendeur.TabIndex = 43;
            this.btnrecherchevendeur.Text = "Rechercher";
            this.btnrecherchevendeur.UseVisualStyleBackColor = true;
            this.btnrecherchevendeur.Click += new System.EventHandler(this.btnrecherchevendeur_Click);
            // 
            // btnSupprimeVendeur
            // 
            this.btnSupprimeVendeur.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimeVendeur.Location = new System.Drawing.Point(720, 178);
            this.btnSupprimeVendeur.Name = "btnSupprimeVendeur";
            this.btnSupprimeVendeur.Size = new System.Drawing.Size(141, 38);
            this.btnSupprimeVendeur.TabIndex = 42;
            this.btnSupprimeVendeur.Text = "Supprimer";
            this.btnSupprimeVendeur.UseVisualStyleBackColor = true;
            this.btnSupprimeVendeur.Click += new System.EventHandler(this.btnSupprimeVendeur_Click);
            // 
            // btnModifVendeur
            // 
            this.btnModifVendeur.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifVendeur.Location = new System.Drawing.Point(720, 127);
            this.btnModifVendeur.Name = "btnModifVendeur";
            this.btnModifVendeur.Size = new System.Drawing.Size(141, 38);
            this.btnModifVendeur.TabIndex = 41;
            this.btnModifVendeur.Text = "Modifier";
            this.btnModifVendeur.UseVisualStyleBackColor = true;
            this.btnModifVendeur.Click += new System.EventHandler(this.btnModifVendeur_Click);
            // 
            // btnAjoutVendeur
            // 
            this.btnAjoutVendeur.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutVendeur.Location = new System.Drawing.Point(720, 78);
            this.btnAjoutVendeur.Name = "btnAjoutVendeur";
            this.btnAjoutVendeur.Size = new System.Drawing.Size(141, 38);
            this.btnAjoutVendeur.TabIndex = 40;
            this.btnAjoutVendeur.Text = "Ajouter";
            this.btnAjoutVendeur.UseVisualStyleBackColor = true;
            this.btnAjoutVendeur.Click += new System.EventHandler(this.btnAjoutVendeur_Click);
            // 
            // txtProvincevendeur
            // 
            this.txtProvincevendeur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvincevendeur.Location = new System.Drawing.Point(482, 166);
            this.txtProvincevendeur.Name = "txtProvincevendeur";
            this.txtProvincevendeur.Size = new System.Drawing.Size(196, 25);
            this.txtProvincevendeur.TabIndex = 38;
            // 
            // txtVilleVendeur
            // 
            this.txtVilleVendeur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVilleVendeur.Location = new System.Drawing.Point(482, 122);
            this.txtVilleVendeur.Name = "txtVilleVendeur";
            this.txtVilleVendeur.Size = new System.Drawing.Size(196, 25);
            this.txtVilleVendeur.TabIndex = 37;
            // 
            // txtAddresseVendeur
            // 
            this.txtAddresseVendeur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddresseVendeur.Location = new System.Drawing.Point(482, 79);
            this.txtAddresseVendeur.Name = "txtAddresseVendeur";
            this.txtAddresseVendeur.Size = new System.Drawing.Size(196, 25);
            this.txtAddresseVendeur.TabIndex = 36;
            // 
            // txtEmailVendeur
            // 
            this.txtEmailVendeur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailVendeur.Location = new System.Drawing.Point(179, 210);
            this.txtEmailVendeur.Name = "txtEmailVendeur";
            this.txtEmailVendeur.Size = new System.Drawing.Size(165, 25);
            this.txtEmailVendeur.TabIndex = 35;
            // 
            // txtTelephonevendeur
            // 
            this.txtTelephonevendeur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephonevendeur.Location = new System.Drawing.Point(179, 166);
            this.txtTelephonevendeur.Name = "txtTelephonevendeur";
            this.txtTelephonevendeur.Size = new System.Drawing.Size(165, 25);
            this.txtTelephonevendeur.TabIndex = 34;
            // 
            // txtNomVendeur
            // 
            this.txtNomVendeur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomVendeur.Location = new System.Drawing.Point(179, 124);
            this.txtNomVendeur.Name = "txtNomVendeur";
            this.txtNomVendeur.Size = new System.Drawing.Size(165, 25);
            this.txtNomVendeur.TabIndex = 33;
            // 
            // txtNumeVendeur
            // 
            this.txtNumeVendeur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeVendeur.Location = new System.Drawing.Point(179, 81);
            this.txtNumeVendeur.Name = "txtNumeVendeur";
            this.txtNumeVendeur.Size = new System.Drawing.Size(165, 25);
            this.txtNumeVendeur.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(376, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 21);
            this.label11.TabIndex = 29;
            this.label11.Text = "Province :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(376, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ville :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(376, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "Adresse :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 21);
            this.label14.TabIndex = 26;
            this.label14.Text = "Téléphone :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 21);
            this.label15.TabIndex = 25;
            this.label15.Text = "Nom :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 21);
            this.label16.TabIndex = 24;
            this.label16.Text = "Numéro vendeur :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1006, 610);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Voiture";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.numericHP);
            this.panel3.Controls.Add(this.numericPortes);
            this.panel3.Controls.Add(this.BtnTrinitialiserVenteVoiture);
            this.panel3.Controls.Add(this.chxboxSieges_Cuire);
            this.panel3.Controls.Add(this.chxboxDemarrage_distance);
            this.panel3.Controls.Add(this.chxboxToit_Ouvrant);
            this.panel3.Controls.Add(this.label45);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.dataGridViewListeVoiture);
            this.panel3.Controls.Add(this.btnRechercher);
            this.panel3.Controls.Add(this.btnSupprimer);
            this.panel3.Controls.Add(this.btnModifier);
            this.panel3.Controls.Add(this.btnAjouter);
            this.panel3.Controls.Add(this.txtNivVoitire);
            this.panel3.Controls.Add(this.txtCouleurVoiture);
            this.panel3.Controls.Add(this.txtAnnee);
            this.panel3.Controls.Add(this.txtModele);
            this.panel3.Controls.Add(this.txtMarque);
            this.panel3.Controls.Add(this.txtNumVoiture);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(5, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 591);
            this.panel3.TabIndex = 0;
            // 
            // numericHP
            // 
            this.numericHP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericHP.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericHP.Location = new System.Drawing.Point(770, 65);
            this.numericHP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericHP.Name = "numericHP";
            this.numericHP.Size = new System.Drawing.Size(120, 25);
            this.numericHP.TabIndex = 59;
            // 
            // numericPortes
            // 
            this.numericPortes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPortes.Location = new System.Drawing.Point(770, 116);
            this.numericPortes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericPortes.Name = "numericPortes";
            this.numericPortes.Size = new System.Drawing.Size(120, 25);
            this.numericPortes.TabIndex = 58;
            // 
            // BtnTrinitialiserVenteVoiture
            // 
            this.BtnTrinitialiserVenteVoiture.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrinitialiserVenteVoiture.Location = new System.Drawing.Point(770, 162);
            this.BtnTrinitialiserVenteVoiture.Name = "BtnTrinitialiserVenteVoiture";
            this.BtnTrinitialiserVenteVoiture.Size = new System.Drawing.Size(120, 38);
            this.BtnTrinitialiserVenteVoiture.TabIndex = 57;
            this.BtnTrinitialiserVenteVoiture.Text = "Reinitialiser";
            this.BtnTrinitialiserVenteVoiture.UseVisualStyleBackColor = true;
            this.BtnTrinitialiserVenteVoiture.Click += new System.EventHandler(this.BtnTrinitialiserVenteVoiture_Click);
            // 
            // chxboxSieges_Cuire
            // 
            this.chxboxSieges_Cuire.AutoSize = true;
            this.chxboxSieges_Cuire.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxboxSieges_Cuire.Location = new System.Drawing.Point(618, 162);
            this.chxboxSieges_Cuire.Name = "chxboxSieges_Cuire";
            this.chxboxSieges_Cuire.Size = new System.Drawing.Size(117, 21);
            this.chxboxSieges_Cuire.TabIndex = 55;
            this.chxboxSieges_Cuire.Text = "Sièges en cuire";
            this.chxboxSieges_Cuire.UseVisualStyleBackColor = true;
            // 
            // chxboxDemarrage_distance
            // 
            this.chxboxDemarrage_distance.AutoSize = true;
            this.chxboxDemarrage_distance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxboxDemarrage_distance.Location = new System.Drawing.Point(433, 159);
            this.chxboxDemarrage_distance.Name = "chxboxDemarrage_distance";
            this.chxboxDemarrage_distance.Size = new System.Drawing.Size(159, 21);
            this.chxboxDemarrage_distance.TabIndex = 54;
            this.chxboxDemarrage_distance.Text = "Démarrage à distance";
            this.chxboxDemarrage_distance.UseVisualStyleBackColor = true;
            // 
            // chxboxToit_Ouvrant
            // 
            this.chxboxToit_Ouvrant.AutoSize = true;
            this.chxboxToit_Ouvrant.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxboxToit_Ouvrant.Location = new System.Drawing.Point(311, 159);
            this.chxboxToit_Ouvrant.Name = "chxboxToit_Ouvrant";
            this.chxboxToit_Ouvrant.Size = new System.Drawing.Size(101, 21);
            this.chxboxToit_Ouvrant.TabIndex = 53;
            this.chxboxToit_Ouvrant.Text = "Toit ouvrant";
            this.chxboxToit_Ouvrant.UseVisualStyleBackColor = true;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(306, 13);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(327, 30);
            this.label45.TabIndex = 52;
            this.label45.Text = "INFORMATIONS DES VOITURES";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(614, 66);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(133, 21);
            this.label26.TabIndex = 47;
            this.label26.Text = "Chevaux vapeur :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(24, 113);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(75, 21);
            this.label25.TabIndex = 46;
            this.label25.Text = "Marque :";
            // 
            // dataGridViewListeVoiture
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewListeVoiture.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewListeVoiture.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListeVoiture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListeVoiture.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewListeVoiture.Location = new System.Drawing.Point(3, 263);
            this.dataGridViewListeVoiture.Name = "dataGridViewListeVoiture";
            this.dataGridViewListeVoiture.RowTemplate.Height = 25;
            this.dataGridViewListeVoiture.Size = new System.Drawing.Size(991, 325);
            this.dataGridViewListeVoiture.TabIndex = 45;
            this.dataGridViewListeVoiture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListeVoiture_CellContentClick);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(295, 215);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(117, 42);
            this.btnRechercher.TabIndex = 43;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnVoitureRechercher_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(770, 215);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(120, 42);
            this.btnSupprimer.TabIndex = 42;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(611, 215);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(124, 42);
            this.btnModifier.TabIndex = 41;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifierVoiture_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(448, 215);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(120, 42);
            this.btnAjouter.TabIndex = 40;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjoutVoiture_Click);
            // 
            // txtNivVoitire
            // 
            this.txtNivVoitire.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivVoitire.Location = new System.Drawing.Point(433, 107);
            this.txtNivVoitire.Name = "txtNivVoitire";
            this.txtNivVoitire.Size = new System.Drawing.Size(135, 25);
            this.txtNivVoitire.TabIndex = 37;
            // 
            // txtCouleurVoiture
            // 
            this.txtCouleurVoiture.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCouleurVoiture.Location = new System.Drawing.Point(433, 69);
            this.txtCouleurVoiture.Name = "txtCouleurVoiture";
            this.txtCouleurVoiture.Size = new System.Drawing.Size(135, 25);
            this.txtCouleurVoiture.TabIndex = 36;
            // 
            // txtAnnee
            // 
            this.txtAnnee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnee.Location = new System.Drawing.Point(123, 195);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(127, 25);
            this.txtAnnee.TabIndex = 34;
            // 
            // txtModele
            // 
            this.txtModele.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModele.Location = new System.Drawing.Point(123, 156);
            this.txtModele.Name = "txtModele";
            this.txtModele.Size = new System.Drawing.Size(127, 25);
            this.txtModele.TabIndex = 33;
            // 
            // txtMarque
            // 
            this.txtMarque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarque.Location = new System.Drawing.Point(123, 112);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(127, 25);
            this.txtMarque.TabIndex = 32;
            // 
            // txtNumVoiture
            // 
            this.txtNumVoiture.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumVoiture.Location = new System.Drawing.Point(123, 71);
            this.txtNumVoiture.Name = "txtNumVoiture";
            this.txtNumVoiture.Size = new System.Drawing.Size(127, 25);
            this.txtNumVoiture.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(614, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 21);
            this.label18.TabIndex = 29;
            this.label18.Text = "Numéro porte";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(307, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 21);
            this.label19.TabIndex = 28;
            this.label19.Text = "NIV";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(307, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 21);
            this.label20.TabIndex = 27;
            this.label20.Text = "Couleur :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(24, 196);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 21);
            this.label21.TabIndex = 26;
            this.label21.Text = "Année :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(24, 157);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 21);
            this.label22.TabIndex = 25;
            this.label22.Text = "Modele :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(24, 72);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 21);
            this.label23.TabIndex = 24;
            this.label23.Text = "Identifiant :";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.dateFactureVenteFin);
            this.tabPage4.Controls.Add(this.dateFactureVenteDebut);
            this.tabPage4.Controls.Add(this.numericPrixVente);
            this.tabPage4.Controls.Add(this.labelPrix);
            this.tabPage4.Controls.Add(this.trackBarPrix);
            this.tabPage4.Controls.Add(this.BtnTrinitialiserFacture_Vente);
            this.tabPage4.Controls.Add(this.txtIdClient);
            this.tabPage4.Controls.Add(this.label42);
            this.tabPage4.Controls.Add(this.btnrechercherFactureVente);
            this.tabPage4.Controls.Add(this.dataGridViewFactureVente);
            this.tabPage4.Controls.Add(this.label34);
            this.tabPage4.Controls.Add(this.txtIdFacture);
            this.tabPage4.Controls.Add(this.btnSupprimFactureVente);
            this.tabPage4.Controls.Add(this.btnModifierFactureVente);
            this.tabPage4.Controls.Add(this.btnAjouterFactureVente);
            this.tabPage4.Controls.Add(this.label33);
            this.tabPage4.Controls.Add(this.txtIdVoiture);
            this.tabPage4.Controls.Add(this.label32);
            this.tabPage4.Controls.Add(this.label31);
            this.tabPage4.Controls.Add(this.txtNumFacture);
            this.tabPage4.Controls.Add(this.label30);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1006, 610);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Facture Vente";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(392, 146);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 21);
            this.label17.TabIndex = 46;
            this.label17.Text = "Date de fin :";
            // 
            // dateFactureVenteFin
            // 
            this.dateFactureVenteFin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFactureVenteFin.Location = new System.Drawing.Point(511, 146);
            this.dateFactureVenteFin.Name = "dateFactureVenteFin";
            this.dateFactureVenteFin.Size = new System.Drawing.Size(149, 25);
            this.dateFactureVenteFin.TabIndex = 45;
            // 
            // dateFactureVenteDebut
            // 
            this.dateFactureVenteDebut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFactureVenteDebut.Location = new System.Drawing.Point(511, 89);
            this.dateFactureVenteDebut.Name = "dateFactureVenteDebut";
            this.dateFactureVenteDebut.Size = new System.Drawing.Size(149, 25);
            this.dateFactureVenteDebut.TabIndex = 44;
            // 
            // numericPrixVente
            // 
            this.numericPrixVente.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPrixVente.Location = new System.Drawing.Point(198, 268);
            this.numericPrixVente.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericPrixVente.Name = "numericPrixVente";
            this.numericPrixVente.Size = new System.Drawing.Size(112, 29);
            this.numericPrixVente.TabIndex = 43;
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.ForeColor = System.Drawing.Color.IndianRed;
            this.labelPrix.Location = new System.Drawing.Point(316, 275);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(15, 16);
            this.labelPrix.TabIndex = 41;
            this.labelPrix.Text = "0";
            // 
            // trackBarPrix
            // 
            this.trackBarPrix.BackColor = System.Drawing.Color.LightGray;
            this.trackBarPrix.LargeChange = 1000;
            this.trackBarPrix.Location = new System.Drawing.Point(392, 270);
            this.trackBarPrix.Maximum = 200000;
            this.trackBarPrix.Name = "trackBarPrix";
            this.trackBarPrix.Size = new System.Drawing.Size(268, 45);
            this.trackBarPrix.SmallChange = 100;
            this.trackBarPrix.TabIndex = 40;
            this.trackBarPrix.TickFrequency = 100;
            this.trackBarPrix.Scroll += new System.EventHandler(this.trackBarPrix_Scroll);
            // 
            // BtnTrinitialiserFacture_Vente
            // 
            this.BtnTrinitialiserFacture_Vente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrinitialiserFacture_Vente.Location = new System.Drawing.Point(851, 267);
            this.BtnTrinitialiserFacture_Vente.Name = "BtnTrinitialiserFacture_Vente";
            this.BtnTrinitialiserFacture_Vente.Size = new System.Drawing.Size(115, 49);
            this.BtnTrinitialiserFacture_Vente.TabIndex = 39;
            this.BtnTrinitialiserFacture_Vente.Text = "Reinitialiser";
            this.BtnTrinitialiserFacture_Vente.UseVisualStyleBackColor = true;
            this.BtnTrinitialiserFacture_Vente.Click += new System.EventHandler(this.BtnTrinitialiserFacture_Vente_Click);
            // 
            // txtIdClient
            // 
            this.txtIdClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdClient.Location = new System.Drawing.Point(198, 147);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(133, 26);
            this.txtIdClient.TabIndex = 37;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(47, 146);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(76, 21);
            this.label42.TabIndex = 36;
            this.label42.Text = "ID Client:";
            // 
            // btnrechercherFactureVente
            // 
            this.btnrechercherFactureVente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrechercherFactureVente.Location = new System.Drawing.Point(716, 266);
            this.btnrechercherFactureVente.Name = "btnrechercherFactureVente";
            this.btnrechercherFactureVente.Size = new System.Drawing.Size(119, 49);
            this.btnrechercherFactureVente.TabIndex = 15;
            this.btnrechercherFactureVente.Text = "Rechercher";
            this.btnrechercherFactureVente.UseVisualStyleBackColor = true;
            this.btnrechercherFactureVente.Click += new System.EventHandler(this.btnrechercherFactureVente_Click);
            // 
            // dataGridViewFactureVente
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewFactureVente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewFactureVente.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFactureVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFactureVente.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewFactureVente.Location = new System.Drawing.Point(3, 334);
            this.dataGridViewFactureVente.Name = "dataGridViewFactureVente";
            this.dataGridViewFactureVente.Size = new System.Drawing.Size(997, 270);
            this.dataGridViewFactureVente.TabIndex = 14;
            this.dataGridViewFactureVente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFactureVente_CellContentClick);
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(47, 89);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(101, 27);
            this.label34.TabIndex = 13;
            this.label34.Text = "ID Facture:              ";
            // 
            // txtIdFacture
            // 
            this.txtIdFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFacture.Location = new System.Drawing.Point(198, 90);
            this.txtIdFacture.Name = "txtIdFacture";
            this.txtIdFacture.Size = new System.Drawing.Size(133, 26);
            this.txtIdFacture.TabIndex = 12;
            // 
            // btnSupprimFactureVente
            // 
            this.btnSupprimFactureVente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimFactureVente.Location = new System.Drawing.Point(716, 147);
            this.btnSupprimFactureVente.Name = "btnSupprimFactureVente";
            this.btnSupprimFactureVente.Size = new System.Drawing.Size(119, 45);
            this.btnSupprimFactureVente.TabIndex = 11;
            this.btnSupprimFactureVente.Text = "Supprimer";
            this.btnSupprimFactureVente.UseVisualStyleBackColor = true;
            this.btnSupprimFactureVente.Click += new System.EventHandler(this.btnSupprimFactureVente_Click);
            // 
            // btnModifierFactureVente
            // 
            this.btnModifierFactureVente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierFactureVente.Location = new System.Drawing.Point(716, 204);
            this.btnModifierFactureVente.Name = "btnModifierFactureVente";
            this.btnModifierFactureVente.Size = new System.Drawing.Size(119, 45);
            this.btnModifierFactureVente.TabIndex = 10;
            this.btnModifierFactureVente.Text = "Modifier";
            this.btnModifierFactureVente.UseVisualStyleBackColor = true;
            this.btnModifierFactureVente.Click += new System.EventHandler(this.btnModifierFactureVente_Click);
            // 
            // btnAjouterFactureVente
            // 
            this.btnAjouterFactureVente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterFactureVente.Location = new System.Drawing.Point(716, 90);
            this.btnAjouterFactureVente.Name = "btnAjouterFactureVente";
            this.btnAjouterFactureVente.Size = new System.Drawing.Size(119, 45);
            this.btnAjouterFactureVente.TabIndex = 9;
            this.btnAjouterFactureVente.Text = "Ajouter";
            this.btnAjouterFactureVente.UseVisualStyleBackColor = true;
            this.btnAjouterFactureVente.Click += new System.EventHandler(this.btnAjouterFactureVente_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(58, 268);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(109, 21);
            this.label33.TabIndex = 7;
            this.label33.Text = "Prix de vente:";
            // 
            // txtIdVoiture
            // 
            this.txtIdVoiture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVoiture.Location = new System.Drawing.Point(511, 208);
            this.txtIdVoiture.Name = "txtIdVoiture";
            this.txtIdVoiture.Size = new System.Drawing.Size(149, 26);
            this.txtIdVoiture.TabIndex = 6;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(392, 206);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(87, 21);
            this.label32.TabIndex = 5;
            this.label32.Text = "ID Voiture:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(49, 208);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(131, 21);
            this.label31.TabIndex = 4;
            this.label31.Text = "Numéro Facture:";
            // 
            // txtNumFacture
            // 
            this.txtNumFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFacture.Location = new System.Drawing.Point(198, 206);
            this.txtNumFacture.Name = "txtNumFacture";
            this.txtNumFacture.Size = new System.Drawing.Size(133, 26);
            this.txtNumFacture.TabIndex = 2;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(392, 90);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(123, 21);
            this.label30.TabIndex = 1;
            this.label30.Text = "Date de début :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(379, 21);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(180, 30);
            this.label29.TabIndex = 0;
            this.label29.Text = "FACTURE  VENTE";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1006, 610);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Facture Achat";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel4.Controls.Add(this.label41);
            this.panel4.Controls.Add(this.numericPrixAchat);
            this.panel4.Controls.Add(this.trackBarPrixAchat);
            this.panel4.Controls.Add(this.label39);
            this.panel4.Controls.Add(this.txtNumFactureAchat);
            this.panel4.Controls.Add(this.txtIdVendeur);
            this.panel4.Controls.Add(this.label35);
            this.panel4.Controls.Add(this.btnRecherche);
            this.panel4.Controls.Add(this.label36);
            this.panel4.Controls.Add(this.txtIdFactureAchat);
            this.panel4.Controls.Add(this.txtIdVoitureAchat);
            this.panel4.Controls.Add(this.label37);
            this.panel4.Controls.Add(this.label38);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.dateAchatFin);
            this.panel4.Controls.Add(this.dateAchatDebut);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.BtnTrinitialiserFactureAchat);
            this.panel4.Controls.Add(this.dataGridViewFactureAchat);
            this.panel4.Controls.Add(this.btnSupprimFactureAchat);
            this.panel4.Controls.Add(this.btnModifieFactureAchat);
            this.panel4.Controls.Add(this.btnAjouterFactAchat);
            this.panel4.Controls.Add(this.label40);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(994, 598);
            this.panel4.TabIndex = 0;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.IndianRed;
            this.label41.Location = new System.Drawing.Point(297, 244);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(15, 16);
            this.label41.TabIndex = 63;
            this.label41.Text = "0";
            // 
            // numericPrixAchat
            // 
            this.numericPrixAchat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPrixAchat.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPrixAchat.Location = new System.Drawing.Point(180, 241);
            this.numericPrixAchat.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericPrixAchat.Name = "numericPrixAchat";
            this.numericPrixAchat.Size = new System.Drawing.Size(109, 25);
            this.numericPrixAchat.TabIndex = 62;
            // 
            // trackBarPrixAchat
            // 
            this.trackBarPrixAchat.BackColor = System.Drawing.Color.LightGray;
            this.trackBarPrixAchat.LargeChange = 1000;
            this.trackBarPrixAchat.Location = new System.Drawing.Point(359, 241);
            this.trackBarPrixAchat.Maximum = 200000;
            this.trackBarPrixAchat.Name = "trackBarPrixAchat";
            this.trackBarPrixAchat.Size = new System.Drawing.Size(265, 45);
            this.trackBarPrixAchat.SmallChange = 100;
            this.trackBarPrixAchat.TabIndex = 61;
            this.trackBarPrixAchat.TickFrequency = 100;
            this.trackBarPrixAchat.Scroll += new System.EventHandler(this.trackBarPrixAchat_Scroll);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(41, 239);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(101, 21);
            this.label39.TabIndex = 60;
            this.label39.Text = "Prix d\'Achat:";
            // 
            // txtNumFactureAchat
            // 
            this.txtNumFactureAchat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFactureAchat.Location = new System.Drawing.Point(180, 179);
            this.txtNumFactureAchat.Name = "txtNumFactureAchat";
            this.txtNumFactureAchat.Size = new System.Drawing.Size(132, 25);
            this.txtNumFactureAchat.TabIndex = 59;
            // 
            // txtIdVendeur
            // 
            this.txtIdVendeur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVendeur.Location = new System.Drawing.Point(180, 129);
            this.txtIdVendeur.Name = "txtIdVendeur";
            this.txtIdVendeur.Size = new System.Drawing.Size(132, 25);
            this.txtIdVendeur.TabIndex = 58;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(41, 135);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(96, 21);
            this.label35.TabIndex = 57;
            this.label35.Text = "ID Vendeur:";
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(670, 236);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(131, 50);
            this.btnRecherche.TabIndex = 56;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(41, 79);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(101, 27);
            this.label36.TabIndex = 55;
            this.label36.Text = "ID Facture:              ";
            // 
            // txtIdFactureAchat
            // 
            this.txtIdFactureAchat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFactureAchat.Location = new System.Drawing.Point(180, 79);
            this.txtIdFactureAchat.Name = "txtIdFactureAchat";
            this.txtIdFactureAchat.Size = new System.Drawing.Size(132, 25);
            this.txtIdFactureAchat.TabIndex = 54;
            // 
            // txtIdVoitureAchat
            // 
            this.txtIdVoitureAchat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVoitureAchat.Location = new System.Drawing.Point(474, 185);
            this.txtIdVoitureAchat.Name = "txtIdVoitureAchat";
            this.txtIdVoitureAchat.Size = new System.Drawing.Size(150, 25);
            this.txtIdVoitureAchat.TabIndex = 53;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(355, 184);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(87, 21);
            this.label37.TabIndex = 52;
            this.label37.Text = "ID Voiture:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(41, 185);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(131, 21);
            this.label38.TabIndex = 51;
            this.label38.Text = "Numéro Facture:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(355, 140);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 21);
            this.label27.TabIndex = 50;
            this.label27.Text = "Date de fin :";
            // 
            // dateAchatFin
            // 
            this.dateAchatFin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAchatFin.Location = new System.Drawing.Point(474, 140);
            this.dateAchatFin.Name = "dateAchatFin";
            this.dateAchatFin.Size = new System.Drawing.Size(150, 25);
            this.dateAchatFin.TabIndex = 49;
            // 
            // dateAchatDebut
            // 
            this.dateAchatDebut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAchatDebut.Location = new System.Drawing.Point(474, 80);
            this.dateAchatDebut.Name = "dateAchatDebut";
            this.dateAchatDebut.Size = new System.Drawing.Size(150, 25);
            this.dateAchatDebut.TabIndex = 48;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(355, 80);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(123, 21);
            this.label28.TabIndex = 47;
            this.label28.Text = "Date de début :";
            // 
            // BtnTrinitialiserFactureAchat
            // 
            this.BtnTrinitialiserFactureAchat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrinitialiserFactureAchat.Location = new System.Drawing.Point(837, 164);
            this.BtnTrinitialiserFactureAchat.Name = "BtnTrinitialiserFactureAchat";
            this.BtnTrinitialiserFactureAchat.Size = new System.Drawing.Size(123, 50);
            this.BtnTrinitialiserFactureAchat.TabIndex = 36;
            this.BtnTrinitialiserFactureAchat.Text = "Reinitialiser";
            this.BtnTrinitialiserFactureAchat.UseVisualStyleBackColor = true;
            this.BtnTrinitialiserFactureAchat.Click += new System.EventHandler(this.BtnTrinitialiserFactureAchat_Click);
            // 
            // dataGridViewFactureAchat
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewFactureAchat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewFactureAchat.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFactureAchat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactureAchat.Location = new System.Drawing.Point(11, 292);
            this.dataGridViewFactureAchat.Name = "dataGridViewFactureAchat";
            this.dataGridViewFactureAchat.Size = new System.Drawing.Size(980, 303);
            this.dataGridViewFactureAchat.TabIndex = 30;
            this.dataGridViewFactureAchat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFactureAchat_CellContentClick);
            // 
            // btnSupprimFactureAchat
            // 
            this.btnSupprimFactureAchat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimFactureAchat.Location = new System.Drawing.Point(837, 236);
            this.btnSupprimFactureAchat.Name = "btnSupprimFactureAchat";
            this.btnSupprimFactureAchat.Size = new System.Drawing.Size(123, 50);
            this.btnSupprimFactureAchat.TabIndex = 27;
            this.btnSupprimFactureAchat.Text = "Supprimer";
            this.btnSupprimFactureAchat.UseVisualStyleBackColor = true;
            this.btnSupprimFactureAchat.Click += new System.EventHandler(this.btnSupprimFactureAchat_Click);
            // 
            // btnModifieFactureAchat
            // 
            this.btnModifieFactureAchat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifieFactureAchat.Location = new System.Drawing.Point(670, 164);
            this.btnModifieFactureAchat.Name = "btnModifieFactureAchat";
            this.btnModifieFactureAchat.Size = new System.Drawing.Size(131, 47);
            this.btnModifieFactureAchat.TabIndex = 26;
            this.btnModifieFactureAchat.Text = "Modifier";
            this.btnModifieFactureAchat.UseVisualStyleBackColor = true;
            this.btnModifieFactureAchat.Click += new System.EventHandler(this.btnModifieFactureAchat_Click);
            // 
            // btnAjouterFactAchat
            // 
            this.btnAjouterFactAchat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterFactAchat.Location = new System.Drawing.Point(670, 79);
            this.btnAjouterFactAchat.Name = "btnAjouterFactAchat";
            this.btnAjouterFactAchat.Size = new System.Drawing.Size(131, 52);
            this.btnAjouterFactAchat.TabIndex = 25;
            this.btnAjouterFactAchat.Text = "Ajouter";
            this.btnAjouterFactAchat.UseVisualStyleBackColor = true;
            this.btnAjouterFactAchat.Click += new System.EventHandler(this.btnAjouterFactAchat_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(399, 17);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(179, 30);
            this.label40.TabIndex = 16;
            this.label40.Text = "FACTURE ACHAT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 657);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeClient)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeVendeur)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPortes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeVoiture)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrixVente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactureVente)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrixAchat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrixAchat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactureAchat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private TextBox txtNumClient;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TextBox txtCodepostalclient;
        private TextBox txtProvinceClient;
        private TextBox txtVilleClient;
        private TextBox txtAdresseClient;
        private TextBox txtEmailClient;
        private TextBox txtTelephoneClient;
        private TextBox txtPrenonClient;
        private TextBox txtNonClient;
        private TabPage tabPage3;
        private DataGridView dataGridViewListeClient;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label24;
        private DataGridView dataGridViewListeVendeur;
        private Button btnrecherchevendeur;
        private Button btnSupprimeVendeur;
        private Button btnModifVendeur;
        private Button btnAjoutVendeur;
        private TextBox txtProvincevendeur;
        private TextBox txtVilleVendeur;
        private TextBox txtAddresseVendeur;
        private TextBox txtEmailVendeur;
        private TextBox txtTelephonevendeur;
        private TextBox txtNomVendeur;
        private TextBox txtNumeVendeur;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Panel panel3;
        private DataGridView dataGridViewListeVoiture;
        private Button btnRechercher;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private TextBox txtNivVoitire;
        private TextBox txtCouleurVoiture;
        private TextBox txtAnnee;
        private TextBox txtModele;
        private TextBox txtMarque;
        private TextBox txtNumVoiture;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label26;
        private Label label25;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label33;
        private TextBox txtIdVoiture;
        private Label label32;
        private Label label31;
        private TextBox txtNumFacture;
        private Label label30;
        private Label label29;
        private Label label34;
        private TextBox txtIdFacture;
        private Button btnSupprimFactureVente;
        private Button btnModifierFactureVente;
        private Button btnAjouterFactureVente;
        private Button btnrechercherFactureVente;
        private DataGridView dataGridViewFactureVente;
        private Panel panel4;
        private DataGridView dataGridViewFactureAchat;
        private Button btnSupprimFactureAchat;
        private Button btnModifieFactureAchat;
        private Button btnAjouterFactAchat;
        private Label label40;
        private TextBox txtIdClient;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private CheckBox chxboxSieges_Cuire;
        private CheckBox chxboxDemarrage_distance;
        private CheckBox chxboxToit_Ouvrant;
        private Button BtnTrinitialiserClient;
        private Button BtnTrinitialiserVendeur;
        private Button BtnTrinitialiserVenteVoiture;
        private Button BtnTrinitialiserFacture_Vente;
        private Button BtnTrinitialiserFactureAchat;
        private Label labelPrix;
        private TrackBar trackBarPrix;
        private NumericUpDown numericPrixVente;
        private Label label17;
        private DateTimePicker dateFactureVenteFin;
        private DateTimePicker dateFactureVenteDebut;
        private NumericUpDown numericPrixAchat;
        private TrackBar trackBarPrixAchat;
        private Label label39;
        private TextBox txtNumFactureAchat;
        private TextBox txtIdVendeur;
        private Label label35;
        private Button btnRecherche;
        private Label label36;
        private TextBox txtIdFactureAchat;
        private TextBox txtIdVoitureAchat;
        private Label label37;
        private Label label38;
        private Label label27;
        private DateTimePicker dateAchatFin;
        private DateTimePicker dateAchatDebut;
        private Label label28;
        private Label label41;
        private NumericUpDown numericPortes;
        private NumericUpDown numericHP;
    }
}