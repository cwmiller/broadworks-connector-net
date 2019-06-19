using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of call types of outgoing calling plan
    /// The response is SystemOutgoingCallingPlanCallTypeGetListResponse or ErrorResponse.
    /// <see cref="SystemOutgoingCallingPlanCallTypeGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:910""}]")]
    public class SystemOutgoingCallingPlanCallTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
