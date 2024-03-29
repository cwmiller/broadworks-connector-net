using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Dial Plan Policy.
    /// The response is either a SystemDialPlanPolicyGetResponse or an
    /// ErrorResponse.
    /// Replaced by: SystemDialPlanPolicyGetRequest17
    /// <see cref="SystemDialPlanPolicyGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemDialPlanPolicyGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:26736""}]")]
    public class SystemDialPlanPolicyGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDialPlanPolicyGetResponse>
    {

    }
}
