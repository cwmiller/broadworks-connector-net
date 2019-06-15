using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSecurityClassificationGetRequest22.
    /// The following elements are only used in Amplify data mode and not returned in AS and XS data mode:
    /// customizedSecurityClassification
        /// <see cref="UserSecurityClassificationGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSecurityClassificationGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _securityClassification;

        [XmlElement(ElementName = "securityClassification", IsNullable = false, Namespace = "")]
        public string SecurityClassification {
            get => _securityClassification;
            set {
                SecurityClassificationSpecified = true;
                _securityClassification = value;
            }
        }

        [XmlIgnore]
        public bool SecurityClassificationSpecified { get; set; }
        
        private string _customizedSecurityClassification;

        [XmlElement(ElementName = "customizedSecurityClassification", IsNullable = false, Namespace = "")]
        public string CustomizedSecurityClassification {
            get => _customizedSecurityClassification;
            set {
                CustomizedSecurityClassificationSpecified = true;
                _customizedSecurityClassification = value;
            }
        }

        [XmlIgnore]
        public bool CustomizedSecurityClassificationSpecified { get; set; }
        
    }
}
