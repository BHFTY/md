using System;
using MediaTekDocuments.controller;
using System.Windows.Forms;

namespace MediaTekDocuments.view
{
     public partial class FrmLogin : Form
     {
          private FrmLoginController controller;
          public FrmLogin()
          {
               InitializeComponent();
               Init();
          }

          /// <summary>
          /// Création du controleur.
          /// </summary>
          private void Init()
          {
               txbLogin.Text = "";
               txbPwd.Text = "";
               controller = new FrmLoginController();
               this.AcceptButton = btnConnec;
          }

          private void btnConnec_Click(object sender, EventArgs e)
          {
               
               if (controller.GetLogin(txbLogin.Text, txbPwd.Text))
                    this.Visible = false;
               
               else
               {
                    MessageBox.Show("Mauvais mot de passe ou login utilisateur");
                    txbLogin.Text = "";
                    txbPwd.Text = "";
               }
          }
     }
}
