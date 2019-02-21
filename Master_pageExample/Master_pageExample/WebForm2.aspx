<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Master_pageExample.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">

    <asp:label id="Label1" runat="server">Hi </asp:label>
        <asp:Button id="Button" runat="server" onClick="Button_Click" text="Logout" style="width: 57px"/><br />
    </form>
</asp:Content>
