using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of expensive alternate call indicators in the system.
    /// The response is either a SystemExpensiveCallTypeGetListResponse or an ErrorResponse.
    /// Replaced by: SystemExpensiveCallTypeGetListRequest16sp1
    /// <see cref="SystemExpensiveCallTypeGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemExpensiveCallTypeGetListRequest16sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:15314""}]")]
    public class SystemExpensiveCallTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
