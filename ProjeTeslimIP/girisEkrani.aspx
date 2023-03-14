<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="girisEkrani.aspx.cs" Inherits="ProjeTeslimIP.girisEkrani" %>

 <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <section class="vh-100" style="background-color: #9A616D;">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col col-xl-10">
        <div class="card" style="border-radius: 1rem;">
          <div class="row g-0">
            <div class="col-md-6 col-lg-5 d-none d-md-block">
              <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/img1.webp"
                alt="login form" class="img-fluid" style="border-radius: 1rem 0 0 1rem;" />
            </div>
            <div class="col-md-6 col-lg-7 d-flex align-items-center">
              <div class="card-body p-4 p-lg-5 text-black">

                  <div class="d-flex align-items-center mb-3 pb-1">
                  </div>

                  <h5 class="fw-normal mb-3 pb-3" style="letter-spacing: 1px;">&nbsp;</h5>

                  <div class="form-outline mb-4">
                    &nbsp;<label class="form-label" for="form2Example17">Email Adres</label><br />
                    <label class="form-label" for="form2Example17">
                      <asp:TextBox ID="epostaTextBox" runat="server" CssClass="form-control form-control-lg"></asp:TextBox>
                      </label>
                  </div>

                  <div class="form-outline mb-4">
                    &nbsp;Şifre<br />
                    <label class="form-label" for="form2Example17">
                      <asp:TextBox ID="sifreTextBox" runat="server" CssClass="form-control form-control-lg"></asp:TextBox>
                      </label>
                  </div>

                  <div class="pt-1 mb-4">

                  <a class="small text-muted" href="#!">
                      <asp:Button ID="Button1" runat="server" CssClass="btn btn-dark btn-lg btn-block" OnClick="Button1_Click" Text="Giriş Yap" />
                      </a>
                  </div>

                  <a class="form-label" href="#!">
                      <asp:Label ID="Label2" runat="server" CssClass="form-label"></asp:Label>
                      </a>

                  <br />
&nbsp;<p class="mb-5 pb-lg-2" style="color: #393f81;">Hesabınız mı yok?
                      <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Kayıt Ol</asp:LinkButton>
                  </p>
                  <p class="mb-5 pb-lg-2" style="color: #393f81;">&nbsp;</p>

              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
    </form>
</body>
</html>