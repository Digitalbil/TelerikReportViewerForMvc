using MsftReporting = Microsoft.Reporting.WebForms;
using TkReporting = Telerik.ReportViewer.WebForms;
using System.Web;
using System.Web.Mvc;

namespace ReportViewerForMvc
{
    /// <summary>
    /// HTML helpers for ReportViewerForMvc
    /// </summary>
    public static class HtmlHelperExtensions
    {
        /// <summary>
        /// Returns an HTML iframe that renders an ASP.NET ReportViewer control.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="reportViewer">The object containing the ReportViewer control properties.</param>
        /// <returns>An HTML iframe that sets its heigh and width based on the content of the report.</returns>
        public static HtmlString ReportViewer(this HtmlHelper helper, MsftReporting.ReportViewer reportViewer)
        {
            return ReportViewerForMvc.GetIframe(reportViewer, null);
        }

        /// <summary>
        /// Returns an HTML iframe that renders an ASP.NET ReportViewer control.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="reportViewer">The object containing the ReportViewer control properties.</param>
        /// <param name="htmlAttributes">The object containing the HTML attributes of the iframe.</param>
        /// <returns>An HTML iframe with the specified attributes that sets its heigh and width based on the content of the report.</returns>
        public static HtmlString ReportViewer(this HtmlHelper helper, MsftReporting.ReportViewer reportViewer, object htmlAttributes)
        {
            return ReportViewerForMvc.GetIframe(reportViewer, htmlAttributes);
        }

        /// <summary>
        /// Returns an HTML iframe that renders an ASP.NET ReportViewer control.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="reportViewer">The object containing the ReportViewer control properties.</param>
        /// <param name="report">An object containing the LocalReport/ServerReport properties.</param>
        /// <returns>An HTML iframe that sets its heigh and width based on the content of the report.</returns>
        public static HtmlString ReportViewer(this HtmlHelper helper, object reportViewer, object report)
        {
            MsftReporting.ReportViewer reportViewerControl = ReportViewerForMvc.AnonymousReportViewer(reportViewer, report);

            return ReportViewerForMvc.GetIframe(reportViewerControl, null);
        }

        /// <summary>
        /// Returns an HTML iframe that renders an ASP.NET ReportViewer control.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="reportViewer">The object containing the ReportViewer control properties.</param>
        /// <param name="report">An object containing the LocalReport/ServerReport properties.</param>
        /// <param name="htmlAttributes">The object containing the HTML attributes of the iframe.</param>
        /// <returns>An HTML iframe with the specified attributes that sets its heigh and width based on the content of the report.</returns>
        public static HtmlString ReportViewer(this HtmlHelper helper, object reportViewer, object report, object htmlAttributes)
        {
            MsftReporting.ReportViewer reportViewerControl = ReportViewerForMvc.AnonymousReportViewer(reportViewer, report);

            return ReportViewerForMvc.GetIframe(reportViewerControl, htmlAttributes);
        }

        /// <summary>
        /// Returns an HTML iframe that renders an ASP.NET ReportViewer control.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="reportViewer">The object containing the ReportViewer control properties.</param>
        /// <param name="report">An object containing the LocalReport/ServerReport properties.</param>
        /// <param name="parameters">Object that contains the parameters for a report.</param>
        /// <param name="htmlAttributes">The object containing the HTML attributes of the iframe.</param>
        /// <returns>An HTML iframe with the specified attributes that sets its heigh and width based on the content of the report.</returns>
        public static HtmlString ReportViewer(this HtmlHelper helper, object reportViewer, object report, object parameters, object htmlAttributes)
        {
            MsftReporting.ReportViewer reportViewerControl = ReportViewerForMvc.AnonymousReportViewer(reportViewer, report, parameters);

            return ReportViewerForMvc.GetIframe(reportViewerControl, htmlAttributes);
        }

        /// <summary>
        /// Returns an HTML iframe that renders an ASP.NET ReportViewer control.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="reportViewer">The object containing the ReportViewer control properties.</param>
        /// <param name="report">An object containing the LocalReport/ServerReport properties.</param>
        /// <param name="parameters">Object that contains the parameters for a report.</param>
        /// <param name="dataSources">The data sources to be added to the report.</param>
        /// <param name="htmlAttributes">The object containing the HTML attributes of the iframe.</param>
        /// <returns>An HTML iframe with the specified attributes that sets its heigh and width based on the content of the report.</returns>
        public static HtmlString ReportViewer(this HtmlHelper helper, object reportViewer, object report, object parameters, object dataSources, object htmlAttributes)
        {
            MsftReporting.ReportViewer reportViewerControl = ReportViewerForMvc.AnonymousReportViewer(reportViewer, report, parameters, dataSources);

            return ReportViewerForMvc.GetIframe(reportViewerControl, htmlAttributes);
        }

        #region Telerik report viewwers
        /// <summary>
        /// Returns an HTML iframe that renders an ASP.NET ReportViewer control.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="reportViewer">The object containing the ReportViewer control properties.</param>
        /// <returns>An HTML iframe that sets its heigh and width based on the content of the report.</returns>
        public static HtmlString TelerikReportViewer(this HtmlHelper helper, TkReporting.ReportViewer reportViewer)
        {
            return TelerikReportViewerForMvc.GetIframe(reportViewer, null);
        }

        /// <summary>
        /// Returns an HTML iframe that renders an ASP.NET ReportViewer control.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="reportViewer">The object containing the ReportViewer control properties.</param>
        /// <param name="htmlAttributes">The object containing the HTML attributes of the iframe.</param>
        /// <returns>An HTML iframe with the specified attributes that sets its heigh and width based on the content of the report.</returns>
        public static HtmlString TelerikReportViewer(this HtmlHelper helper, TkReporting.ReportViewer reportViewer, object htmlAttributes)
        {
            return TelerikReportViewerForMvc.GetIframe(reportViewer, htmlAttributes);
        }

        /// <summary>
        /// Returns an HTML iframe that renders an ASP.NET ReportViewer control.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="reportViewer">The object containing the ReportViewer control properties.</param>
        /// <param name="report">An object containing the LocalReport/ServerReport properties.</param>
        /// <returns>An HTML iframe that sets its heigh and width based on the content of the report.</returns>
        public static HtmlString TelerikReportViewer(this HtmlHelper helper, object reportViewer, object report)
        {
            MsftReporting.ReportViewer reportViewerControl = ReportViewerForMvc.AnonymousReportViewer(reportViewer, report);

            return ReportViewerForMvc.GetIframe(reportViewerControl, null);
        }

        /// <summary>
        /// Returns an HTML iframe that renders an ASP.NET ReportViewer control.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="reportViewer">The object containing the ReportViewer control properties.</param>
        /// <param name="report">An object containing the LocalReport/ServerReport properties.</param>
        /// <param name="htmlAttributes">The object containing the HTML attributes of the iframe.</param>
        /// <returns>An HTML iframe with the specified attributes that sets its heigh and width based on the content of the report.</returns>
        public static HtmlString TelerikReportViewer(this HtmlHelper helper, object reportViewer, object report, object htmlAttributes)
        {
            TkReporting.ReportViewer reportViewerControl = TelerikReportViewerForMvc.AnonymousReportViewer(reportViewer, report);

            return TelerikReportViewerForMvc.GetIframe(reportViewerControl, htmlAttributes);
        }

        /// <summary>
        /// Returns an HTML iframe that renders an ASP.NET ReportViewer control.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="reportViewer">The object containing the ReportViewer control properties.</param>
        /// <param name="report">An object containing the LocalReport/ServerReport properties.</param>
        /// <param name="parameters">Object that contains the parameters for a report.</param>
        /// <param name="htmlAttributes">The object containing the HTML attributes of the iframe.</param>
        /// <returns>An HTML iframe with the specified attributes that sets its heigh and width based on the content of the report.</returns>
        public static HtmlString TelerikReportViewer(this HtmlHelper helper, object reportViewer, object report, object parameters, object htmlAttributes)
        {
            TkReporting.ReportViewer reportViewerControl = TelerikReportViewerForMvc.AnonymousReportViewer(reportViewer, report, parameters);

            return TelerikReportViewerForMvc.GetIframe(reportViewerControl, htmlAttributes);
        }

        /// <summary>
        /// Returns an HTML iframe that renders an ASP.NET ReportViewer control.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="reportViewer">The object containing the ReportViewer control properties.</param>
        /// <param name="report">An object containing the LocalReport/ServerReport properties.</param>
        /// <param name="parameters">Object that contains the parameters for a report.</param>
        /// <param name="dataSources">The data sources to be added to the report.</param>
        /// <param name="htmlAttributes">The object containing the HTML attributes of the iframe.</param>
        /// <returns>An HTML iframe with the specified attributes that sets its heigh and width based on the content of the report.</returns>
        public static HtmlString TelerikReportViewer(this HtmlHelper helper, object reportViewer, object report, object parameters, object dataSources, object htmlAttributes)
        {
            TkReporting.ReportViewer reportViewerControl = TelerikReportViewerForMvc.AnonymousReportViewer(reportViewer, report, parameters, dataSources);

            return TelerikReportViewerForMvc.GetIframe(reportViewerControl, htmlAttributes);
        }
        #endregion
    }
}