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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9198""}]")]
    public class SystemDialPlanPolicyGetAccessCodeListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDialPlanPolicyGetAccessCodeListResponse>
    {

    }
}
