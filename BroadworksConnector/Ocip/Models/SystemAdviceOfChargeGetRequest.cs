using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Advice of Charge system parameters.
    /// The response is either SystemAdviceOfChargeGetResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemAdviceOfChargeGetRequest19sp1
    /// <see cref="SystemAdviceOfChargeGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemAdviceOfChargeGetRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:19736""}]")]
    public class SystemAdviceOfChargeGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
