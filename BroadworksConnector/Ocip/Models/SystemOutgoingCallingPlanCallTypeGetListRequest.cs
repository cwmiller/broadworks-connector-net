using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of call types of outgoing calling plan
    /// Response is SystemOutgoingCallingPlanCallTypeGetListRequest or ErrorResponse.
    /// <see cref="SystemOutgoingCallingPlanCallTypeGetListRequest"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:914""}]")]
    public class SystemOutgoingCallingPlanCallTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemOutgoingCallingPlanCallTypeGetListResponse>
    {

    }
}
