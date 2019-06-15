using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a language properties in the system.
    /// If the becomeDefaultLanguage element is present, the language in this request becomes
    /// the default language for the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLanguageModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        public string Language {
            get => _language;
            set {
                LanguageSpecified = true;
                _language = value;
            }
        }

        [XmlIgnore]
        public bool LanguageSpecified { get; set; }
        
        private bool _becomeDefaultLanguage;

        [XmlElement(ElementName = "becomeDefaultLanguage", IsNullable = false, Namespace = "")]
        public bool BecomeDefaultLanguage {
            get => _becomeDefaultLanguage;
            set {
                BecomeDefaultLanguageSpecified = true;
                _becomeDefaultLanguage = value;
            }
        }

        [XmlIgnore]
        public bool BecomeDefaultLanguageSpecified { get; set; }
        
        private string _locale;

        [XmlElement(ElementName = "locale", IsNullable = false, Namespace = "")]
        public string Locale {
            get => _locale;
            set {
                LocaleSpecified = true;
                _locale = value;
            }
        }

        [XmlIgnore]
        public bool LocaleSpecified { get; set; }
        
        private string _encoding;

        [XmlElement(ElementName = "encoding", IsNullable = false, Namespace = "")]
        public string Encoding {
            get => _encoding;
            set {
                EncodingSpecified = true;
                _encoding = value;
            }
        }

        [XmlIgnore]
        public bool EncodingSpecified { get; set; }
        
    }
}
