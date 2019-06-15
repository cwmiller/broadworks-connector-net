using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the carriers defined in the system.
    /// The response is either a SystemPreferredCarrierGetListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemPreferredCarrierGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPreferredCarrierGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
