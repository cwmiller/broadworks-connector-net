using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of GETS Session Priority maps.
    /// The response is either SystemGETSSessionPriorityMapGetListResponse or ErrorResponse.
        /// <see cref="SystemGETSSessionPriorityMapGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGETSSessionPriorityMapGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
