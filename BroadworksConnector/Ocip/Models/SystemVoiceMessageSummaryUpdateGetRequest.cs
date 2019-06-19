using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:536""}]")]
    public class SystemVoiceMessageSummaryUpdateGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
