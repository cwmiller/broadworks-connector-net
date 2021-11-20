using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Hunt Group.
    /// The response is either a SystemHuntGroupGetResponse or an
    /// ErrorResponse.
    /// Replaced by: SystemHuntGroupGetRequest17
    /// <see cref="SystemHuntGroupGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemHuntGroupGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27268""}]")]
    public class SystemHuntGroupGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemHuntGroupGetResponse>
    {

    }
}
