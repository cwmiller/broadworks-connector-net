using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Dial Plan Policy.
    /// The response is either a SystemDialPlanPolicyGetResponse17 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemDialPlanPolicyGetRequest22 in AS data mode.
    /// <see cref="SystemDialPlanPolicyGetResponse17"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemDialPlanPolicyGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemDialPlanPolicyGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDialPlanPolicyGetResponse17>
    {

    }
}
