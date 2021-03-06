//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLStyleElement { WebKitDOMHTMLElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLStyleElement
    {
        // DEBUG: WebKitDOMHTMLElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLStyleElementClass { WebKitDOMHTMLElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLStyleElementClass
    {
        // DEBUG: WebKitDOMHTMLElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLStyleElement: GLib.Object
    {
        public WebKitDOMHTMLStyleElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_style_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_style_element_get_type")]
        internal static extern uint webkit_dom_html_style_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_style_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_style_element_get_disabled(WebKitDOMHTMLStyleElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_style_element_get_disabled")]
        internal static extern int webkit_dom_html_style_element_get_disabled(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_style_element_set_disabled(WebKitDOMHTMLStyleElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_style_element_set_disabled")]
        internal static extern void webkit_dom_html_style_element_set_disabled(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_style_element_get_scoped(WebKitDOMHTMLStyleElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_style_element_get_scoped")]
        internal static extern int webkit_dom_html_style_element_get_scoped(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_style_element_set_scoped(WebKitDOMHTMLStyleElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_style_element_set_scoped")]
        internal static extern void webkit_dom_html_style_element_set_scoped(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_style_element_get_media(WebKitDOMHTMLStyleElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_style_element_get_media")]
        internal static extern sbyte* webkit_dom_html_style_element_get_media(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_style_element_set_media(WebKitDOMHTMLStyleElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_style_element_set_media")]
        internal static extern void webkit_dom_html_style_element_set_media(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API WebKitDOMStyleSheet*webkit_dom_html_style_element_get_sheet(WebKitDOMHTMLStyleElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_style_element_get_sheet")]
        internal static extern global::System.IntPtr webkit_dom_html_style_element_get_sheet(global::System.IntPtr self);
    }
}
