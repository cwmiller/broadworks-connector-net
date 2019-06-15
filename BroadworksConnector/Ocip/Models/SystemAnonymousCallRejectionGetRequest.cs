using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get Anonymous Call Rejection system parameters.
    /// The response is either a SystemAnonymousCallRejectionGetResponse or
    /// an ErrorResponse.
        /// <see cref="SystemAnonymousCallRejectionGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAnonymousCallRejectionGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
