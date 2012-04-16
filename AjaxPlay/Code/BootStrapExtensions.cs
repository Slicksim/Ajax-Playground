using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxPlay.Code.BootStrap
{
    public class BootStrapModalOptions
    {
        public bool BackdropClickable  { get; set; }

        public bool EscKeyCloses { get; set; }

        public bool Fade { get; set; }

        public bool Show { get; set; }

        public string Id { get; set; }
    }
    public static class BootStrapExtensions
    {
        //public static MvcHtmlString BootStrapModal(this HtmlHelper helper, BootStrapModalOptions modalOptions, object htmlAttributes)
        //{
        //    var modalBuilder = new TagBuilder("div");
        //    modalBuilder.AddCssClass("modal");

        //    modalBuilder.MergeAttribute("id", modalOptions.ModalId);

        //    if(!modalOptions.Show)
        //        modalBuilder.AddCssClass("hide");

        //    if(modalOptions.Fade)
        //        modalBuilder.AddCssClass("fade");

        //    if(!modalOptions.BackdropClickable)
        //        modalBuilder.MergeAttribute("data-backdrop", "static");

        //    if(!modalOptions.EscKeyCloses)
        //        modalBuilder.MergeAttribute("data-keyboard", "false");

        //    modalBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

        //    var modalHeaderBuilder = new TagBuilder("div");
        //    modalHeaderBuilder.AddCssClass("modal-header");
        //    modalHeaderBuilder.InnerHtml = string.Format("<a class=\"close\" data-dismiss=\"modal\">×</a><h3>{0}</h3>", modalOptions.HeaderText);

        //    var modalBodyBuilder = new TagBuilder("div");
        //    modalBodyBuilder.AddCssClass("modal-contact");
        //    modalBodyBuilder.MergeAttribute("id", modalOptions.ContentId);

        //    var modalFooterBuilder = new TagBuilder("div");

        //    modalFooterBuilder.AddCssClass("modal-footer");

        //    modalBuilder.InnerHtml =string.Format("{0}\n{1}\n{2}", modalHeaderBuilder.ToString(TagRenderMode.Normal), modalBodyBuilder.ToString(TagRenderMode.Normal),
        //                                         modalFooterBuilder.ToString(TagRenderMode.Normal));

        //    return new MvcHtmlString(modalBuilder.ToString(TagRenderMode.Normal));
        //}

        public static BootStrapModal BeginBootStrapModal(this HtmlHelper helper, BootStrapModalOptions modalOptions, object htmlAttributes)
        {
            var modalBuilder = new TagBuilder("div");
            modalBuilder.AddCssClass("modal");

            if (!modalOptions.Show)
                modalBuilder.AddCssClass("hide");

            if (modalOptions.Fade)
                modalBuilder.AddCssClass("fade");

            if (!modalOptions.BackdropClickable)
                modalBuilder.MergeAttribute("data-backdrop", "static");

            if (!modalOptions.EscKeyCloses)
                modalBuilder.MergeAttribute("data-keyboard", "false");

            modalBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            helper.ViewContext.Writer.Write(modalBuilder.ToString(TagRenderMode.StartTag));
            return new BootStrapModal(helper.ViewContext);
        }

        public static BootStrapModalHeader BeginBootStrapModalHeader(this HtmlHelper helper, object htmlAttributes )
        {
            var modalBuilder = new TagBuilder("div");
            modalBuilder.AddCssClass("modal-header");           

            modalBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            helper.ViewContext.Writer.Write(modalBuilder.ToString(TagRenderMode.StartTag));
            return new BootStrapModalHeader(helper.ViewContext);
        }

        public static BootStrapModalContent BeginBootStrapModalContent(this HtmlHelper helper, object htmlAttributes)
        {
            var modalBuilder = new TagBuilder("div");
            modalBuilder.AddCssClass("modal-body");

            modalBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            helper.ViewContext.Writer.Write(modalBuilder.ToString(TagRenderMode.StartTag));
            return new BootStrapModalContent(helper.ViewContext);
        }

        public static BootStrapModalFooter BeginBootStrapModalFooter(this HtmlHelper helper, object htmlAttributes)
        {
            var modalBuilder = new TagBuilder("div");
            modalBuilder.AddCssClass("modal-footer");

            modalBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            helper.ViewContext.Writer.Write(modalBuilder.ToString(TagRenderMode.StartTag));
            return new BootStrapModalFooter(helper.ViewContext);
        }

    }

    public class BootStrapModal : IDisposable
    {
        public BootStrapModal(HttpResponseBase httpResponse)
        {
            if (httpResponse == null)
                throw new ArgumentNullException("httpResponse");

            this._writer = httpResponse.Output;
        }

        public BootStrapModal(ViewContext viewContext)
        {
            if (viewContext == null)
                throw new ArgumentNullException("viewContext");

            this._writer = viewContext.Writer;
        }

        private bool _disposed;
        private readonly TextWriter _writer;

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool isDispose)
        {
            if (!this._disposed)
            {
                this._disposed = true;
                this._writer.Write("</div>");
            }
        }

        public void EndAnchor()
        {
            Dispose(true);
        }

        #endregion
    }

    public class BootStrapModalHeader : IDisposable
    {
        public BootStrapModalHeader(HttpResponseBase httpResponse)
        {
            if (httpResponse == null)
                throw new ArgumentNullException("httpResponse");

            this._writer = httpResponse.Output;
        }

        public BootStrapModalHeader(ViewContext viewContext)
        {
            if (viewContext == null)
                throw new ArgumentNullException("viewContext");

            this._writer = viewContext.Writer;
        }

        private bool _disposed;
        private readonly TextWriter _writer;

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool isDispose)
        {
            if (!this._disposed)
            {
                this._disposed = true;
                this._writer.Write("</div>");
            }
        }

        public void EndAnchor()
        {
            Dispose(true);
        }

        #endregion
    }

    public class BootStrapModalContent : IDisposable
    {
        public BootStrapModalContent(HttpResponseBase httpResponse)
        {
            if (httpResponse == null)
                throw new ArgumentNullException("httpResponse");

            this._writer = httpResponse.Output;
        }

        public BootStrapModalContent(ViewContext viewContext)
        {
            if (viewContext == null)
                throw new ArgumentNullException("viewContext");

            this._writer = viewContext.Writer;
        }

        private bool _disposed;
        private readonly TextWriter _writer;

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool isDispose)
        {
            if (!this._disposed)
            {
                this._disposed = true;
                this._writer.Write("</div>");
            }
        }

        public void EndAnchor()
        {
            Dispose(true);
        }

        #endregion
    }

    public class BootStrapModalFooter : IDisposable
    {
        public BootStrapModalFooter(HttpResponseBase httpResponse)
        {
            if (httpResponse == null)
                throw new ArgumentNullException("httpResponse");

            this._writer = httpResponse.Output;
        }

        public BootStrapModalFooter(ViewContext viewContext)
        {
            if (viewContext == null)
                throw new ArgumentNullException("viewContext");

            this._writer = viewContext.Writer;
        }

        private bool _disposed;
        private readonly TextWriter _writer;

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool isDispose)
        {
            if (!this._disposed)
            {
                this._disposed = true;
                this._writer.Write("</div>");
            }
        }

        public void EndAnchor()
        {
            Dispose(true);
        }

        #endregion
    }

}