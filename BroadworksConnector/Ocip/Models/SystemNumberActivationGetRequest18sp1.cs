using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the Number Activation state.
    /// The response is either SystemNumberActivationGetResponse18sp1 or ErrorResponse.
    /// Replaced by: SystemNumberActivationGetRequest21
    /// <see cref="SystemNumberActivationGetResponse18sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemNumberActivationGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:8737""}]")]
    public class SystemNumberActivationGetRequest18sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemNumberActivationGetResponse18sp1>
    {

    }
}
