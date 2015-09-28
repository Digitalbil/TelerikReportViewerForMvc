﻿using Microsoft.Reporting.WebForms;
using System;
using System.Web.UI.WebControls;

namespace ReportViewerForMvc
{
    /// <summary>
    /// The Web Form used for rendering a ReportViewer control.
    /// </summary>
    public partial class TelerikReportViewerWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BuildReportViewer();
        }

        private void BuildReportViewer()
        {
            if (!IsPostBack)
            {
                TelerikReportViewerForMvc.ReportViewer.ID = ReportViewer1.ID;

                //ReportViewer1.SetProperties(ReportViewerForMvc.ReportViewer);
            }
        }
    }
}