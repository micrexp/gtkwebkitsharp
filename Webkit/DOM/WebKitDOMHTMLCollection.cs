//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLCollection { WebKitDOMObject parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLCollection
    {
        // DEBUG: WebKitDOMObject parent_instance
        [FieldOffset(0)]
        public _WebKitDOMObject parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLCollectionClass { WebKitDOMObjectClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLCollectionClass
    {
        // DEBUG: WebKitDOMObjectClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMObjectClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLCollection: GLib.Object
    {
        public WebKitDOMHTMLCollection(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_collection_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_collection_get_type")]
        internal static extern uint webkit_dom_html_collection_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_collection_get_type());
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_html_collection_item(WebKitDOMHTMLCollection* self, gulong index)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_collection_item")]
        internal static extern global::System.IntPtr webkit_dom_html_collection_item(global::System.IntPtr self, uint index);

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_html_collection_named_item(WebKitDOMHTMLCollection* self, const gchar* name)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_collection_named_item")]
        internal static extern global::System.IntPtr webkit_dom_html_collection_named_item(global::System.IntPtr self, global::System.IntPtr name);

        // DEBUG: WEBKIT_API gulongwebkit_dom_html_collection_get_length(WebKitDOMHTMLCollection* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_collection_get_length")]
        internal static extern uint webkit_dom_html_collection_get_length(global::System.IntPtr self);
    }
}
