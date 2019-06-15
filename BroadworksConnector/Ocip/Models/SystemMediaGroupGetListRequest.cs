using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of media groups.
    /// The response is either SystemMediaGroupGetListResponse or ErrorResponse.
        /// <see cref="SystemMediaGroupGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMediaGroupGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
