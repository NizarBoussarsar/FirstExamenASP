using FirstExamenASP.Domain.Entities;
using FirstExamenASP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstExamenASP.GUI
{
    public partial class AddEntrepreneur : System.Web.UI.Page
    {
        IMyService service;
        TextBox CINTextBox, NomTextBox, PrenomTextBox, AdresseTextBox, TelephoneTextBox, EmailTextBox;

        protected void Page_Load(object sender, EventArgs e)
        {
            service = new MyService();
            CINTextBox = FormView1.FindControl("CINTextBox") as TextBox;
            NomTextBox = FormView1.FindControl("NomTextBox") as TextBox;
            PrenomTextBox = FormView1.FindControl("PrenomTextBox") as TextBox;
            AdresseTextBox = FormView1.FindControl("AdresseTextBox") as TextBox;
            TelephoneTextBox = FormView1.FindControl("TelephoneTextBox") as TextBox;
            EmailTextBox = FormView1.FindControl("EmailTextBox") as TextBox;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Entrepreneur entrepreneur = new Entrepreneur();
            entrepreneur.CIN = Convert.ToInt32(CINTextBox.Text);
            entrepreneur.Nom = NomTextBox.Text;
            entrepreneur.Prenom = PrenomTextBox.Text;
            entrepreneur.Adresse = AdresseTextBox.Text;
            entrepreneur.Telephone = Convert.ToInt32(TelephoneTextBox.Text);
            entrepreneur.Email = EmailTextBox.Text;
            if (service.AddEntrepreneur(entrepreneur))
            {
                Response.Write(service.GetFirstLetters(entrepreneur.Nom, entrepreneur.Prenom) + " a été ajouté");
            }
            else
            {
                Response.Write("L'ajout n'a pas été effecté");
            }
        }

    }
}