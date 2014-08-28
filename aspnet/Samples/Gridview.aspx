<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridview.aspx.cs" Inherits="aspnet.Samples.Gridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="myGrid" runat="server" AutoGenerateColumns="false" OnRowDataBound="myGrid_RowDataBound">
            <Columns>
                <asp:BoundField  DataField="Name" HeaderText="Name"/>
                  <asp:BoundField  DataField="Age" HeaderText="Name"/>
                <asp:TemplateField HeaderText="Country">
                    <ItemTemplate>
                        <asp:DropDownList ID="myDropdown" runat="server" OnSelectedIndexChanged="myDropdown_SelectedIndexChanged" >
                            <asp:ListItem> US</asp:ListItem>
                               <asp:ListItem>EN</asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
  
    </form>
</body>
</html>
