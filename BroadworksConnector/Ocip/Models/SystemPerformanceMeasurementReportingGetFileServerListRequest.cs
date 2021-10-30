using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list performance measurements reporting ftp servers.
    /// The response is either SystemPerformanceMeasurementReportingGetFileServerListResponse or ErrorResponse.
    /// <see cref="SystemPerformanceMeasurementReportingGetFileServerListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:28295""}]")]
    public class SystemPerformanceMeasurementReportingGetFileServerListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemPerformanceMeasurementReportingGetFileServerListResponse>
    {

    }
}
