using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests system voice mail message summary update parameter settings.
    /// The response is either SystemVoiceMessageSummaryUpdateGetResponse25 or ErrorResponse.
    /// <see cref="SystemVoiceMessageSummaryUpdateGetResponse25"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:536""}]")]
    public class SystemVoiceMessageSummaryUpdateGetRequest25 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemVoiceMessageSummaryUpdateGetResponse25>
    {

    }
}
