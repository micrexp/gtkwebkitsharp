//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMWebKitAnimation { WebKitDOMObject parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMWebKitAnimation
    {
        // DEBUG: WebKitDOMObject parent_instance
        [FieldOffset(0)]
        public _WebKitDOMObject parent_instance;
    }

    // DEBUG: struct _WebKitDOMWebKitAnimationClass { WebKitDOMObjectClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMWebKitAnimationClass
    {
        // DEBUG: WebKitDOMObjectClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMObjectClass parent_class;
    }

    public unsafe partial class WebKitDOMWebKitAnimation: GLib.Object
    {
        public WebKitDOMWebKitAnimation(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_webkit_animation_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_webkit_animation_get_type")]
        internal static extern uint webkit_dom_webkit_animation_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_webkit_animation_get_type());
            }
        }

        // DEBUG: WEBKIT_API voidwebkit_dom_webkit_animation_play(WebKitDOMWebKitAnimation* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_webkit_animation_play")]
        internal static extern void webkit_dom_webkit_animation_play(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_webkit_animation_pause(WebKitDOMWebKitAnimation* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_webkit_animation_pause")]
        internal static extern void webkit_dom_webkit_animation_pause(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_webkit_animation_get_name(WebKitDOMWebKitAnimation* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_webkit_animation_get_name")]
        internal static extern sbyte* webkit_dom_webkit_animation_get_name(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gdoublewebkit_dom_webkit_animation_get_duration(WebKitDOMWebKitAnimation* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_webkit_animation_get_duration")]
        internal static extern double webkit_dom_webkit_animation_get_duration(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gdoublewebkit_dom_webkit_animation_get_elapsed_time(WebKitDOMWebKitAnimation* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_webkit_animation_get_elapsed_time")]
        internal static extern double webkit_dom_webkit_animation_get_elapsed_time(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_webkit_animation_set_elapsed_time(WebKitDOMWebKitAnimation* self, gdouble value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_webkit_animation_set_elapsed_time")]
        internal static extern void webkit_dom_webkit_animation_set_elapsed_time(global::System.IntPtr self, double value);

        // DEBUG: WEBKIT_API gdoublewebkit_dom_webkit_animation_get_delay(WebKitDOMWebKitAnimation* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_webkit_animation_get_delay")]
        internal static extern double webkit_dom_webkit_animation_get_delay(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_webkit_animation_get_paused(WebKitDOMWebKitAnimation* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_webkit_animation_get_paused")]
        internal static extern int webkit_dom_webkit_animation_get_paused(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_webkit_animation_get_ended(WebKitDOMWebKitAnimation* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_webkit_animation_get_ended")]
        internal static extern int webkit_dom_webkit_animation_get_ended(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gushortwebkit_dom_webkit_animation_get_direction(WebKitDOMWebKitAnimation* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_webkit_animation_get_direction")]
        internal static extern ushort webkit_dom_webkit_animation_get_direction(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gushortwebkit_dom_webkit_animation_get_fill_mode(WebKitDOMWebKitAnimation* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_webkit_animation_get_fill_mode")]
        internal static extern ushort webkit_dom_webkit_animation_get_fill_mode(global::System.IntPtr self);
    }
}
