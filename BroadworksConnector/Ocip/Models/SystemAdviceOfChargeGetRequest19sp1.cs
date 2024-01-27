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
    /// Replaced by: SystemAdviceOfChargeGetRequest25.
    /// <see cref="SystemAdviceOfChargeGetResponse19sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemAdviceOfChargeGetRequest25"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:20450""}]")]
    public class SystemAdviceOfChargeGetRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAdviceOfChargeGetResponse19sp1>
    {

    }
}
