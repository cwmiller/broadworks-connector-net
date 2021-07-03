using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the third-party emergency call service settings for the system.
    /// The response is either a SystemThirdPartyEmergencyCallingGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemThirdPartyEmergencyCallingGetRequest24
    /// <see cref="SystemThirdPartyEmergencyCallingGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemThirdPartyEmergencyCallingGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35452""}]")]
    public class SystemThirdPartyEmergencyCallingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
