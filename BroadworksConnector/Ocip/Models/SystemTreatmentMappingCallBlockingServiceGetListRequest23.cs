using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Call Blocking Service Mappings in the system.
    /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse23
    /// or an ErrorResponse.
        /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListResponse23"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingCallBlockingServiceGetListRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
