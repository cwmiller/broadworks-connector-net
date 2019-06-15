using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Dial Plan Policy.
    /// The response is either a SystemDialPlanPolicyGetResponse or an ErrorResponse.
    /// Replaced by: SystemDialPlanPolicyGetRequest17
        /// <see cref="SystemDialPlanPolicyGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemDialPlanPolicyGetRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDialPlanPolicyGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
