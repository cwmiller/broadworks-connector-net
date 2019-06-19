using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Processing Policy.
    /// The response is either a SystemCallProcessingGetPolicyResponse17sp3 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallProcessingGetPolicyRequest17sp4
    /// <see cref="SystemCallProcessingGetPolicyResponse17sp3"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallProcessingGetPolicyRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:21242""}]")]
    public class SystemCallProcessingGetPolicyRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
