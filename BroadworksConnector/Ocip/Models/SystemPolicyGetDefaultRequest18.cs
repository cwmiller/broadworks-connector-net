using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system's default policy settings.
    /// The response is either SystemPolicyGetDefaultResponse18 or ErrorResponse.
    /// 
    /// Replaced by: SystemPolicyGetDefaultRequest20 in AS data mode
    /// <see cref="SystemPolicyGetDefaultResponse18"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemPolicyGetDefaultRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:1636""}]")]
    public class SystemPolicyGetDefaultRequest18 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
