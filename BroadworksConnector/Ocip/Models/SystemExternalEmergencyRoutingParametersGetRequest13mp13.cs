using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of External Emergency Routing system parameters.
    /// The response is either SystemExternalEmergencyRoutingParametersGetResponse13mp13 or ErrorResponse.
        /// <see cref="SystemExternalEmergencyRoutingParametersGetResponse13mp13"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemExternalEmergencyRoutingParametersGetRequest13mp13 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
