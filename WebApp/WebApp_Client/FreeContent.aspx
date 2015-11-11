<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FreeContent.aspx.cs" Inherits="WebApp_Client.FreeContent" MasterPageFile="~/Site.Master"%>
<%@ Register Src="~/timecontrol.ascx" TagPrefix="uc" TagName="time" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">

    <h1>Free Content</h1>
    <asp:Button runat="server" ID="loginButton" Text="login" OnClick="loginButton_Click"/>
    <uc:time runat="server"></uc:time>
</asp:Content>

