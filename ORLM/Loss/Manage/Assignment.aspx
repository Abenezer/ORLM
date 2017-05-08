<%@ Page Title="" Language="C#" MasterPageFile="~/Loss/Manage/Loss.master" AutoEventWireup="true" CodeBehind="Assignment.aspx.cs" Inherits="ORLM.Loss.Assignment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="LossContent" runat="server">

  <h2>  <asp:Label ID="ProcessLabel" runat="server" Text="Label"></asp:Label> Process </h2>

   

     <div class="form-horizontal">
        <h4>Assign a Case</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        

          <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="BranchDropList" CssClass="col-md-2 control-label">Branch</asp:Label>
            <div class="col-md-10">
                
                   <asp:DropDownList ID="BranchDropList" runat="server" DataTextField="Name" DataValueField="ID" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="BranchDropList_SelectedIndexChanged"></asp:DropDownList>
             </div>
        </div>
          <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="CasesDropList" CssClass="col-md-2 control-label">Case</asp:Label>
            <div class="col-md-10">
                
                <asp:DropDownList ID="CasesDropList" runat="server" DataTextField="Title" DataValueField="ID" CssClass="form-control"></asp:DropDownList>
   

                <asp:RequiredFieldValidator runat="server" ControlToValidate="CasesDropList"
                    CssClass="text-danger" ErrorMessage="The Case field is required." />
            </div>
        </div>

          <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="PSODropList" CssClass="col-md-2 control-label">PSO</asp:Label>
            <div class="col-md-10">
                
                <asp:DropDownList ID="PSODropList" runat="server" DataTextField="FullName" DataValueField="ID" CssClass="form-control"></asp:DropDownList>
   

                <asp:RequiredFieldValidator runat="server" ControlToValidate="PSODropList"
                    CssClass="text-danger" ErrorMessage="The PSO field is required." />
            </div>
        </div>

            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="DateField" CssClass="col-md-2 control-label">Assigned Date</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="DateField"  CssClass="form-control" Enabled="False" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="DateField"
                    CssClass="text-danger" ErrorMessage="The Assigned Date field is required." />
            </div>
        </div>

         
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" Text="Assign" CssClass="btn btn-default" ID="assignBtn" OnClick="assignBtn_Click" />
            </div>
        </div>
    </div>

</asp:Content>
