using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system-level intercept user service settings.
    /// The response is either a SystemInterceptUserGetResponse or an ErrorResponse.
        /// <see cref="SystemInterceptUserGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemInterceptUserGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
