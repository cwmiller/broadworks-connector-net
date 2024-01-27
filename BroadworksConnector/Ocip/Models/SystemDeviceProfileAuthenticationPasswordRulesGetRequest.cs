using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system level device profile authentication password rule settings.
    /// The response is either a SystemDeviceProfileAuthenticationPasswordRulesGetResponse or an ErrorResponse.
    /// <see cref="SystemDeviceProfileAuthenticationPasswordRulesGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8691""}]")]
    public class SystemDeviceProfileAuthenticationPasswordRulesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDeviceProfileAuthenticationPasswordRulesGetResponse>
    {

    }
}
