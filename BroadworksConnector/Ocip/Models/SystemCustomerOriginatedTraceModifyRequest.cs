using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Customer Originated Trace.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCustomerOriginatedTraceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _screenMaliciousCallers;

        [XmlElement(ElementName = "screenMaliciousCallers", IsNullable = false, Namespace = "")]
        public bool ScreenMaliciousCallers {
            get => _screenMaliciousCallers;
            set {
                ScreenMaliciousCallersSpecified = true;
                _screenMaliciousCallers = value;
            }
        }

        [XmlIgnore]
        public bool ScreenMaliciousCallersSpecified { get; set; }
        
    }
}
