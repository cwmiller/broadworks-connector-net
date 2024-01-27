using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system level SIP authentication password rule settings.
    /// The response is either a SystemSIPAuthenticationPasswordRulesGetResponse or an ErrorResponse.
    /// <see cref="SystemSIPAuthenticationPasswordRulesGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16824""}]")]
    public class SystemSIPAuthenticationPasswordRulesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSIPAuthenticationPasswordRulesGetResponse>
    {

    }
}
