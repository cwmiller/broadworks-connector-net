using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response is either a SystemVoiceMessagingGroupGetResponse22 or an ErrorResponse.
    /// 
    /// Replaced by: SystemVoiceMessagingGroupGetRequest22V2.
    /// <see cref="SystemVoiceMessagingGroupGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemVoiceMessagingGroupGetRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:12159""}]")]
    public class SystemVoiceMessagingGroupGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
