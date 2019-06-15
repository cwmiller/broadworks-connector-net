using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the hPBX mobile termination related configuration parameters.
    /// The response is either a SystemHPBXMobileTerminationGetResponse or an ErrorResponse.
        /// <see cref="SystemHPBXMobileTerminationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemHPBXMobileTerminationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
