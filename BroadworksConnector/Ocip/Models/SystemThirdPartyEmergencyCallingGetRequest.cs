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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:36173""}]")]
    public class SystemThirdPartyEmergencyCallingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemThirdPartyEmergencyCallingGetResponse>
    {

    }
}
