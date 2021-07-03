using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the Trunk Group service.
    /// The response is either SystemTrunkGroupGetResponse19sp1 or ErrorResponse.
    /// Replaced by: SystemTrunkGroupGetRequest21
    /// <see cref="SystemTrunkGroupGetResponse19sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemTrunkGroupGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35780""}]")]
    public class SystemTrunkGroupGetRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
