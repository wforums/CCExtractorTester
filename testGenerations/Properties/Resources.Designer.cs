﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testGenerations.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("testGenerations.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;xs:schema xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///    &lt;xs:element name=&quot;multitest&quot;&gt;
        ///        &lt;xs:complexType&gt;
        ///            &lt;xs:sequence&gt;
        ///                &lt;xs:element name=&quot;testfile&quot; maxOccurs=&quot;unbounded&quot; minOccurs=&quot;1&quot;&gt;
        ///                    &lt;xs:complexType&gt;
        ///                        &lt;xs:sequence&gt;
        ///                            &lt;xs:element type=&quot;xs:string&quot; name=&quot;location&quot;/&gt;
        ///                        &lt;/xs:sequence&gt;
        ///                    &lt;/xs:complexType&gt;
        ///                &lt;/xs:element&gt;
        ///            &lt;/xs:sequence&gt;
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string multitest {
            get {
                return ResourceManager.GetString("multitest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///    &lt;xs:element name=&quot;tests&quot;&gt;
        ///        &lt;xs:complexType&gt;
        ///            &lt;xs:sequence&gt;
        ///                &lt;xs:element name=&quot;test&quot; maxOccurs=&quot;unbounded&quot; minOccurs=&quot;1&quot;&gt;
        ///                    &lt;xs:complexType&gt;
        ///                        &lt;xs:sequence&gt;
        ///                            &lt;xs:element type=&quot;xs:string&quot; name=&quot;sample&quot;/&gt;
        ///                            &lt;xs:element type=&quot;xs:string&quot; name=&quot;cmd&quot;/&gt;
        ///               [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tests {
            get {
                return ResourceManager.GetString("tests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///    &lt;xs:element name=&quot;tests&quot;&gt;
        ///        &lt;xs:complexType&gt;
        ///            &lt;xs:sequence&gt;
        ///                &lt;xs:element name=&quot;entry&quot; maxOccurs=&quot;unbounded&quot; minOccurs=&quot;1&quot;&gt;
        ///                    &lt;xs:complexType&gt;
        ///                        &lt;xs:sequence&gt;
        ///                            &lt;xs:element type=&quot;xs:string&quot; name=&quot;command&quot;/&gt;
        ///                            &lt;xs:element nam [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string testsuite {
            get {
                return ResourceManager.GetString("testsuite", resourceCulture);
            }
        }
    }
}
