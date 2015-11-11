<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="timecontrol.ascx.cs" Inherits="WebApp_Client.timecontrol" %>

<asp:Button runat="server" ID="timeButton" Text ="Update Time" OnClick="timeButton_Click"/> 

<asp:UpdatePanel runat="server" ID="timePanel" UpdateMode="Conditional">
    <ContentTemplate>
        <asp:Timer runat="server" ID="timeTimer" Interval="10000" OnTick="timeButton_Click"></asp:Timer>
        <br />
        <asp:Label runat="server" ID="timeLabel" Font-Size="XX-Large"></asp:Label>
        <br />
    </ContentTemplate>
    <Triggers>
        <asp:PostBackTrigger runat="server" ControlID="timeButton" />
    </Triggers>
</asp:UpdatePanel>

