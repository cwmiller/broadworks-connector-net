using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with session audit.
    /// The response is either a SystemSessionAuditGetResponse23 or
    /// an ErrorResponse.
        /// <see cref="SystemSessionAuditGetResponse23"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSessionAuditGetRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
