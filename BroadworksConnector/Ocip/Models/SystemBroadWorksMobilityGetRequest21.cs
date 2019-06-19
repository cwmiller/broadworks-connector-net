using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the broadworks mobility system parameters.
    /// The response is either a SystemBroadWorksMobilityGetResponse21 or an ErrorResponse.
    /// 
    /// Replaced by: SystemBroadWorksMobilityGetRequest22 in AS data mode
    /// <see cref="SystemBroadWorksMobilityGetResponse21"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemBroadWorksMobilityGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:37119""}]")]
    public class SystemBroadWorksMobilityGetRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
