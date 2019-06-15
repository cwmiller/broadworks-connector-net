using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Network Server Sync system parameters.
    /// The response is either SystemNetworkServerSyncParametersGetResponse16 or ErrorResponse.
    /// Replaced By: SystemNetworkServerSyncParametersGetRequest17sp4
        /// <see cref="SystemNetworkServerSyncParametersGetResponse16"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemNetworkServerSyncParametersGetRequest17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkServerSyncParametersGetRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
