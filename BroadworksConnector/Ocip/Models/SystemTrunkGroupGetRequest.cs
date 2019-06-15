using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the Trunk Group service.
    /// The response is either SystemTrunkGroupGetResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemTrunkGroupGetRequest19sp1.
        /// <see cref="SystemTrunkGroupGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemTrunkGroupGetRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTrunkGroupGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
