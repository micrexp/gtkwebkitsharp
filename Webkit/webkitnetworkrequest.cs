//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: typedef struct _WebKitNetworkRequestPrivate WebKitNetworkRequestPrivate
    // DEBUG: struct _WebKitNetworkRequestPrivate
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public unsafe struct _WebKitNetworkRequestPrivate
    {
    }

    // DEBUG: struct _WebKitNetworkRequest { GObject parent_instance; /*< private >*/ WebKitNetworkRequestPrivate *priv;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitNetworkRequest
    {
        // DEBUG: GObject parent_instance
        [FieldOffset(0)]
        public _GObject parent_instance;

        // DEBUG: WebKitNetworkRequestPrivate *priv
        [FieldOffset(12)]
        public global::System.IntPtr priv;
    }

    // DEBUG: struct _WebKitNetworkRequestClass { GObjectClass parent_class; /* Padding for future expansion */ void (*_webkit_reserved0) (void); void (*_webkit_reserved1) (void); void (*_webkit_reserved2) (void); void (*_webkit_reserved3) (void);}
    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public unsafe struct _WebKitNetworkRequestClass
    {
        // DEBUG: GObjectClass parent_class
        [FieldOffset(0)]
        public _GObjectClass parent_class;
    }

    public unsafe partial class WebKitNetworkRequest: GLib.Object
    {
        public WebKitNetworkRequest(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_network_request_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_network_request_get_type")]
        internal static extern uint webkit_network_request_get_type();

        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_network_request_get_type());
            }
        }

        // DEBUG: WEBKIT_API WebKitNetworkRequest *webkit_network_request_new (const gchar *uri)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet=CharSet.Ansi,
            EntryPoint="webkit_network_request_new")]
        internal static extern global::System.IntPtr webkit_network_request_new(string uri);

        public WebKitNetworkRequest(string uri) : base(webkit_network_request_new(uri)) { }

        // DEBUG: WEBKIT_API voidwebkit_network_request_set_uri (WebKitNetworkRequest *request, const gchar* uri)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = CharSet.Ansi,
            EntryPoint="webkit_network_request_set_uri")]
        internal static extern void webkit_network_request_set_uri(global::System.IntPtr request, string uri);

        // DEBUG: WEBKIT_API const gchar *webkit_network_request_get_uri (WebKitNetworkRequest *request)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = CharSet.Ansi,
            EntryPoint="webkit_network_request_get_uri")]
        internal static extern string webkit_network_request_get_uri(global::System.IntPtr request);

        public string Uri
        {
            get
            {
                return webkit_network_request_get_uri(this.Handle);
            }
            set
            {
                webkit_network_request_set_uri(this.Handle, value);
            }
        }

        // DEBUG: WEBKIT_API SoupMessage *webkit_network_request_get_message(WebKitNetworkRequest* request)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_network_request_get_message")]
        internal static extern global::System.IntPtr webkit_network_request_get_message(global::System.IntPtr request);

        public SoupMessage Message
        {
            get
            {
                return new SoupMessage(webkit_network_request_get_message(this.Handle));
            }
        }
    }
}
