#pragma checksum "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48ecb7838c448446850407a56f5b123a9b14a08f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderUI), @"mvc.1.0.view", @"/Views/Order/OrderUI.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/_ViewImports.cshtml"
using PizzaOrdering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/_ViewImports.cshtml"
using PizzaOrdering.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48ecb7838c448446850407a56f5b123a9b14a08f", @"/Views/Order/OrderUI.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec38a142931a1c2c1aaf133ff5ad690794621278", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderUI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ClearOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 6 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
  
    ViewBag.Title = "Place Order";

    List<string> orderTypeOptions = new List<string> { "Pickup", "Delivery" };

    // Session states to keep track of current order
    var session = new OrderSession(Context.Session);
    var pizzas = session.GetPizzas();
    string subtotalString = session.GetSubtotal();
    var subtotal = System.Convert.ToDecimal(subtotalString);
    string taxString = session.GetTax();
    var tax = System.Convert.ToDecimal(taxString);
    var total = subtotal + tax;
    var ordertype = session.GetOrderType();
    var deliveryaddress = session.GetDeliveryAddress();

    CultureInfo ci = new CultureInfo("en-us"); // for USD $ currency format

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-left\">\n    <h2>Place a Pizza Order</h2>\n</div>\n<br />\n\n");
#nullable restore
#line 31 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
 using (Html.BeginForm("SaveInfo", "Order", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48ecb7838c448446850407a56f5b123a9b14a08f6209", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 33 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("    <div>\n        <label id=\"OrderType\"><strong>Order Type</strong></label> <br />\n");
#nullable restore
#line 37 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
         if (ordertype == null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
       Write(Html.DropDownList("OrderType", new SelectList(orderTypeOptions), "Select"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                                                                                       ;
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <select id=\"OrderType\" name=\"OrderType\" required>\n");
#nullable restore
#line 44 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                 for (int i = 0; i < orderTypeOptions.Count; i++)
                {
                    if (ordertype == orderTypeOptions[i])
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48ecb7838c448446850407a56f5b123a9b14a08f9373", async() => {
#nullable restore
#line 48 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                                                                 Write(orderTypeOptions[i]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                           WriteLiteral(orderTypeOptions[i]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 49 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48ecb7838c448446850407a56f5b123a9b14a08f11974", async() => {
#nullable restore
#line 52 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                                                        Write(orderTypeOptions[i]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                           WriteLiteral(orderTypeOptions[i]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 53 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\n");
#nullable restore
#line 56 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <br />\n    <div>\n        <label id=\"DeliveryAddress\"><strong>Delivery Address</strong></label> <br />\n");
#nullable restore
#line 62 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
         if (deliveryaddress == null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
       Write(Html.TextBox("DeliveryAddress"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                                            
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input id=\"DeliveryAddress\" name=\"DeliveryAddress\"");
            BeginWriteAttribute("value", " value=\"", 2145, "\"", 2169, 1);
#nullable restore
#line 68 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
WriteAttributeValue("", 2153, deliveryaddress, 2153, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required />\n");
#nullable restore
#line 69 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    <br />\n    <button type=\"submit\" class=\"btn btn-primary\">Save Info</button>\n    <br />\n");
#nullable restore
#line 74 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n\n");
#nullable restore
#line 78 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
 if (pizzas.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p><strong>Pizzas</strong></p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48ecb7838c448446850407a56f5b123a9b14a08f16993", async() => {
                WriteLiteral("Start Over");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <table class=\"table table-bordered table-striped\">\n        <thead>\n            <tr><th>Type</th><th>Toppings</th><th>Quantity</th><th>Price</th>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 88 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
             foreach (var pizza in pizzas)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 91 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                   Write(pizza.PizzaType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n");
#nullable restore
#line 93 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                         foreach (var topping in pizza.Toppings)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>");
#nullable restore
#line 95 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                             Write(topping.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 95 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                                             Write(topping.Price.ToString("C", ci));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\n");
#nullable restore
#line 96 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                    <td>");
#nullable restore
#line 98 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                   Write(pizza.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 99 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                   Write(pizza.Price.ToString("C", ci));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 101 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td></td>\n                <td></td>\n                <td>Subtotal:</td>\n                <td>");
#nullable restore
#line 106 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
               Write(subtotal.ToString("C", ci));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td></td>\n                <td></td>\n                <td>Tax:</td>\n                <td>");
#nullable restore
#line 112 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
               Write(tax.ToString("C", ci));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td></td>\n                <td></td>\n                <td><strong>Total:</strong></td>\n                <td><strong>");
#nullable restore
#line 118 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                       Write(total.ToString("C", ci));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\n            </tr>\n        </tbody>\n    </table>\n    <br />\n");
#nullable restore
#line 124 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
     using (Html.BeginForm("SubmitOrder", "Order", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button type=\"submit\" class=\"btn btn-primary\">Submit Order</button>\n");
#nullable restore
#line 127 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n\n");
#nullable restore
#line 132 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
 using (Html.BeginForm("AddPizza", "Pizza", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48ecb7838c448446850407a56f5b123a9b14a08f24225", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 134 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("    <div>\n        <label><strong>Pizza Type</strong></label> <br />\n        ");
#nullable restore
#line 138 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
   Write(Html.RadioButton("PizzaType", "Classic"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span> Classic</span><br />\n        ");
#nullable restore
#line 139 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
   Write(Html.RadioButton("PizzaType", "Thin Crust"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span> Thin Crust</span><br />\n        ");
#nullable restore
#line 140 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
   Write(Html.RadioButton("PizzaType", "Deep Dish"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span> Deep Dish</span><br />\n        ");
#nullable restore
#line 141 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
   Write(Html.RadioButton("PizzaType", "Cecilian"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span> Cecilian</span><br />\n    </div>\n    <br />\n    <div>\n        <label><strong>Toppings</strong></label> <br />\n        ");
#nullable restore
#line 146 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
   Write(Html.CheckBox("Pepperoni", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 146 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                                      Write(Html.Label("Pepperoni"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n        ");
#nullable restore
#line 147 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
   Write(Html.CheckBox("Sausage", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 147 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                                    Write(Html.Label("Sausage"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n        ");
#nullable restore
#line 148 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
   Write(Html.CheckBox("Bacon", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 148 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                                  Write(Html.Label("Bacon"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n        ");
#nullable restore
#line 149 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
   Write(Html.CheckBox("Mushrooms", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 149 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                                      Write(Html.Label("Mushrooms"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n        ");
#nullable restore
#line 150 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
   Write(Html.CheckBox("Onions", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 150 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                                   Write(Html.Label("Onions"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n        ");
#nullable restore
#line 151 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
   Write(Html.CheckBox("ExtraCheese", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 151 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
                                        Write(Html.Label("Extra Cheese"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n    </div>\n    <br />\n");
            WriteLiteral("    <div>\n        <label><strong>Quantity</strong></label> <br />\n        ");
#nullable restore
#line 157 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"
   Write(Html.TextBox("Quantity"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <br />\n    <button type=\"submit\" class=\"btn btn-primary\">Add Pizza</button>\n");
#nullable restore
#line 161 "/Users/dominicrzepecki/Documents/School/Spring 2022/Programming for the Internet/Final Project/PizzaOrdering/PizzaOrdering/Views/Order/OrderUI.cshtml"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591