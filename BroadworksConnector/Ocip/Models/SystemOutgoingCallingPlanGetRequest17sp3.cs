using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Outgoing Calling Plan.
    /// The response is either a SystemOutgoingCallingPlanGetResponse17sp3 or an ErrorResponse.
        /// <see cref="SystemOutgoingCallingPlanGetResponse17sp3"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOutgoingCallingPlanGetRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
