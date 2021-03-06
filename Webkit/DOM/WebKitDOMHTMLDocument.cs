//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLDocument { WebKitDOMDocument parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLDocument
    {
        // DEBUG: WebKitDOMDocument parent_instance
        [FieldOffset(0)]
        public _WebKitDOMDocument parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLDocumentClass { WebKitDOMDocumentClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLDocumentClass
    {
        // DEBUG: WebKitDOMDocumentClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMDocumentClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLDocument: GLib.Object
    {
        public WebKitDOMHTMLDocument(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_document_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_type")]
        internal static extern uint webkit_dom_html_document_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_document_get_type());
            }
        }

        // DEBUG: WEBKIT_API voidwebkit_dom_html_document_open(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_open")]
        internal static extern void webkit_dom_html_document_open(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_document_close(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_close")]
        internal static extern void webkit_dom_html_document_close(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_document_clear(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_clear")]
        internal static extern void webkit_dom_html_document_clear(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_document_capture_events(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_capture_events")]
        internal static extern void webkit_dom_html_document_capture_events(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_document_release_events(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_release_events")]
        internal static extern void webkit_dom_html_document_release_events(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_document_has_focus(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_has_focus")]
        internal static extern int webkit_dom_html_document_has_focus(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMHTMLCollection*webkit_dom_html_document_get_embeds(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_embeds")]
        internal static extern global::System.IntPtr webkit_dom_html_document_get_embeds(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMHTMLCollection*webkit_dom_html_document_get_plugins(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_plugins")]
        internal static extern global::System.IntPtr webkit_dom_html_document_get_plugins(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMHTMLCollection*webkit_dom_html_document_get_scripts(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_scripts")]
        internal static extern global::System.IntPtr webkit_dom_html_document_get_scripts(global::System.IntPtr self);

        // DEBUG: WEBKIT_API glongwebkit_dom_html_document_get_width(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_width")]
        internal static extern int webkit_dom_html_document_get_width(global::System.IntPtr self);

        // DEBUG: WEBKIT_API glongwebkit_dom_html_document_get_height(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_height")]
        internal static extern int webkit_dom_html_document_get_height(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_document_get_dir(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_dir")]
        internal static extern sbyte* webkit_dom_html_document_get_dir(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_document_set_dir(WebKitDOMHTMLDocument* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_set_dir")]
        internal static extern void webkit_dom_html_document_set_dir(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_document_get_design_mode(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_design_mode")]
        internal static extern sbyte* webkit_dom_html_document_get_design_mode(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_document_set_design_mode(WebKitDOMHTMLDocument* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_set_design_mode")]
        internal static extern void webkit_dom_html_document_set_design_mode(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_document_get_compat_mode(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_compat_mode")]
        internal static extern sbyte* webkit_dom_html_document_get_compat_mode(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMElement*webkit_dom_html_document_get_active_element(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_active_element")]
        internal static extern global::System.IntPtr webkit_dom_html_document_get_active_element(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_document_get_bg_color(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_bg_color")]
        internal static extern sbyte* webkit_dom_html_document_get_bg_color(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_document_set_bg_color(WebKitDOMHTMLDocument* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_set_bg_color")]
        internal static extern void webkit_dom_html_document_set_bg_color(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_document_get_fg_color(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_fg_color")]
        internal static extern sbyte* webkit_dom_html_document_get_fg_color(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_document_set_fg_color(WebKitDOMHTMLDocument* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_set_fg_color")]
        internal static extern void webkit_dom_html_document_set_fg_color(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_document_get_alink_color(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_alink_color")]
        internal static extern sbyte* webkit_dom_html_document_get_alink_color(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_document_set_alink_color(WebKitDOMHTMLDocument* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_set_alink_color")]
        internal static extern void webkit_dom_html_document_set_alink_color(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_document_get_link_color(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_link_color")]
        internal static extern sbyte* webkit_dom_html_document_get_link_color(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_document_set_link_color(WebKitDOMHTMLDocument* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_set_link_color")]
        internal static extern void webkit_dom_html_document_set_link_color(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_document_get_vlink_color(WebKitDOMHTMLDocument* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_get_vlink_color")]
        internal static extern sbyte* webkit_dom_html_document_get_vlink_color(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_document_set_vlink_color(WebKitDOMHTMLDocument* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_document_set_vlink_color")]
        internal static extern void webkit_dom_html_document_set_vlink_color(global::System.IntPtr self, global::System.IntPtr value);
    }
}
