using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response is either a SystemCallProcessingGetPolicyResponse21sp2 or an ErrorResponse.
    /// Replaced by: SystemCallProcessingGetPolicyRequest22 in AS data mode.
    /// <see cref="SystemCallProcessingGetPolicyResponse21sp2"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallProcessingGetPolicyRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:7051""}]")]
    public class SystemCallProcessingGetPolicyRequest21sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallProcessingGetPolicyResponse21sp2>
    {

    }
}
