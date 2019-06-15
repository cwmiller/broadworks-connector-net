using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list system Number Portability Query Statuses.
    /// The response is either SystemNumberPortabilityQueryStatusGetListResponse or ErrorResponse.
        /// <see cref="SystemNumberPortabilityQueryStatusGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNumberPortabilityQueryStatusGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
