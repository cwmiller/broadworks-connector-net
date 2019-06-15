using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Hunt Group.
    /// The response is either a SystemHuntGroupGetResponse or an ErrorResponse.
    /// Replaced by: SystemHuntGroupGetRequest21 in AS data mode
        /// <see cref="SystemHuntGroupGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemHuntGroupGetRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemHuntGroupGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
