using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Center.
    /// The response is either a SystemCallCenterGetResponse17sp4 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallCenterGetRequest19
    /// <see cref="SystemCallCenterGetResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallCenterGetRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20799""}]")]
    public class SystemCallCenterGetRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallCenterGetResponse17sp4>
    {

    }
}
