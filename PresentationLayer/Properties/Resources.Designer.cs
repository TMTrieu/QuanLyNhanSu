namespace PresentationLayer.Properties {
    using System;
    using System.Drawing;
    using System.Resources;
    using System.Globalization;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.CodeDom.Compiler;

    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources {
        private static ResourceManager resourceMan;
        private static CultureInfo resourceCulture;

        internal Resources() { }

        internal static ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    resourceMan = new ResourceManager("PresentationLayer.Properties.Resources", typeof(Resources).Assembly);
                }
                return resourceMan;
            }
        }

        internal static CultureInfo Culture {
            get { return resourceCulture; }
            set { resourceCulture = value; }
        }

        internal static Bitmap đóng => (Bitmap)ResourceManager.GetObject("đóng", resourceCulture);
        internal static Bitmap đóng1 => (Bitmap)ResourceManager.GetObject("đóng1", resourceCulture);
        internal static Bitmap hủy => (Bitmap)ResourceManager.GetObject("hủy", resourceCulture);
        internal static Bitmap icons8_add_button_48 => (Bitmap)ResourceManager.GetObject("icons8-add-button-48", resourceCulture);
        internal static Bitmap icons8_payroll_32 => (Bitmap)ResourceManager.GetObject("icons8-payroll-32", resourceCulture);
        internal static Bitmap icons8_printer_50 => (Bitmap)ResourceManager.GetObject("icons8-printer-50", resourceCulture);
        internal static Bitmap imageres_5315 => (Bitmap)ResourceManager.GetObject("imageres_5315", resourceCulture);
        internal static Bitmap sửa => (Bitmap)ResourceManager.GetObject("sửa", resourceCulture);
        internal static Bitmap png_transparent_home_icon => (Bitmap)ResourceManager.GetObject("png-transparent-computer-icons-home-house-home-angle-building-rectangle-thumbnail", resourceCulture);
    }
}
