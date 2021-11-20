using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Dial Plan Policy.
    /// The response is either a SystemDialPlanPolicyGetResponse22 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemDialPlanPolicyGetRequest22V2 in AS data mode.
    /// <see cref="SystemDialPlanPolicyGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemDialPlanPolicyGetRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemDialPlanPolicyGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDialPlanPolicyGetResponse22>
    {

    }
}
