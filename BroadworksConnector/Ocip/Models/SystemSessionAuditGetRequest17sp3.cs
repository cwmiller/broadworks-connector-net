using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with session audit.
    /// The response is either a SystemSessionAuditGetResponse17sp3 or
    /// an ErrorResponse.
    /// 
    /// Replaced by: SystemSessionAuditGetRequest23 in AS data mode.
        /// <see cref="SystemSessionAuditGetResponse17sp3"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSessionAuditGetRequest23"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSessionAuditGetRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
