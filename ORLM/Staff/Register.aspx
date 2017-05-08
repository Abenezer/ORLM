<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ORLM.Staff.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Register as a staff</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
           <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ProcessDD" CssClass="col-md-2 control-label">Process</asp:Label>
            <div class="col-md-10">
                
                  <asp:DropDownList ID="ProcessDD" runat="server" DataTextField="Name" DataValueField="ID" CssClass="form-control"></asp:DropDownList>

                <asp:RequiredFieldValidator runat="server" ControlToValidate="ProcessDD"
                    CssClass="text-danger" ErrorMessage="The Process field is required." />
            </div>
        </div>

                   <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TitleDD" CssClass="col-md-2 control-label">Title</asp:Label>
            <div class="col-md-10">
                
                  <asp:DropDownList ID="TitleDD" runat="server" DataTextField="Name" DataValueField="ID"  CssClass="form-control"></asp:DropDownList>

                <asp:RequiredFieldValidator runat="server" ControlToValidate="TitleDD"
                    CssClass="text-danger" ErrorMessage="The Title field is required." />
            </div>
        </div>

                <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="FName" CssClass="col-md-2 control-label">First Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="FName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="FName"
                    CssClass="text-danger" ErrorMessage="The First Name field is required." />
            </div>
        </div>

                        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="LName" CssClass="col-md-2 control-label">Last Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="LName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="LName"
                    CssClass="text-danger" ErrorMessage="The Last Name field is required." />
            </div>
        </div>


                <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Phone" CssClass="col-md-2 control-label">Phone Number</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Phone" CssClass="form-control" TextMode="Phone" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Phone"
                    CssClass="text-danger" ErrorMessage="The Phone Number is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Confirm password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" ID="RegisterBtn" Text="Register" CssClass="btn btn-default" OnClick="RegisterBtn_Click" />
            </div>
        </div>
    </div>

</asp:Content>
