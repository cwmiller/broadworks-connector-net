using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of media in the system.
    /// The response is either a SystemMediaGetListResponse or an
    /// ErrorResponse.
        /// <see cref="SystemMediaGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMediaGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
