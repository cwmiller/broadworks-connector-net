using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Physical Location system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPhysicalLocationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _alwaysAllowEmergencyCalls;

        [XmlElement(ElementName = "alwaysAllowEmergencyCalls", IsNullable = false, Namespace = "")]
        public bool AlwaysAllowEmergencyCalls {
            get => _alwaysAllowEmergencyCalls;
            set {
                AlwaysAllowEmergencyCallsSpecified = true;
                _alwaysAllowEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        public bool AlwaysAllowEmergencyCallsSpecified { get; set; }
        
    }
}
