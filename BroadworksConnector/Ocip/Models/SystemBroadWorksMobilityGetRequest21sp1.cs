using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the broadworks mobility system parameters.
    /// The response is either a SystemBroadWorksMobilityGetResponse21sp1 or an ErrorResponse.
    /// 
    /// Replaced by SystemBroadWorksMobilityGetRequest22V2.
    /// <see cref="SystemBroadWorksMobilityGetResponse21sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemBroadWorksMobilityGetRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:41557""}]")]
    public class SystemBroadWorksMobilityGetRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
