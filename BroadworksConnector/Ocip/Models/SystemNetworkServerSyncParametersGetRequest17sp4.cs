using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Network Server Sync system parameters.
    /// The response is either SystemNetworkServerSyncParametersGetResponse17sp4 or ErrorResponse.
        /// <see cref="SystemNetworkServerSyncParametersGetResponse17sp4"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkServerSyncParametersGetRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
