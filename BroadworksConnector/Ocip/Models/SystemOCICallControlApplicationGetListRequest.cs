using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the OCI call control application list.
    /// The response is either SystemOCICallControlApplicationGetListResponse or ErrorResponse.
        /// <see cref="SystemOCICallControlApplicationGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOCICallControlApplicationGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
