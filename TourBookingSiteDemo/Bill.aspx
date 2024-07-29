<%@ Page Title="" Language="C#" MasterPageFile="~/Tour.Master" AutoEventWireup="true" CodeBehind="Bill.aspx.cs" Inherits="TourBookingSiteDemo.Bill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
.auto-style1 {
width: 778px;
}

.auto-style2 {
width: 788px;
}

.auto-style5 {
width: 807px;
}

.auto-style6 {
width: 842px;
}

.auto-style9 {
width: 421px;
}

.auto-style12 {
width: 777px;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container mt-3">
<asp:Panel ID="Panel1" CssClass="mt-3" runat="server" Height="566px">
<table align="center" class="auto-style5" border="1">
<tr>
<td class="auto-style2" colspan="2" style="text-align: center"><strong>Retail Invoice</strong></td>
</tr>
<tr>
<td class="auto-style1">Booking Date  :
<asp:Label ID="lb_Bookingdate" runat="server"></asp:Label>
</td>
</tr>
<tr>



<td width="25%">Booking Holder Name :
<br />
<asp:Label ID="lb_bookername" runat="server" Text=""></asp:Label>
</td>
<td class="auto-style9">Hotel Address :<br />
Hotel Actual Address Goes Here
</td>



</tr>
<tr>
<td class="auto-style12">
<asp:Label ID="lb_rt" runat="server" Text="Room TYpe :"></asp:Label>

</td>
<td>
<asp:Label ID="lb_roomtype" runat="server" Text=""></asp:Label>
</td>
</tr>
<tr>
<td class="auto-style12">
<asp:Label ID="lb_ac" runat="server" Text="AdharCard Number :"></asp:Label>

</td>
<td>
<asp:Label ID="lb_adharcard" runat="server" Text=""></asp:Label>
</td>
</tr>
<tr>
<td rowspan="3">
<asp:Label ID="Label1" runat="server" Text="Grand Total:"></asp:Label>

</td>
<td>
<asp:Label ID="lb_fair" runat="server"></asp:Label>
</td>

</tr>
<tr>
<td>
<asp:Label ID="lb_gst" runat="server"></asp:Label>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lb_gt" runat="server"></asp:Label>
</td>
</tr>
<tr>
<td colspan="2" class="auto-style6">Declaration : We declare that this invoice shows actual price of goods described inclusive of taxes and that all particulars are true and Correct.<br />
Incase you find selling price on this invoice to be more than MRP mentioned on product, Please inform - <a href="mailto:hotel@gmail.com">restro@gmail.com</a><br />
<br />
This is a computer generated invoice and does not require signature.</td>
</tr>
</table>
            
</asp:Panel>
<div align="center" class="mb-5 ">
<asp:Button runat="server" align="center" ID="btn_download" class="btn btn-primary text-white py-3 px-5 font-weight-bold" Text="Download Recipt" OnClick="btn_download_Click" />
</div>

</div>
</asp:Content>
