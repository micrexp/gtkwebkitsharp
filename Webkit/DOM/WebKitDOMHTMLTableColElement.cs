//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLTableColElement { WebKitDOMHTMLElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLTableColElement
    {
        // DEBUG: WebKitDOMHTMLElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLTableColElementClass { WebKitDOMHTMLElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLTableColElementClass
    {
        // DEBUG: WebKitDOMHTMLElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLTableColElement: GLib.Object
    {
        public WebKitDOMHTMLTableColElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_table_col_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_table_col_element_get_type")]
        internal static extern uint webkit_dom_html_table_col_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_table_col_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_table_col_element_get_align(WebKitDOMHTMLTableColElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_table_col_element_get_align")]
        internal static extern sbyte* webkit_dom_html_table_col_element_get_align(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_table_col_element_set_align(WebKitDOMHTMLTableColElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_table_col_element_set_align")]
        internal static extern void webkit_dom_html_table_col_element_set_align(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_table_col_element_get_ch(WebKitDOMHTMLTableColElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_table_col_element_get_ch")]
        internal static extern sbyte* webkit_dom_html_table_col_element_get_ch(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_table_col_element_set_ch(WebKitDOMHTMLTableColElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_table_col_element_set_ch")]
        internal static extern void webkit_dom_html_table_col_element_set_ch(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_table_col_element_get_ch_off(WebKitDOMHTMLTableColElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_table_col_element_get_ch_off")]
        internal static extern sbyte* webkit_dom_html_table_col_element_get_ch_off(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_table_col_element_set_ch_off(WebKitDOMHTMLTableColElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_table_col_element_set_ch_off")]
        internal static extern void webkit_dom_html_table_col_element_set_ch_off(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API glongwebkit_dom_html_table_col_element_get_span(WebKitDOMHTMLTableColElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_table_col_element_get_span")]
        internal static extern int webkit_dom_html_table_col_element_get_span(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_table_col_element_set_span(WebKitDOMHTMLTableColElement* self, glong value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_table_col_element_set_span")]
        internal static extern void webkit_dom_html_table_col_element_set_span(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_table_col_element_get_v_align(WebKitDOMHTMLTableColElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_table_col_element_get_v_align")]
        internal static extern sbyte* webkit_dom_html_table_col_element_get_v_align(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_table_col_element_set_v_align(WebKitDOMHTMLTableColElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_table_col_element_set_v_align")]
        internal static extern void webkit_dom_html_table_col_element_set_v_align(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_table_col_element_get_width(WebKitDOMHTMLTableColElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_table_col_element_get_width")]
        internal static extern sbyte* webkit_dom_html_table_col_element_get_width(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_table_col_element_set_width(WebKitDOMHTMLTableColElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_table_col_element_set_width")]
        internal static extern void webkit_dom_html_table_col_element_set_width(global::System.IntPtr self, global::System.IntPtr value);
    }
}
