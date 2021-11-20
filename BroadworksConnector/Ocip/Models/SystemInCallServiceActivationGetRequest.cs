using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's DTMF based in-call service activation trigger attributes. The response is either a SystemInCallServiceActivationGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemInCallServiceActivationGetRequest17
    /// <see cref="SystemInCallServiceActivationGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemInCallServiceActivationGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27300""}]")]
    public class SystemInCallServiceActivationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemInCallServiceActivationGetResponse>
    {

    }
}
