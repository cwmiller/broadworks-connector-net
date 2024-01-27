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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:27089""}]")]
    public class SystemExpensiveCallTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemExpensiveCallTypeGetListResponse>
    {

    }
}
