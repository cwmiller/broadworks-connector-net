using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Voice Messaging.
    /// The response is either a SystemVoiceMessagingGroupGetResponse20 or an ErrorResponse.
    /// Replaced by: SystemVoiceMessagingGroupGetRequest21
        /// <see cref="SystemVoiceMessagingGroupGetResponse20"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemVoiceMessagingGroupGetRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVoiceMessagingGroupGetRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
