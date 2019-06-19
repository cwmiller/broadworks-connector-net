using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response is either a SystemCallProcessingGetPolicyResponse17 or an
    /// ErrorResponse.
    /// <see cref="SystemCallProcessingGetPolicyResponse17"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:21225""}]")]
    public class SystemCallProcessingGetPolicyRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
