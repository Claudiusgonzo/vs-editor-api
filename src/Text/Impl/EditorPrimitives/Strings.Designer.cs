﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.Text.EditorPrimitives.Implementation {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.VisualStudio.Text.Implementation.Text.Impl.EditorPrimitives.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to The other TextPoint is from a different TextBuffer than this TextPoint..
        /// </summary>
        internal static string OtherPointFromWrongBuffer {
            get {
                return ResourceManager.GetString("OtherPointFromWrongBuffer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The other TextRange is from a different TextBuffer than this TextRange..
        /// </summary>
        internal static string OtherRangeFromWrongBuffer {
            get {
                return ResourceManager.GetString("OtherRangeFromWrongBuffer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The start point&apos;s TextBuffer is different than this TextRange&apos;s TextBuffer..
        /// </summary>
        internal static string StartPointFromWrongBuffer {
            get {
                return ResourceManager.GetString("StartPointFromWrongBuffer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The TextPoint is from a TextBuffer that is not this one..
        /// </summary>
        internal static string TextPointFromWrongBuffer {
            get {
                return ResourceManager.GetString("TextPointFromWrongBuffer", resourceCulture);
            }
        }
    }
}
