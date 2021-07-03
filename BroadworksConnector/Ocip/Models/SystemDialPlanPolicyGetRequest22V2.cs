using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Dial Plan Policy.
    /// The response is either a SystemDialPlanPolicyGetResponse22V2 or an
    /// ErrorResponse.
    /// <see cref="SystemDialPlanPolicyGetResponse22V2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemDialPlanPolicyGetRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
