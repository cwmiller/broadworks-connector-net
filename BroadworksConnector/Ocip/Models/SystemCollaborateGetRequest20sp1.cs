using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with collaborate services.
    /// The response is either a SystemCollaborateGetResponse20sp1 or an ErrorResponse.
    /// 
    /// Replaced by: SystemCollaborateGetRequest20sp1V2
        /// <see cref="SystemCollaborateGetResponse20sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCollaborateGetRequest20sp1V2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCollaborateGetRequest20sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
