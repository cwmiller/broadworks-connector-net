using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderLanguageGetListRequest.
        /// <see cref="ServiceProviderLanguageGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderLanguageGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        public List<string> Language {
            get => _language;
            set {
                LanguageSpecified = true;
                _language = value;
            }
        }

        [XmlIgnore]
        public bool LanguageSpecified { get; set; }
        
        private string _defaultLanguage;

        [XmlElement(ElementName = "defaultLanguage", IsNullable = false, Namespace = "")]
        public string DefaultLanguage {
            get => _defaultLanguage;
            set {
                DefaultLanguageSpecified = true;
                _defaultLanguage = value;
            }
        }

        [XmlIgnore]
        public bool DefaultLanguageSpecified { get; set; }
        
    }
}
