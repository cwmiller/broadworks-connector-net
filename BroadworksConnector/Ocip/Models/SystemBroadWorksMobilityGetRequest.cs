using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the broadworks mobility system parameters.
    /// The response is either a SystemBroadWorksMobilityGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemBroadWorksMobilityGetRequest17sp4.
    /// <see cref="SystemBroadWorksMobilityGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemBroadWorksMobilityGetRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20099""}]")]
    public class SystemBroadWorksMobilityGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
