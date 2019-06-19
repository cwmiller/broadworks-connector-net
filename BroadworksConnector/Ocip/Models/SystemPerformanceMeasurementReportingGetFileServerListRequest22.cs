using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list performance measurements reporting ftp servers.
    /// The response is either SystemPerformanceMeasurementReportingGetFileServerListResponse22 or ErrorResponse.
    /// <see cref="SystemPerformanceMeasurementReportingGetFileServerListResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13220""}]")]
    public class SystemPerformanceMeasurementReportingGetFileServerListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
