using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the authentication lockout settings in the system.
    /// The response is either a SystemAuthenticationLockoutSettingsGetResponse or an ErrorResponse.
    /// <see cref="SystemAuthenticationLockoutSettingsGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2044""}]")]
    public class SystemAuthenticationLockoutSettingsGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
