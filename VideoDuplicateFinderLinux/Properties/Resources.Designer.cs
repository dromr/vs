﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoDuplicateFinderLinux.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VideoDuplicateFinderLinux.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to permanently delete the selected files from disk?.
        /// </summary>
        internal static string ConfirmationDeleteFromDisk {
            get {
                return ResourceManager.GetString("ConfirmationDeleteFromDisk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure to delete selected from list (keep files)?.
        /// </summary>
        internal static string ConfirmationDeleteFromList {
            get {
                return ResourceManager.GetString("ConfirmationDeleteFromList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete file &apos;{0}&apos;, reason: {1}, Stacktrace {2}.
        /// </summary>
        internal static string FailedToDeleteFileReasonStacktrace {
            get {
                return ResourceManager.GetString("FailedToDeleteFileReasonStacktrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FFmpeg / FFprobe is missing but required. Please make sure its installed and PATH enviroment variable is set. You need to restart this application after installation..
        /// </summary>
        internal static string FFmpegFFprobeIsMissing {
            get {
                return ResourceManager.GetString("FFmpegFFprobeIsMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save Duplicates.
        /// </summary>
        internal static string SaveDuplicates {
            get {
                return ResourceManager.GetString("SaveDuplicates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select folder.
        /// </summary>
        internal static string SelectFolder {
            get {
                return ResourceManager.GetString("SelectFolder", resourceCulture);
            }
        }
    }
}
