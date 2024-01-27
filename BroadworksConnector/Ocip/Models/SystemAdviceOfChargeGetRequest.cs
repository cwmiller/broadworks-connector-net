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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:20435""}]")]
    public class SystemAdviceOfChargeGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAdviceOfChargeGetResponse>
    {

    }
}
