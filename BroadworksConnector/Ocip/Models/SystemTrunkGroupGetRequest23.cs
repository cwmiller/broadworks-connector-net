using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the Trunk Group service.
    /// The response is either SystemTrunkGroupGetResponse23 or ErrorResponse.
        /// <see cref="SystemTrunkGroupGetResponse23"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTrunkGroupGetRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
