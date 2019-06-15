using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a Call Blocking Service mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2 in AS data mode
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingCallBlockingServiceDeleteRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private BroadWorksConnector.Ocip.Models.CallBlockingService22 _callBlockingService;

        [XmlElement(ElementName = "callBlockingService", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallBlockingService22 CallBlockingService {
            get => _callBlockingService;
            set {
                CallBlockingServiceSpecified = true;
                _callBlockingService = value;
            }
        }

        [XmlIgnore]
        public bool CallBlockingServiceSpecified { get; set; }
        
    }
}
