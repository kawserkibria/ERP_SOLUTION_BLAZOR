// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ERP_SOLUTION.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\Kawsar\ERP_SOLUTION_BlAZOR\ERP_SOLUTION_BLAZOR\ERP_SOLUTION\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\Kawsar\ERP_SOLUTION_BlAZOR\ERP_SOLUTION_BLAZOR\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Kawsar\ERP_SOLUTION_BlAZOR\ERP_SOLUTION_BLAZOR\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\Kawsar\ERP_SOLUTION_BlAZOR\ERP_SOLUTION_BLAZOR\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\Kawsar\ERP_SOLUTION_BlAZOR\ERP_SOLUTION_BLAZOR\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\Kawsar\ERP_SOLUTION_BlAZOR\ERP_SOLUTION_BLAZOR\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\Kawsar\ERP_SOLUTION_BlAZOR\ERP_SOLUTION_BLAZOR\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\Kawsar\ERP_SOLUTION_BlAZOR\ERP_SOLUTION_BLAZOR\ERP_SOLUTION\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\Kawsar\ERP_SOLUTION_BlAZOR\ERP_SOLUTION_BLAZOR\ERP_SOLUTION\_Imports.razor"
using ERP_SOLUTION;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\Desktop\Kawsar\ERP_SOLUTION_BlAZOR\ERP_SOLUTION_BLAZOR\ERP_SOLUTION\_Imports.razor"
using ERP_SOLUTION.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 980 "C:\Users\Administrator\Desktop\Kawsar\ERP_SOLUTION_BlAZOR\ERP_SOLUTION_BLAZOR\ERP_SOLUTION\Shared\MainLayout.razor"
       
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
