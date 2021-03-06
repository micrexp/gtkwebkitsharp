//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLVideoElement { WebKitDOMHTMLMediaElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLVideoElement
    {
        // DEBUG: WebKitDOMHTMLMediaElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLMediaElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLVideoElementClass { WebKitDOMHTMLMediaElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLVideoElementClass
    {
        // DEBUG: WebKitDOMHTMLMediaElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLMediaElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLVideoElement: GLib.Object
    {
        public WebKitDOMHTMLVideoElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_video_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_get_type")]
        internal static extern uint webkit_dom_html_video_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_video_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API voidwebkit_dom_html_video_element_webkit_enter_fullscreen(WebKitDOMHTMLVideoElement* self, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_webkit_enter_fullscreen")]
        internal static extern void webkit_dom_html_video_element_webkit_enter_fullscreen(global::System.IntPtr self, global::System.IntPtr error);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_video_element_webkit_exit_fullscreen(WebKitDOMHTMLVideoElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_webkit_exit_fullscreen")]
        internal static extern void webkit_dom_html_video_element_webkit_exit_fullscreen(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_video_element_webkit_enter_full_screen(WebKitDOMHTMLVideoElement* self, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_webkit_enter_full_screen")]
        internal static extern void webkit_dom_html_video_element_webkit_enter_full_screen(global::System.IntPtr self, global::System.IntPtr error);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_video_element_webkit_exit_full_screen(WebKitDOMHTMLVideoElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_webkit_exit_full_screen")]
        internal static extern void webkit_dom_html_video_element_webkit_exit_full_screen(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gulongwebkit_dom_html_video_element_get_width(WebKitDOMHTMLVideoElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_get_width")]
        internal static extern uint webkit_dom_html_video_element_get_width(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_video_element_set_width(WebKitDOMHTMLVideoElement* self, gulong value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_set_width")]
        internal static extern void webkit_dom_html_video_element_set_width(global::System.IntPtr self, uint value);

        // DEBUG: WEBKIT_API gulongwebkit_dom_html_video_element_get_height(WebKitDOMHTMLVideoElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_get_height")]
        internal static extern uint webkit_dom_html_video_element_get_height(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_video_element_set_height(WebKitDOMHTMLVideoElement* self, gulong value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_set_height")]
        internal static extern void webkit_dom_html_video_element_set_height(global::System.IntPtr self, uint value);

        // DEBUG: WEBKIT_API gulongwebkit_dom_html_video_element_get_video_width(WebKitDOMHTMLVideoElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_get_video_width")]
        internal static extern uint webkit_dom_html_video_element_get_video_width(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gulongwebkit_dom_html_video_element_get_video_height(WebKitDOMHTMLVideoElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_get_video_height")]
        internal static extern uint webkit_dom_html_video_element_get_video_height(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_video_element_get_poster(WebKitDOMHTMLVideoElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_get_poster")]
        internal static extern sbyte* webkit_dom_html_video_element_get_poster(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_video_element_set_poster(WebKitDOMHTMLVideoElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_set_poster")]
        internal static extern void webkit_dom_html_video_element_set_poster(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_video_element_get_webkit_supports_fullscreen(WebKitDOMHTMLVideoElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_get_webkit_supports_fullscreen")]
        internal static extern int webkit_dom_html_video_element_get_webkit_supports_fullscreen(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_video_element_get_webkit_displaying_fullscreen(WebKitDOMHTMLVideoElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_get_webkit_displaying_fullscreen")]
        internal static extern int webkit_dom_html_video_element_get_webkit_displaying_fullscreen(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gulongwebkit_dom_html_video_element_get_webkit_decoded_frame_count(WebKitDOMHTMLVideoElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_get_webkit_decoded_frame_count")]
        internal static extern uint webkit_dom_html_video_element_get_webkit_decoded_frame_count(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gulongwebkit_dom_html_video_element_get_webkit_dropped_frame_count(WebKitDOMHTMLVideoElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_video_element_get_webkit_dropped_frame_count")]
        internal static extern uint webkit_dom_html_video_element_get_webkit_dropped_frame_count(global::System.IntPtr self);
    }
}
