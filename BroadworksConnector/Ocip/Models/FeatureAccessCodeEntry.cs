using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Feature Access Code Entry
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class FeatureAccessCodeEntry 
    {

        
        private string _featureAccessCodeName;

        [XmlElement(ElementName = "featureAccessCodeName", IsNullable = false, Namespace = "")]
        public string FeatureAccessCodeName {
            get => _featureAccessCodeName;
            set {
                FeatureAccessCodeNameSpecified = true;
                _featureAccessCodeName = value;
            }
        }

        [XmlIgnore]
        public bool FeatureAccessCodeNameSpecified { get; set; }
        
        private string _mainCode;

        [XmlElement(ElementName = "mainCode", IsNullable = false, Namespace = "")]
        public string MainCode {
            get => _mainCode;
            set {
                MainCodeSpecified = true;
                _mainCode = value;
            }
        }

        [XmlIgnore]
        public bool MainCodeSpecified { get; set; }
        
        private string _alternateCode;

        [XmlElement(ElementName = "alternateCode", IsNullable = true, Namespace = "")]
        public string AlternateCode {
            get => _alternateCode;
            set {
                AlternateCodeSpecified = true;
                _alternateCode = value;
            }
        }

        [XmlIgnore]
        public bool AlternateCodeSpecified { get; set; }
        
    }
}
