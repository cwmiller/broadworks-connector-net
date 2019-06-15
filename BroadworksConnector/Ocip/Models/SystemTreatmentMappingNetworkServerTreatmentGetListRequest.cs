using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing NS Treatment Mappings in the system.
    /// The response is either a   SystemTreatmentMappingNetworkServerTreatmentGetListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemTreatmentMappingNetworkServerTreatmentGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingNetworkServerTreatmentGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
