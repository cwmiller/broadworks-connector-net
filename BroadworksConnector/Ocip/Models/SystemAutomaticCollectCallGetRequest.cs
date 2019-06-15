using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get system Automatic Collect Call service settings.
    /// The response is either SystemAutomaticCollectCallGetResponse or ErrorResponse.
        /// <see cref="SystemAutomaticCollectCallGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAutomaticCollectCallGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
