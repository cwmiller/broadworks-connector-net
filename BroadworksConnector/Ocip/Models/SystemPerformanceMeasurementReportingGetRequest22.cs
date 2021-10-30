using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the performance measurements reporting settings.
    /// The response is either SystemPerformanceMeasurementReportingGetResponse22 or ErrorResponse.
    /// Replaced by: SystemPerformanceMeasurementReportingGetRequest24
    /// <see cref="SystemPerformanceMeasurementReportingGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemPerformanceMeasurementReportingGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:28342""}]")]
    public class SystemPerformanceMeasurementReportingGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemPerformanceMeasurementReportingGetResponse22>
    {

    }
}
