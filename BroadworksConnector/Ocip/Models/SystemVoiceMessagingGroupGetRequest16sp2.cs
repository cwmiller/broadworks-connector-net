using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Voice Messaging.
    /// The response is either a SystemVoiceMessagingGroupGetResponse16sp2 or an ErrorResponse.
    /// 
    /// Replaced by: SystemVoiceMessagingGroupGetRequest20 in AS data mode
    /// <see cref="SystemVoiceMessagingGroupGetResponse16sp2"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemVoiceMessagingGroupGetRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:16233""}]")]
    public class SystemVoiceMessagingGroupGetRequest16sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetResponse16sp2>
    {

    }
}
