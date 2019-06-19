using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response is either a SystemCallProcessingGetPolicyResponse22 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallProcessingGetPolicyRequest22V2 in AS data mode.
    /// <see cref="SystemCallProcessingGetPolicyResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallProcessingGetPolicyRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:5902""}]")]
    public class SystemCallProcessingGetPolicyRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
