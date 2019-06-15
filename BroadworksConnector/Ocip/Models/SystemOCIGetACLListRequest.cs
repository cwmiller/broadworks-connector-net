using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the OCI access control list.
    /// The response is either SystemOCIGetACLListResponse or ErrorResponse.
        /// <see cref="SystemOCIGetACLListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOCIGetACLListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
