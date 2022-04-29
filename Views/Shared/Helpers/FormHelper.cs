using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab3_mvc.Views.Shared.Helpers
{
    public static class FormHelper
    {
        public static MvcHtmlString AddForm(this HtmlHelper html)
        {
            TagBuilder divTag = new TagBuilder("div");
            TagBuilder inputName = new TagBuilder("input");
            TagBuilder inputPhone = new TagBuilder("input");
            TagBuilder inputSubmit = new TagBuilder("input");

            inputName.Attributes.Add("type", "text");
            inputPhone.Attributes.Add("type", "text");
            inputSubmit.Attributes.Add("type", "submit");

            inputName.Attributes.Add("name", "LastName");
            inputPhone.Attributes.Add("name", "Number");

            inputName.Attributes.Add("placeholder", "LastName");
            inputPhone.Attributes.Add("placeholder", "Number");

            inputName.Attributes.Add("value", "");
            inputPhone.Attributes.Add("value", "");
            inputSubmit.Attributes.Add("value", "Add Record");

            divTag.InnerHtml += inputName.ToString();
            divTag.InnerHtml += inputPhone.ToString();
            divTag.InnerHtml += inputSubmit.ToString();


            return new MvcHtmlString(divTag.ToString());
        }
    }
}