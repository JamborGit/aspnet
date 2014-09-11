<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sitemap.aspx.cs" Inherits="aspnet.Samples.sitemap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server"  ></asp:SiteMapPath>
         <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />  
    </div>
    </form>
</body>
</html>
