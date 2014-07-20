//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLMarqueeElement { WebKitDOMHTMLElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLMarqueeElement
    {
        // DEBUG: WebKitDOMHTMLElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLMarqueeElementClass { WebKitDOMHTMLElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLMarqueeElementClass
    {
        // DEBUG: WebKitDOMHTMLElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLMarqueeElement: GLib.Object
    {
        public WebKitDOMHTMLMarqueeElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_marquee_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_get_type")]
        internal static extern uint webkit_dom_html_marquee_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_marquee_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API voidwebkit_dom_html_marquee_element_start(WebKitDOMHTMLMarqueeElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_start")]
        internal static extern void webkit_dom_html_marquee_element_start(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_marquee_element_stop(WebKitDOMHTMLMarqueeElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_stop")]
        internal static extern void webkit_dom_html_marquee_element_stop(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_marquee_element_get_behavior(WebKitDOMHTMLMarqueeElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_get_behavior")]
        internal static extern sbyte* webkit_dom_html_marquee_element_get_behavior(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_marquee_element_set_behavior(WebKitDOMHTMLMarqueeElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_set_behavior")]
        internal static extern void webkit_dom_html_marquee_element_set_behavior(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_marquee_element_get_bg_color(WebKitDOMHTMLMarqueeElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_get_bg_color")]
        internal static extern sbyte* webkit_dom_html_marquee_element_get_bg_color(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_marquee_element_set_bg_color(WebKitDOMHTMLMarqueeElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_set_bg_color")]
        internal static extern void webkit_dom_html_marquee_element_set_bg_color(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_marquee_element_get_direction(WebKitDOMHTMLMarqueeElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_get_direction")]
        internal static extern sbyte* webkit_dom_html_marquee_element_get_direction(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_marquee_element_set_direction(WebKitDOMHTMLMarqueeElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_set_direction")]
        internal static extern void webkit_dom_html_marquee_element_set_direction(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_marquee_element_get_height(WebKitDOMHTMLMarqueeElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_get_height")]
        internal static extern sbyte* webkit_dom_html_marquee_element_get_height(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_marquee_element_set_height(WebKitDOMHTMLMarqueeElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_set_height")]
        internal static extern void webkit_dom_html_marquee_element_set_height(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gulongwebkit_dom_html_marquee_element_get_hspace(WebKitDOMHTMLMarqueeElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_get_hspace")]
        internal static extern uint webkit_dom_html_marquee_element_get_hspace(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_marquee_element_set_hspace(WebKitDOMHTMLMarqueeElement* self, gulong value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_set_hspace")]
        internal static extern void webkit_dom_html_marquee_element_set_hspace(global::System.IntPtr self, uint value);

        // DEBUG: WEBKIT_API glongwebkit_dom_html_marquee_element_get_loop(WebKitDOMHTMLMarqueeElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_get_loop")]
        internal static extern int webkit_dom_html_marquee_element_get_loop(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_marquee_element_set_loop(WebKitDOMHTMLMarqueeElement* self, glong value, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_set_loop")]
        internal static extern void webkit_dom_html_marquee_element_set_loop(global::System.IntPtr self, int value, global::System.IntPtr error);

        // DEBUG: WEBKIT_API glongwebkit_dom_html_marquee_element_get_scroll_amount(WebKitDOMHTMLMarqueeElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_get_scroll_amount")]
        internal static extern int webkit_dom_html_marquee_element_get_scroll_amount(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_marquee_element_set_scroll_amount(WebKitDOMHTMLMarqueeElement* self, glong value, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_set_scroll_amount")]
        internal static extern void webkit_dom_html_marquee_element_set_scroll_amount(global::System.IntPtr self, int value, global::System.IntPtr error);

        // DEBUG: WEBKIT_API glongwebkit_dom_html_marquee_element_get_scroll_delay(WebKitDOMHTMLMarqueeElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_get_scroll_delay")]
        internal static extern int webkit_dom_html_marquee_element_get_scroll_delay(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_marquee_element_set_scroll_delay(WebKitDOMHTMLMarqueeElement* self, glong value, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_set_scroll_delay")]
        internal static extern void webkit_dom_html_marquee_element_set_scroll_delay(global::System.IntPtr self, int value, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_marquee_element_get_true_speed(WebKitDOMHTMLMarqueeElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_get_true_speed")]
        internal static extern int webkit_dom_html_marquee_element_get_true_speed(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_marquee_element_set_true_speed(WebKitDOMHTMLMarqueeElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_set_true_speed")]
        internal static extern void webkit_dom_html_marquee_element_set_true_speed(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gulongwebkit_dom_html_marquee_element_get_vspace(WebKitDOMHTMLMarqueeElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_get_vspace")]
        internal static extern uint webkit_dom_html_marquee_element_get_vspace(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_marquee_element_set_vspace(WebKitDOMHTMLMarqueeElement* self, gulong value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_set_vspace")]
        internal static extern void webkit_dom_html_marquee_element_set_vspace(global::System.IntPtr self, uint value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_marquee_element_get_width(WebKitDOMHTMLMarqueeElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_get_width")]
        internal static extern sbyte* webkit_dom_html_marquee_element_get_width(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_marquee_element_set_width(WebKitDOMHTMLMarqueeElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_marquee_element_set_width")]
        internal static extern void webkit_dom_html_marquee_element_set_width(global::System.IntPtr self, global::System.IntPtr value);
    }
}