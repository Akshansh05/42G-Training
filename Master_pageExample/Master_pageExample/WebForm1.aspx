<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Master_pageExample.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
<form id="form1" runat="server" class="form-horizontal">
  First name:<br/>
  <asp:TextBox type="text" runat="server" name="firstname" value="Mickey" ID="usename"></asp:TextBox>
  <br/>
  Last name:<br/>
  <asp:TextBox runat="server" type="text" name="lastname" value="Mouse" ID="password"></asp:TextBox>
  <br/><br/>
  <asp:Button id="Button" runat="server" onClick="button1_Click" text="Submit"/>
</form> 

        </center>
</asp:Content>
