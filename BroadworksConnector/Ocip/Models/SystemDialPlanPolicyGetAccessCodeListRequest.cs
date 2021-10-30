using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level Access Codes data associated with Dial Plan Policy.
    /// The response is either a SystemDialPlanPolicyGetAccessCodeListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemDialPlanPolicyGetAccessCodeListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9074""}]")]
    public class SystemDialPlanPolicyGetAccessCodeListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDialPlanPolicyGetAccessCodeListResponse>
    {

    }
}
