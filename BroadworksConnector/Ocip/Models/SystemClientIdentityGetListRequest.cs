using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of client identities.
    /// The response is either a SystemClientIdentityGetListResponse or an ErrorResponse.
        /// <see cref="SystemClientIdentityGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemClientIdentityGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
