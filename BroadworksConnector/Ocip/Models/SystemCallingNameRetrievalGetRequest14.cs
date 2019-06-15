using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's calling name retrieval attributes.
    /// The response is either a SystemCallingNameRetrievalGetResponse14 or an ErrorResponse.
        /// <see cref="SystemCallingNameRetrievalGetResponse14"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallingNameRetrievalGetRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
