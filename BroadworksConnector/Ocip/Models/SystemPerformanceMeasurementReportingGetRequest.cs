using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the performance measurements reporting settings.
    /// The response is either SystemPerformanceMeasurementReportingGetResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemPerformanceMeasurementReportingGetRequest22
    /// <see cref="SystemPerformanceMeasurementReportingGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemPerformanceMeasurementReportingGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:28845""}]")]
    public class SystemPerformanceMeasurementReportingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemPerformanceMeasurementReportingGetResponse>
    {

    }
}
