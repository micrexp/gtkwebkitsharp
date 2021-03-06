//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLOListElement { WebKitDOMHTMLElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLOListElement
    {
        // DEBUG: WebKitDOMHTMLElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLOListElementClass { WebKitDOMHTMLElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLOListElementClass
    {
        // DEBUG: WebKitDOMHTMLElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLOListElement: GLib.Object
    {
        public WebKitDOMHTMLOListElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_htmlo_list_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_htmlo_list_element_get_type")]
        internal static extern uint webkit_dom_htmlo_list_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_htmlo_list_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_htmlo_list_element_get_compact(WebKitDOMHTMLOListElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_htmlo_list_element_get_compact")]
        internal static extern int webkit_dom_htmlo_list_element_get_compact(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_htmlo_list_element_set_compact(WebKitDOMHTMLOListElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_htmlo_list_element_set_compact")]
        internal static extern void webkit_dom_htmlo_list_element_set_compact(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API glongwebkit_dom_htmlo_list_element_get_start(WebKitDOMHTMLOListElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_htmlo_list_element_get_start")]
        internal static extern int webkit_dom_htmlo_list_element_get_start(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_htmlo_list_element_set_start(WebKitDOMHTMLOListElement* self, glong value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_htmlo_list_element_set_start")]
        internal static extern void webkit_dom_htmlo_list_element_set_start(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_htmlo_list_element_get_reversed(WebKitDOMHTMLOListElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_htmlo_list_element_get_reversed")]
        internal static extern int webkit_dom_htmlo_list_element_get_reversed(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_htmlo_list_element_set_reversed(WebKitDOMHTMLOListElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_htmlo_list_element_set_reversed")]
        internal static extern void webkit_dom_htmlo_list_element_set_reversed(global::System.IntPtr self, int value);
    }
}
