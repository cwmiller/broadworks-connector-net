using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Call Blocking Service Mappings in the system.
    /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse19sp1
    /// or an ErrorResponse.
    /// 
    /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest22
        /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListResponse19sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
