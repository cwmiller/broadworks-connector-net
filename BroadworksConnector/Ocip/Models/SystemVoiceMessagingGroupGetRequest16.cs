using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Voice Messaging.
    /// The response is either a SystemVoiceMessagingGroupGetResponse16 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemVoiceMessagingGroupGetRequest16sp2
    /// <see cref="SystemVoiceMessagingGroupGetResponse16"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemVoiceMessagingGroupGetRequest16sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:36096""}]")]
    public class SystemVoiceMessagingGroupGetRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
