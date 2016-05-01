var myApp = angular.module('Api', []);

myApp.controller("CrlPrincipal", function ($scope) {

    $scope.Titulo = "SisSchool";

});


myApp.directive("menuprincipal", function () {
    return {
        restrict: "E",
        template:   
        '<div class="navbar-default sidebar" role="navigation">'+
                '<div class="sidebar-nav navbar-collapse">'+
                    '<ul class="nav" id="side-menu">'+
                        '<li>'+
                            '<a href="index.html"><i class="fa fa-dashboard fa-fw nav_icon"></i>Dashboard</a>'+
                            '</li>'+
                            '<li class="active">'+
                                '<a href="#"><i class="fa fa-laptop nav_icon"></i>Layouts<span class="fa arrow"></span></a>'+
                            '<ul class="nav nav-second-level collapse in" aria-expanded="true">'+
                                '<li>'+
                                    '<a href="grids.html">Grid System</a>'+
                            '</li>'+
                        '</ul>'+                           
                        '</li>'+
                        '<li class="">'+
                        '<a href="#"><i class="fa fa-indent nav_icon"></i>Menu Levels<span class="fa arrow"></span></a>'+
                            '<ul class="nav nav-second-level collapse" aria-expanded="false" style="height: 0px;">'+
                                '<li>'+
                                    '<a href="graphs.html">Graphs</a>'+
                            '</li>'+
                            '<li>'+
                                '<a href="typography.html" class="active">Typography</a>'+
                            '</li>'+
                        '</ul>'+                          
                        '</li>'+
                        '<li>'+
                        '<a href="#"><i class="fa fa-envelope nav_icon"></i>Mailbox<span class="fa arrow"></span></a>'+
                            '<ul class="nav nav-second-level collapse">'+
                                '<li>'+
                                    '<a href="inbox.html">Inbox</a>'+
                            '</li>'+
                            '<li>'+
                                '<a href="compose.html">Compose email</a>'+
                            '</li>'+
                        '</ul>'+                            
                        '</li>'+
                        '<li>'+
                        '<a href="widgets.html"><i class="fa fa-flask nav_icon"></i>Widgets</a>'+
                            '</li>'+
                             '<li>'+
                                '<a href="#"><i class="fa fa-check-square-o nav_icon"></i>Forms<span class="fa arrow"></span></a>'+
                            '<ul class="nav nav-second-level collapse">'+
                                '<li>'+
                                    '<a href="forms.html">Basic Forms</a>'+
                            '</li>'+
                            '<li>'+
                                '<a href="validation.html">Validation</a>'+
                            '</li>'+
                        '</ul>'+                           
                        '</li>'+
                        '<li>'+
                        '<a href="#"><i class="fa fa-table nav_icon"></i>Tables<span class="fa arrow"></span></a>'+
                        '<ul class="nav nav-second-level collapse">'+
                            '<li>'+
                                '<a href="basic_tables.html">Basic Tables</a>'+
                        '</li>'+
                        '</ul>'+
                            
                        '</li>'+
                        '<li>'+
                        '<a href="#"><i class="fa fa-sitemap fa-fw nav_icon"></i>Css<span class="fa arrow"></span></a>'+
                        '<ul class="nav nav-second-level collapse">'+
                            '<li>'+
                                '<a href="media.html">Media</a>'+
                        '</li>'+
                        '<li>'+
                            '<a href="login.html">Login</a>'+
                        '</li>'+
                        '</ul>'+                       
                        '</li>'+
                        '</ul>'+
                        '</div>'+              
                        '</div>'
    }
});





//myApp.directive("Cuerpo", function () {
//    return {
//        restrict: "E",
//        template:""
       
//    }
//});
