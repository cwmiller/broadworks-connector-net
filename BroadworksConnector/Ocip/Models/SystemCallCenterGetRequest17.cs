using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Center.
    /// The response is either a SystemCallCenterGetResponse17 or an
    /// ErrorResponse.
    /// 
    /// Replaced by SystemCallCenterGetRequest17sp4.
    /// <see cref="SystemCallCenterGetResponse17"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallCenterGetRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20782""}]")]
    public class SystemCallCenterGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallCenterGetResponse17>
    {

    }
}
