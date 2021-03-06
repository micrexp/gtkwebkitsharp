//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMXPathResult { WebKitDOMObject parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMXPathResult
    {
        // DEBUG: WebKitDOMObject parent_instance
        [FieldOffset(0)]
        public _WebKitDOMObject parent_instance;
    }

    // DEBUG: struct _WebKitDOMXPathResultClass { WebKitDOMObjectClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMXPathResultClass
    {
        // DEBUG: WebKitDOMObjectClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMObjectClass parent_class;
    }

    public unsafe partial class WebKitDOMXPathResult: GLib.Object
    {
        public WebKitDOMXPathResult(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_xpath_result_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_xpath_result_get_type")]
        internal static extern uint webkit_dom_xpath_result_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_xpath_result_get_type());
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_xpath_result_iterate_next(WebKitDOMXPathResult* self, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_xpath_result_iterate_next")]
        internal static extern global::System.IntPtr webkit_dom_xpath_result_iterate_next(global::System.IntPtr self, global::System.IntPtr error);

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_xpath_result_snapshot_item(WebKitDOMXPathResult* self, gulong index, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_xpath_result_snapshot_item")]
        internal static extern global::System.IntPtr webkit_dom_xpath_result_snapshot_item(global::System.IntPtr self, uint index, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gushortwebkit_dom_xpath_result_get_result_type(WebKitDOMXPathResult* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_xpath_result_get_result_type")]
        internal static extern ushort webkit_dom_xpath_result_get_result_type(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gdoublewebkit_dom_xpath_result_get_number_value(WebKitDOMXPathResult* self, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_xpath_result_get_number_value")]
        internal static extern double webkit_dom_xpath_result_get_number_value(global::System.IntPtr self, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gchar*webkit_dom_xpath_result_get_string_value(WebKitDOMXPathResult* self, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_xpath_result_get_string_value")]
        internal static extern sbyte* webkit_dom_xpath_result_get_string_value(global::System.IntPtr self, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_xpath_result_get_boolean_value(WebKitDOMXPathResult* self, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_xpath_result_get_boolean_value")]
        internal static extern int webkit_dom_xpath_result_get_boolean_value(global::System.IntPtr self, global::System.IntPtr error);

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_xpath_result_get_single_node_value(WebKitDOMXPathResult* self, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_xpath_result_get_single_node_value")]
        internal static extern global::System.IntPtr webkit_dom_xpath_result_get_single_node_value(global::System.IntPtr self, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_xpath_result_get_invalid_iterator_state(WebKitDOMXPathResult* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_xpath_result_get_invalid_iterator_state")]
        internal static extern int webkit_dom_xpath_result_get_invalid_iterator_state(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gulongwebkit_dom_xpath_result_get_snapshot_length(WebKitDOMXPathResult* self, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_xpath_result_get_snapshot_length")]
        internal static extern uint webkit_dom_xpath_result_get_snapshot_length(global::System.IntPtr self, global::System.IntPtr error);
    }
}
