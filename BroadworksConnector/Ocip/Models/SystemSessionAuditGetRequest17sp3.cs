using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with session audit.
    /// The response is either a SystemSessionAuditGetResponse17sp3 or
    /// an ErrorResponse.
    /// 
    /// Replaced by: SystemSessionAuditGetRequest23 in AS data mode.
    /// <see cref="SystemSessionAuditGetResponse17sp3"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSessionAuditGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:11524""}]")]
    public class SystemSessionAuditGetRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSessionAuditGetResponse17sp3>
    {

    }
}
