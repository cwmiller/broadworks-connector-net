using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of Call Center Reporting Server.
    /// The response is either SystemCallCenterReportingServerGetListResponse or ErrorResponse.
    /// <see cref="SystemCallCenterReportingServerGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20975""}]")]
    public class SystemCallCenterReportingServerGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
