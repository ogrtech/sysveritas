<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <%--title>AdminLTE 2 | Log in</title>--%>
    <!-- Tell the browser to be responsive to screen width -->

    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <!-- Bootstrap 3.3.7 -->
    <link rel="stylesheet" href="bower_components/bootstrap/dist/css/bootstrap.min.css">
    <!-- Font Awesome -->
    <link rel="stylesheet" href="bower_components/font-awesome/css/font-awesome.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="bower_components/Ionicons/css/ionicons.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="dist/css/AdminLTE.min.css">
    <!-- iCheck -->
    <link rel="stylesheet" href="plugins/iCheck/square/blue.css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->

    <!-- Google Font -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
    <script src="js/sha512.min.js"></script>
    <script type="text/javascript">
        function callMe() {
            debugger;
            var hash = sha512(document.getElementById('txtUserName').value + document.getElementById('txtPass').value);
            document.getElementById('txtHash').value = hash;
            document.getElementById('txtPass').value = '';
            return true;
        }
    </script>
</head>
<body class="hold-transition login-page">
    <div class="login-box">
        <div class="login-logo">
            <b>SysVéritas</b>FV</a>
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">Inicio de Sesión</p>

            <form runat="server" id="form1Login">
                <div class="form-group has-feedback">
                    <asp:TextBox runat="server" ID="txtUserName" class="form-control" placeholder="Ingrese su usuario"></asp:TextBox>
                    <%--<input type="text" runat="server" id="txtUserName" class="form-control" placeholder="Ingrese su usuario">--%>
                    <span class="glyphicon glyphicon-user form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <input type="password" runat="server" id="txtPass" class="form-control" placeholder="Ingrese su contraseña">
                    <asp:HiddenField ID="txtHash" runat="server" />
                    <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                </div>
                <div class="row">

                    <!-- /.col -->
                    <div class="col-xs-12 text-center">

                        <asp:Button runat="server" ID="btnLogin" OnClientClick="return callMe()" OnClick="btnLogin_Click" class="btn btn-block btn-primary  btn-flat" Text="Ingresar" />

                        <%--<button type="button" runat="server" onclick="" class="btn btn-block btn-primary  btn-flat">Ingresar</button>--%>
                    </div>
                    <!-- /.col -->
                </div>
            </form>


            <!-- /.social-auth-links -->



        </div>
        <!-- /.login-box-body -->
    </div>
    <!-- /.login-box -->

    <!-- jQuery 3 -->
    <script src="bower_components/jquery/dist/jquery.min.js"></script>
    <!-- Bootstrap 3.3.7 -->
    <script src="bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
    <!-- iCheck -->
    <script src="plugins/iCheck/icheck.min.js"></script>
    <script>
        $(function () {
            $('input').iCheck({
                checkboxClass: 'icheckbox_square-blue',
                radioClass: 'iradio_square-blue',
                increaseArea: '20%' /* optional */
            });
        });
    </script>
</body>
</html>
