//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: typedef struct _WebKitWebWindowFeaturesPrivate WebKitWebWindowFeaturesPrivate
    // DEBUG: struct _WebKitWebWindowFeaturesPrivate
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public unsafe struct _WebKitWebWindowFeaturesPrivate
    {
    }

    // DEBUG: struct _WebKitWebWindowFeatures { GObject parent_instance; /*< private >*/ WebKitWebWindowFeaturesPrivate* priv;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitWebWindowFeatures
    {
        // DEBUG: GObject parent_instance
        [FieldOffset(0)]
        public _GObject parent_instance;

        // DEBUG: WebKitWebWindowFeaturesPrivate* priv
        [FieldOffset(12)]
        public global::System.IntPtr priv;
    }

    // DEBUG: struct _WebKitWebWindowFeaturesClass { GObjectClass parent_class; /*< private >*/ /* Padding for future expansion */ void (*_webkit_reserved1) (void); void (*_webkit_reserved2) (void); void (*_webkit_reserved3) (void); void (*_webkit_reserved4) (void);}
    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public unsafe struct _WebKitWebWindowFeaturesClass
    {
        // DEBUG: GObjectClass parent_class
        [FieldOffset(0)]
        public _GObjectClass parent_class;
    }

    public unsafe class WebKitWebWindowFeatures : GLib.Object
    {
        public WebKitWebWindowFeatures(IntPtr handle):base(handle){}
        public WebKitWebWindowFeatures():base(webkit_web_window_features_new()){};

        
        // DEBUG: WEBKIT_API GTypewebkit_web_window_features_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_window_features_get_type")]
        internal static extern uint webkit_web_window_features_get_type();

         public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_web_window_features_get_type());
            }
        }

        // DEBUG: WEBKIT_API WebKitWebWindowFeatures*webkit_web_window_features_new (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_window_features_new")]
        internal static extern global::System.IntPtr webkit_web_window_features_new();

        
        // DEBUG: WEBKIT_API gbooleanwebkit_web_window_features_equal (WebKitWebWindowFeatures* features1, WebKitWebWindowFeatures* features2)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_window_features_equal")]
        internal static extern bool webkit_web_window_features_equal(global::System.IntPtr features1, global::System.IntPtr features2);

        public static bool operator ==(WebKitWebWindowFeatures a, WebKitWebWindowFeatures b)
        {   
            return a.Equals(b);
        }

        public static bool operator !=(WebKitWebWindowFeatures a, WebKitWebWindowFeatures b)
        {
            return !a.Equals(b);
        }

        public override bool Equals(object obj)
        {
            if (obj is WebKitWebWindowFeatures)
                return false;

            return webkit_web_window_features_equal(this.Handle, ((WebKitWebWindowFeatures)obj).Handle);
        }

        public override int GetHashCode()
        {   
            return this.Handle.GetHashCode();
        }

        

       
    }
}
