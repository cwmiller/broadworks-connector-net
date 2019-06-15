using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of access device types.
    /// The response is either SystemAccessDeviceTypeGetListResponse or ErrorResponse.
        /// <see cref="SystemAccessDeviceTypeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccessDeviceTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
