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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:10319""}]")]
    public class SystemDomainGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDomainGetListResponse>
    {

    }
}
