using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with collaborate services.
    /// The response is either a SystemCollaborateGetResponse20sp1V2 or an ErrorResponse.
        /// <see cref="SystemCollaborateGetResponse20sp1V2"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCollaborateGetRequest20sp1V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
