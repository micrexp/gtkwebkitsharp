//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLMediaElement { WebKitDOMHTMLElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLMediaElement
    {
        // DEBUG: WebKitDOMHTMLElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLMediaElementClass { WebKitDOMHTMLElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLMediaElementClass
    {
        // DEBUG: WebKitDOMHTMLElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLMediaElement: GLib.Object
    {
        public WebKitDOMHTMLMediaElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_media_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_type")]
        internal static extern uint webkit_dom_html_media_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_media_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_load(WebKitDOMHTMLMediaElement* self, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_load")]
        internal static extern void webkit_dom_html_media_element_load(global::System.IntPtr self, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_media_element_can_play_type(WebKitDOMHTMLMediaElement* self, const gchar* type)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_can_play_type")]
        internal static extern sbyte* webkit_dom_html_media_element_can_play_type(global::System.IntPtr self, global::System.IntPtr type);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_play(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_play")]
        internal static extern void webkit_dom_html_media_element_play(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_pause(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_pause")]
        internal static extern void webkit_dom_html_media_element_pause(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMMediaError*webkit_dom_html_media_element_get_error(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_error")]
        internal static extern global::System.IntPtr webkit_dom_html_media_element_get_error(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_media_element_get_src(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_src")]
        internal static extern sbyte* webkit_dom_html_media_element_get_src(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_src(WebKitDOMHTMLMediaElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_src")]
        internal static extern void webkit_dom_html_media_element_set_src(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_media_element_get_current_src(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_current_src")]
        internal static extern sbyte* webkit_dom_html_media_element_get_current_src(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gushortwebkit_dom_html_media_element_get_network_state(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_network_state")]
        internal static extern ushort webkit_dom_html_media_element_get_network_state(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_media_element_get_preload(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_preload")]
        internal static extern sbyte* webkit_dom_html_media_element_get_preload(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_preload(WebKitDOMHTMLMediaElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_preload")]
        internal static extern void webkit_dom_html_media_element_set_preload(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API WebKitDOMTimeRanges*webkit_dom_html_media_element_get_buffered(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_buffered")]
        internal static extern global::System.IntPtr webkit_dom_html_media_element_get_buffered(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gushortwebkit_dom_html_media_element_get_ready_state(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_ready_state")]
        internal static extern ushort webkit_dom_html_media_element_get_ready_state(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_media_element_get_seeking(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_seeking")]
        internal static extern int webkit_dom_html_media_element_get_seeking(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gfloatwebkit_dom_html_media_element_get_current_time(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_current_time")]
        internal static extern float webkit_dom_html_media_element_get_current_time(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_current_time(WebKitDOMHTMLMediaElement* self, gfloat value, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_current_time")]
        internal static extern void webkit_dom_html_media_element_set_current_time(global::System.IntPtr self, float value, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gdoublewebkit_dom_html_media_element_get_initial_time(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_initial_time")]
        internal static extern double webkit_dom_html_media_element_get_initial_time(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gfloatwebkit_dom_html_media_element_get_start_time(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_start_time")]
        internal static extern float webkit_dom_html_media_element_get_start_time(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gfloatwebkit_dom_html_media_element_get_duration(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_duration")]
        internal static extern float webkit_dom_html_media_element_get_duration(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_media_element_get_paused(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_paused")]
        internal static extern int webkit_dom_html_media_element_get_paused(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gfloatwebkit_dom_html_media_element_get_default_playback_rate(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_default_playback_rate")]
        internal static extern float webkit_dom_html_media_element_get_default_playback_rate(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_default_playback_rate(WebKitDOMHTMLMediaElement* self, gfloat value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_default_playback_rate")]
        internal static extern void webkit_dom_html_media_element_set_default_playback_rate(global::System.IntPtr self, float value);

        // DEBUG: WEBKIT_API gfloatwebkit_dom_html_media_element_get_playback_rate(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_playback_rate")]
        internal static extern float webkit_dom_html_media_element_get_playback_rate(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_playback_rate(WebKitDOMHTMLMediaElement* self, gfloat value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_playback_rate")]
        internal static extern void webkit_dom_html_media_element_set_playback_rate(global::System.IntPtr self, float value);

        // DEBUG: WEBKIT_API WebKitDOMTimeRanges*webkit_dom_html_media_element_get_played(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_played")]
        internal static extern global::System.IntPtr webkit_dom_html_media_element_get_played(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMTimeRanges*webkit_dom_html_media_element_get_seekable(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_seekable")]
        internal static extern global::System.IntPtr webkit_dom_html_media_element_get_seekable(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_media_element_get_ended(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_ended")]
        internal static extern int webkit_dom_html_media_element_get_ended(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_media_element_get_autoplay(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_autoplay")]
        internal static extern int webkit_dom_html_media_element_get_autoplay(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_autoplay(WebKitDOMHTMLMediaElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_autoplay")]
        internal static extern void webkit_dom_html_media_element_set_autoplay(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_media_element_get_loop(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_loop")]
        internal static extern int webkit_dom_html_media_element_get_loop(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_loop(WebKitDOMHTMLMediaElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_loop")]
        internal static extern void webkit_dom_html_media_element_set_loop(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_media_element_get_controls(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_controls")]
        internal static extern int webkit_dom_html_media_element_get_controls(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_controls(WebKitDOMHTMLMediaElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_controls")]
        internal static extern void webkit_dom_html_media_element_set_controls(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gfloatwebkit_dom_html_media_element_get_volume(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_volume")]
        internal static extern float webkit_dom_html_media_element_get_volume(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_volume(WebKitDOMHTMLMediaElement* self, gfloat value, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_volume")]
        internal static extern void webkit_dom_html_media_element_set_volume(global::System.IntPtr self, float value, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_media_element_get_muted(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_muted")]
        internal static extern int webkit_dom_html_media_element_get_muted(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_muted(WebKitDOMHTMLMediaElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_muted")]
        internal static extern void webkit_dom_html_media_element_set_muted(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_media_element_get_default_muted(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_default_muted")]
        internal static extern int webkit_dom_html_media_element_get_default_muted(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_default_muted(WebKitDOMHTMLMediaElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_default_muted")]
        internal static extern void webkit_dom_html_media_element_set_default_muted(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_media_element_get_webkit_preserves_pitch(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_webkit_preserves_pitch")]
        internal static extern int webkit_dom_html_media_element_get_webkit_preserves_pitch(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_webkit_preserves_pitch(WebKitDOMHTMLMediaElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_webkit_preserves_pitch")]
        internal static extern void webkit_dom_html_media_element_set_webkit_preserves_pitch(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_media_element_get_webkit_has_closed_captions(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_webkit_has_closed_captions")]
        internal static extern int webkit_dom_html_media_element_get_webkit_has_closed_captions(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_media_element_get_webkit_closed_captions_visible(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_webkit_closed_captions_visible")]
        internal static extern int webkit_dom_html_media_element_get_webkit_closed_captions_visible(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_webkit_closed_captions_visible(WebKitDOMHTMLMediaElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_webkit_closed_captions_visible")]
        internal static extern void webkit_dom_html_media_element_set_webkit_closed_captions_visible(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gulongwebkit_dom_html_media_element_get_webkit_audio_decoded_byte_count(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_webkit_audio_decoded_byte_count")]
        internal static extern uint webkit_dom_html_media_element_get_webkit_audio_decoded_byte_count(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gulongwebkit_dom_html_media_element_get_webkit_video_decoded_byte_count(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_webkit_video_decoded_byte_count")]
        internal static extern uint webkit_dom_html_media_element_get_webkit_video_decoded_byte_count(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_media_element_get_media_group(WebKitDOMHTMLMediaElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_get_media_group")]
        internal static extern sbyte* webkit_dom_html_media_element_get_media_group(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_media_element_set_media_group(WebKitDOMHTMLMediaElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_media_element_set_media_group")]
        internal static extern void webkit_dom_html_media_element_set_media_group(global::System.IntPtr self, global::System.IntPtr value);
    }
}
