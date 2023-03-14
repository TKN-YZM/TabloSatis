<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sepetim.aspx.cs" Inherits="ProjeTeslimIP.Sepetim" %>

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
                
        <li class="nav-item">
             <asp:LinkButton ID="LinkButton3" runat="server" CssClass="nav-link" OnClick="LinkButton1_Click1"   >Profil</asp:LinkButton>
        </ul>
        </div>
    </nav>
    <div class="container mt-3">
        <div class="row">
            <div class="col-lg-12 col-sm-12">
                <div class="p-3 mb-2 bg-secondary text-white mt-3 text-center">&quot;Resim,dili olmayan bir şiir,şiir de kör bir resim dir.&quot; Leonardo da Vinci</div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-4 col-sm-12">
                <div class="card">
                    <div class="card-body">
                    <h5 class="card-title">
                        &nbsp;</h5>
                        <h5 class="card-title">
                        <asp:Label ID="baslik1" runat="server" Text="Label"></asp:Label>
                        </h5>
                        <p class="card-title">
                            &nbsp;</p>
                    <p class="card-text">
                        <asp:Label ID="aciklama1" runat="server" Text="Label"></asp:Label>
                        </p>
                
            &nbsp;<asp:Button ID="Button9" runat="server" OnClick="Button9_Click2" Text="Sepetten Çıkar" Width="113px" />
                        <asp:Label ID="fiyat1" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="d1" runat="server" Text="$"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-12">
                <div class="card">
                  &nbsp;<div class="card-body">
                    <h5 class="card-title">
                        <asp:Label ID="baslik2" runat="server" Text="Label"></asp:Label>
                        </h5>
                        <p class="card-title">&nbsp;</p>
                    <p class="card-text">
                        <asp:Label ID="aciklama2" runat="server" Text="Label"></asp:Label>
                        </p>
                
                        <asp:Button ID="urunButton2" runat="server" OnClick="Button9_Click" Text="Sepetten Çıkar" Width="112px" />
            &nbsp;<asp:Label ID="fiyat2" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="d2" runat="server" Text="$"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-12">
                
                <div class="card">
                  &nbsp;<div class="card-body">
                    <h5 class="card-title">
                        <asp:Label ID="denemeee" runat="server" Text="Label"></asp:Label>
                        </h5>
                        <p class="card-title">&nbsp;</p>
                    <p class="card-text">
                        <asp:Label ID="aciklama3" runat="server" Text="Label"></asp:Label>
                        </p>
                
                        <asp:Button ID="urunButton3" runat="server" OnClick="Button9_Click" Text="Sepetten Çıkar" Width="113px" />
            &nbsp;<asp:Label ID="fiyat3" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="d3" runat="server" Text="$"></asp:Label>
                    </div>
                </div>
                
            </div>
        </div>
        <br />

        <div class="row">
            <div class="col-lg-4 col-sm-12">
                <div class="card">
                  &nbsp;<div class="card-body">
                    <h5 class="card-title">
                        <asp:Label ID="baslik4" runat="server" Text="Label"></asp:Label>
                        </h5>
                        <p class="card-title">&nbsp;</p>
                    <p class="card-text">
                        <asp:Label ID="aciklama4" runat="server" Text="Label"></asp:Label>
                        </p>
                
                        <asp:Button ID="urunButton4" runat="server" OnClick="Button10_Click1" Text="Sepetten Çıkar" Width="113px" />
            &nbsp;<asp:Label ID="fiyat4" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="d4" runat="server" Text="$"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-12">
                <div class="card">
                  &nbsp;<div class="card-body">
                    <h5 class="card-title">
                        <asp:Label ID="baslik5" runat="server" Text="Label"></asp:Label>
                        </h5>
                        <p class="card-title">&nbsp;</p>
                    <p class="card-text">
                        <asp:Label ID="aciklama5" runat="server" Text="Label"></asp:Label>
                        </p>
                
                        <asp:Button ID="urunButton5" runat="server" OnClick="Button11_Click" Text="Sepetten Çıkar" Width="119px" />
            &nbsp;<asp:Label ID="fiyat5" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="d5" runat="server" Text="$"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-12">
                <div class="card">
                  &nbsp;<div class="card-body">
                        <h5 class="card-title">
                        <asp:Label ID="baslik6" runat="server" Text="Label"></asp:Label>
                        </h5>
                        <p class="card-title">&nbsp;</p>
                    <p class="card-text">
                        <asp:Label ID="aciklama6" runat="server" Text="Label"></asp:Label>
                        </p>
            &nbsp;<asp:Button ID="urunButton6" runat="server" OnClick="Button12_Click" Text="Sepetten Çıkar" Width="113px" />
                        <asp:Label ID="fiyat6" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="d6" runat="server" Text="$"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
        <br />
          <br />
        <div class="row">
            <div class="col-lg-12 col-sm-12">
                <div class="col-lg-12 col-sm-12">
                    <center>
                        Toplam Tutarı:<br />
                        <asp:Label ID="fiyat" runat="server" Text="0"></asp:Label>
                        <asp:Label ID="d7" runat="server" Text="$"></asp:Label>
                    </center>
                    
                    <br />
                        <br />
                <center>
                    <asp:Button ID="odemeButton" runat="server" OnClick="Button1_Click" Text="Ödemeye Sayfasına Geç" Width="682px" CssClass="btn btn-primary" />
                </center>
                   <br />
                        <br />
                        <br />

                
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
