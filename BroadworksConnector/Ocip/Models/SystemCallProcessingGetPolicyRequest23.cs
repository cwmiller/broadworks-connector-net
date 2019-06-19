using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response is either a SystemCallProcessingGetPolicyResponse23 or an
    /// ErrorResponse.
    /// <see cref="SystemCallProcessingGetPolicyResponse23"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2618""}]")]
    public class SystemCallProcessingGetPolicyRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
