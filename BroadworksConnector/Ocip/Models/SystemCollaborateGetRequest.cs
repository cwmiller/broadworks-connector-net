using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with collaborate services.
    /// The response is either a SystemCollaborateGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemCollaborateGetRequest20sp1
        /// <see cref="SystemCollaborateGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCollaborateGetRequest20sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCollaborateGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
