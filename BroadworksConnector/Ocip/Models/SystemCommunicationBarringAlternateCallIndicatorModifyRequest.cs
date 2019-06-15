using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Communication Barring Alternate Call Indicator.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringAlternateCallIndicatorModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _alternateCallIndicator;

        [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false, Namespace = "")]
        public string AlternateCallIndicator {
            get => _alternateCallIndicator;
            set {
                AlternateCallIndicatorSpecified = true;
                _alternateCallIndicator = value;
            }
        }

        [XmlIgnore]
        public bool AlternateCallIndicatorSpecified { get; set; }
        
        private string _networkServerAlternateCallIndicator;

        [XmlElement(ElementName = "networkServerAlternateCallIndicator", IsNullable = false, Namespace = "")]
        public string NetworkServerAlternateCallIndicator {
            get => _networkServerAlternateCallIndicator;
            set {
                NetworkServerAlternateCallIndicatorSpecified = true;
                _networkServerAlternateCallIndicator = value;
            }
        }

        [XmlIgnore]
        public bool NetworkServerAlternateCallIndicatorSpecified { get; set; }
        
    }
}
