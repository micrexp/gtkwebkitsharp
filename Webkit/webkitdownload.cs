//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: enum { WEBKIT_DOWNLOAD_STATUS_ERROR = -1, WEBKIT_DOWNLOAD_STATUS_CREATED = 0, WEBKIT_DOWNLOAD_STATUS_STARTED, WEBKIT_DOWNLOAD_STATUS_CANCELLED, WEBKIT_DOWNLOAD_STATUS_FINISHED}
    /// <summary>
    /// <para>WebKitDownloadStatus: _DOWNLOAD_STATUS_ERROR: The download failed
    /// because of an error other than user cancellation. _DOWNLOAD_STATUS_CREATED:
    /// The download has not started yet. _DOWNLOAD_STATUS_STARTED: The download
    /// has started, but has not completed yet. _DOWNLOAD_STATUS_CANCELLED: The
    /// user canceled the download. _DOWNLOAD_STATUS_FINISHED: The download
    /// completed successfully.</para>
    /// </summary>
    /// <remarks>
    /// <para>/**</para>
    /// <para> * WebKitDownloadStatus:</para>
    /// <para> * @WEBKIT_DOWNLOAD_STATUS_ERROR: The download failed because of
    /// an error other than user cancellation.</para>
    /// <para> * @WEBKIT_DOWNLOAD_STATUS_CREATED: The download has not started
    /// yet.</para>
    /// <para> * @WEBKIT_DOWNLOAD_STATUS_STARTED: The download has started, but
    /// has not completed yet.</para>
    /// <para> * @WEBKIT_DOWNLOAD_STATUS_CANCELLED: The user canceled the
    /// download.</para>
    /// <para> * @WEBKIT_DOWNLOAD_STATUS_FINISHED: The download completed
    /// successfully.</para>
    /// <para> *</para>
    /// <para> * Enum values used to denote the various states of a
    /// download.</para>
    /// <para> **/</para>
    /// </remarks>
    // DEBUG: enum { WEBKIT_DOWNLOAD_STATUS_ERROR = -1, WEBKIT_DOWNLOAD_STATUS_CREATED = 0, WEBKIT_DOWNLOAD_STATUS_STARTED, WEBKIT_DOWNLOAD_STATUS_CANCELLED, WEBKIT_DOWNLOAD_STATUS_FINISHED}
    public enum WebKitDownloadStatus
    {
        WEBKIT_DOWNLOAD_STATUS_ERROR = -1,
        WEBKIT_DOWNLOAD_STATUS_CREATED = 0,
        WEBKIT_DOWNLOAD_STATUS_STARTED = 1,
        WEBKIT_DOWNLOAD_STATUS_CANCELLED = 2,
        WEBKIT_DOWNLOAD_STATUS_FINISHED = 3
    }

    // DEBUG: enum { WEBKIT_DOWNLOAD_ERROR_CANCELLED_BY_USER, WEBKIT_DOWNLOAD_ERROR_DESTINATION, WEBKIT_DOWNLOAD_ERROR_NETWORK}
    /// <summary>
    /// <para>WebKitDownloadError: _DOWNLOAD_ERROR_CANCELLED_BY_USER: The
    /// download failed due to user cancellation. _DOWNLOAD_ERROR_DESTINATION: The
    /// download failed due to disk write failure. _DOWNLOAD_ERROR_NETWORK: The
    /// download failed due to a network error.</para>
    /// </summary>
    /// <remarks>
    /// <para>/**</para>
    /// <para> * WebKitDownloadError:</para>
    /// <para> * @WEBKIT_DOWNLOAD_ERROR_CANCELLED_BY_USER: The download failed
    /// due to user cancellation.</para>
    /// <para> * @WEBKIT_DOWNLOAD_ERROR_DESTINATION: The download failed due to
    /// disk write failure.</para>
    /// <para> * @WEBKIT_DOWNLOAD_ERROR_NETWORK: The download failed due to a
    /// network error.</para>
    /// <para> *</para>
    /// <para> * Enum values used to denote the various download errors.</para>
    /// <para> **/</para>
    /// </remarks>
    // DEBUG: enum { WEBKIT_DOWNLOAD_ERROR_CANCELLED_BY_USER, WEBKIT_DOWNLOAD_ERROR_DESTINATION, WEBKIT_DOWNLOAD_ERROR_NETWORK}
    public enum WebKitDownloadError
    {
        WEBKIT_DOWNLOAD_ERROR_CANCELLED_BY_USER = 0,
        WEBKIT_DOWNLOAD_ERROR_DESTINATION = 1,
        WEBKIT_DOWNLOAD_ERROR_NETWORK = 2
    }

    // DEBUG: typedef struct _WebKitDownloadPrivate WebKitDownloadPrivate
    // DEBUG: typedef enum { WEBKIT_DOWNLOAD_STATUS_ERROR = -1, WEBKIT_DOWNLOAD_STATUS_CREATED = 0, WEBKIT_DOWNLOAD_STATUS_STARTED, WEBKIT_DOWNLOAD_STATUS_CANCELLED, WEBKIT_DOWNLOAD_STATUS_FINISHED} WebKitDownloadStatus
    // DEBUG: typedef enum { WEBKIT_DOWNLOAD_ERROR_CANCELLED_BY_USER, WEBKIT_DOWNLOAD_ERROR_DESTINATION, WEBKIT_DOWNLOAD_ERROR_NETWORK} WebKitDownloadError
    // DEBUG: struct _WebKitDownloadPrivate
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public unsafe struct _WebKitDownloadPrivate
    {
    }

    // DEBUG: struct _WebKitDownload { GObject parent_instance; WebKitDownloadPrivate *priv;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDownload
    {
        // DEBUG: GObject parent_instance
        [FieldOffset(0)]
        public _GObject parent_instance;

        // DEBUG: WebKitDownloadPrivate *priv
        [FieldOffset(12)]
        public global::System.IntPtr priv;
    }

    // DEBUG: struct _WebKitDownloadClass { GObjectClass parent_class; /* Padding for future expansion */ void (*_webkit_reserved0) (void); void (*_webkit_reserved1) (void); void (*_webkit_reserved2) (void); void (*_webkit_reserved3) (void);}
    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public unsafe struct _WebKitDownloadClass
    {
        // DEBUG: GObjectClass parent_class
        [FieldOffset(0)]
        public _GObjectClass parent_class;
    }

    public unsafe partial class WebKitDownload : GLib.Object
    {
        public WebKitDownload(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_download_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_download_get_type")]
        internal static extern uint webkit_download_get_type();

        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_download_get_type());
            }
        }

        // DEBUG: WEBKIT_API WebKitDownload* webkit_download_new (WebKitNetworkRequest *request)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_download_new")]
        internal static extern global::System.IntPtr webkit_download_new(global::System.IntPtr request);

        public WebKitDownload(WebKitNetworkRequest request)
            :base(webkit_download_new(request.Handle))
        {
        }

        // DEBUG: WEBKIT_API voidwebkit_download_start (WebKitDownload *download)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_download_start")]
        internal static extern void webkit_download_start(global::System.IntPtr download);

        public void Start()
        {
            webkit_download_start(this.Handle);
        }

        // DEBUG: WEBKIT_API voidwebkit_download_cancel (WebKitDownload *download)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_download_cancel")]
        internal static extern void webkit_download_cancel(global::System.IntPtr download);
        public void Cancel()
        {
            webkit_download_cancel(this.Handle);
        }

        // DEBUG: WEBKIT_API const gchar*webkit_download_get_uri (WebKitDownload *download)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = CharSet.Ansi,
            EntryPoint="webkit_download_get_uri")]
        internal static extern string webkit_download_get_uri(global::System.IntPtr download);

        public string Url
        {
            return webkit_download_get_uri(this.Handle);
        }


        // DEBUG: WEBKIT_API WebKitNetworkRequest*webkit_download_get_network_request (WebKitDownload *download)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_download_get_network_request")]
        internal static extern global::System.IntPtr webkit_download_get_network_request(global::System.IntPtr download);
        public WebKitNetworkRequest NetworkRequest{
            get{
                return new WebKitNetworkResponse(webkit_download_get_network_request(this.Handle));
            }
        }



        // DEBUG: WEBKIT_API WebKitNetworkResponse*webkit_download_get_network_response (WebKitDownload *download)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_download_get_network_response")]
        internal static extern global::System.IntPtr webkit_download_get_network_response(global::System.IntPtr download);

        public WebKitNetworkResponse NetworkResponse{
            get{
                return new WebKitNetworkResponse(webkit_download_get_network_response(this.Handle));
            }
        }

        // DEBUG: WEBKIT_API const gchar*webkit_download_get_suggested_filename (WebKitDownload *download)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet=CharSet.Ansi,
            EntryPoint="webkit_download_get_suggested_filename")]
        internal static extern string webkit_download_get_suggested_filename(global::System.IntPtr download);

        public string SuggestedFileName{
            get{
                return webkit_download_get_suggested_filename(this.Handle);
            }
        }

        // DEBUG: WEBKIT_API const gchar*webkit_download_get_destination_uri (WebKitDownload *download)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet=CharSet.Ansi,
            EntryPoint="webkit_download_get_destination_uri")]
        internal static extern string webkit_download_get_destination_uri(global::System.IntPtr download);

        // DEBUG: WEBKIT_API voidwebkit_download_set_destination_uri (WebKitDownload *download, const gchar *destination_uri)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet=CharSet.Ansi,
            EntryPoint="webkit_download_set_destination_uri")]
        internal static extern void webkit_download_set_destination_uri(global::System.IntPtr download, string destination_uri);

        public string DestinationUri{
            get{
                return webkit_download_get_destination_uri(this.Handle);
            }
            set{
                webkit_download_set_destination_uri(this.Handle,value);
            }
        }

        // DEBUG: WEBKIT_API gdoublewebkit_download_get_progress (WebKitDownload *download)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_download_get_progress")]
        internal static extern double webkit_download_get_progress(global::System.IntPtr download);

        public double Progress{
            get{
                return webkit_download_get_progress(this.Handle);
            }
        }

        // DEBUG: WEBKIT_API gdoublewebkit_download_get_elapsed_time (WebKitDownload *download)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_download_get_elapsed_time")]
        internal static extern double webkit_download_get_elapsed_time(global::System.IntPtr download);

        public double ElapsedTime{
            get{
                return webkit_download_get_elapsed_time(this.Handle);
            }
        }

        // DEBUG: WEBKIT_API guint64webkit_download_get_total_size (WebKitDownload *download)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_download_get_total_size")]
        internal static extern ulong webkit_download_get_total_size(global::System.IntPtr download);

        public ulong TotalSize{
            get{
                return webkit_download_get_total_size(this.Handle);
            }
        }

        // DEBUG: WEBKIT_API guint64webkit_download_get_current_size (WebKitDownload *download)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_download_get_current_size")]
        internal static extern ulong webkit_download_get_current_size(global::System.IntPtr download);


        public ulong CurrentSize{
            get{
                return webkit_download_get_current_size(this.Handle);
            }
        }

        // DEBUG: WEBKIT_API WebKitDownloadStatuswebkit_download_get_status (WebKitDownload *download)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_download_get_status")]
        internal static extern WebKitDownloadStatus webkit_download_get_status(global::System.IntPtr download);

        public WebKitDownloadStatus CurrentSize{
            get{
                return webkit_download_get_status(this.Handle);
            }
        }
    }
}
