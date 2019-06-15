using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the ordered list of supported codecs in the system.
    /// The ordered list of codecs is sent to MGCP devices when creating connections.
    /// The response is either a SystemCodecGetListResponse or an ErrorResponse.
        /// <see cref="SystemCodecGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCodecGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
