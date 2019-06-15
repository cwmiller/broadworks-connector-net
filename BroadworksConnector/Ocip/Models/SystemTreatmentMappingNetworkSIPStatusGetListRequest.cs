using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Network SIP Status Code Mappings in the system.
    /// The response is either an SystemTreatmentMappingNetworkSIPStatusGetListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemTreatmentMappingNetworkSIPStatusGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingNetworkSIPStatusGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
