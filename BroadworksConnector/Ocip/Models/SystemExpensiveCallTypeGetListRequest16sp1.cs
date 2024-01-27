using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of expensive alternate call indicators in the system.
    /// The response is either a SystemExpensiveCallTypeGetListResponse16sp1
    /// or an ErrorResponse.
    /// <see cref="SystemExpensiveCallTypeGetListResponse16sp1"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9997""}]")]
    public class SystemExpensiveCallTypeGetListRequest16sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemExpensiveCallTypeGetListResponse16sp1>
    {

    }
}
