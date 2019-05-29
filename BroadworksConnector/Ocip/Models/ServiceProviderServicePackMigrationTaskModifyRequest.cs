using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackMigrationTaskModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "taskName", IsNullable = false)]
    public string TaskName { get; set; }
    [XmlElement(ElementName = "newTaskName", IsNullable = false)]
    public string NewTaskName { get; set; }
    [XmlElement(ElementName = "startTimestamp", IsNullable = false)]
    public string StartTimestamp { get; set; }
    [XmlElement(ElementName = "expireAfterNumHours", IsNullable = false)]
    public int ExpireAfterNumHours { get; set; }
    [XmlElement(ElementName = "maxDurationHours", IsNullable = false)]
    public int MaxDurationHours { get; set; }
    [XmlElement(ElementName = "sendReportEmail", IsNullable = false)]
    public bool SendReportEmail { get; set; }
    [XmlElement(ElementName = "reportDeliveryEmailAddress", IsNullable = true)]
    public string ReportDeliveryEmailAddress { get; set; }
    [XmlElement(ElementName = "abortOnError", IsNullable = false)]
    public bool AbortOnError { get; set; }
    [XmlElement(ElementName = "abortErrorThreshold", IsNullable = true)]
    public int? AbortErrorThreshold { get; set; }
    [XmlElement(ElementName = "reportAllUsers", IsNullable = false)]
    public bool ReportAllUsers { get; set; }
    [XmlElement(ElementName = "automaticallyIncrementServiceQuantity", IsNullable = false)]
    public bool AutomaticallyIncrementServiceQuantity { get; set; }
 }
}
