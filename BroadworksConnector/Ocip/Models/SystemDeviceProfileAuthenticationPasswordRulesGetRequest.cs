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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8572""}]")]
    public class SystemDeviceProfileAuthenticationPasswordRulesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDeviceProfileAuthenticationPasswordRulesGetResponse>
    {

    }
}
