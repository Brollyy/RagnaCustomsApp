﻿
using System;

namespace RagnaCustoms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Téléchargement = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.refreshApps = new System.Windows.Forms.Button();
            this.ragnarockApp = new System.Windows.Forms.Label();
            this.bot_enabled = new System.Windows.Forms.CheckBox();
            this.twitchChannel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.twitchOAuth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.helptwitchtmi = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.Téléchargement.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(187, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Téléchargement en 1 clic activé ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(219, 241);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(165, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Application by twitch.tv/Rhokapa";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(248, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Fermeture automatique après téléchargement ?";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 118);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(344, 21);
            this.comboBox3.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(6, 146);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(121, 23);
            this.downloadButton.TabIndex = 14;
            this.downloadButton.Text = "button1";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(6, 94);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(35, 13);
            this.searchLabel.TabIndex = 15;
            this.searchLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Téléchargement);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(375, 225);
            this.tabControl1.TabIndex = 17;
            // 
            // Téléchargement
            // 
            this.Téléchargement.Controls.Add(this.comboBox1);
            this.Téléchargement.Controls.Add(this.label1);
            this.Téléchargement.Controls.Add(this.checkBox2);
            this.Téléchargement.Controls.Add(this.textBox1);
            this.Téléchargement.Controls.Add(this.checkBox1);
            this.Téléchargement.Controls.Add(this.downloadButton);
            this.Téléchargement.Controls.Add(this.comboBox3);
            this.Téléchargement.Controls.Add(this.searchLabel);
            this.Téléchargement.Location = new System.Drawing.Point(4, 22);
            this.Téléchargement.Name = "Téléchargement";
            this.Téléchargement.Padding = new System.Windows.Forms.Padding(3);
            this.Téléchargement.Size = new System.Drawing.Size(367, 199);
            this.Téléchargement.TabIndex = 0;
            this.Téléchargement.Text = global::RagnaCustoms.Resources.strings.Download;
            this.Téléchargement.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.refreshApps);
            this.tabPage2.Controls.Add(this.ragnarockApp);
            this.tabPage2.Controls.Add(this.bot_enabled);
            this.tabPage2.Controls.Add(this.twitchChannel);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.twitchOAuth);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.helptwitchtmi);
            this.tabPage2.Controls.Add(this.linkLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(367, 199);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = global::RagnaCustoms.Resources.strings.Twitch_bot;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // refreshApps
            // 
            this.refreshApps.Location = new System.Drawing.Point(9, 118);
            this.refreshApps.Name = "refreshApps";
            this.refreshApps.Size = new System.Drawing.Size(75, 23);
            this.refreshApps.TabIndex = 8;
            this.refreshApps.Text = "button1";
            this.refreshApps.UseVisualStyleBackColor = true;
            this.refreshApps.Click += new System.EventHandler(this.refreshApps_Click);
            // 
            // ragnarockApp
            // 
            this.ragnarockApp.AutoSize = true;
            this.ragnarockApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ragnarockApp.Location = new System.Drawing.Point(9, 101);
            this.ragnarockApp.Name = "ragnarockApp";
            this.ragnarockApp.Size = new System.Drawing.Size(35, 13);
            this.ragnarockApp.TabIndex = 7;
            this.ragnarockApp.Text = "label4";
            // 
            // bot_enabled
            // 
            this.bot_enabled.AutoSize = true;
            this.bot_enabled.Location = new System.Drawing.Point(9, 77);
            this.bot_enabled.Name = "bot_enabled";
            this.bot_enabled.Size = new System.Drawing.Size(74, 17);
            this.bot_enabled.TabIndex = 6;
            this.bot_enabled.Text = "Enabled ?";
            this.bot_enabled.UseVisualStyleBackColor = true;
            this.bot_enabled.CheckedChanged += new System.EventHandler(this.bot_enabled_CheckedChanged);
            // 
            // twitchChannel
            // 
            this.twitchChannel.Location = new System.Drawing.Point(160, 47);
            this.twitchChannel.Name = "twitchChannel";
            this.twitchChannel.Size = new System.Drawing.Size(201, 20);
            this.twitchChannel.TabIndex = 5;
            this.twitchChannel.TextChanged += new System.EventHandler(this.twitchChannel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your twitch channel";
            // 
            // twitchOAuth
            // 
            this.twitchOAuth.Location = new System.Drawing.Point(160, 7);
            this.twitchOAuth.Name = "twitchOAuth";
            this.twitchOAuth.Size = new System.Drawing.Size(201, 20);
            this.twitchOAuth.TabIndex = 3;
            this.twitchOAuth.TextChanged += new System.EventHandler(this.twitchOAuth_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Twitch Chat OAuth password";
            // 
            // helptwitchtmi
            // 
            this.helptwitchtmi.AutoSize = true;
            this.helptwitchtmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helptwitchtmi.Location = new System.Drawing.Point(9, 30);
            this.helptwitchtmi.Name = "helptwitchtmi";
            this.helptwitchtmi.Size = new System.Drawing.Size(207, 13);
            this.helptwitchtmi.TabIndex = 1;
            this.helptwitchtmi.Text = "Récupérez votre clé Chat OAuth Twitch sur";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(219, 30);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(130, 13);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://twitchapps.com/tmi/";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 267);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.linkLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Téléchargement.ResumeLayout(false);
            this.Téléchargement.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Téléchargement;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label helptwitchtmi;
        private System.Windows.Forms.TextBox twitchOAuth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox twitchChannel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox bot_enabled;
        private System.Windows.Forms.Button refreshApps;
        private System.Windows.Forms.Label ragnarockApp;
    }
}
