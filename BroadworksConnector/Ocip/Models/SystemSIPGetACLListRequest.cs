using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the SIP access control list.
    /// The response is either SystemSIPGetACLListResponse or ErrorResponse.
        /// <see cref="SystemSIPGetACLListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPGetACLListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
