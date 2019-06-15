using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Feature Access Code Entry to be used in all user modify command.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserFeatureAccessCodeModifyEntry 
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
        
        private bool _enableFAC;

        [XmlElement(ElementName = "enableFAC", IsNullable = false, Namespace = "")]
        public bool EnableFAC {
            get => _enableFAC;
            set {
                EnableFACSpecified = true;
                _enableFAC = value;
            }
        }

        [XmlIgnore]
        public bool EnableFACSpecified { get; set; }
        
    }
}
