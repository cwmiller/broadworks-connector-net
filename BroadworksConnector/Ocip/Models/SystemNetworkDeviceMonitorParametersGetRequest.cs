using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Network Device Polling system parameters.
    /// The response is either SystemNetworkDeviceMonitorParametersGetResponse or ErrorResponse.
        /// <see cref="SystemNetworkDeviceMonitorParametersGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkDeviceMonitorParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
