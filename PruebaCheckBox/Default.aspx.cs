using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace PruebaCheckBox
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlTableCell cell = new HtmlTableCell();
            HtmlTableRow row = new HtmlTableRow();
            cell.InnerText = "Uno";
            row.Cells.Add(cell);

            cell = new HtmlTableCell();
            cell.InnerText = "Dos";
            row.Cells.Add(cell);

            cell = new HtmlTableCell();
            cell.InnerText = "Activo";
            row.Cells.Add(cell);
           
            cell = new HtmlTableCell();
            cell.InnerText = "Inactivo";
            row.Cells.Add(cell);
             
            cell = new HtmlTableCell();
            cell.InnerHtml = "<input type=\"checkbox\" id=\"CheckBox1\" onclick=\"javascript:submit();\" onserverchange=\"Server_Changed\" runat=\"server\" value=\"1\" name=\"Test\" data-label=\"test\" checked=\"checked\" enableviewstate=\"true\"/>"; //"<input runa=\"server\" type=\"checkbox\" class=\"form-check-input\" id=\"check_" + n.IdEmpleado + "\" enableviewstate=\"true\" onchange=\"EventoClick(" + n.IdEmpleado + ", " + idEstatusActivar + ", 'check_" + n.IdEmpleado + "')\" " + disabledActivar + ">";
            row.Cells.Add(cell);

            cell = new HtmlTableCell();
            cell.InnerHtml = "<input runat=\"server\" name=\"ctl00$MainContent$CheckBox2\" type=\"checkbox\" id=\"MainContent_CheckBox1\" onclick=\"javascript:submit();\" onserverchange=\"Server_Changed\" value=\"1\" data-label=\"test\" enableviewstate=\"true\">";
            row.Cells.Add(cell);

            tablaEmpleado.Rows.Add(row);
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Server_Changed(object sender, EventArgs e)
        {
        }
    }
}