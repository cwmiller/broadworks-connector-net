using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests system voice mail message summary update parameter settings.
    /// The response is either SystemVoiceMessageSummaryUpdateGetResponse or ErrorResponse.
        /// <see cref="SystemVoiceMessageSummaryUpdateGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVoiceMessageSummaryUpdateGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
