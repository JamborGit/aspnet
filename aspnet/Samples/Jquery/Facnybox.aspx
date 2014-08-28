<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Facnybox.aspx.cs" Inherits="aspnet.Samples.Jquery.Facnybox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="../../Scripts/jquery-1.8.2.min.js"></script>
    <script src="../../Scripts/jquery.fancybox.js"></script>
    <link href="../../Scripts/jquery.fancybox.css" rel="stylesheet" />
    <title></title>
    <script type="text/javascript">
        $(function () {
            ////$('.pick-price').click(function (e) {
            ////    var url = $(this).attr('href');
              
            ////    if (url != null && url != '') {
            ////        e.preventDefault();
            ////        $.fancybox({
            ////            href: url ,
            ////            type: 'iframe'
            ////        });
            ////    }
            ////    else {
            ////        currentPricePicker = $(this).attr('id');
            ////    }
            ////});
        })
       
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a class="fancybox" rel="group" href="http://www.w3schools.com/images/pulpit.jpg">test</a>
            <asp:HyperLink ID="hlunitprice01" CssClass="pick-price" runat="server" ImageUrl="../../Images/orderedList1.png"     NavigateUrl="http://www.w3schools.com"
              > </asp:HyperLink>
            <asp:HyperLink
                ImageUrl="../../Images/orderedList1.png"
                NavigateUrl="http://www.w3schools.com"
                Text="Visit W3Schools!"
                Target="_blank"
                runat="server" />
        </div>
    </form>
</body>
</html>
