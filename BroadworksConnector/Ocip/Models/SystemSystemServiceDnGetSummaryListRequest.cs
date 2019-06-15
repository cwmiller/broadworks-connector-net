using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a summary table of all System Service DNs.
    /// The response is either SystemSystemServiceDnGetSummaryListResponse or ErrorResponse.
        /// <see cref="SystemSystemServiceDnGetSummaryListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSystemServiceDnGetSummaryListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
