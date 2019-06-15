using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Voice Messaging.
    /// The response is either a SystemVoiceMessagingGroupGetResponse22V2 or an ErrorResponse.
        /// <see cref="SystemVoiceMessagingGroupGetResponse22V2"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVoiceMessagingGroupGetRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
