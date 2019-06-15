using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the Group Night Forwarding system parameters.
    /// The response is either SystemGroupNightForwardingGetResponse or ErrorResponse.
        /// <see cref="SystemGroupNightForwardingGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGroupNightForwardingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
