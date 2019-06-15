using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the Trunk Group service.
    /// The response is either SystemTrunkGroupGetResponse21 or ErrorResponse.
    /// 
    /// Replaced by: SystemTrunkGroupGetRequest22
        /// <see cref="SystemTrunkGroupGetResponse21"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemTrunkGroupGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTrunkGroupGetRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
