#pragma checksum "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9145d056e4a94d7f511ac97e72d293ae870de4d"
// <auto-generated/>
#pragma warning disable 1591
namespace ERP_SOLUTION.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using ERP_SOLUTION;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using ERP_SOLUTION.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"sidebar-mobile\" class=\"position-fixed\" b-w8pu1xshx1><div class=\"sidebar-wrapper\" b-w8pu1xshx1><ul class=\"list-group mt-4\" b-w8pu1xshx1><li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1></div>\r\n                <span class=\"material-symbols-outlined mr-3\" b-w8pu1xshx1>\r\n                    home\r\n                </span>\r\n                Home\r\n            </li>\r\n            <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end\" data-toggle=\"collapse\" href=\"#subListcollapse-2\" role=\"button\" aria-expanded=\"false\" aria-controls=\"subListcollapse-2\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1><i class=\"fa-solid fa-caret-right\" b-w8pu1xshx1></i></div>\r\n\r\n                <span class=\"material-symbols-outlined mr-3\" b-w8pu1xshx1>\r\n                    person\r\n                </span>\r\n                <p class=\"m-0\" b-w8pu1xshx1>Admin</p></li>\r\n            <div class=\"collapse subListcollapse\" id=\"subListcollapse-2\" b-w8pu1xshx1><ul class=\"list-group\" b-w8pu1xshx1><li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" data-toggle=\"collapse\" href=\"#subListcollapse-2-1\" role=\"button\" aria-expanded=\"false\" aria-controls=\"subListcollapse-2-1\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1><i class=\"fa-solid fa-caret-right\" b-w8pu1xshx1></i></div>\r\n                        <p class=\"m-0\" b-w8pu1xshx1>Directory-01</p></li>\r\n                    <div class=\"collapse subListcollapse\" id=\"subListcollapse-2-1\" b-w8pu1xshx1><ul class=\"list-group\" b-w8pu1xshx1><li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                Directory-01-01\r\n                            </li>\r\n                            <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                Directory-01-02\r\n                            </li>\r\n                            <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                Directory-01-03\r\n                            </li></ul></div>\r\n                    <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                        Directory-02\r\n                    </li>\r\n                    <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                        Directory-02\r\n                    </li></ul></div>\r\n            <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1><i class=\"fa-solid fa-caret-right\" b-w8pu1xshx1></i></div>\r\n                <span class=\"material-symbols-outlined mr-3\" b-w8pu1xshx1>\r\n                    devices\r\n                </span>\r\n                <p class=\"m-0\" b-w8pu1xshx1>Devices</p></li>\r\n            <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1><i class=\"fa-solid fa-caret-right\" b-w8pu1xshx1></i></div>\r\n                <span class=\"material-symbols-outlined mr-3\" b-w8pu1xshx1>\r\n                    apps\r\n                </span>\r\n                <p class=\"m-0\" b-w8pu1xshx1>Apps</p></li>\r\n            <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1><i class=\"fa-solid fa-caret-right\" b-w8pu1xshx1></i></div>\r\n                <span class=\"material-symbols-outlined mr-3\" b-w8pu1xshx1>\r\n                    credit_card\r\n                </span>\r\n                <p class=\"m-0\" b-w8pu1xshx1>Billing</p></li>\r\n\r\n\r\n            <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end\" data-toggle=\"collapse\" href=\"#hr-subListcollapse-2\" role=\"button\" aria-expanded=\"false\" aria-controls=\"subListcollapse-2\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1><i class=\"fa-solid fa-caret-right\" b-w8pu1xshx1></i></div>\r\n\r\n                <span class=\"material-symbols-outlined mr-3\" b-w8pu1xshx1>\r\n                    person\r\n                </span>\r\n                <p class=\"m-0\" b-w8pu1xshx1>HR</p></li>\r\n            <div class=\"collapse subListcollapse\" id=\"hr-subListcollapse-2\" b-w8pu1xshx1><ul class=\"list-group\" b-w8pu1xshx1><li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" data-toggle=\"collapse\" href=\"#subListcollapse-2-1\" role=\"button\" aria-expanded=\"false\" aria-controls=\"subListcollapse-2-1\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1><i class=\"fa-solid fa-caret-right\" b-w8pu1xshx1></i></div>\r\n                        <p class=\"m-0\" b-w8pu1xshx1>Directory-01</p></li>\r\n                    <div class=\"collapse subListcollapse\" id=\"subListcollapse-2-1\" b-w8pu1xshx1><ul class=\"list-group\" b-w8pu1xshx1><li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                Directory-01-01\r\n                            </li>\r\n                            <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                Directory-01-02\r\n                            </li>\r\n                            <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                Directory-01-03\r\n                            </li></ul></div>\r\n                    <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                        Directory-02\r\n                    </li>\r\n                    <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                        Directory-02\r\n                    </li></ul></div>\r\n\r\n\r\n            <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1><i class=\"fa-solid fa-caret-right\" b-w8pu1xshx1></i></div>\r\n\r\n                <span class=\"material-symbols-outlined mr-3\" b-w8pu1xshx1>\r\n                    alternate_email\r\n                </span>\r\n                <p class=\"m-0\" b-w8pu1xshx1>Account</p></li>\r\n            \r\n            <div class=\"collapse\" id=\"collapseExample\" b-w8pu1xshx1><li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end\" data-toggle=\"collapse\" href=\"#subListcollapse-1\" role=\"button\" aria-expanded=\"false\" aria-controls=\"subListcollapse-1\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1><i class=\"fa-solid fa-caret-right\" b-w8pu1xshx1></i></div>\r\n\r\n                <span class=\"material-symbols-outlined mr-3\" b-w8pu1xshx1>\r\n                    person\r\n                </span>Home\r\n            </li>\r\n            <div class=\"collapse subListcollapse\" id=\"subListcollapse-1\" b-w8pu1xshx1><ul class=\"list-group\" b-w8pu1xshx1><li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                        test1\r\n                    </li></ul></div></div></ul></div></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "main d-flex flex-column");
            __builder.AddAttribute(3, "b-w8pu1xshx1");
            __builder.OpenElement(4, "nav");
            __builder.AddAttribute(5, "class", "d-flex w-100 position-fixed px-3");
            __builder.AddAttribute(6, "b-w8pu1xshx1");
            __builder.AddMarkupContent(7, "<div class=\"nav-left d-flex align-items-center flex-grow-1\" b-w8pu1xshx1><a class=\"navbar-brand text-white ml-3\" href=\"WebsiteAdmin\" b-w8pu1xshx1>\r\n                ERP Solution\r\n            </a></div>\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "nav-right d-flex flex-grow-1 justify-content-end");
            __builder.AddAttribute(10, "b-w8pu1xshx1");
            __builder.AddMarkupContent(11, "<div class=\"nav-group-icons d-flex align-items-center\" b-w8pu1xshx1><ul class=\"list-group list-group-horizontal mr-3\" b-w8pu1xshx1><li class=\"list-group-item border-0\" b-w8pu1xshx1><div class=\"btn-group\" b-w8pu1xshx1><span class=\"material-symbols-outlined text-white\" data-toggle=\"dropdown\" aria-expanded=\"false\" b-w8pu1xshx1>\r\n                                notifications\r\n                            </span>\r\n                            <div class=\"dropdown-menu dropdown-menu-right px-2\" style=\"width: 350px;height: 350px;overflow: auto\" b-w8pu1xshx1><div class=\"noti-header d-flex justify-content-between\" b-w8pu1xshx1><span b-w8pu1xshx1>Alert</span>\r\n                                    <span b-w8pu1xshx1>View All</span></div>\r\n                                <div class=\"noti-wrapper d-flex mt-2\" b-w8pu1xshx1><div class=\"noti-left d-flex align-items-start\" b-w8pu1xshx1><img src=\"images/gmail.png\" alt width=\"20\" height=\"20\" class=\"mr-2 mt-1\" b-w8pu1xshx1></div>\r\n                                    <div class=\"d-flex justify-content-between flex-grow-1\" b-w8pu1xshx1><div class=\"noti-title-middle d-flex flex-grow-1\" b-w8pu1xshx1><div class=\"noti-sub-details d-flex flex-column justify-content-between\" b-w8pu1xshx1><span b-w8pu1xshx1>Google Operations</span>\r\n                                                <small class=\"text-truncate\" style=\"max-width: 235px;\" b-w8pu1xshx1>\r\n                                                    this is some\r\n                                                    random text for test\r\n                                                    purpose.this is some random\r\n                                                    text for test purposethis is some random text for test\r\n                                                    purpose\r\n                                                </small></div></div>\r\n                                        <div class=\"noti-title-right d-flex flex-column justify-content-between\" style=\"min-width: 60px;\" b-w8pu1xshx1><small b-w8pu1xshx1>2022-06-30</small>\r\n                                            <span class=\"badge badge-primary mt-2\" b-w8pu1xshx1>Primary</span></div></div></div>\r\n                                <div class=\"noti-wrapper d-flex mt-2\" b-w8pu1xshx1><div class=\"noti-left d-flex align-items-start\" b-w8pu1xshx1><img src=\"images/gmail.png\" alt width=\"20\" height=\"20\" class=\"mr-2 mt-1\" b-w8pu1xshx1></div>\r\n                                    <div class=\"d-flex justify-content-between flex-grow-1\" b-w8pu1xshx1><div class=\"noti-title-middle d-flex flex-grow-1\" b-w8pu1xshx1><div class=\"noti-sub-details d-flex flex-column justify-content-between\" b-w8pu1xshx1><span b-w8pu1xshx1>Google Operations</span>\r\n                                                <small class=\"text-truncate\" style=\"max-width: 235px;\" b-w8pu1xshx1>\r\n                                                    this is some\r\n                                                    random text for test\r\n                                                    purpose.this is some random\r\n                                                    text for test purposethis is some random text for test\r\n                                                    purpose\r\n                                                </small></div></div>\r\n                                        <div class=\"noti-title-right d-flex flex-column justify-content-between\" style=\"min-width: 60px;\" b-w8pu1xshx1><small b-w8pu1xshx1>2022-06-30</small>\r\n                                            <span class=\"badge badge-primary mt-2\" b-w8pu1xshx1>Primary</span></div></div></div></div></div></li>\r\n                    <li class=\"list-group-item border-0\" b-w8pu1xshx1><div class=\"btn-group\" b-w8pu1xshx1><span class=\"material-symbols-outlined text-white \" data-toggle=\"dropdown\" aria-expanded=\"false\" b-w8pu1xshx1>\r\n                                hourglass_empty\r\n                            </span>\r\n                            <div class=\"dropdown-menu dropdown-menu-right px-2\" style=\"width: 350px;height: 350px;overflow: auto\" b-w8pu1xshx1><div class=\"noti-header d-flex justify-content-between\" b-w8pu1xshx1><span b-w8pu1xshx1>Alert</span>\r\n                                    <span b-w8pu1xshx1>View All</span></div>\r\n                                <div class=\"noti-wrapper d-flex mt-2\" b-w8pu1xshx1><div class=\"noti-left d-flex align-items-start\" b-w8pu1xshx1><img src=\"images/gmail.png\" alt width=\"20\" height=\"20\" class=\"mr-2 mt-1\" b-w8pu1xshx1></div>\r\n                                    <div class=\"d-flex justify-content-between flex-grow-1\" b-w8pu1xshx1><div class=\"noti-title-middle d-flex flex-grow-1\" b-w8pu1xshx1><div class=\"noti-sub-details d-flex flex-column justify-content-between\" b-w8pu1xshx1><span b-w8pu1xshx1>Google Operations</span>\r\n                                                <small class=\"text-truncate\" style=\"max-width: 235px;\" b-w8pu1xshx1>\r\n                                                    this is some\r\n                                                    random text for test\r\n                                                    purpose.this is some random\r\n                                                    text for test purposethis is some random text for test\r\n                                                    purpose\r\n                                                </small></div></div>\r\n                                        <div class=\"noti-title-right d-flex flex-column justify-content-between\" style=\"min-width: 60px;\" b-w8pu1xshx1><small b-w8pu1xshx1>2022-06-30</small>\r\n                                            <span class=\"badge badge-primary mt-2\" b-w8pu1xshx1>Primary</span></div></div></div>\r\n                                <div class=\"noti-wrapper d-flex mt-2\" b-w8pu1xshx1><div class=\"noti-left d-flex align-items-start\" b-w8pu1xshx1><img src=\"images/gmail.png\" alt width=\"20\" height=\"20\" class=\"mr-2 mt-1\" b-w8pu1xshx1></div>\r\n                                    <div class=\"d-flex justify-content-between flex-grow-1\" b-w8pu1xshx1><div class=\"noti-title-middle d-flex flex-grow-1\" b-w8pu1xshx1><div class=\"noti-sub-details d-flex flex-column justify-content-between\" b-w8pu1xshx1><span b-w8pu1xshx1>Google Operations</span>\r\n                                                <small class=\"text-truncate\" style=\"max-width: 235px;\" b-w8pu1xshx1>\r\n                                                    this is some\r\n                                                    random text for test\r\n                                                    purpose.this is some random\r\n                                                    text for test purposethis is some random text for test\r\n                                                    purpose\r\n                                                </small></div></div>\r\n                                        <div class=\"noti-title-right d-flex flex-column justify-content-between\" style=\"min-width: 60px;\" b-w8pu1xshx1><small b-w8pu1xshx1>2022-06-30</small>\r\n                                            <span class=\"badge badge-primary mt-2\" b-w8pu1xshx1>Primary</span></div></div></div></div></div></li>\r\n                    <li class=\"list-group-item border-0\" b-w8pu1xshx1><div class=\"btn-group\" b-w8pu1xshx1><span class=\"material-symbols-outlined text-white \" data-toggle=\"dropdown\" aria-expanded=\"false\" b-w8pu1xshx1>\r\n                                help\r\n                            </span>\r\n                            <div class=\"dropdown-menu dropdown-menu-right px-2\" b-w8pu1xshx1><a href=\"Manual\" target=\"_blank\" b-w8pu1xshx1>Manual</a></div></div></li></ul></div>\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "nav-user-icons d-flex align-items-center");
            __builder.AddAttribute(14, "b-w8pu1xshx1");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "class", "list-group list-group-horizontal");
            __builder.AddAttribute(17, "b-w8pu1xshx1");
            __builder.AddMarkupContent(18, @"<li class=""list-group-item border-0 d-flex align-items-center mini-search-input"" b-w8pu1xshx1><div class=""btn-group"" b-w8pu1xshx1><span class=""material-symbols-outlined text-white "" data-toggle=""dropdown"" aria-expanded=""false"" b-w8pu1xshx1>
                                search
                            </span>
                            <div class=""dropdown-menu dropdown-menu-right p-2"" style=""width: 275px;overflow-y: auto;"" b-w8pu1xshx1><input type=""text"" class=""form-control"" placeholder=""Search.."" b-w8pu1xshx1></div></div></li>
                    ");
            __builder.AddMarkupContent(19, "<li class=\"list-group-item border-0 d-flex align-items-center\" b-w8pu1xshx1><div class=\"btn-group\" b-w8pu1xshx1><span class=\"material-symbols-outlined text-white \" data-toggle=\"dropdown\" aria-expanded=\"false\" b-w8pu1xshx1>\r\n                                apps\r\n                            </span>\r\n                            <div class=\"dropdown-menu dropdown-menu-right p-2\" style=\"width: 275px;height: 350px;overflow-y: auto;\" b-w8pu1xshx1><div class=\"container-fluid\" b-w8pu1xshx1><div class=\"row\" b-w8pu1xshx1><div class=\"col-4 col-md-4 p-3 d-flex flex-column align-items-center justify-content-center apps-icons\" b-w8pu1xshx1><div class=\"apps-wrapper d-flex flex-column justify-content-center align-items-center\" b-w8pu1xshx1><img src=\"images/google.png\" alt width=\"40\" height=\"40\" b-w8pu1xshx1>\r\n                                                <span style=\"font-size: 14px;\" b-w8pu1xshx1>Search</span></div></div>\r\n                                        <div class=\"col-4 col-md-4 p-3 d-flex flex-column align-items-center justify-content-center apps-icons\" b-w8pu1xshx1><img src=\"images/gmail.png\" alt width=\"40\" height=\"40\" b-w8pu1xshx1>\r\n                                            <span style=\"font-size: 14px;\" b-w8pu1xshx1>Gmail</span></div>\r\n                                        <div class=\"col-4 col-md-4 p-3 d-flex flex-column align-items-center justify-content-center apps-icons\" b-w8pu1xshx1><img src=\"images/photos.png\" alt width=\"40\" height=\"40\" b-w8pu1xshx1>\r\n                                            <span style=\"font-size: 14px;\" b-w8pu1xshx1>Photos</span></div>\r\n                                        <div class=\"col-4 col-md-4 p-3 d-flex flex-column align-items-center justify-content-center apps-icons\" b-w8pu1xshx1><img src=\"images/google.png\" alt width=\"40\" height=\"40\" b-w8pu1xshx1>\r\n                                            <span style=\"font-size: 14px;\" b-w8pu1xshx1>Search</span></div>\r\n                                        <div class=\"col-4 col-md-4 p-3 d-flex flex-column align-items-center justify-content-center apps-icons\" b-w8pu1xshx1><img src=\"images/gmail.png\" alt width=\"40\" height=\"40\" b-w8pu1xshx1>\r\n                                            <span style=\"font-size: 14px;\" b-w8pu1xshx1>Gmail</span></div>\r\n                                        <div class=\"col-4 col-md-4 p-3 d-flex flex-column align-items-center justify-content-center apps-icons\" b-w8pu1xshx1><img src=\"./images/photos.png\" alt width=\"40\" height=\"40\" b-w8pu1xshx1>\r\n                                            <span style=\"font-size: 14px;\" b-w8pu1xshx1>Photos</span></div>\r\n                                        <div class=\"col-4 col-md-4 p-3 d-flex flex-column align-items-center justify-content-center apps-icons\" b-w8pu1xshx1><img src=\"images/google.png\" alt width=\"40\" height=\"40\" b-w8pu1xshx1>\r\n                                            <span style=\"font-size: 14px;\" b-w8pu1xshx1>Search</span></div>\r\n                                        <div class=\"col-4 col-md-4 p-3 d-flex flex-column align-items-center justify-content-center apps-icons\" b-w8pu1xshx1><img src=\"images/gmail.png\" alt width=\"40\" height=\"40\" b-w8pu1xshx1>\r\n                                            <span style=\"font-size: 14px;\" b-w8pu1xshx1>Gmail</span></div>\r\n                                        <div class=\"col-4 col-md-4 p-3 d-flex flex-column align-items-center justify-content-center apps-icons\" b-w8pu1xshx1><img src=\"images/photos.png\" alt width=\"40\" height=\"40\" b-w8pu1xshx1>\r\n                                            <span style=\"font-size: 14px;\" b-w8pu1xshx1>Photos</span></div></div></div></div></div></li>\r\n                    ");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "list-group-item border-0");
            __builder.AddAttribute(22, "b-w8pu1xshx1");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "btn-group");
            __builder.AddAttribute(25, "b-w8pu1xshx1");
            __builder.AddMarkupContent(26, "<img src=\"images/Account-User-PNG-HD.png\" width=\"35\" height=\"35\" alt class=\"rounded-circle dropdown-toggle\" data-toggle=\"dropdown\" aria-expanded=\"false\" b-w8pu1xshx1>\r\n                            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "dropdown-menu dropdown-menu-right py-3 ");
            __builder.AddAttribute(29, "b-w8pu1xshx1");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "user-details d-flex flex-column align-items-center");
            __builder.AddAttribute(32, "b-w8pu1xshx1");
            __builder.AddMarkupContent(33, "<img src=\"images/Account-User-PNG-HD.png\" alt width=\"80\" height=\"80\" class=\"rounded-pill\" b-w8pu1xshx1>\r\n                                    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "userName");
            __builder.AddAttribute(36, "b-w8pu1xshx1");
            __builder.AddContent(37, 
#nullable restore
#line 426 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\Shared\MainLayout.razor"
                                         employeeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "userEmail");
            __builder.AddAttribute(41, "b-w8pu1xshx1");
            __builder.AddContent(42, 
#nullable restore
#line 429 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\Shared\MainLayout.razor"
                                         loginId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                                <hr b-w8pu1xshx1>\r\n                                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", " d-flex justify-content-center");
            __builder.AddAttribute(46, "b-w8pu1xshx1");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "class", "py-2 px-3 bg-white singOut-btn rounded font-weight-bold");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 434 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\Shared\MainLayout.razor"
                                                                                                                      Logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "b-w8pu1xshx1");
            __builder.AddMarkupContent(51, "\r\n                                        Sign Out\r\n                                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "layout d-flex flex-grow-1");
            __builder.AddAttribute(55, "b-w8pu1xshx1");
            __builder.AddMarkupContent(56, "<div class=\"sidebar d-flex flex-column position-relative\" id=\"sidebar\" b-w8pu1xshx1><div class=\"sidebar-content position-fixed h-100\" b-w8pu1xshx1><div class=\"sidebar-top d-flex flex-column border-bottom\" b-w8pu1xshx1><ul class=\"list-group mt-4\" b-w8pu1xshx1><li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon\" b-w8pu1xshx1></div>\r\n                            <span class=\"material-symbols-outlined mr-3\" b-w8pu1xshx1>\r\n                                home\r\n                            </span>\r\n                            <a href=\"Home\" b-w8pu1xshx1>\r\n                                Home\r\n                            </a></li>\r\n                        <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end\" data-toggle=\"collapse\" href=\"#accounce-subListcollapse-2\" role=\"button\" aria-expanded=\"false\" aria-controls=\"subListcollapse-2\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1><i class=\"fa-solid fa-caret-right\" b-w8pu1xshx1></i></div>\r\n\r\n                            <span class=\"material-symbols-outlined mr-3\" b-w8pu1xshx1>\r\n                                person\r\n                            </span>\r\n                            <p class=\"m-0\" b-w8pu1xshx1>Inventory</p></li>\r\n                        <div class=\"collapse subListcollapse\" id=\"accounce-subListcollapse-2\" b-w8pu1xshx1><ul class=\"list-group\" b-w8pu1xshx1><li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" data-toggle=\"collapse\" href=\"#subListcollapse-2-1\" role=\"button\" aria-expanded=\"false\" aria-controls=\"subListcollapse-2-1\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1><i class=\"fa-solid fa-caret-right\" b-w8pu1xshx1></i></div>\r\n                                    <p class=\"m-0\" b-w8pu1xshx1>Master</p></li>\r\n                                <div class=\"collapse subListcollapse\" id=\"subListcollapse-2-1\" b-w8pu1xshx1><ul class=\"list-group\" b-w8pu1xshx1><li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1><a href=\"Supplier\" b-w8pu1xshx1>Supplier</a></li>\r\n                                        <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                            B\r\n                                        </li>\r\n                                        <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                            C\r\n                                        </li>\r\n                                        <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                            D\r\n                                        </li>\r\n                                        <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                            E\r\n                                        </li></ul></div>\r\n                                \r\n                                <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" data-toggle=\"collapse\" href=\"#transection_subListcollapse\" role=\"button\" aria-expanded=\"false\" aria-controls=\"subListcollapse-2-1\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1><i class=\"fa-solid fa-caret-right\" b-w8pu1xshx1></i></div>\r\n                                    <p class=\"m-0\" b-w8pu1xshx1>Transection</p></li>\r\n                                <div class=\"collapse subListcollapse\" id=\"transection_subListcollapse\" b-w8pu1xshx1><ul class=\"list-group\" b-w8pu1xshx1><li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                            Payment\r\n                                        </li>\r\n                                        <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                            Receipt\r\n                                        </li>\r\n                                        <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                            Journal\r\n                                        </li>\r\n                                        <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1>\r\n                                            Contra\r\n                                        </li></ul></div>\r\n                                <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" data-toggle=\"collapse\" href=\"#report_subListcollapse\" role=\"button\" aria-expanded=\"false\" aria-controls=\"subListcollapse-2-1\" b-w8pu1xshx1><div class=\"sub-list-collapse-icon align-self-center\" b-w8pu1xshx1><i class=\"fa-solid fa-caret-right\" b-w8pu1xshx1></i></div>\r\n                                    <p class=\"m-0\" b-w8pu1xshx1>Reports</p></li>\r\n                                <div class=\"collapse subListcollapse\" id=\"report_subListcollapse\" b-w8pu1xshx1><ul class=\"list-group\" b-w8pu1xshx1><li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1><a data-toggle=\"modal\" data-backdrop=\"static\" data-keyboard=\"false\" href data-target=\"._bd-example-modal-lg\" b-w8pu1xshx1>Trial Balance</a></li>\r\n                                        <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1><a data-toggle=\"modal\" data-backdrop=\"static\" data-keyboard=\"false\" href data-target=\"._bd-example-modal-lg\" b-w8pu1xshx1>Balance Sheet</a></li>\r\n                                        <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1><a data-toggle=\"modal\" data-backdrop=\"static\" data-keyboard=\"false\" href data-target=\"._bd-example-modal-lg\" b-w8pu1xshx1>Profit & Loss</a></li>\r\n                                        <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1><a data-toggle=\"modal\" data-backdrop=\"static\" data-keyboard=\"false\" href data-target=\"._bd-example-modal-lg_gl\" b-w8pu1xshx1>General Ledger</a></li>\r\n                                        <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-center\" b-w8pu1xshx1><a href=\"General_Journal\" b-w8pu1xshx1>General Journal</a></li></ul></div></ul></div>\r\n\r\n                        \r\n                        \r\n                        <div class=\"collapse\" id=\"collapseExample\" b-w8pu1xshx1></div></ul></div></div></div>\r\n        \r\n        ");
            __builder.AddMarkupContent(57, "<div class=\"mini-sidebar d-flex flex-column position-relative\" b-w8pu1xshx1><div class=\"mini-sidebar-wrapper position-fixed\" b-w8pu1xshx1><ul class=\"list-group mt-4\" b-w8pu1xshx1><li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end mini-sidebar-list\" b-w8pu1xshx1><span class=\"material-symbols-outlined\" b-w8pu1xshx1>\r\n                            home\r\n                        </span></li>\r\n                    <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end mini-sidebar-list\" data-toggle=\"collapse\" href=\"#subListcollapse-2\" role=\"button\" aria-expanded=\"false\" aria-controls=\"subListcollapse-2\" b-w8pu1xshx1><span class=\"material-symbols-outlined\" b-w8pu1xshx1>\r\n                            person\r\n                        </span></li>\r\n                    <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end mini-sidebar-list\" b-w8pu1xshx1><span class=\"material-symbols-outlined\" b-w8pu1xshx1>\r\n                            devices\r\n                        </span></li>\r\n                    <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end mini-sidebar-list\" b-w8pu1xshx1><span class=\"material-symbols-outlined\" b-w8pu1xshx1>\r\n                            apps\r\n                        </span></li>\r\n                    <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end mini-sidebar-list\" b-w8pu1xshx1><span class=\"material-symbols-outlined\" b-w8pu1xshx1>\r\n                            credit_card\r\n                        </span></li>\r\n                    <li class=\"list-group-item border-0 px-3 py-2 d-flex align-items-end mini-sidebar-list\" b-w8pu1xshx1><span class=\"material-symbols-outlined\" b-w8pu1xshx1>\r\n                            alternate_email\r\n                        </span></li></ul></div></div>\r\n        \r\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "dashMainContainer px-3 pt-3 pb-5");
            __builder.AddAttribute(60, "style", "margin-top:20px;margin-left:20px");
            __builder.AddAttribute(61, "b-w8pu1xshx1");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "container-fluid");
            __builder.AddAttribute(64, "b-w8pu1xshx1");
            __builder.AddContent(65, 
#nullable restore
#line 617 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 626 "C:\Users\Administrator\Desktop\Kawsar\blazor\ERP_SOLUTION\ERP_SOLUTION\Shared\MainLayout.razor"
       
    IJSObjectReference module;
    [Inject]
    public IJSRuntime JSRuntime { get; set; }
    private IJSObjectReference _jsModule;
    public static string employeeName;
    public static string employeeDesignation;
    public static string employeeDepartment;
    public static string loginId;



    protected override async Task OnInitializedAsync()
    {

    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            //await JsRuntime.InvokeVoidAsync("JsInteropcollaps");
            //await ijsruntime.InvokeAsync<string>(
            //    "QuillFunctions.createQuill", divEditorElement);


        }

    }


    public async Task Logout()
    {
        UriHelper.NavigateTo("/", true);
    }


    void Requisition() { UriHelper.NavigateTo("PurchaseRequisition"); }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
