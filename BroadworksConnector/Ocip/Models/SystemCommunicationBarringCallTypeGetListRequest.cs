using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get all the Communication Barring Call Types defined in the system.
    /// The response is either a SystemCommunicationBarringCallTypeGetListResponse or an ErrorResponse.
        /// <see cref="SystemCommunicationBarringCallTypeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringCallTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
