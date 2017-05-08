<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="ConfirmStaff.aspx.cs" Inherits="ORLM.Admin.ConfirmStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdminContent" runat="server">

      <asp:DropDownList ID="ProcessDropList" runat="server" DataTextField="Name" DataValueField="ID" CssClass="form-control" OnSelectedIndexChanged="ProcessDropList_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    
    

    <asp:ListView ID="PendingStaffsListView" runat="server">
        <LayoutTemplate>
   <ul class="list-group row">
        <li id="itemPlaceholder" runat="server" />
       </ul>
  </LayoutTemplate>
  <ItemTemplate>

    <li class="list-group-item col-md-8">
      
        <p class="col-md-8"><%#Eval("FName")%> <%#Eval("LName")%> </p>
        <div class="col-md-4"><asp:CheckBox ID="togglebox" runat="server" /></div>
        <asp:HiddenField ID="ID" Value='<%# Eval("ID") %>'  runat="server" />
    </li>
  </ItemTemplate>


    </asp:ListView>
  
    <asp:Button ID="Approve" runat="server" Text="Approve" CssClass="btn btn-primary" OnClick="Approve_Click" />
</asp:Content>
