namespace ModPackInstaller
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_op = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_default = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.FolderBwser = new System.Windows.Forms.FolderBrowserDialog();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_forge = new System.Windows.Forms.Button();
            this.pb_statut = new System.Windows.Forms.ProgressBar();
            this.cb_ressources = new System.Windows.Forms.CheckBox();
            this.gp_options = new System.Windows.Forms.GroupBox();
            this.cb_shaders = new System.Windows.Forms.CheckBox();
            this.lbl_pct = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_maj = new System.Windows.Forms.Button();
            this.lbl_git = new System.Windows.Forms.Label();
            this.gp_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(261, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilitaire d\'installation des mods";
            // 
            // lbl_op
            // 
            this.lbl_op.Location = new System.Drawing.Point(12, 487);
            this.lbl_op.Name = "lbl_op";
            this.lbl_op.Size = new System.Drawing.Size(480, 26);
            this.lbl_op.TabIndex = 4;
            this.lbl_op.Text = "OPERATION EN COURS : ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chemin d\'installation :";
            // 
            // tb_path
            // 
            this.tb_path.Enabled = false;
            this.tb_path.Location = new System.Drawing.Point(128, 152);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(516, 20);
            this.tb_path.TabIndex = 7;
            // 
            // btn_default
            // 
            this.btn_default.Location = new System.Drawing.Point(680, 152);
            this.btn_default.Margin = new System.Windows.Forms.Padding(0);
            this.btn_default.Name = "btn_default";
            this.btn_default.Size = new System.Drawing.Size(87, 21);
            this.btn_default.TabIndex = 8;
            this.btn_default.Text = "Par défaut";
            this.btn_default.UseVisualStyleBackColor = true;
            this.btn_default.Click += new System.EventHandler(this.btn_default_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(647, 152);
            this.btn_search.Margin = new System.Windows.Forms.Padding(0);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 21);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "...";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Enabled = false;
            this.btn_valider.Location = new System.Drawing.Point(676, 474);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(112, 25);
            this.btn_valider.TabIndex = 10;
            this.btn_valider.Text = "Valider l\'installation";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(96, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(621, 67);
            this.label3.TabIndex = 11;
            this.label3.Text = "NB : N\'oubliez pas de démarrer une instance neuve de Minecraft en 1.12.2 afin de " + "générer les fichiers nécessaires\r\nau bon fonctionnement du modpack :)\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_version
            // 
            this.lbl_version.Location = new System.Drawing.Point(12, 190);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(356, 106);
            this.lbl_version.TabIndex = 12;
            this.lbl_version.Text = "Version détectée :";
            // 
            // FolderBwser
            // 
            this.FolderBwser.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            // 
            // btn_forge
            // 
            this.btn_forge.Location = new System.Drawing.Point(676, 444);
            this.btn_forge.Name = "btn_forge";
            this.btn_forge.Size = new System.Drawing.Size(112, 24);
            this.btn_forge.TabIndex = 13;
            this.btn_forge.Text = "Installer Forge";
            this.btn_forge.UseVisualStyleBackColor = true;
            this.btn_forge.Click += new System.EventHandler(this.btn_forge_Click);
            // 
            // pb_statut
            // 
            this.pb_statut.BackColor = System.Drawing.SystemColors.Highlight;
            this.pb_statut.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb_statut.Location = new System.Drawing.Point(0, 535);
            this.pb_statut.Name = "pb_statut";
            this.pb_statut.Size = new System.Drawing.Size(800, 17);
            this.pb_statut.TabIndex = 14;
            // 
            // cb_ressources
            // 
            this.cb_ressources.Location = new System.Drawing.Point(30, 21);
            this.cb_ressources.Name = "cb_ressources";
            this.cb_ressources.Size = new System.Drawing.Size(180, 22);
            this.cb_ressources.TabIndex = 15;
            this.cb_ressources.Text = "Installer les ressources packs";
            this.cb_ressources.UseVisualStyleBackColor = true;
            // 
            // gp_options
            // 
            this.gp_options.Controls.Add(this.cb_shaders);
            this.gp_options.Controls.Add(this.cb_ressources);
            this.gp_options.Location = new System.Drawing.Point(435, 414);
            this.gp_options.Name = "gp_options";
            this.gp_options.Size = new System.Drawing.Size(236, 85);
            this.gp_options.TabIndex = 16;
            this.gp_options.TabStop = false;
            this.gp_options.Text = "Options";
            // 
            // cb_shaders
            // 
            this.cb_shaders.Location = new System.Drawing.Point(30, 49);
            this.cb_shaders.Name = "cb_shaders";
            this.cb_shaders.Size = new System.Drawing.Size(180, 22);
            this.cb_shaders.TabIndex = 16;
            this.cb_shaders.Text = "Installer les shaders packs";
            this.cb_shaders.UseVisualStyleBackColor = true;
            // 
            // lbl_pct
            // 
            this.lbl_pct.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pct.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_pct.Location = new System.Drawing.Point(375, 536);
            this.lbl_pct.Name = "lbl_pct";
            this.lbl_pct.Size = new System.Drawing.Size(58, 16);
            this.lbl_pct.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_maj
            // 
            this.btn_maj.Location = new System.Drawing.Point(691, 10);
            this.btn_maj.Name = "btn_maj";
            this.btn_maj.Size = new System.Drawing.Size(97, 44);
            this.btn_maj.TabIndex = 18;
            this.btn_maj.Text = "Vérifier les mises à jour";
            this.btn_maj.UseVisualStyleBackColor = true;
            this.btn_maj.Click += new System.EventHandler(this.btn_maj_Click);
            // 
            // lbl_git
            // 
            this.lbl_git.Location = new System.Drawing.Point(556, 26);
            this.lbl_git.Name = "lbl_git";
            this.lbl_git.Size = new System.Drawing.Size(115, 16);
            this.lbl_git.TabIndex = 19;
            this.lbl_git.Text = "Version : ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.lbl_git);
            this.Controls.Add(this.btn_maj);
            this.Controls.Add(this.lbl_pct);
            this.Controls.Add(this.gp_options);
            this.Controls.Add(this.pb_statut);
            this.Controls.Add(this.btn_forge);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_default);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_op);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gp_options.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_git;

        private System.Windows.Forms.Button btn_maj;

        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Label lbl_pct;

        private System.Windows.Forms.CheckBox cb_ressources;
        private System.Windows.Forms.CheckBox cb_shaders;
        private System.Windows.Forms.GroupBox gp_options;

        private System.Windows.Forms.ProgressBar pb_statut;

        private System.Windows.Forms.Button btn_forge;

        private System.Windows.Forms.OpenFileDialog FileDialog;

        private System.Windows.Forms.FolderBrowserDialog FolderBwser;

        private System.Windows.Forms.Label lbl_version;

        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button btn_default;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_path;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label lbl_op;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}