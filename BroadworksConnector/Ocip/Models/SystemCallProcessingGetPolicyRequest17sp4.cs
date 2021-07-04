using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response is either a SystemCallProcessingGetPolicyResponse17sp4 or an
    /// ErrorResponse.
    /// Replaced By : SystemCallProcessingGetPolicyRequest18sp1
    /// <see cref="SystemCallProcessingGetPolicyResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallProcessingGetPolicyRequest18sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:21366""}]")]
    public class SystemCallProcessingGetPolicyRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
