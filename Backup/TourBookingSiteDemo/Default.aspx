<%@ Page Title="" Language="C#" MasterPageFile="~/Tour.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="TourBookingSiteDemo.Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="header">
    <h1 id="pose"> <asp:Label ID="heading" runat="server" Text="Welcome To Our Site"></asp:Label><asp:Label ID="sitename" runat="server" Text=" Tour Trip"></asp:Label> <asp:Label ID="user" runat="server" Text=" user"></asp:Label><i style="color:white;" class="fa fa-plane fa-lg" aria-hidden="true"></i>
</h1>
            </section>
   
        
    <div id="homes1">
        <asp:Label ID="lbuser" runat="server" Text="Welcome "></asp:Label>
      
        <div class="row">
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
               <div class="m-2">
                <a href="gallery.aspx?galname=<%#Eval("gallery_image_name") %>">
                    <asp:Image ID="Image1" runat="server" Style="margin-left:70px; margin-top:50px; border-radius:50px; border:1px solid; border-width:4px;"
                        ImageUrl='<%#Eval("gallery_imgpath") %>' Height="200px" Width="200px" />
                </a>&nbsp;<br />
                <asp:Label ID="Label3" runat="server" Text='<%#Eval("gallery_image_name") %>' Font-Bold="True" Font-Italic="True" style="margin-left:130px" Font-Size="Medium"></asp:Label>
                &nbsp;
               </div>
            </ItemTemplate>
            
        </asp:Repeater>
        </div>
    </div>
   
    <br />
    <div class="gallery1">
<h2>
        <br />
        </div>
    <br />
    <br />
    </asp:Content>
