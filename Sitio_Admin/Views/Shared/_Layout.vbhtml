<!DOCTYPE html>
<html lang="en">
<head>
    <title>Admin Tienda</title>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="~/Content/bootstrap-responsive.min.css" rel="stylesheet" />
    <link href="~/Content/fullcalendar.css" rel="stylesheet" />
    <link href="~/Content/matrix-style.css" rel="stylesheet" />
    <link href="~/Content/matrix-media.css" rel="stylesheet" />
    <link href="~/fonts/css/font-awesome.css" rel="stylesheet" />

    <script src="~/Scripts/jquery.flot.min.js"></script>
    <script src="~/Scripts/jquery.flot.pie.min.js"></script>
    <script src="~/Scripts/matrix.charts.js"></script>
    <script src="~/Scripts/jquery.flot.resize.min.js"></script>
    <script src="~/Scripts/jquery.peity.min.js"></script> 
    <script src="~/Scripts/matrix.dashboard.js"></script>


    <script src="~/Scripts/moment.min.js"></script>
    <script src="~/Scripts/jquery.min.js"></script>
    <script src="~/Scripts/jquery.ui.custom.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
    <script src="~/Scripts/fullcalendar.min.js"></script>
    <script src="~/Scripts/matrix.js"></script>
    <script src="~/Scripts/matrix.calendar.js"></script>
    <script src="~/Scripts/locale-all.js"></script>
    <link href="~/Content/jquery.gritter.css" rel="stylesheet" />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,700,800' rel='stylesheet' type='text/css'>


   
</head>
<body>

    <!--Header-part-->
    <div id="header">
        <h1><a href="dashboard.html">Admin Tienda</a></h1>
    </div>
    <!--close-Header-part-->
    <!--top-Header-menu-->
    <div id="user-nav" class="navbar navbar-inverse">
        <ul class="nav">
            <li class="dropdown" id="profile-messages">
                <a title="" href="#" data-toggle="dropdown" data-target="#profile-messages" class="dropdown-toggle"><i class="icon icon-user"></i>  <span class="text">Bienvenido Usuario</span><b class="caret"></b></a>
                <ul class="dropdown-menu">
                    <li><a href="#"><i class="icon-user"></i> Mi Perfil</a></li>
                    <li class="divider"></li>
                    <li><a href="#"><i class="icon-check"></i> Mis Tareas</a></li>
                    <li class="divider"></li>
                    <li><a href="login.html"><i class="icon-key"></i> Cerrar Sesiòn</a></li>
                </ul>
            </li>
            <li class="dropdown" id="menu-messages">
                <a href="#" data-toggle="dropdown" data-target="#menu-messages" class="dropdown-toggle"><i class="icon icon-envelope"></i> <span class="text">Notificaciones</span> <span class="label label-important">5</span> <b class="caret"></b></a>
                <ul class="dropdown-menu">
                    @*<li><a class="sAdd" title="" href="#"><i class="icon-plus"></i> Nuevo Mensaje</a></li>*@
                    <li class="divider"></li>
                    <li><a class="sInbox" title="" href="#"><i class="icon-envelope"></i> Nuevas</a></li>
                    <li class="divider"></li>
                    @*<li><a class="sOutbox" title="" href="#"><i class="icon-arrow-up"></i> Salida</a></li>*@
                    <li class="divider"></li>
                    <li><a class="sOutbox" title="" href="#"><i class="icon-arrow-up"></i> Leidas</a></li>
                </ul>
            </li>
            <li class=""><a title="" href="#"><i class="icon icon-cog"></i> <span class="text">Configuracion</span></a></li>
            <li class=""><a title="" href="login.html"><i class="icon icon-share-alt"></i> <span class="text">Salir</span></a></li>
        </ul>
    </div>
    <!--close-top-Header-menu-->
    <!--start-top-serch-->
    <div id="search">
        <input type="text" placeholder="Buscar..." />
        <button type="submit" class="tip-bottom" title="Search"><i class="icon-search icon-white"></i></button>
    </div>
    <!--close-top-serch-->
    <!--sidebar-menu-->
    <div id="sidebar">
        <a href="#" class="visible-phone"><i class="icon icon-home"></i> Inicio</a>
        <ul>
            <li class="active"><a href="@Url.Action("Index", "Home")"><i class="icon icon-home"></i> <span>Inicio</span></a> </li>
            <li> <a href="charts.html"><i class="icon icon-signal"></i> <span>Charts &amp; graphs</span></a> </li>
            <li> <a href="widgets.html"><i class="icon icon-inbox"></i> <span>Widgets</span></a> </li>
            <li><a href="tables.html"><i class="icon icon-th"></i> <span>Tables</span></a></li>
            <li><a href="grid.html"><i class="icon icon-fullscreen"></i> <span>Full width</span></a></li>
            <li class="submenu">
                <a href="#"><i class="icon icon-th-list"></i> <span>Forms</span> <span class="label label-important">3</span></a>
                <ul>
                    <li><a href="form-common.html">Basic Form</a></li>
                    <li><a href="form-validation.html">Form with Validation</a></li>
                    <li><a href="form-wizard.html">Form with Wizard</a></li>
                </ul>
            </li>
            <li><a href="buttons.html"><i class="icon icon-tint"></i> <span>Buttons &amp; icons</span></a></li>
            <li><a href="interface.html"><i class="icon icon-pencil"></i> <span>Eelements</span></a></li>
            <li class="submenu">
                <a href="#"><i class="icon icon-file"></i> <span>Addons</span> <span class="label label-important">5</span></a>
                <ul>
                    <li><a href="index2.html">Dashboard2</a></li>
                    <li><a href="gallery.html">Gallery</a></li>
                    <li><a href="@Url.Action("Calendario", "Home")">Calendario</a></li>
                    <li><a href="invoice.html">Invoice</a></li>
                    <li><a href="chat.html">Chat option</a></li>
                </ul>
            </li>
            <li class="submenu">
                <a href="#"><i class="icon icon-info-sign"></i> <span>Error</span> <span class="label label-important">4</span></a>
                <ul>
                    <li><a href="error403.html">Error 403</a></li>
                    <li><a href="error404.html">Error 404</a></li>
                    <li><a href="error405.html">Error 405</a></li>
                    <li><a href="error500.html">Error 500</a></li>
                </ul>
            </li>
            <li class="content">
                <span>Monthly Bandwidth Transfer</span>
                <div class="progress progress-mini progress-danger active progress-striped">
                    <div style="width: 77%;" class="bar"></div>
                </div>
                <span class="percent">77%</span>
                <div class="stat">21419.94 / 14000 MB</div>
            </li>
            <li class="content">
                <span>Disk Space Usage</span>
                <div class="progress progress-mini active progress-striped">
                    <div style="width: 87%;" class="bar"></div>
                </div>
                <span class="percent">87%</span>
                <div class="stat">604.44 / 4000 MB</div>
            </li>
        </ul>
    </div>
    <!--sidebar-menu-->
    <!--main-container-part-->
    <div id="content">
        <!--breadcrumbs-->
        <div id="content-header">
            <div id="breadcrumb"> <a class="tip-bottom"> </a></div>
        </div>
        <!--End-breadcrumbs-->
        <!--Action boxes-->
        <div class="container-fluid">
            <div class="quick-actions_homepage">
                <ul class="quick-actions">
                    @*<li class="bg_lb"> <a href="index.html"> <i class="icon-dashboard"></i> <span class="label label-important">20</span> My Dashboard </a> </li>*@
                    <li class="bg_lg"> <a href="@Url.Action("Calendario", "Home")"> <i class="icon-calendar"></i> Agenda</a> </li>
                    <li class="bg_lo"> <a href="tables.html"> <i class="icon-th"></i> Colección Noviembre</a> </li>
                    <li class="bg_ls"> <a href="@Url.Action("Graficos", "Home")"> <i class="icon-signal"></i> Gráficos de Ventas</a> </li>
                    <li class="bg_ly"> <a href="widgets.html"> <i class="icon-inbox"></i><span class="label label-success">101</span> Comentarios </a> </li>
                    @*<li class="bg_ls"> <a href="grid.html"> <i class="icon-fullscreen"></i> Full width</a> </li>
                    <li class="bg_lo"> <a href="form-common.html"> <i class="icon-th-list"></i> Forms</a> </li>
                    <li class="bg_ls"> <a href="buttons.html"> <i class="icon-tint"></i> Buttons</a> </li>
                    <li class="bg_lb"> <a href="interface.html"> <i class="icon-pencil"></i>Elements</a> </li>
                    <li class="bg_lr"> <a href="error404.html"> <i class="icon-info-sign"></i> Error</a> </li>*@

                </ul>
            </div>
            <!--End-Action boxes-->


        </div>
        @RenderBody()
    </div>

    <!--end-main-container-part-->
    <!--Footer-part-->
 
    <div class="row-fluid">
        <div id="footer" class="span12"> 2013 &copy; Admin Tienda. Brought to you by <a href="http://themedesigner.in">Themedesigner.in</a> </div>
    </div>

    <!--end-Footer-part-->

    <script src="js/excanvas.min.js"></script>
    <script src="js/jquery.min.js"></script>
    <script src="js/jquery.ui.custom.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.flot.min.js"></script>
    <script src="js/jquery.flot.resize.min.js"></script>
    <script src="js/jquery.peity.min.js"></script>
    <script src="js/fullcalendar.min.js"></script>
    <script src="js/matrix.js"></script>
    <script src="js/matrix.dashboard.js"></script>
    <script src="js/jquery.gritter.min.js"></script>
    <script src="js/matrix.interface.js"></script>
    <script src="js/matrix.chat.js"></script>
    <script src="js/jquery.validate.js"></script>
    <script src="js/matrix.form_validation.js"></script>
    <script src="js/jquery.wizard.js"></script>
    <script src="js/jquery.uniform.js"></script>
    <script src="js/select2.min.js"></script>
    <script src="js/matrix.popover.js"></script>
    <script src="js/jquery.dataTables.min.js"></script>
    <script src="js/matrix.tables.js"></script>

    <script type="text/javascript">
  // This function is called from the pop-up menus to transfer to
  // a different page. Ignore if the value returned is a null string:
  function goPage (newURL) {

      // if url is empty, skip the menu dividers and reset the menu selection to default
      if (newURL != "") {

          // if url is "-", it is this page -- reset the menu:
          if (newURL == "-" ) {
              resetMenu();
          }
          // else, send page to designated URL
          else {
            document.location.href = newURL;
          }
      }
  }

// resets the menu selection upon entry to this page:
function resetMenu() {
   document.gomenu.selector.selectedIndex = 2;
}
    </script>
</body>
</html>
