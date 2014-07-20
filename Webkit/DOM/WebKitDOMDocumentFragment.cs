//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMDocumentFragment { WebKitDOMNode parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMDocumentFragment
    {
        // DEBUG: WebKitDOMNode parent_instance
        [FieldOffset(0)]
        public _WebKitDOMNode parent_instance;
    }

    // DEBUG: struct _WebKitDOMDocumentFragmentClass { WebKitDOMNodeClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMDocumentFragmentClass
    {
        // DEBUG: WebKitDOMNodeClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMNodeClass parent_class;
    }

    public unsafe partial class WebKitDOMDocumentFragment: GLib.Object
    {
        public WebKitDOMDocumentFragment(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_document_fragment_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_document_fragment_get_type")]
        internal static extern uint webkit_dom_document_fragment_get_type();

        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_document_fragment_get_type());
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMElement*webkit_dom_document_fragment_query_selector(WebKitDOMDocumentFragment* self, const gchar* selectors, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_document_fragment_query_selector")]
        internal static extern global::System.IntPtr webkit_dom_document_fragment_query_selector(global::System.IntPtr self, global::System.IntPtr selectors, global::System.IntPtr error);

        // DEBUG: WEBKIT_API WebKitDOMNodeList*webkit_dom_document_fragment_query_selector_all(WebKitDOMDocumentFragment* self, const gchar* selectors, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_document_fragment_query_selector_all")]
        internal static extern global::System.IntPtr webkit_dom_document_fragment_query_selector_all(global::System.IntPtr self, global::System.IntPtr selectors, global::System.IntPtr error);
    }
}
