using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Access Side SIP Status Code Mappings in the system.
    /// The response is either an SystemTreatmentMappingAccessSIPStatusGetListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemTreatmentMappingAccessSIPStatusGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingAccessSIPStatusGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
