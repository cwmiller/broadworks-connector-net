using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Media Sets in the system.
    /// The response is either a SystemMediaSetGetListResponse or an ErrorResponse.
        /// <see cref="SystemMediaSetGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMediaSetGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
