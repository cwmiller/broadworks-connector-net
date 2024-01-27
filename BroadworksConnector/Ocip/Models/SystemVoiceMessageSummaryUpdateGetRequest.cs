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
    /// 
    /// Replaced By: SystemVoiceMessageSummaryUpdateGetRequest25
    /// <see cref="SystemVoiceMessageSummaryUpdateGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemVoiceMessageSummaryUpdateGetRequest25"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:36755""}]")]
    public class SystemVoiceMessageSummaryUpdateGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemVoiceMessageSummaryUpdateGetResponse>
    {

    }
}
