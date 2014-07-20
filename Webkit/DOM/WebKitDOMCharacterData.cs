//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMCharacterData { WebKitDOMNode parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMCharacterData
    {
        // DEBUG: WebKitDOMNode parent_instance
        [FieldOffset(0)]
        public _WebKitDOMNode parent_instance;
    }

    // DEBUG: struct _WebKitDOMCharacterDataClass { WebKitDOMNodeClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMCharacterDataClass
    {
        // DEBUG: WebKitDOMNodeClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMNodeClass parent_class;
    }

    public unsafe partial class WebKitDOMCharacterData : GLib.Object
    {
        public WebKitDOMCharacterData(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_character_data_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_character_data_get_type")]
        internal static extern uint webkit_dom_character_data_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_character_data_get_type());
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_character_data_substring_data(WebKitDOMCharacterData* self, gulong offset, gulong length, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_character_data_substring_data")]
        internal static extern string webkit_dom_character_data_substring_data(global::System.IntPtr self, uint offset, uint length, ref global::System.IntPtr error);

        public string SubStringData(uint offset, uint length)
        {
            IntPtr error;
            string data = webkit_dom_character_data_substring_data(this.Handle, offset, length, ref error);
            if (error != IntPtr.Zero)
                throw new GLib.GException(error);
            return data;
                 
        }
        // DEBUG: WEBKIT_API voidwebkit_dom_character_data_append_data(WebKitDOMCharacterData* self, const gchar* data, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_character_data_append_data")]
        internal static extern void webkit_dom_character_data_append_data(global::System.IntPtr self, global::System.IntPtr data, global::System.IntPtr error);

        // DEBUG: WEBKIT_API voidwebkit_dom_character_data_insert_data(WebKitDOMCharacterData* self, gulong offset, const gchar* data, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_character_data_insert_data")]
        internal static extern void webkit_dom_character_data_insert_data(global::System.IntPtr self, uint offset, global::System.IntPtr data, global::System.IntPtr error);

        // DEBUG: WEBKIT_API voidwebkit_dom_character_data_delete_data(WebKitDOMCharacterData* self, gulong offset, gulong length, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_character_data_delete_data")]
        internal static extern void webkit_dom_character_data_delete_data(global::System.IntPtr self, uint offset, uint length, global::System.IntPtr error);

        // DEBUG: WEBKIT_API voidwebkit_dom_character_data_replace_data(WebKitDOMCharacterData* self, gulong offset, gulong length, const gchar* data, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_character_data_replace_data")]
        internal static extern void webkit_dom_character_data_replace_data(global::System.IntPtr self, uint offset, uint length, global::System.IntPtr data, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gchar*webkit_dom_character_data_get_data(WebKitDOMCharacterData* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_character_data_get_data")]
        internal static extern sbyte* webkit_dom_character_data_get_data(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_character_data_set_data(WebKitDOMCharacterData* self, const gchar* value, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_character_data_set_data")]
        internal static extern void webkit_dom_character_data_set_data(global::System.IntPtr self, global::System.IntPtr value, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gulongwebkit_dom_character_data_get_length(WebKitDOMCharacterData* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_character_data_get_length")]
        internal static extern uint webkit_dom_character_data_get_length(global::System.IntPtr self);
    }
}