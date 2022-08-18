<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Whatsapp_Api_Cloud._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
           
  
    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label1" runat="server" Height="50px" Text="Cabecera del Mensaje" Width="100px"></asp:Label>
            <asp:TextBox Text="Cabecera del Mensaje" Width="300px" Height="50px" ID="txt_cabecera_mensaje" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-4">
          
        </div>
  
    </div>

      <div class="row">
        <div class="col-md-4">
             <asp:Label ID="Label2" runat="server" Height="70px" Text="Cuerpo del Mensaje" Width="100px"></asp:Label>
             <asp:TextBox Text="Cuerpo del Mensaje" Width="300px" Height="70px" ID="txt_cuerpo_mensaje" runat="server"></asp:TextBox>
             <asp:Button ID="btn_enviar_mensaje" runat="server" Height="50px" OnClick="btn_enviar_mensaje_Click" Text="Enviar Mensaje" Width="100px" />
        </div>
        <div class="col-md-4">
          
        </div>
  
    </div>

</asp:Content>
