using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with session audit.
    /// The response is either a SystemSessionAuditGetResponse14sp3 or
    /// an ErrorResponse.
        /// <see cref="SystemSessionAuditGetResponse14sp3"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSessionAuditGetRequest14sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
