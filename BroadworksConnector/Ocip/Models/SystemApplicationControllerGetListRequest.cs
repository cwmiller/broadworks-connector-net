using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of application controllers that are configured for the system.
    /// The response is either SystemApplicationControllerGetListResponse or ErrorResponse.
        /// <see cref="SystemApplicationControllerGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemApplicationControllerGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
