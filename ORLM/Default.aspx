<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ORLM._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

      <asp:LoginView ID="loginView" runat="server" ViewStateMode="Disabled">
                        <AnonymousTemplate>

                            
    <div class="jumbotron">
        <div class="row">
            <div class="col-md-8">
        <h1>Ethiopian Commercial Bank</h1>
        <p class="lead">Organizational Risk Managment System (ORLM)</p>
        <p><a href="Staff/Register" class="btn btn-primary btn-lg">Register as Staff &raquo;</a></p>
            </div>
        
                <div class="form-horizontal col-md-4 ">
                   
                   
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group ">
                        
                       
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" placeholder="Email" />
                           
                        </div>
                        </div>
                                        <div class="form-group ">
                        <div class="col-md-10">
                           
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" placeholder="Password"  CssClass="form-control" />
                            
                             </div>
                                
                                 </div>


                     <div class="form-group ">
                        <div class="col-md-offset-6 col-md-10">
                            <asp:Button runat="server" Text="Log in" ID="loginBtn" CssClass="btn btn-success" OnClick="loginBtn_Click" />
                        </div>
                   
                    </div>
                    
                  
                </div>


</div>

    </div>
                          
                        </AnonymousTemplate>
                        <LoggedInTemplate>
                            

                            <h1><%= WelcomeLabel %></h1>
                                <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Loss Occured?</h2>
            <p>
                You recored loss when it occus dont ofrget to edit this text according to the bank guideline etc just a placeholder
            </p>
            <asp:LinkButton ID="LossRecoredBtn" href="/Loss/Recored" runat="server" Enabled="false" CssClass="btn btn-success btn-lg">Recored Loss &raquo;</asp:LinkButton>
                
              
         
        </div>
                                    
    </div>
                            
                        </LoggedInTemplate>
                    </asp:LoginView>








</asp:Content>
