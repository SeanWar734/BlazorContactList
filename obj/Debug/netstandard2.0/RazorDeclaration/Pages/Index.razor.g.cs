#pragma checksum "C:\Users\swarc\OneDrive\Desktop\Blazor\BlazorContactList\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f25414d277e02693367c7233a54fab81ef216705"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorContactList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\swarc\OneDrive\Desktop\Blazor\BlazorContactList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\swarc\OneDrive\Desktop\Blazor\BlazorContactList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\swarc\OneDrive\Desktop\Blazor\BlazorContactList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\swarc\OneDrive\Desktop\Blazor\BlazorContactList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\swarc\OneDrive\Desktop\Blazor\BlazorContactList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\swarc\OneDrive\Desktop\Blazor\BlazorContactList\_Imports.razor"
using BlazorContactList;

#line default
#line hidden
#line 7 "C:\Users\swarc\OneDrive\Desktop\Blazor\BlazorContactList\_Imports.razor"
using BlazorContactList.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 30 "C:\Users\swarc\OneDrive\Desktop\Blazor\BlazorContactList\Pages\Index.razor"
 
    public String contactFirstName { get; set; }
    public String contactLastName { get; set; }
    public String contactPhoneNumber { get; set; }
    public DateTime contactBirthDay { get; set; }

    public Class Contact
    {

        private guid id;
        public string contactFirstName;
        public string contactLastName;
        public string contactPhoneNumber;
        public string contactBirthDay;                
    
        public Contact(string firstName, string lastName, string phoneNumber, DateTime birthDay)
        {
            contactFirstName = firstName;
            contactLastName = lastName;
            contactPhoneNumber = phoneNumber;
            contactBirthDay = birthDay;
        }
    }

    public list<contact> contactList = new list<contact>();

    public void addContact(string contactFirstName, string contactLastName, string contactPhoneNumber, DateTime contactBirthDay) 
    {
        Contact newContact = new Contact(contactFirstName, contactLastName, contactPhoneNumber, contactBirthDay);
        contactList.add(newContact);
        return;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
