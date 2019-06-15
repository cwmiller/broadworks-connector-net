using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system's provisioning validation attributes.
    /// The response is either a SystemProvisioningValidationGetResponse or and ErrorResponse.
        /// <see cref="SystemProvisioningValidationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemProvisioningValidationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
