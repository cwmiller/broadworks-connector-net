using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level Access Codes data associated with Dial Plan Policy.
    /// The response is either a SystemDialPlanPolicyGetAccessCodeListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemDialPlanPolicyGetAccessCodeListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDialPlanPolicyGetAccessCodeListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
