using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system Emergency Call DDos Protection configurations.
    /// The response is either SystemEmergencyCallDDoSProtectionGetResponse or ErrorResponse.
    /// <see cref="SystemEmergencyCallDDoSProtectionGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9762""}]")]
    public class SystemEmergencyCallDDoSProtectionGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemEmergencyCallDDoSProtectionGetResponse>
    {

    }
}
