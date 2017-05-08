<%@ Page Title="" Language="C#" MasterPageFile="~/Loss/Manage/Loss.master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ORLM.Loss._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="LossContent" runat="server">
   

     <h1>Manage Loss</h1>

     <div class="container">

  <div class="row">
      <a href="Identification">
    <div class="col-sm-4">
      <div class="tile purple">
        <h3 class="title">Identify Loss</h3>
        <p>Enter new Loss encountered into the system.</p>
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
        <a href="Assignment">
      <div class="tile green">
        <h3 class="title">Assign Case</h3>
        <p>Assign Loss Case to Process Support Officer</p>
      </div>
            </a>
    </div>
    <div class="col-sm-4">
      <div class="tile black">
        <h3 class="title">Other Function</h3>
        <p>Add admin function here.</p>
      </div>
    </div>    
  </div>
</div>
</asp:Content>
