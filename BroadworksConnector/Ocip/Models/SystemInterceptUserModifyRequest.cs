using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system-level intercept user service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemInterceptUserModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _emergencyAndRepairIntercept;

        [XmlElement(ElementName = "emergencyAndRepairIntercept", IsNullable = false, Namespace = "")]
        public bool EmergencyAndRepairIntercept {
            get => _emergencyAndRepairIntercept;
            set {
                EmergencyAndRepairInterceptSpecified = true;
                _emergencyAndRepairIntercept = value;
            }
        }

        [XmlIgnore]
        public bool EmergencyAndRepairInterceptSpecified { get; set; }
        
    }
}
