//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMDOMPluginArray { WebKitDOMObject parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMDOMPluginArray
    {
        // DEBUG: WebKitDOMObject parent_instance
        [FieldOffset(0)]
        public _WebKitDOMObject parent_instance;
    }

    // DEBUG: struct _WebKitDOMDOMPluginArrayClass { WebKitDOMObjectClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMDOMPluginArrayClass
    {
        // DEBUG: WebKitDOMObjectClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMObjectClass parent_class;
    }

    public unsafe partial class WebKitDOMDOMPluginArray: GLib.Object
    {
        public WebKitDOMDOMPluginArray(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_dom_plugin_array_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_dom_plugin_array_get_type")]
        internal static extern uint webkit_dom_dom_plugin_array_get_type();

        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_dom_plugin_array_get_type());
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMDOMPlugin*webkit_dom_dom_plugin_array_item(WebKitDOMDOMPluginArray* self, gulong index)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_dom_plugin_array_item")]
        internal static extern global::System.IntPtr webkit_dom_dom_plugin_array_item(global::System.IntPtr self, uint index);

        // DEBUG: WEBKIT_API WebKitDOMDOMPlugin*webkit_dom_dom_plugin_array_named_item(WebKitDOMDOMPluginArray* self, const gchar* name)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_dom_plugin_array_named_item")]
        internal static extern global::System.IntPtr webkit_dom_dom_plugin_array_named_item(global::System.IntPtr self, global::System.IntPtr name);

        // DEBUG: WEBKIT_API voidwebkit_dom_dom_plugin_array_refresh(WebKitDOMDOMPluginArray* self, gboolean reload)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_dom_plugin_array_refresh")]
        internal static extern void webkit_dom_dom_plugin_array_refresh(global::System.IntPtr self, int reload);

        // DEBUG: WEBKIT_API gulongwebkit_dom_dom_plugin_array_get_length(WebKitDOMDOMPluginArray* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_dom_plugin_array_get_length")]
        internal static extern uint webkit_dom_dom_plugin_array_get_length(global::System.IntPtr self);
    }
}
