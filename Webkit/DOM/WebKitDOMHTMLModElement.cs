//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLModElement { WebKitDOMHTMLElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLModElement
    {
        // DEBUG: WebKitDOMHTMLElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLModElementClass { WebKitDOMHTMLElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLModElementClass
    {
        // DEBUG: WebKitDOMHTMLElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLModElement: GLib.Object
    {
        public WebKitDOMHTMLModElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_mod_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_mod_element_get_type")]
        internal static extern uint webkit_dom_html_mod_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_mod_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_mod_element_get_cite(WebKitDOMHTMLModElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_mod_element_get_cite")]
        internal static extern sbyte* webkit_dom_html_mod_element_get_cite(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_mod_element_set_cite(WebKitDOMHTMLModElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_mod_element_set_cite")]
        internal static extern void webkit_dom_html_mod_element_set_cite(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_mod_element_get_date_time(WebKitDOMHTMLModElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_mod_element_get_date_time")]
        internal static extern sbyte* webkit_dom_html_mod_element_get_date_time(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_mod_element_set_date_time(WebKitDOMHTMLModElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_mod_element_set_date_time")]
        internal static extern void webkit_dom_html_mod_element_set_date_time(global::System.IntPtr self, global::System.IntPtr value);
    }
}
