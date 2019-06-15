using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's general routing attributes.
    /// The response is either a SystemRoutingGetResponse or an ErrorResponse.
        /// <see cref="SystemRoutingGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
