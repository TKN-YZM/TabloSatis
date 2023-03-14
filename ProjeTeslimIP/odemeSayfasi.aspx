<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="odemeSayfasi.aspx.cs" Inherits="ProjeTeslimIP.odemeSayfasi" %>

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
          <asp:LinkButton ID="LinkButton4" runat="server" CssClass="navbar-brand" ForeColor="#99CCFF" OnClick="LinkButton4_Click">Resim Sanatı</asp:LinkButton>
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
             <asp:LinkButton ID="LinkButton5" runat="server" CssClass="nav-link" OnClick="LinkButton5_Click">Profil</asp:LinkButton>
        </ul>
        </div>
    </nav>
    <div class="container mt-3">
    
        <div class="row">
            <div class="col-lg-8 col-sm-12">
                <asp:Panel ID="Panel1" runat="server" Height="299px">
                    <center>
                        <asp:Label ID="Label1" runat="server" Text="Lütfen Seçim Yapın: "></asp:Label>
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
                            <asp:ListItem>Şirket</asp:ListItem>
                            <asp:ListItem>Bireysel</asp:ListItem>
                    </asp:DropDownList>
                        <br />
                        <br />
                        <asp:Label ID="Label3" runat="server" Text="Lütfen Kargo Seçimi Yapınız"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                            <asp:ListItem Value="UPS">UPS (9.90 $)</asp:ListItem>
                            <asp:ListItem Value="FEDEX">FEDEX (8.90$)</asp:ListItem>
                            <asp:ListItem Value="MNG">MNG (7.90$)</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <br />
                        <asp:Label ID="Label4" runat="server" Text="Extra Bakım Ekipmanı Olsun Mu"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="evetRadio" runat="server" GroupName="A" Text="Evet" OnCheckedChanged="evetRadio_CheckedChanged" />
                        <asp:RadioButton ID="hayirRadio" runat="server" GroupName="A" Text="Hayır" />
                    </center>
                </asp:Panel>
            </div>
           

            <div class="col-lg-4 col-sm-12">
                <h2>
                    Sepet Tutar:<asp:Label ID="sepetTutar" runat="server" Text="Label"></asp:Label>
                    $</h2>
                <h2>
                    Toplam Tutar:
                    <asp:Label ID="toplamTutar" runat="server"></asp:Label>
                    $</h2>
                <p class="text-justify">
                    &nbsp;</p>
                
                <asp:Button ID="tamamButton" runat="server" OnClick="Button1_Click" Text="İşlemleri Tamamla" Width="173px" CssClass="btn btn-primary" />
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
