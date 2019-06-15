using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of system administrators.
    /// The response is either a SystemAdminGetResponse or an ErrorResponse.
        /// <see cref="SystemAdminGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAdminGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
