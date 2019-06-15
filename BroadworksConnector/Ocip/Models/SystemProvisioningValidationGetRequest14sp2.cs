using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system's provisioning validation attributes.
    /// The response is either a SystemProvisioningValidationGetResponse14sp2 or ErrorResponse.
        /// <see cref="SystemProvisioningValidationGetResponse14sp2"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemProvisioningValidationGetRequest14sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
