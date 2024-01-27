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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13408""}]")]
    public class SystemNumberPortabilityQueryStatusGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemNumberPortabilityQueryStatusGetListResponse>
    {

    }
}
