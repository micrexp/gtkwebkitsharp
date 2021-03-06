//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLParagraphElement { WebKitDOMHTMLElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLParagraphElement
    {
        // DEBUG: WebKitDOMHTMLElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLParagraphElementClass { WebKitDOMHTMLElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLParagraphElementClass
    {
        // DEBUG: WebKitDOMHTMLElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLParagraphElement: GLib.Object
    {
        public WebKitDOMHTMLParagraphElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_paragraph_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_paragraph_element_get_type")]
        internal static extern uint webkit_dom_html_paragraph_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_paragraph_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_paragraph_element_get_align(WebKitDOMHTMLParagraphElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_paragraph_element_get_align")]
        internal static extern sbyte* webkit_dom_html_paragraph_element_get_align(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_paragraph_element_set_align(WebKitDOMHTMLParagraphElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_paragraph_element_set_align")]
        internal static extern void webkit_dom_html_paragraph_element_set_align(global::System.IntPtr self, global::System.IntPtr value);
    }
}
