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
    /// The response is either SystemPasswordRulesGetResponse16 or ErrorResponse.
    /// 
    /// Replaced by: SystemPasswordRulesGetRequest22 in AS data mode.
    /// <see cref="SystemPasswordRulesGetResponse16"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemPasswordRulesGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:6340""}]")]
    public class SystemPasswordRulesGetRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
