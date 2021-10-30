using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with session audit.
    /// The response is either a SystemSessionAuditGetResponse or an
    /// ErrorResponse.
    /// Replaced By: SystemSessionAuditGetRequest14sp3
    /// <see cref="SystemSessionAuditGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSessionAuditGetRequest14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:29252""}]")]
    public class SystemSessionAuditGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSessionAuditGetResponse>
    {

    }
}
