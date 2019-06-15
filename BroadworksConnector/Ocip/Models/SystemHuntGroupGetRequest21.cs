using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Hunt Group.
    /// The response is either a SystemHuntGroupGetResponse21 or an
    /// ErrorResponse.
        /// <see cref="SystemHuntGroupGetResponse21"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemHuntGroupGetRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
