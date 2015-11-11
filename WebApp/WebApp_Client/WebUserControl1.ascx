<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebApp_Client.WebUserControl1" %>
<%@ Register Src="~/timecontrol.ascx" TagPrefix="uc" TagName="time" %>


        <asp:Label runat="server" ID="nameLabel">username</asp:Label>
        <asp:TextBox runat="server" ID="usernameText"></asp:TextBox>
        <br />
        <asp:Label runat="server" ID="passwordLable">password</asp:Label>
        <asp:TextBox runat="server" ID="passwordText"></asp:TextBox>
        <br />
        <asp:Button runat="server" ID="loginButton" Text="login" OnClick="loginButton_Click"/>
        <asp:Button runat="server" ID="clearButton" Text="clear" OnClick="clearButton_Click"/>
        <br />
        <br />
        <uc:time runat="server"></uc:time>