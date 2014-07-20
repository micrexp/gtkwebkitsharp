//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMMediaQueryList { WebKitDOMObject parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMMediaQueryList
    {
        // DEBUG: WebKitDOMObject parent_instance
        [FieldOffset(0)]
        public _WebKitDOMObject parent_instance;
    }

    // DEBUG: struct _WebKitDOMMediaQueryListClass { WebKitDOMObjectClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMMediaQueryListClass
    {
        // DEBUG: WebKitDOMObjectClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMObjectClass parent_class;
    }

    public unsafe partial class WebKitDOMMediaQueryList: GLib.Object
    {
        public WebKitDOMMediaQueryList(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_media_query_list_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_media_query_list_get_type")]
        internal static extern uint webkit_dom_media_query_list_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_media_query_list_get_type());
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_media_query_list_get_media(WebKitDOMMediaQueryList* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_media_query_list_get_media")]
        internal static extern sbyte* webkit_dom_media_query_list_get_media(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_media_query_list_get_matches(WebKitDOMMediaQueryList* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_media_query_list_get_matches")]
        internal static extern int webkit_dom_media_query_list_get_matches(global::System.IntPtr self);
    }
}
