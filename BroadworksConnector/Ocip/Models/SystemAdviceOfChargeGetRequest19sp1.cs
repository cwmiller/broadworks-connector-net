using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Advice of Charge system parameters.
    /// The response is either SystemAdviceOfChargeGetResponse19sp1 or ErrorResponse.
    /// <see cref="SystemAdviceOfChargeGetResponse19sp1"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a69fde15f3aa7494d83b57461a7a70bb:234""}]")]
    public class SystemAdviceOfChargeGetRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
