using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with session audit.
    /// The response is either a SystemSessionAuditGetResponse or an
    /// ErrorResponse.
    /// Replaced By: SystemSessionAuditGetRequest14sp3
        /// <see cref="SystemSessionAuditGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSessionAuditGetRequest14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSessionAuditGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
