using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the broadworks mobility system parameters.
    /// The response is either a SystemBroadWorksMobilityGetResponse22V2 or an ErrorResponse.
    /// 
    /// Replaced by SystemBroadWorksMobilityGetRequest22V3.
    /// <see cref="SystemBroadWorksMobilityGetResponse22V2"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemBroadWorksMobilityGetRequest22V3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20209""}]")]
    public class SystemBroadWorksMobilityGetRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
