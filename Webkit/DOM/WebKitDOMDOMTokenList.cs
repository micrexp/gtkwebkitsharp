//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMDOMTokenList { WebKitDOMObject parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMDOMTokenList
    {
        // DEBUG: WebKitDOMObject parent_instance
        [FieldOffset(0)]
        public _WebKitDOMObject parent_instance;
    }

    // DEBUG: struct _WebKitDOMDOMTokenListClass { WebKitDOMObjectClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMDOMTokenListClass
    {
        // DEBUG: WebKitDOMObjectClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMObjectClass parent_class;
    }

    public unsafe partial class WebKitDOMDOMTokenList: GLib.Object
    {
        public WebKitDOMDOMTokenList(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_dom_token_list_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_dom_token_list_get_type")]
        internal static extern uint webkit_dom_dom_token_list_get_type();

        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_dom_token_list_get_type());
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_dom_token_list_item(WebKitDOMDOMTokenList* self, gulong index)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_dom_token_list_item")]
        internal static extern sbyte* webkit_dom_dom_token_list_item(global::System.IntPtr self, uint index);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_dom_token_list_contains(WebKitDOMDOMTokenList* self, const gchar* token, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_dom_token_list_contains")]
        internal static extern int webkit_dom_dom_token_list_contains(global::System.IntPtr self, global::System.IntPtr token, global::System.IntPtr error);

        // DEBUG: WEBKIT_API voidwebkit_dom_dom_token_list_add(WebKitDOMDOMTokenList* self, const gchar* token, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_dom_token_list_add")]
        internal static extern void webkit_dom_dom_token_list_add(global::System.IntPtr self, global::System.IntPtr token, global::System.IntPtr error);

        // DEBUG: WEBKIT_API voidwebkit_dom_dom_token_list_remove(WebKitDOMDOMTokenList* self, const gchar* token, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_dom_token_list_remove")]
        internal static extern void webkit_dom_dom_token_list_remove(global::System.IntPtr self, global::System.IntPtr token, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_dom_token_list_toggle(WebKitDOMDOMTokenList* self, const gchar* token, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_dom_token_list_toggle")]
        internal static extern int webkit_dom_dom_token_list_toggle(global::System.IntPtr self, global::System.IntPtr token, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gulongwebkit_dom_dom_token_list_get_length(WebKitDOMDOMTokenList* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_dom_token_list_get_length")]
        internal static extern uint webkit_dom_dom_token_list_get_length(global::System.IntPtr self);
    }
}
