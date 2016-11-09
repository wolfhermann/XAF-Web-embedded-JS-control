<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChartControl.ascx.cs" Inherits="CustomJSControl.Web.Controls.ChartControl" %>
<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<dx:ASPxPanel ID="ASPxPanel1" runat="server" Width="100%" Height="500px">
    <ClientSideEvents Init="function(s, e) { DxCode.ChartControl.createControl(s); }" />
</dx:ASPxPanel>
