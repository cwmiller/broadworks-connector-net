using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of System Service DN utilization.
    /// The response is either SystemSystemServiceDnGetUsageListResponse or ErrorResponse.
        /// <see cref="SystemSystemServiceDnGetUsageListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSystemServiceDnGetUsageListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
