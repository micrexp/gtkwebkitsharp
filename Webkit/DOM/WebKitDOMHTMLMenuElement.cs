//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLMenuElement { WebKitDOMHTMLElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLMenuElement
    {
        // DEBUG: WebKitDOMHTMLElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLMenuElementClass { WebKitDOMHTMLElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLMenuElementClass
    {
        // DEBUG: WebKitDOMHTMLElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLMenuElement: GLib.Object
    {
        public WebKitDOMHTMLMenuElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_menu_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_menu_element_get_type")]
        internal static extern uint webkit_dom_html_menu_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_menu_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_menu_element_get_compact(WebKitDOMHTMLMenuElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_menu_element_get_compact")]
        internal static extern int webkit_dom_html_menu_element_get_compact(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_menu_element_set_compact(WebKitDOMHTMLMenuElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_menu_element_set_compact")]
        internal static extern void webkit_dom_html_menu_element_set_compact(global::System.IntPtr self, int value);
    }
}
