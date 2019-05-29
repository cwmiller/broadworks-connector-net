using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPerformanceMeasurementReportingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "reportingInterval", IsNullable = false)]
    public int ReportingInterval { get; set; }
    [XmlElement(ElementName = "resetMeasurementsAfterEachReport", IsNullable = false)]
    public bool ResetMeasurementsAfterEachReport { get; set; }
    [XmlElement(ElementName = "reportEnterprise", IsNullable = false)]
    public bool ReportEnterprise { get; set; }
    [XmlElement(ElementName = "reportServiceProvider", IsNullable = false)]
    public bool ReportServiceProvider { get; set; }
    [XmlElement(ElementName = "reportDevice", IsNullable = false)]
    public bool ReportDevice { get; set; }
 }
}
