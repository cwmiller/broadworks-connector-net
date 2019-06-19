using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Center.
    /// The response is either a SystemCallCenterGetResponse14sp9 or an
    /// ErrorResponse.
    /// 
    /// Replaced By: SystemCallCenterGetRequest16
    /// <see cref="SystemCallCenterGetResponse14sp9"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallCenterGetRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:9984""}]")]
    public class SystemCallCenterGetRequest14sp9 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
