using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Center.
    /// The response is either a SystemCallCenterGetResponse19 or an
    /// ErrorResponse.
    /// Replaced by SystemCallCenterGetRequest21.
    /// <see cref="SystemCallCenterGetResponse19"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallCenterGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20815""}]")]
    public class SystemCallCenterGetRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
