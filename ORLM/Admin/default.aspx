<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ORLM.Admin._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdminContent" runat="server">
    <h1>Admin Page</h1>

    <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Name" DataValueField="ID" CssClass="form-control"></asp:DropDownList>

</asp:Content>
