using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system's default policy settings.
    /// The response is either SystemPolicyGetDefaultResponse17sp1 or ErrorResponse.
    /// <see cref="SystemPolicyGetDefaultResponse17sp1"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:28503""}]")]
    public class SystemPolicyGetDefaultRequest17sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemPolicyGetDefaultResponse17sp1>
    {

    }
}
