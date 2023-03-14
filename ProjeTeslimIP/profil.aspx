<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profil.aspx.cs" Inherits="ProjeTeslimIP.profil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <html lang="tr">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
 
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
 
    <title>tasarimkodlama.com</title>
  </head>
  <body>
      <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
          <asp:LinkButton ID="LinkButton4" runat="server" CssClass="navbar-brand" OnClick="LinkButton4_Click">Resim Sanatı</asp:LinkButton>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse justify-content-end mr-5" id="navbarNavDropdown">
        <ul class="navbar-nav">
        <li class="nav-item active">
        <a class="nav-link" href="index.html">&nbsp;<span class="sr-only">(current)</span></a>
        </li>
        <li class="nav-item">
        &nbsp;</li>
        <li class="nav-item">
        &nbsp;</li>
       
                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="nav-link" OnClick="LinkButton1_Click1"   ></asp:LinkButton>
                 <asp:LinkButton ID="LinkButton2" runat="server" CssClass="nav-link" OnClick="LinkButton1_Click1"   >Sepet</asp:LinkButton>    
        <li class="nav-item">
             </ul>
        </div>
    </nav>
    <div class="container mt-3">
    
        <div class="row">
            <div class="col-lg-8 col-sm-12">
                <asp:Panel ID="Panel1" runat="server" Height="299px">
                    <center>
                        <div class="form-outline mb-4">
                            &nbsp;&nbsp;&nbsp;
                            <label class="form-label" for="form2Example17">
                            &nbsp;EPosta<br />
                            <asp:TextBox ID="epostaTextBox" runat="server" CssClass="form-control form-control-lg" OnTextChanged="epostaTextBox_TextChanged"></asp:TextBox>
                            </label>
                        </div>
                        <div class="form-outline mb-4">
                            Yeni&nbsp;Şifre<br />
                            <label class="form-label" for="form2Example17">
                            <asp:TextBox ID="sifreTextBox" runat="server" CssClass="form-control form-control-lg"></asp:TextBox>
                            <br />
                            </label>
                        </div>
                        <div class="pt-1 mb-4">
                            <a class="small text-muted" href="#!">
                            <asp:Button ID="Button1" runat="server" CssClass="btn btn-dark btn-lg btn-block" OnClick="Button1_Click" Text="Güncelle" />
                            </a>
                        </div>
                        <a class="form-label" href="#!">
                        <asp:Label ID="Label2" runat="server" CssClass="form-label"></asp:Label>
                        </a>
                    </center>
                </asp:Panel>
            </div>
           

            <div class="col-lg-4 col-sm-12">
                <h2>
                    &nbsp;</h2>
                <p class="text-justify">
                    &nbsp;</p>
                
            &nbsp;</div>
        </div>
         <br />
        <div class="row">
            <div class="col-lg-12 col-sm-12">
                
            </div>
        </div>
     
      

        <div class="row">
            <div class="col-lg-12 col-sm-12">
                <div class="col-lg-12 col-sm-12">
                
            </div>
            </div>
        </div>
    
    </div>
 
      
      
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
  </body>
</html>
    </form>
</body>
</html>
