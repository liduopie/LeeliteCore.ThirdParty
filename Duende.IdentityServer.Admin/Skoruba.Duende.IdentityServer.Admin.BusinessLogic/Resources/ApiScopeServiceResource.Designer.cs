﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skoruba.Duende.IdentityServer.Admin.BusinessLogic.Resources {
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
    public class ApiScopeServiceResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ApiScopeServiceResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Skoruba.Duende.IdentityServer.Admin.BusinessLogic.Resources.ApiScopeServiceResour" +
                            "ce", typeof(ApiScopeServiceResource).Assembly);
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
        ///   Looks up a localized string similar to Api Scope with id {0} doesn&apos;t exist.
        /// </summary>
        public static string ApiScopeDoesNotExist {
            get {
                return ResourceManager.GetString("ApiScopeDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Api Scope already exists.
        /// </summary>
        public static string ApiScopeExistsKey {
            get {
                return ResourceManager.GetString("ApiScopeExistsKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Api Scope ({0}) already exists.
        /// </summary>
        public static string ApiScopeExistsValue {
            get {
                return ResourceManager.GetString("ApiScopeExistsValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Api Scope Property with id {0} doesn&apos;t exist.
        /// </summary>
        public static string ApiScopePropertyDoesNotExist {
            get {
                return ResourceManager.GetString("ApiScopePropertyDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Api Scope Property already exists.
        /// </summary>
        public static string ApiScopePropertyExistsKey {
            get {
                return ResourceManager.GetString("ApiScopePropertyExistsKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Api Scope Property ({0}) already exists.
        /// </summary>
        public static string ApiScopePropertyExistsValue {
            get {
                return ResourceManager.GetString("ApiScopePropertyExistsValue", resourceCulture);
            }
        }
    }
}
