//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: enum { WEBKIT_EDITING_BEHAVIOR_MAC, WEBKIT_EDITING_BEHAVIOR_WINDOWS, WEBKIT_EDITING_BEHAVIOR_UNIX}
    /// <summary>
    /// <para>WebKitEditingBehavior: _EDITING_BEHAVIOR_MAC: Editing behavior
    /// mimicking OS X user interfaces. _EDITING_BEHAVIOR_WINDOWS: Editing behavior
    /// mimicking Windows user interfaces. _EDITING_BEHAVIOR_UNIX: Editing behavior
    /// mimicking free desktop user interfaces.</para>
    /// </summary>
    /// <remarks>
    /// <para>/**</para>
    /// <para> * WebKitEditingBehavior:</para>
    /// <para> * @WEBKIT_EDITING_BEHAVIOR_MAC: Editing behavior mimicking OS X
    /// user interfaces.</para>
    /// <para> * @WEBKIT_EDITING_BEHAVIOR_WINDOWS: Editing behavior mimicking
    /// Windows user interfaces.</para>
    /// <para> * @WEBKIT_EDITING_BEHAVIOR_UNIX: Editing behavior mimicking free
    /// desktop user interfaces.</para>
    /// <para> *</para>
    /// <para> * Enum values used for determining the editing behavior of
    /// editable elements.</para>
    /// <para> *</para>
    /// <para> **/</para>
    /// </remarks>
    // DEBUG: enum { WEBKIT_EDITING_BEHAVIOR_MAC, WEBKIT_EDITING_BEHAVIOR_WINDOWS, WEBKIT_EDITING_BEHAVIOR_UNIX}
    public enum WebKitEditingBehavior
    {
        WEBKIT_EDITING_BEHAVIOR_MAC = 0,
        WEBKIT_EDITING_BEHAVIOR_WINDOWS = 1,
        WEBKIT_EDITING_BEHAVIOR_UNIX = 2
    }

    // DEBUG: typedef struct _WebKitWebSettingsPrivate WebKitWebSettingsPrivate
    // DEBUG: typedef enum { WEBKIT_EDITING_BEHAVIOR_MAC, WEBKIT_EDITING_BEHAVIOR_WINDOWS, WEBKIT_EDITING_BEHAVIOR_UNIX} WebKitEditingBehavior
    // DEBUG: struct _WebKitWebSettingsPrivate
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public unsafe struct _WebKitWebSettingsPrivate
    {
    }

    // DEBUG: struct _WebKitWebSettings { GObject parent_instance; /*< private >*/ WebKitWebSettingsPrivate *priv;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitWebSettings
    {
        // DEBUG: GObject parent_instance
        [FieldOffset(0)]
        public _GObject parent_instance;

        // DEBUG: WebKitWebSettingsPrivate *priv
        [FieldOffset(12)]
        public global::System.IntPtr priv;
    }

    // DEBUG: struct _WebKitWebSettingsClass { GObjectClass parent_class; /* Padding for future expansion */ void (*_webkit_reserved1) (void); void (*_webkit_reserved2) (void); void (*_webkit_reserved3) (void); void (*_webkit_reserved4) (void);}
    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public unsafe struct _WebKitWebSettingsClass
    {
        // DEBUG: GObjectClass parent_class
        [FieldOffset(0)]
        public _GObjectClass parent_class;
    }

    public unsafe partial class WebKitWebSettings: GLib.Object
    {
        public WebKitWebSettings(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_web_settings_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_settings_get_type")]
        internal static extern uint webkit_web_settings_get_type();

        public override GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_web_settings_get_type());
            }
        }

        // DEBUG: WEBKIT_API WebKitWebSettings *webkit_web_settings_new (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_settings_new")]
        internal static extern global::System.IntPtr webkit_web_settings_new();

        public WebKitWebSettings() : base(webkit_web_settings_new()) { }

        // DEBUG: WEBKIT_API WebKitWebSettings *webkit_web_settings_copy (WebKitWebSettings *web_settings)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_settings_copy")]
        internal static extern global::System.IntPtr webkit_web_settings_copy(global::System.IntPtr web_settings);

        public WebKitWebSettings Copy()
        {
            return new WebKitWebSettings(webkit_web_settings_copy(this.Handle));
        }

        // DEBUG: WEBKIT_API const gchar *webkit_web_settings_get_user_agent (WebKitWebSettings *web_settings)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet=CharSet.Ansi,
            EntryPoint="webkit_web_settings_get_user_agent")]
        internal static extern string webkit_web_settings_get_user_agent(global::System.IntPtr web_settings);

        public string UserAgent
        {
            get
            {
                return webkit_web_settings_get_user_agent(this.Handle);
            }
        }
    }
}