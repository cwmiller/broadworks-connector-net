using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Voice Messaging.
    /// The response is either a SystemVoiceMessagingGroupGetResponse21 or an ErrorResponse.
    /// 
    /// Replaced by: SystemVoiceMessagingGroupGetRequest22 in AS data mode
    /// <see cref="SystemVoiceMessagingGroupGetResponse21"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemVoiceMessagingGroupGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:12144""}]")]
    public class SystemVoiceMessagingGroupGetRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetResponse21>
    {

    }
}
