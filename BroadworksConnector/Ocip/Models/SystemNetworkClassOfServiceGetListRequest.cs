using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Network Classes of Service.
    /// The response is either a SystemNetworkClassOfServiceGetListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemNetworkClassOfServiceGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkClassOfServiceGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
