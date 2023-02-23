using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Helpers
{
    public static class Helpers
    {
        public static MvcHtmlString AddForm(this HtmlHelper html)
        {
            TagBuilder tag = new TagBuilder("form");
            tag.MergeAttribute("action", "/Dict/AddSave");
            tag.MergeAttribute("method", "POST");

            TagBuilder name = new TagBuilder("input");
            name.MergeAttribute("name", "name");
            name.MergeAttribute("type", "text");
            name.MergeAttribute("placeholder", "Имя");

            TagBuilder phone = new TagBuilder("input");
            phone.MergeAttribute("name", "phone");
            phone.MergeAttribute("type", "text");
            phone.MergeAttribute("placeholder", "Телефон");

            TagBuilder add = new TagBuilder("input");
            add.MergeAttribute("name", "Add");
            add.MergeAttribute("type", "submit");
            add.MergeAttribute("value", "Добавить");

            TagBuilder cancel = new TagBuilder("a");
            cancel.MergeAttribute("href", "/Dict/Index");
            cancel.InnerHtml += "Отмена";

            tag.InnerHtml += name.ToString();
            tag.InnerHtml += phone.ToString();
            tag.InnerHtml += add.ToString();
            tag.InnerHtml += cancel.ToString();

            tag.InnerHtml += html.ValidationSummary().ToString();

            return new MvcHtmlString(tag.ToString());
        }

        public static MvcHtmlString UpdateForm(this HtmlHelper html, string n, string ph)
        {
            TagBuilder tag = new TagBuilder("form");
            tag.MergeAttribute("action", "/Dict/UpdateSave");
            tag.MergeAttribute("method", "POST");

            TagBuilder name = new TagBuilder("input");
            name.MergeAttribute("name", "name");
            name.MergeAttribute("type", "text");
            name.MergeAttribute("placeholder", "Имя");
            name.MergeAttribute("value", n);
            name.MergeAttribute("readonly", true.ToString());

            TagBuilder phone = new TagBuilder("input");
            phone.MergeAttribute("name", "phone");
            phone.MergeAttribute("type", "text");
            phone.MergeAttribute("placeholder", "Новый телефон");
            phone.MergeAttribute("value", ph);

            TagBuilder add = new TagBuilder("input");
            add.MergeAttribute("name", "Update");
            add.MergeAttribute("type", "submit");
            add.MergeAttribute("value", "Изменить");

            TagBuilder cancel = new TagBuilder("a");
            cancel.MergeAttribute("href", "/Dict/Index");
            cancel.InnerHtml += "Отмена";

            tag.InnerHtml += name.ToString();
            tag.InnerHtml += phone.ToString();
            tag.InnerHtml += add.ToString();
            tag.InnerHtml += cancel.ToString();

            tag.InnerHtml += html.ValidationSummary().ToString();

            return new MvcHtmlString(tag.ToString());
        }
    }
}