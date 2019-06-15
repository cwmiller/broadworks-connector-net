using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a system Anonymous Call Rejection parameter.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAnonymousCallRejectionModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _paiRequired;

        [XmlElement(ElementName = "paiRequired", IsNullable = false, Namespace = "")]
        public bool PaiRequired {
            get => _paiRequired;
            set {
                PaiRequiredSpecified = true;
                _paiRequired = value;
            }
        }

        [XmlIgnore]
        public bool PaiRequiredSpecified { get; set; }
        
        private bool _screenOnlyLocalCalls;

        [XmlElement(ElementName = "screenOnlyLocalCalls", IsNullable = false, Namespace = "")]
        public bool ScreenOnlyLocalCalls {
            get => _screenOnlyLocalCalls;
            set {
                ScreenOnlyLocalCallsSpecified = true;
                _screenOnlyLocalCalls = value;
            }
        }

        [XmlIgnore]
        public bool ScreenOnlyLocalCallsSpecified { get; set; }
        
    }
}
