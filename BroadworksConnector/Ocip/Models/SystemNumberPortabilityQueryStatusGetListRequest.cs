using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list system Number Portability Query Statuses.
    /// The response is either SystemNumberPortabilityQueryStatusGetListResponse or ErrorResponse.
    /// <see cref="SystemNumberPortabilityQueryStatusGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12111""}]")]
    public class SystemNumberPortabilityQueryStatusGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
