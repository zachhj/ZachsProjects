<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApp_Client.login" MasterPageFile="~/Site.Master"%>
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc" TagName="login" %>
<%@ Register Src ="~/timecontrol.ascx" TagPrefix="uc" TagName="time" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <uc:time runat="server"></uc:time>
</asp:Content>

