using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the third-party emergency call service settings for the system.
    /// The response is either a SystemThirdPartyEmergencyCallingGetResponse24 or an ErrorResponse.
    /// <see cref="SystemThirdPartyEmergencyCallingGetResponse24"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18528""}]")]
    public class SystemThirdPartyEmergencyCallingGetRequest24 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
