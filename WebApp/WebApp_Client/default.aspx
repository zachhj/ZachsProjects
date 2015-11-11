<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApp_Client._default" MasterPageFile ="~/Site.Master"%>
<%@ Register Src="~/timecontrol.ascx" TagPrefix="uc" TagName="time" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">

        <asp:Label ID="nameLabel" runat="server" Text="Search: "></asp:Label>
        <p>
        <asp:TextBox ID="nameText" runat="server" OnTextChanged="nameText_TextChanged"></asp:TextBox>
        <asp:DropDownList ID="nameDrop" runat="server" Height="19px" Width="195px">
        </asp:DropDownList>
        </p>
        <p>
        <asp:Button ID="nameButton" runat="server" Height="26px" Text="Search" OnClick="nameButton_Click" />
        </p>
        <asp:ListBox ID="nameList" runat="server" Height="113px" Width="201px"></asp:ListBox>
        <b />
        <uc:time runat="server"></uc:time>

</asp:Content>


