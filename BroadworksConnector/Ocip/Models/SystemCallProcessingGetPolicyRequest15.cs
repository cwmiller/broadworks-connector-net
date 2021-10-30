using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Processing Policy.
    /// The response is either a SystemCallProcessingGetPolicyResponse15 or an
    /// ErrorResponse.
    /// Replaced By: SystemCallProcessingGetPolicyRequest15sp2
    /// <see cref="SystemCallProcessingGetPolicyResponse15"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallProcessingGetPolicyRequest15sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:21275""}]")]
    public class SystemCallProcessingGetPolicyRequest15 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallProcessingGetPolicyResponse15>
    {

    }
}
