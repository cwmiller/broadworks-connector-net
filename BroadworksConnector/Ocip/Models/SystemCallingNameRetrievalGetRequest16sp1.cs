using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's calling name retrieval attributes.
    /// The response is either a SystemCallingNameRetrievalGetResponse16sp1 or an ErrorResponse.
    /// 
    /// Replaced by: SystemCallingNameRetrievalGetRequest17sp4
        /// <see cref="SystemCallingNameRetrievalGetResponse16sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallingNameRetrievalGetRequest17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallingNameRetrievalGetRequest16sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
