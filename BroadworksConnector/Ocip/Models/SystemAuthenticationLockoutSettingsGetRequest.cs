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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2507""}]")]
    public class SystemAuthenticationLockoutSettingsGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAuthenticationLockoutSettingsGetResponse>
    {

    }
}
