using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of system level successful SIP OPTIONS message respoonse status codes.
    /// The response is either SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse or ErrorResponse.
        /// <see cref="SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
