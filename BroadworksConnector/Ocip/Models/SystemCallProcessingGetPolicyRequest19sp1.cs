using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response is either a SystemCallProcessingGetPolicyResponse19sp1 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallProcessingGetPolicyRequest21sp1
    /// <see cref="SystemCallProcessingGetPolicyResponse19sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallProcessingGetPolicyRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:21398""}]")]
    public class SystemCallProcessingGetPolicyRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
