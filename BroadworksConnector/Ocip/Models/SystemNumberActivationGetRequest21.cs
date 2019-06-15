using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the number activation state and enterprise trunk number range activation status.
    /// The response is either SystemNumberActivationGetResponse21 or ErrorResponse.
        /// <see cref="SystemNumberActivationGetResponse21"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNumberActivationGetRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
