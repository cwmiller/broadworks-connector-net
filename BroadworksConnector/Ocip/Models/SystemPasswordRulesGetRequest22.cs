using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system's password rules setting applicable to
    /// System administrator, Provisioning Administrator,
    /// and/or Service Provider Administrator, Group Administrator, Department Administrator, user.
    /// The response is either SystemPasswordRulesGetResponse22 or ErrorResponse.
    /// 
    /// Replaced by: SystemPasswordRulesGetRequest23 in AS data mode.
    /// <see cref="SystemPasswordRulesGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemPasswordRulesGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:8811""}]")]
    public class SystemPasswordRulesGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemPasswordRulesGetResponse22>
    {

    }
}
