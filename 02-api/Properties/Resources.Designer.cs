﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ini.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ini.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to ...Configuration not validated..
        /// </summary>
        internal static string ConfigReaderConfigNotValidated {
            get {
                return ResourceManager.GetString("ConfigReaderConfigNotValidated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ...Configuration validated against a specification.
        ///	Origin: {0}..
        /// </summary>
        internal static string ConfigReaderConfigValidated {
            get {
                return ResourceManager.GetString("ConfigReaderConfigValidated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line {0}: link specifies too many target components in section &apos;{1}&apos; and option &apos;{2}&apos;. The link:
        ///	{3}.
        /// </summary>
        internal static string ConfigReaderConfusingLinkTarget {
            get {
                return ResourceManager.GetString("ConfigReaderConfusingLinkTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line {0}: duplicate option &apos;{1}&apos; in section &apos;{2}&apos;..
        /// </summary>
        internal static string ConfigReaderDuplicateOption {
            get {
                return ResourceManager.GetString("ConfigReaderDuplicateOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line {0}: duplicate section (&apos;{1}&apos;)..
        /// </summary>
        internal static string ConfigReaderDuplicateSection {
            get {
                return ResourceManager.GetString("ConfigReaderDuplicateSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line {0}: link specifies too few target components in section &apos;{1}&apos; and option &apos;{2}&apos;. The link:
        ///	{3}.
        /// </summary>
        internal static string ConfigReaderIncompleteLinkTarget {
            get {
                return ResourceManager.GetString("ConfigReaderIncompleteLinkTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line {0}: link target (section &apos;{1}&apos; and option &apos;{2}&apos;) not found.
        ///	Link defined in section &apos;{3}&apos; and option &apos;{4}&apos;..
        /// </summary>
        internal static string ConfigReaderInvalidLinkTarget {
            get {
                return ResourceManager.GetString("ConfigReaderInvalidLinkTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: strict validation mode was applied but the received specification was not valid..
        /// </summary>
        internal static string ConfigReaderInvalidSpecification {
            get {
                return ResourceManager.GetString("ConfigReaderInvalidSpecification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ...Commencing new configuration parsing task..
        /// </summary>
        internal static string ConfigReaderNewConfigStart {
            get {
                return ResourceManager.GetString("ConfigReaderNewConfigStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line {0}: specification is missing definition for option &apos;{1}&apos; in section &apos;{2}&apos;..
        /// </summary>
        internal static string ConfigReaderNoOptionSpecification {
            get {
                return ResourceManager.GetString("ConfigReaderNoOptionSpecification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line {0}: specification is missing definition for section &apos;{1}&apos;..
        /// </summary>
        internal static string ConfigReaderNoSectionSpecification {
            get {
                return ResourceManager.GetString("ConfigReaderNoSectionSpecification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: strict validation mode was applied but no specification has been specified..
        /// </summary>
        internal static string ConfigReaderNoSpecification {
            get {
                return ResourceManager.GetString("ConfigReaderNoSpecification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line {0}: unknown syntax. Content:
        ///	{1}.
        /// </summary>
        internal static string ConfigReaderUnknownLineSyntax {
            get {
                return ResourceManager.GetString("ConfigReaderUnknownLineSyntax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ...Validation mode: {0}..
        /// </summary>
        internal static string ConfigReaderValidationMode {
            get {
                return ResourceManager.GetString("ConfigReaderValidationMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: configuration can not be validated because its associated specification is not valid..
        /// </summary>
        internal static string ConfigValidationInvalidSpecification {
            get {
                return ResourceManager.GetString("ConfigValidationInvalidSpecification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: option &apos;{0}&apos; in section &apos;{1}&apos; contains a link that references a removed option &apos;{2}&apos; or section &apos;{3}&apos;..
        /// </summary>
        internal static string ConfigValidationLinkInconsistent {
            get {
                return ResourceManager.GetString("ConfigValidationLinkInconsistent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: missing mandatory option &apos;{0}&apos; in section &apos;{1}&apos;.
        ///	Hint: try relaxed validation mode..
        /// </summary>
        internal static string ConfigValidationMissingMandatoryOption {
            get {
                return ResourceManager.GetString("ConfigValidationMissingMandatoryOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: missing mandatory section &apos;{0}&apos;.
        ///	Hint: try relaxed validation mode..
        /// </summary>
        internal static string ConfigValidationMissingMandatorySection {
            get {
                return ResourceManager.GetString("ConfigValidationMissingMandatorySection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: validation of option &apos;{0}&apos; in section &apos;{1}&apos; was skipped as it wasn&apos;t found in the associated specification..
        /// </summary>
        internal static string ConfigValidationNoOptionSpecification {
            get {
                return ResourceManager.GetString("ConfigValidationNoOptionSpecification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: validation of section &apos;{0}&apos; was skipped as it wasn&apos;t found in the associated specification..
        /// </summary>
        internal static string ConfigValidationNoSectionSpecification {
            get {
                return ResourceManager.GetString("ConfigValidationNoSectionSpecification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: configuration can not be validated because it isn&apos;t associated to a specification..
        /// </summary>
        internal static string ConfigValidationNoSpecification {
            get {
                return ResourceManager.GetString("ConfigValidationNoSpecification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: option &apos;{0}&apos; in section &apos;{1}&apos; is mandatory but it doesn&apos;t contain a value..
        /// </summary>
        internal static string ConfigValidationNoValue {
            get {
                return ResourceManager.GetString("ConfigValidationNoValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: option &apos;{0}&apos; in section &apos;{1}&apos; is declared as single-value but instead it contains multiple values..
        /// </summary>
        internal static string ConfigValidationTooManyValues {
            get {
                return ResourceManager.GetString("ConfigValidationTooManyValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: option &apos;{0}&apos; in section &apos;{1}&apos; contains a value that is not explicitly allowed (&apos;{2}&apos;)..
        /// </summary>
        internal static string ConfigValidationValueNotAllowed {
            get {
                return ResourceManager.GetString("ConfigValidationValueNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: option &apos;{0}&apos; in section &apos;{1}&apos; contains a value that is out of range (&apos;{2}&apos;)..
        /// </summary>
        internal static string ConfigValidationValueOutOfRange {
            get {
                return ResourceManager.GetString("ConfigValidationValueOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: option &apos;{0}&apos; in section &apos;{1}&apos; is of type &apos;{2}&apos;. Expected: &apos;{3}&apos;..
        /// </summary>
        internal static string ConfigValidationValueTypeMismatch {
            get {
                return ResourceManager.GetString("ConfigValidationValueTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 	Origin: {0}..
        /// </summary>
        internal static string ReaderOrigin {
            get {
                return ResourceManager.GetString("ReaderOrigin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ...Commencing new specification parsing task..
        /// </summary>
        internal static string SpecReaderNewSpecification {
            get {
                return ResourceManager.GetString("SpecReaderNewSpecification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: duplicate option &apos;{0}&apos; in section &apos;{1}&apos;..
        /// </summary>
        internal static string SpecValidationDuplicateOption {
            get {
                return ResourceManager.GetString("SpecValidationDuplicateOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: duplicate section &apos;{0}&apos;..
        /// </summary>
        internal static string SpecValidationDuplicateSection {
            get {
                return ResourceManager.GetString("SpecValidationDuplicateSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: option &apos;{0}&apos; in section &apos;{1}&apos; doesn&apos;t define enough enumeration values..
        /// </summary>
        internal static string SpecValidationNoEnumValues {
            get {
                return ResourceManager.GetString("SpecValidationNoEnumValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: option &apos;{0}&apos; in section &apos;{1}&apos; is optional but it doesn&apos;t define any default value..
        /// </summary>
        internal static string SpecValidationNoValue {
            get {
                return ResourceManager.GetString("SpecValidationNoValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: option &apos;{0}&apos; in section &apos;{1}&apos; is declared as single-value but instead it defines multiple default values..
        /// </summary>
        internal static string SpecValidationTooManyValues {
            get {
                return ResourceManager.GetString("SpecValidationTooManyValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: option &apos;{0}&apos; in section &apos;{1}&apos; contains a default value (&apos;{2}&apos;) that is not explicitly allowed..
        /// </summary>
        internal static string SpecValidationValueNotAllowed {
            get {
                return ResourceManager.GetString("SpecValidationValueNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: option &apos;{0}&apos; in section &apos;{1}&apos; contains a default value (&apos;{2}&apos;) that is out of range..
        /// </summary>
        internal static string SpecValidationValueOutOfRange {
            get {
                return ResourceManager.GetString("SpecValidationValueOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: invalid configuration. Stopping...
        ///	Hint: either correct the configuration or try again with validation disabled..
        /// </summary>
        internal static string WriterInvalidConfiguration {
            get {
                return ResourceManager.GetString("WriterInvalidConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: no specification to use. Stopping...
        ///	Hint: either associate the configuration with a specification or try again with different options..
        /// </summary>
        internal static string WriterNoSpecification {
            get {
                return ResourceManager.GetString("WriterNoSpecification", resourceCulture);
            }
        }
    }
}
