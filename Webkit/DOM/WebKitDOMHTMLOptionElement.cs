//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLOptionElement { WebKitDOMHTMLElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLOptionElement
    {
        // DEBUG: WebKitDOMHTMLElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLOptionElementClass { WebKitDOMHTMLElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLOptionElementClass
    {
        // DEBUG: WebKitDOMHTMLElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLOptionElement: GLib.Object
    {
        public WebKitDOMHTMLOptionElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_option_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_get_type")]
        internal static extern uint webkit_dom_html_option_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_option_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMHTMLFormElement*webkit_dom_html_option_element_get_form(WebKitDOMHTMLOptionElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_get_form")]
        internal static extern global::System.IntPtr webkit_dom_html_option_element_get_form(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_option_element_get_default_selected(WebKitDOMHTMLOptionElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_get_default_selected")]
        internal static extern int webkit_dom_html_option_element_get_default_selected(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_option_element_set_default_selected(WebKitDOMHTMLOptionElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_set_default_selected")]
        internal static extern void webkit_dom_html_option_element_set_default_selected(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_option_element_get_text(WebKitDOMHTMLOptionElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_get_text")]
        internal static extern sbyte* webkit_dom_html_option_element_get_text(global::System.IntPtr self);

        // DEBUG: WEBKIT_API glongwebkit_dom_html_option_element_get_index(WebKitDOMHTMLOptionElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_get_index")]
        internal static extern int webkit_dom_html_option_element_get_index(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_option_element_get_disabled(WebKitDOMHTMLOptionElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_get_disabled")]
        internal static extern int webkit_dom_html_option_element_get_disabled(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_option_element_set_disabled(WebKitDOMHTMLOptionElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_set_disabled")]
        internal static extern void webkit_dom_html_option_element_set_disabled(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_option_element_get_label(WebKitDOMHTMLOptionElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_get_label")]
        internal static extern sbyte* webkit_dom_html_option_element_get_label(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_option_element_set_label(WebKitDOMHTMLOptionElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_set_label")]
        internal static extern void webkit_dom_html_option_element_set_label(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_option_element_get_selected(WebKitDOMHTMLOptionElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_get_selected")]
        internal static extern int webkit_dom_html_option_element_get_selected(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_option_element_set_selected(WebKitDOMHTMLOptionElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_set_selected")]
        internal static extern void webkit_dom_html_option_element_set_selected(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_option_element_get_value(WebKitDOMHTMLOptionElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_get_value")]
        internal static extern sbyte* webkit_dom_html_option_element_get_value(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_option_element_set_value(WebKitDOMHTMLOptionElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_option_element_set_value")]
        internal static extern void webkit_dom_html_option_element_set_value(global::System.IntPtr self, global::System.IntPtr value);
    }
}