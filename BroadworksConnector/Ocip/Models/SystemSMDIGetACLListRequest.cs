using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the SMDI access control list.
    /// The response is either SystemSMDIGetACLListResponse or ErrorResponse.
        /// <see cref="SystemSMDIGetACLListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSMDIGetACLListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
