using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the broadworks mobility system parameters.
    /// The response is either a SystemBroadWorksMobilityGetResponse17sp4 or an ErrorResponse.
    /// Replaced by: SystemBroadWorksMobilityGetRequest19sp1
    /// <see cref="SystemBroadWorksMobilityGetResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemBroadWorksMobilityGetRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20114""}]")]
    public class SystemBroadWorksMobilityGetRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
