//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMXPathNSResolver { WebKitDOMObject parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMXPathNSResolver
    {
        // DEBUG: WebKitDOMObject parent_instance
        [FieldOffset(0)]
        public _WebKitDOMObject parent_instance;
    }

    // DEBUG: struct _WebKitDOMXPathNSResolverClass { WebKitDOMObjectClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMXPathNSResolverClass
    {
        // DEBUG: WebKitDOMObjectClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMObjectClass parent_class;
    }

    public unsafe partial class WebKitDOMXPathNSResolver: GLib.Object
    {
        public WebKitDOMXPathNSResolver(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_xpath_ns_resolver_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_xpath_ns_resolver_get_type")]
        internal static extern uint webkit_dom_xpath_ns_resolver_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_xpath_ns_resolver_get_type());
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_xpath_ns_resolver_lookup_namespace_uri(WebKitDOMXPathNSResolver* self, const gchar* prefix)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_xpath_ns_resolver_lookup_namespace_uri")]
        internal static extern sbyte* webkit_dom_xpath_ns_resolver_lookup_namespace_uri(global::System.IntPtr self, global::System.IntPtr prefix);
    }
}
