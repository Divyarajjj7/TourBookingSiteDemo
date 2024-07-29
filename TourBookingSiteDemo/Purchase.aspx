<%@ Page Title="" Language="C#" MasterPageFile="~/Tour.Master" AutoEventWireup="true" CodeBehind="Purchase.aspx.cs" Inherits="TourBookingSiteDemo.Purchase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link href="css/bootstrap.css" rel="stylesheet" />
    
<div id="purchase1" runat="server" align="center">
<asp:Repeater ID="Repeater1" runat="server" onitemcommand="Repeater1_ItemCommand">
<HeaderTemplate>
<h1>Your Bill is:</h1>
<table border="1" class="table" align="center">
<tr>
<th>Place Name</th>
<th>Place Image</th>
<th>Price</th>
</tr>
</HeaderTemplate>
<ItemTemplate>
<tr>
<td><%#Eval("place_name") %></td>
<td><asp:Image Width="100px" Height="100px" ID="img" runat="server" ImageUrl='<%#Eval("place_imgpath") %>' /></td>
<td><%#Eval("price") %></td>
               
</tr>
</ItemTemplate>
<FooterTemplate>
<td colspan="2" align="left">Total Rs. </td><td colspan="2" align="right"><%#sum() %></td>

</table>
</table>
</FooterTemplate>
</asp:Repeater>
<asp:Button ID="home" align="left" Text="Generate Bill" runat="server" 
        class="btn btn-warning" CausesValidation="False" onclick="home_Click"/>              

</div>
</asp:Content>
