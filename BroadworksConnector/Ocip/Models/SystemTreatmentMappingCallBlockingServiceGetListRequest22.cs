using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Call Blocking Service Mappings in the system.
    /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse22
    /// or an ErrorResponse.
    /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest23
        /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListResponse22"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListRequest23"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingCallBlockingServiceGetListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
