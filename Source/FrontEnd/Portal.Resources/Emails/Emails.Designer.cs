﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portal.Resources.Emails {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Emails {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Emails() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Portal.Resources.Emails.Emails", typeof(Emails).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clickberry.
        /// </summary>
        public static string SenderDisplayName {
            get {
                return ResourceManager.GetString("SenderDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Abuse for video {0}.
        /// </summary>
        public static string SubjectAbuseReport {
            get {
                return ResourceManager.GetString("SubjectAbuseReport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clickberry Website Feedback.
        /// </summary>
        public static string SubjectFeedback {
            get {
                return ResourceManager.GetString("SubjectFeedback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Congrats On Your First Clickberry Tag.
        /// </summary>
        public static string SubjectFirstTag {
            get {
                return ResourceManager.GetString("SubjectFirstTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You requested a new clickberry.tv password.
        /// </summary>
        public static string SubjectPasswordRecovery {
            get {
                return ResourceManager.GetString("SubjectPasswordRecovery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Payment completed.
        /// </summary>
        public static string SubjectPaymentCompleted {
            get {
                return ResourceManager.GetString("SubjectPaymentCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Payment Failed.
        /// </summary>
        public static string SubjectPaymentFailed {
            get {
                return ResourceManager.GetString("SubjectPaymentFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Payment Refunded.
        /// </summary>
        public static string SubjectPaymentRefunded {
            get {
                return ResourceManager.GetString("SubjectPaymentRefunded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome to Clickberry.
        /// </summary>
        public static string SubjectRegistration {
            get {
                return ResourceManager.GetString("SubjectRegistration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New comment for your video.
        /// </summary>
        public static string SubjectVideoComment {
            get {
                return ResourceManager.GetString("SubjectVideoComment", resourceCulture);
            }
        }
    }
}
