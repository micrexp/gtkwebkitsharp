//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLFrameElement { WebKitDOMHTMLElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLFrameElement
    {
        // DEBUG: WebKitDOMHTMLElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLFrameElementClass { WebKitDOMHTMLElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLFrameElementClass
    {
        // DEBUG: WebKitDOMHTMLElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLFrameElement: GLib.Object
    {
        public WebKitDOMHTMLFrameElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_frame_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_get_type")]
        internal static extern uint webkit_dom_html_frame_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_frame_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_frame_element_get_frame_border(WebKitDOMHTMLFrameElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_get_frame_border")]
        internal static extern sbyte* webkit_dom_html_frame_element_get_frame_border(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_frame_element_set_frame_border(WebKitDOMHTMLFrameElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_set_frame_border")]
        internal static extern void webkit_dom_html_frame_element_set_frame_border(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_frame_element_get_long_desc(WebKitDOMHTMLFrameElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_get_long_desc")]
        internal static extern sbyte* webkit_dom_html_frame_element_get_long_desc(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_frame_element_set_long_desc(WebKitDOMHTMLFrameElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_set_long_desc")]
        internal static extern void webkit_dom_html_frame_element_set_long_desc(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_frame_element_get_margin_height(WebKitDOMHTMLFrameElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_get_margin_height")]
        internal static extern sbyte* webkit_dom_html_frame_element_get_margin_height(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_frame_element_set_margin_height(WebKitDOMHTMLFrameElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_set_margin_height")]
        internal static extern void webkit_dom_html_frame_element_set_margin_height(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_frame_element_get_margin_width(WebKitDOMHTMLFrameElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_get_margin_width")]
        internal static extern sbyte* webkit_dom_html_frame_element_get_margin_width(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_frame_element_set_margin_width(WebKitDOMHTMLFrameElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_set_margin_width")]
        internal static extern void webkit_dom_html_frame_element_set_margin_width(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_frame_element_get_name(WebKitDOMHTMLFrameElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_get_name")]
        internal static extern sbyte* webkit_dom_html_frame_element_get_name(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_frame_element_set_name(WebKitDOMHTMLFrameElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_set_name")]
        internal static extern void webkit_dom_html_frame_element_set_name(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_frame_element_get_no_resize(WebKitDOMHTMLFrameElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_get_no_resize")]
        internal static extern int webkit_dom_html_frame_element_get_no_resize(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_frame_element_set_no_resize(WebKitDOMHTMLFrameElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_set_no_resize")]
        internal static extern void webkit_dom_html_frame_element_set_no_resize(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_frame_element_get_scrolling(WebKitDOMHTMLFrameElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_get_scrolling")]
        internal static extern sbyte* webkit_dom_html_frame_element_get_scrolling(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_frame_element_set_scrolling(WebKitDOMHTMLFrameElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_set_scrolling")]
        internal static extern void webkit_dom_html_frame_element_set_scrolling(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_frame_element_get_src(WebKitDOMHTMLFrameElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_get_src")]
        internal static extern sbyte* webkit_dom_html_frame_element_get_src(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_frame_element_set_src(WebKitDOMHTMLFrameElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_set_src")]
        internal static extern void webkit_dom_html_frame_element_set_src(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API WebKitDOMDocument*webkit_dom_html_frame_element_get_content_document(WebKitDOMHTMLFrameElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_get_content_document")]
        internal static extern global::System.IntPtr webkit_dom_html_frame_element_get_content_document(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMDOMWindow*webkit_dom_html_frame_element_get_content_window(WebKitDOMHTMLFrameElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_get_content_window")]
        internal static extern global::System.IntPtr webkit_dom_html_frame_element_get_content_window(global::System.IntPtr self);

        // DEBUG: WEBKIT_API glongwebkit_dom_html_frame_element_get_width(WebKitDOMHTMLFrameElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_get_width")]
        internal static extern int webkit_dom_html_frame_element_get_width(global::System.IntPtr self);

        // DEBUG: WEBKIT_API glongwebkit_dom_html_frame_element_get_height(WebKitDOMHTMLFrameElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_frame_element_get_height")]
        internal static extern int webkit_dom_html_frame_element_get_height(global::System.IntPtr self);
    }
}
