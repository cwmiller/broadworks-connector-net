using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the OCI call control access control list.
    /// The response is either SystemOCICallControlGetACLListResponse or ErrorResponse.
        /// <see cref="SystemOCICallControlGetACLListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOCICallControlGetACLListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
