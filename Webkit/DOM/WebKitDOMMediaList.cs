//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMMediaList { WebKitDOMObject parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMMediaList
    {
        // DEBUG: WebKitDOMObject parent_instance
        [FieldOffset(0)]
        public _WebKitDOMObject parent_instance;
    }

    // DEBUG: struct _WebKitDOMMediaListClass { WebKitDOMObjectClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMMediaListClass
    {
        // DEBUG: WebKitDOMObjectClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMObjectClass parent_class;
    }

    public unsafe partial class WebKitDOMMediaList: GLib.Object
    {
        public WebKitDOMMediaList(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_media_list_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_media_list_get_type")]
        internal static extern uint webkit_dom_media_list_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_media_list_get_type());
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_media_list_item(WebKitDOMMediaList* self, gulong index)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_media_list_item")]
        internal static extern sbyte* webkit_dom_media_list_item(global::System.IntPtr self, uint index);

        // DEBUG: WEBKIT_API voidwebkit_dom_media_list_delete_medium(WebKitDOMMediaList* self, const gchar* old_medium, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_media_list_delete_medium")]
        internal static extern void webkit_dom_media_list_delete_medium(global::System.IntPtr self, global::System.IntPtr old_medium, global::System.IntPtr error);

        // DEBUG: WEBKIT_API voidwebkit_dom_media_list_append_medium(WebKitDOMMediaList* self, const gchar* new_medium, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_media_list_append_medium")]
        internal static extern void webkit_dom_media_list_append_medium(global::System.IntPtr self, global::System.IntPtr new_medium, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gchar*webkit_dom_media_list_get_media_text(WebKitDOMMediaList* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_media_list_get_media_text")]
        internal static extern sbyte* webkit_dom_media_list_get_media_text(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_media_list_set_media_text(WebKitDOMMediaList* self, const gchar* value, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_media_list_set_media_text")]
        internal static extern void webkit_dom_media_list_set_media_text(global::System.IntPtr self, global::System.IntPtr value, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gulongwebkit_dom_media_list_get_length(WebKitDOMMediaList* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_media_list_get_length")]
        internal static extern uint webkit_dom_media_list_get_length(global::System.IntPtr self);
    }
}
