<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="email.aspx.cs" Inherits="email" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   
        <div class="box">
            <div class="box-header">
                <button type="button" class="btn btn-success" onclick="location='add.aspx'">Nuevo Correo</button>
            </div>
            <!-- /.box-header -->
            <div class="box-body" id="contenido" runat="server">
            </div>
        </div>
        <!-- /.box-body -->
        <!-- jQuery 3 -->
        <%--<script src="bower_components/jquery/dist/jquery.min.js"></script>--%>
        <!-- Bootstrap 3.3.7 -->
        <%--<script src="bower_components/bootstrap/dist/js/bootstrap.min.js"></script>--%>
        <!-- DataTables -->
       <%-- <script src="bower_components/datatables.net/js/jquery.dataTables.min.js"></script>
        <script src="bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"></script>--%>
        <!-- SlimScroll -->
        <%--<script src="bower_components/jquery-slimscroll/jquery.slimscroll.min.js"></script>--%>
        <!-- FastClick -->
        <%--<script src="bower_components/fastclick/lib/fastclick.js"></script>--%>
        <!-- AdminLTE App -->
        <%--<script src="dist/js/adminlte.min.js"></script>--%>
        <!-- AdminLTE for demo purposes -->
        <%--<script src="dist/js/demo.js"></script>--%>
        
    <%--</body>--%>
</asp:Content>

