using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Voice Messaging.
    /// The response is either a SystemVoiceMessagingGroupGetResponse14 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemVoiceMessagingGroupGetRequest16
    /// <see cref="SystemVoiceMessagingGroupGetResponse14"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemVoiceMessagingGroupGetRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:10722""}]")]
    public class SystemVoiceMessagingGroupGetRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
