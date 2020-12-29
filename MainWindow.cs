﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;
using Timer = System.Threading.Timer;

namespace ModPackInstaller
{
    public partial class MainWindow : Form
    {
        protected bool GoodVersion;
        private string _path;
        private int _ticks = 0;
        private const string _version = "v1.0";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_default_Click(object sender, EventArgs e)
        {
            tb_path.Text = @"C:\Users\" + Environment.UserName +
                           @"\AppData\Roaming\.minecraft\versions\1.12.2-forge-14.23.5.2854";
            SubstrVersion(tb_path.Text);
        }

        public int GetPbValue()
        {
            return pb_statut.Value;
        }

        public void SetPbValue(int value)
        {
            pb_statut.Value = value;
        }

        public void SubstrVersion(string path)
        {
            if (path.Contains('-'))
            {
                var pos = path.LastIndexOf(@"\") + 1;
                var substrVersion = tb_path.Text.Substring(pos, tb_path.Text.Length - pos);
                var infos = substrVersion.Split('-');
                var version = infos[0] + '-' + infos[1];
                SetVersionColor(version, infos[2]);
                _path = path;
            }
            else
            {
                var pos = path.LastIndexOf(@"\") + 1;
                var substrVersion = tb_path.Text.Substring(pos, tb_path.Text.Length - pos);
                SetVersionColor(substrVersion, "Introuvable");
                _path = path;
            }
        }

        public void SetVersionColor(string version, string forgeVersion)
        {
            if (version == "1.12.2-forge")
            {
                lbl_version.ForeColor = Color.Green;
                lbl_version.Text = "Version de Minecraft détectée : 1.12.2\r" +
                                   "Version de Forge : " + forgeVersion +
                                   "\r\rTOUT EST OK!";
                btn_forge.Enabled = false;
                btn_valider.Enabled = true;
                GoodVersion = true;
            }
            else if (version == "1.12.2")
            {
                lbl_version.ForeColor = Color.OrangeRed;
                lbl_version.Text = "Version de Minecraft détectée : 1.12.2\r" +
                                   "Forge n'est pas installé\r\r" +
                                   "Veuillez installer Forge avant de lancer l'installation des mods!";
                btn_forge.Enabled = true;
                btn_valider.Enabled = false;
                GoodVersion = false;
            }
            else
            {
                lbl_version.ForeColor = Color.Red;
                lbl_version.Text = "Version détectée : " + version + "\r" +
                                   "La version de Minecraft n'est pas la bonne : " + version + " au lieu de 1.12.2" +
                                   "\rL'installation ne pourra pas se faire";
                btn_valider.Enabled = false;
                btn_forge.Enabled = false;
                GoodVersion = false;
            }
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            var result = FolderBwser.ShowDialog();
            if (result == DialogResult.OK)
            {
                var folderName = FolderBwser.SelectedPath;
                tb_path.Text = folderName;
                SubstrVersion(folderName);
            }
        }

        private void btn_forge_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "NB : Le dossier d'installation de Forge doit être modifié, il doit pointer vers : .minecraft/versions/",
                "À lire attentivement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Process.Start("forge-1.12.2-14.23.5.2854-installer.jar");
        }

        private void MovingMods()
        {
            if (GoodVersion)
            {
                lbl_op.Text = "OPERATION EN COURS : Démarrage de l'installation";
                SetPbValue(2);
                lbl_pct.Text = GetPbValue().ToString() + " %";
                if (Directory.Exists(@"mods"))
                {
                    if (Directory.Exists(@"config"))
                    {
                        lbl_op.Text = "OPERATION EN COURS : Déplacement du dossier mods";
                        Directory.Move(@"mods", _path + @".\mods\");
                        SetPbValue(15);
                        lbl_pct.Text = GetPbValue().ToString() + " %";
                        lbl_op.Text = "OPERATION EN COURS : Déplacement du dossier config";
                        Directory.Move(@"config", _path + @".\config\");
                        SetPbValue(46);
                        lbl_pct.Text = GetPbValue().ToString() + " %";

                        if (cb_ressources.Checked)
                        {
                            if (Directory.Exists(@"resourcepacks"))
                            {
                                Directory.Move(@"resourcepacks", _path + @".\resourcepacks\");
                                lbl_op.Text = "OPERATION EN COURS : Déplacement du dossier shaderpacks";
                                SetPbValue(67);
                                lbl_pct.Text = GetPbValue().ToString() + " %";
                            }
                            else
                            {
                                MessageBox.Show("Dossier resourcepacks introuvable");
                            }
                        }

                        if (cb_shaders.Checked)
                        {
                            if (Directory.Exists(@"shaderpacks"))
                            {
                                Directory.Move(@"shaderpacks", _path + @".\shaderpacks\");
                                SetPbValue(83);
                                lbl_pct.Text = GetPbValue().ToString() + " %";
                            }
                            else
                            {
                                MessageBox.Show("Dossier shaderpacks introuvable");
                            }
                        }

                        SetPbValue(100);
                        lbl_pct.Text = GetPbValue().ToString() + " %";
                        MessageBox.Show(
                            "Installation terminée, vous pouvez dès à présent démarrer votre Minecraft");
                        SetPbValue(0);
                    }
                    else
                    {
                        MessageBox.Show("Dossier config introuvable", "Erreur", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dossier mods introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "Vous essayez d'installer des mods pour la version 1.12.2, mais votre version de Minecraft n'est pas la bonne",
                    "Erreur lors de l'installation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            pb_statut.ForeColor = Color.Teal;
            pb_statut.Value = 0;
        }

        private void SaveFolders()
        {
            var date = DateTime.Now.ToString("yyyy-M-d_hh-mm-ss");
            var dirPath = _path + @".\backup\" + date;
            MessageBox.Show(
                "Une sauvegarde de vos fichiers existants va être faite\rElle sera disponible au chemin suivant\r" +
                dirPath);
            Directory.CreateDirectory(dirPath);
            if (Directory.Exists(_path + @".\config\"))
            {
                Directory.Move(_path + @".\config\", dirPath + @".\config");
                if (Directory.Exists(_path + @".\mods\"))
                {
                    Directory.Move(_path + @".\mods\", dirPath + @".\mods");
                    if (Directory.Exists(_path + @".\resourcepacks\"))
                    {
                        Directory.Move(_path + @".\resourcepacks\", dirPath + @".\resourcepacks");
                        if (Directory.Exists(_path + @".\shaderpacks\"))
                        {
                            Directory.Move(_path + @".\shaderpacks\", dirPath + @".\shaderpacks");
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks == 1)
            {
                lbl_op.Text = "OPERATION EN COURS : Lancement de l'installation dans 3";
            }

            if (_ticks == 2)
            {
                lbl_op.Text = "OPERATION EN COURS : Lancement de l'installation dans 2";
            }

            if (_ticks == 3)
            {
                lbl_op.Text = "OPERATION EN COURS : Lancement de l'installation dans 1";
                
            }
            if (_ticks == 4)
            {
                lbl_op.Text = "OPERATION EN COURS : Installation du modpack";
                SaveFolders();
                MovingMods();
            }
        }

        private void btn_maj_Click(object sender, EventArgs e)
        {
            
        }
        private async System.Threading.Tasks.Task CheckGitHubNewerVersion()
        {
            //Get all releases from GitHub
            //Source: https://octokitnet.readthedocs.io/en/latest/getting-started/
            GitHubClient client = new GitHubClient(new ProductHeaderValue("SomeName"));
            IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("thomasrts", "ModPackInstaller");
    
            //Setup the versions
            Version latestGitHubVersion = new Version(releases[0].TagName);
            Version localVersion = new Version("X.X.X"); //Replace this with your local version. 
            //Only tested with numeric values.
    
            //Compare the Versions
            //Source: https://stackoverflow.com/questions/7568147/compare-version-numbers-without-using-split-function
            int versionComparison = localVersion.CompareTo(latestGitHubVersion);
            if (versionComparison < 0)
            {
                //The version on GitHub is more up to date than this local release.
            }
            else if (versionComparison > 0)
            {
                //This local version is greater than the release version on GitHub.
            }
            else
            {
                //This local Version and the Version on GitHub are equal.
            }
        }
    }
}