using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the list of file repositories in the system.
    /// The response is either a SystemFileRepositoryDeviceGetListResponse or an ErrorResponse.
        /// <see cref="SystemFileRepositoryDeviceGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFileRepositoryDeviceGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
