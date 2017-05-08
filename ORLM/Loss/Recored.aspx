<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Recored.aspx.cs" Inherits="ORLM.Loss.Recored" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <div class="form-horizontal">
        <h4>Recored a Case</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        

          
          <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="CasesDropList" CssClass="col-md-2 control-label">Case</asp:Label>
            <div class="col-md-10">
                
                <asp:DropDownList ID="CasesDropList" runat="server" DataTextField="Title" DataValueField="case_id" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="CasesDropList_SelectedIndexChanged"></asp:DropDownList>
   

                <asp:RequiredFieldValidator runat="server" ControlToValidate="CasesDropList"
                    CssClass="text-danger" ErrorMessage="The Case field is required." />
            </div>
        </div>

          <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="BranchDropList" CssClass="col-md-2 control-label">Branch</asp:Label>
            <div class="col-md-10">
                
                   <asp:DropDownList ID="BranchDropList" runat="server" DataTextField="Name" DataValueField="ID"  CssClass="form-control" ></asp:DropDownList>
             </div>
        </div>


             <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="LossTypeDropList" CssClass="col-md-2 control-label">Loss Type</asp:Label>
            <div class="col-md-10">
                
                   <asp:DropDownList ID="LossTypeDropList" runat="server" DataTextField="Name" DataValueField="ID"  CssClass="form-control" ></asp:DropDownList>
             </div>
        </div>



            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="DateField" CssClass="col-md-2 control-label">Loss Date</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="DateField"  CssClass="form-control" TextMode="Date" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="DateField"
                    CssClass="text-danger" ErrorMessage="The Assigned Date field is required." />
            </div>
        </div>

          <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TextBoxAmount" CssClass="col-md-2 control-label">Amount</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBoxAmount"  CssClass="form-control" TextMode="Number"  step="any" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBoxAmount"
                    CssClass="text-danger" ErrorMessage="The Ammount field is required." />
            </div>
        </div>

            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TextBoxCause" CssClass="col-md-2 control-label">Discription</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBoxDescription"  CssClass="form-control" TextMode="MultiLine" />
               
            </div>
        </div>



          <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TextBoxCause" CssClass="col-md-2 control-label">Cause</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBoxCause"  CssClass="form-control" TextMode="MultiLine" />
               
            </div>
        </div>


<div class="form-group">
            <asp:Label runat="server" AssociatedControlID="CheckBoxRecovered" CssClass="col-md-2 control-label">Recovered</asp:Label>
            <div class="col-md-10">
                <asp:CheckBox runat="server" ID="CheckBoxRecovered"  CssClass="form-control" />
               
            </div>
        </div>



        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" Text="Report" CssClass="btn btn-default" ID="ReportBtn" OnClick="ReportBtn_Click" />
            </div>
        </div>
    </div>


</asp:Content>
