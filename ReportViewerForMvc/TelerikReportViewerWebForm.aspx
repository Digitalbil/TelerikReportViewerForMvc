<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="TelerikReportViewerWebForm.aspx.cs" Inherits="ReportViewerForMvc.TelerikReportViewerWebForm" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.ReportViewer.WebForms"
        Assembly="Telerik.ReportViewer.WebForms, Version=7.2.14.127, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 0px; padding: 0px;">
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
                <Scripts>
                    <asp:ScriptReference Assembly="ReportViewerForMvc" Name="ReportViewerForMvc.Scripts.PostMessage.js" />
                </Scripts>
            </asp:ScriptManager>
            <telerik:ReportViewer ID="ReportViewer1" runat="server"></telerik:ReportViewer>
            <%--<rsweb:ReportViewer ID="ReportViewer1" runat="server"></rsweb:ReportViewer>--%>
        </div>
    </form>
</body>
</html>
