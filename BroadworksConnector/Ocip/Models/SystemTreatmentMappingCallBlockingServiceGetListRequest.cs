using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Call Blocking Service Mappings in the system.
    /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse
    /// or an ErrorResponse.
    /// 
    /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1 in AS data mode
        /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingCallBlockingServiceGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
