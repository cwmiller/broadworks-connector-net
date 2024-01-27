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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:28860""}]")]
    public class SystemPerformanceMeasurementReportingGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemPerformanceMeasurementReportingGetResponse22>
    {

    }
}
