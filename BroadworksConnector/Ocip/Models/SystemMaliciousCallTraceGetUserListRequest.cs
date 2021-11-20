using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the list of users that use the Malicious Call Trace feature.
    /// The response is either a SystemMaliciousCallTraceGetUserListResponse or an
    /// ErrorResponse.
    /// Replaced By: SystemMaliciousCallTraceGetRequest
    /// <see cref="SystemMaliciousCallTraceGetUserListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemMaliciousCallTraceGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27572""}]")]
    public class SystemMaliciousCallTraceGetUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemMaliciousCallTraceGetUserListResponse>
    {

    }
}
