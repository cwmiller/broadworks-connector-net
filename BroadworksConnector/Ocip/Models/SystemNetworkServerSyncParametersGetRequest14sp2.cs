using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Network Server Sync system parameters.
    /// The response is either SystemNetworkServerSyncParametersGetResponse14sp2 or ErrorResponse.
    /// Replaced By: SystemNetworkServerSyncParametersGetRequest16
        /// <see cref="SystemNetworkServerSyncParametersGetResponse14sp2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemNetworkServerSyncParametersGetRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkServerSyncParametersGetRequest14sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
