using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:36111""}]")]
    public class SystemVoiceMessagingGroupGetRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetResponse20>
    {

    }
}
