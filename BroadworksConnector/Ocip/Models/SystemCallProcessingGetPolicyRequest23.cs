using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response is either a SystemCallProcessingGetPolicyResponse23 or an ErrorResponse.
    /// 
    /// Replaced by: SystemCallProcessingGetPolicyRequest23V2 in AS data mode.
    /// <see cref="SystemCallProcessingGetPolicyResponse23"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallProcessingGetPolicyRequest23V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:7110""}]")]
    public class SystemCallProcessingGetPolicyRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
