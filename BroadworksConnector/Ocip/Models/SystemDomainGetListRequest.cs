using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of all system-level domain names.
    /// The response is either SystemDomainGetListResponse or ErrorResponse.
    /// 
    /// Replaced by SystemDomainGetListRequest22 in AS data mode.
    /// <see cref="SystemDomainGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemDomainGetListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:6279""}]")]
    public class SystemDomainGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
