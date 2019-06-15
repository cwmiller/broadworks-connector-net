using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Dial Plan Policy.
    /// The response is either a SystemDialPlanPolicyGetResponse17 or an
    /// ErrorResponse.
        /// <see cref="SystemDialPlanPolicyGetResponse17"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDialPlanPolicyGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
