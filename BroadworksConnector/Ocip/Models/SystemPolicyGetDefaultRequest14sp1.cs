using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system's default policy settings.
    /// The response is either SystemPolicyGetDefaultResponse14sp1 or ErrorResponse.
    /// Replaced By: SystemPolicyGetDefaultRequest14sp4
    /// <see cref="SystemPolicyGetDefaultResponse14sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemPolicyGetDefaultRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:28951""}]")]
    public class SystemPolicyGetDefaultRequest14sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemPolicyGetDefaultResponse14sp1>
    {

    }
}
