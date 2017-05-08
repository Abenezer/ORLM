<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ORLM.Admin._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdminContent" runat="server">
    <h1>Admin Page</h1>





    <div class="container">

  <div class="row">
      <a href="CreateProcess">
    <div class="col-sm-4">
      <div class="tile purple">
        <h3 class="title">Create Process</h3>
        <p>Enter new Process into the system.</p>
      </div>
    </div>
          </a>
    <div class="col-sm-4">
      <div class="tile red">
        <h3 class="title">Other Function</h3>
        <p>Add another function here</p>
      </div>
    </div>

  </div>
  <div class="row">
     
    <div class="col-sm-4">
        <a href="ConfirmStaff">
      <div class="tile green">
        <h3 class="title">Confirm Registerd Staffs</h3>
        <p>Confirm Registerd Staffs to allow them access</p>
      </div>
            </a>
    </div>
    <div class="col-sm-4">
      <div class="tile blue">
        <h3 class="title">Other Function</h3>
        <p>Add admin function here.</p>
      </div>
    </div>    
  </div>
</div>



</asp:Content>
