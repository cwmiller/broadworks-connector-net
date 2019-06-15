using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system provisioning configuration for all subscribers
    /// The response is either a SystemSubscriberGetProvisioningParametersResponse
    /// or an ErrorResponse.
        /// <see cref="SystemSubscriberGetProvisioningParametersResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSubscriberGetProvisioningParametersRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
