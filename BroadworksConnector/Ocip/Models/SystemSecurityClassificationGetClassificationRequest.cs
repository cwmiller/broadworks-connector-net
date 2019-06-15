using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a system Security Classification.
    /// The response is either SystemSecurityClassificationGetClassificationResponse or ErrorResponse.
        /// <see cref="SystemSecurityClassificationGetClassificationResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSecurityClassificationGetClassificationRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _securityClassificationName;

        [XmlElement(ElementName = "securityClassificationName", IsNullable = false, Namespace = "")]
        public string SecurityClassificationName {
            get => _securityClassificationName;
            set {
                SecurityClassificationNameSpecified = true;
                _securityClassificationName = value;
            }
        }

        [XmlIgnore]
        public bool SecurityClassificationNameSpecified { get; set; }
        
    }
}
