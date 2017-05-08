<%@ Page Title="" Language="C#" MasterPageFile="~/Loss/Manage/Loss.master" AutoEventWireup="true" CodeBehind="Identification.aspx.cs" Inherits="ORLM.Loss.Identification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="LossContent" runat="server">

     <div class="form-horizontal">
        <h4>Identify a Case</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TitleTB" CssClass="col-md-2 control-label">Title</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TitleTB" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TitleTB"
                    CssClass="text-danger" ErrorMessage="The Title field is required." />
            </div>
        </div>

          <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="CaseTypeDD" CssClass="col-md-2 control-label">CaseType</asp:Label>
            <div class="col-md-10">
                
                  <asp:DropDownList ID="CaseTypeDD" runat="server" DataTextField="Name" DataValueField="ID" CssClass="form-control"></asp:DropDownList>

                <asp:RequiredFieldValidator runat="server" ControlToValidate="CaseTypeDD"
                    CssClass="text-danger" ErrorMessage="The CaseType field is required." />
            </div>
        </div>


           <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="BranchDropList" CssClass="col-md-2 control-label">Branch</asp:Label>
            <div class="col-md-10">
                
                   <asp:DropDownList ID="BranchDropList" runat="server" DataTextField="Name" DataValueField="ID"  CssClass="form-control" ></asp:DropDownList>
             </div>
        </div>




        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" Text="Create Case" CssClass="btn btn-default" ID="createBtn" OnClick="createBtn_Click" />
            </div>
        </div>
    </div>


</asp:Content>
