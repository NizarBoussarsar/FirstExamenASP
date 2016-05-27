using FirstExamenASP.Domain.Entities;
using FirstExamenASP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstExamenASP.GUI
{
    public partial class Domiciles : System.Web.UI.Page
    {
        IMyService service;

        protected void Page_Load(object sender, EventArgs e)
        {
            service = new MyService();
        }

        public IQueryable<Domicile> GetDomicilesSurfaceOrPrice([Control] float? Prix)
        {
            if (Prix.HasValue)
            {
                return service.GetDomiciles().Where(p => p.Prix <= Prix);
            }
            else
            {
                Response.Write("Il n y a pas des domiciles qui correspondent à ces critères");
                return null;
            }
        }
    }
}