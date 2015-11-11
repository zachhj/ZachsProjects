<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="WebApp_Client.StartPage" MasterPageFile="~/Site.Master"%>
<%@ Register Src="~/timecontrol.ascx" TagPrefix="uc" TagName="time" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
            <header>
                <h1>Start Page</h1>
            </header>
<asp:Button runat="server" ID="loginButton" Text="login" OnClick="loginButton_Click"/>
    <uc:time runat="server"></uc:time>

</asp:Content>

