using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the Trunk Group service.
    /// The response is either SystemTrunkGroupGetResponse22 or ErrorResponse.
    /// 
    /// Replaced by: SystemTrunkGroupGetRequest23
    /// <see cref="SystemTrunkGroupGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemTrunkGroupGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35812""}]")]
    public class SystemTrunkGroupGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
