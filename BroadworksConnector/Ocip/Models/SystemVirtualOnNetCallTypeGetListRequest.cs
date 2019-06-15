using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list Virtual On-Net Call Types in the system.
    /// The response is either a SystemVirtualOnNetCallTypeGetListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemVirtualOnNetCallTypeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVirtualOnNetCallTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
