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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14507""}]")]
    public class SystemPerformanceMeasurementReportingGetFileServerListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemPerformanceMeasurementReportingGetFileServerListResponse22>
    {

    }
}
