using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list Virtual On-Net Call Types in the system.
    /// The response is either a SystemVirtualOnNetCallTypeGetListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemVirtualOnNetCallTypeGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ef8bc875d664cdc920228d455073e594:277""}]")]
    public class SystemVirtualOnNetCallTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemVirtualOnNetCallTypeGetListResponse>
    {

    }
}
