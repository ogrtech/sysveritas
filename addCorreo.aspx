<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addCorreo.aspx.cs" Inherits="add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <!-- Bootstrap 3.3.7 -->
    <link rel="stylesheet" href="bower_components/bootstrap/dist/css/bootstrap.min.css" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="bower_components/font-awesome/css/font-awesome.min.css" />
    <!-- Ionicons -->
    <link rel="stylesheet" href="bower_components/Ionicons/css/ionicons.min.css" />
    <!-- Theme style -->
    <link rel="stylesheet" href="dist/css/AdminLTE.min.css" />
    <!-- AdminLTE Skins. Choose a skin from the css/skins
       folder instead of downloading all of them to reduce the load. -->
    <link rel="stylesheet" href="dist/css/skins/_all-skins.min.css" />
    <!-- iCheck -->
    <link rel="stylesheet" href="plugins/iCheck/flat/blue.css" />
    <!-- bootstrap wysihtml5 - text editor -->
    <link rel="stylesheet" href="plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css" />
    <!-- Google Font -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="box box-primary">
            <div class="box-header with-border">
                <h3 class="box-title">Envio de correo</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <div class="form-group">
                    <asp:TextBox ID="txtDestino" runat="server" CssClass="form-control" placeholder="Para:" TextMode="Email"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtAsunto" runat="server" CssClass="form-control" placeholder="Asunto:"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox id="__composetextarea" runat="server" class="form-control" style="height: 300px" TextMode="MultiLine">
                    </asp:TextBox>
                </div>
            </div>
            <!-- /.box-body -->
            <div class="box-footer">
                <div class="pull-right">
                    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-default" Text="Cancelar" OnClick="btnCancelar_Click" />
                    <asp:Button ID="btnEnviar" runat="server" CssClass="btn btn-primary" Text="Enviar" OnClick="btnEnviar_Click" />
                </div>
            </div>
            <!-- /.box-footer -->
        </div>
    </form>
    <!-- jQuery 3 -->
    <script src="bower_components/jquery/dist/jquery.min.js"></script>
    <!-- Bootstrap 3.3.7 -->
    <script src="bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
    <!-- Slimscroll -->
    <script src="bower_components/jquery-slimscroll/jquery.slimscroll.min.js"></script>
    <!-- FastClick -->
    <script src="bower_components/fastclick/lib/fastclick.js"></script>
    <!-- AdminLTE App -->
    <script src="dist/js/adminlte.min.js"></script>
    <!-- Bootstrap WYSIHTML5 -->
    <script src="plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"></script>
    <script>
        $(function () {
            //Add text editor
            $("#__composetextarea").wysihtml5();
        });
</script>
</body>
</html>
