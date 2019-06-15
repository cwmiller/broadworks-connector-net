using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of Intercept User dns defined in the system.
    /// The response is either a SystemInterceptUserGetDnListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemInterceptUserGetDnListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemInterceptUserGetDnListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
