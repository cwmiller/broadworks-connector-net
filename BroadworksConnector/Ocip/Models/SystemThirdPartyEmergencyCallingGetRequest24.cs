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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18762""}]")]
    public class SystemThirdPartyEmergencyCallingGetRequest24 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemThirdPartyEmergencyCallingGetResponse24>
    {

    }
}
