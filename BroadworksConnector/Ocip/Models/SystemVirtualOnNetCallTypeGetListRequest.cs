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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""179b744b0183abe614e8c32c17c96b7e:279""}]")]
    public class SystemVirtualOnNetCallTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
