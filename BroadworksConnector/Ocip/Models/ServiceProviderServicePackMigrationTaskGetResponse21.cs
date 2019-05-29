using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackMigrationTaskGetResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "taskName", IsNullable = false)]
    public string TaskName { get; set; }
    [XmlElement(ElementName = "startTimestamp", IsNullable = false)]
    public string StartTimestamp { get; set; }
    [XmlElement(ElementName = "actualStartTimestamp", IsNullable = false)]
    public string ActualStartTimestamp { get; set; }
    [XmlElement(ElementName = "expireAfterNumHours", IsNullable = false)]
    public int ExpireAfterNumHours { get; set; }
    [XmlElement(ElementName = "maxDurationHours", IsNullable = false)]
    public int MaxDurationHours { get; set; }
    [XmlElement(ElementName = "sendReportEmail", IsNullable = false)]
    public bool SendReportEmail { get; set; }
    [XmlElement(ElementName = "reportDeliveryEmailAddress", IsNullable = false)]
    public string ReportDeliveryEmailAddress { get; set; }
    [XmlElement(ElementName = "abortOnError", IsNullable = false)]
    public bool AbortOnError { get; set; }
    [XmlElement(ElementName = "abortErrorThreshold", IsNullable = false)]
    public int AbortErrorThreshold { get; set; }
    [XmlElement(ElementName = "reportAllUsers", IsNullable = false)]
    public bool ReportAllUsers { get; set; }
    [XmlElement(ElementName = "automaticallyIncrementServiceQuantity", IsNullable = false)]
    public bool AutomaticallyIncrementServiceQuantity { get; set; }
    [XmlElement(ElementName = "errorCount", IsNullable = false)]
    public int ErrorCount { get; set; }
    [XmlElement(ElementName = "status", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServicePackMigrationTaskStatus21 Status { get; set; }
    [XmlElement(ElementName = "groupsProcessed", IsNullable = false)]
    public int GroupsProcessed { get; set; }
    [XmlElement(ElementName = "groupsTotal", IsNullable = false)]
    public int GroupsTotal { get; set; }
    [XmlElement(ElementName = "usersProcessed", IsNullable = false)]
    public int UsersProcessed { get; set; }
    [XmlElement(ElementName = "usersTotal", IsNullable = false)]
    public int UsersTotal { get; set; }
    [XmlElement(ElementName = "userSelectionType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServicePackMigrationTaskUserSelectionType UserSelectionType { get; set; }
    [XmlElement(ElementName = "reportFilePathName", IsNullable = false)]
    public string ReportFilePathName { get; set; }
    [XmlElement(ElementName = "migrateAllGroups", IsNullable = false)]
    public bool MigrateAllGroups { get; set; }
    [XmlElement(ElementName = "groupTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupTable { get; set; }
    [XmlElement(ElementName = "userSelectionServicePackName", IsNullable = false)]
    public List<string> UserSelectionServicePackName { get; set; }
    [XmlElement(ElementName = "userSelectionServiceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.UserService> UserSelectionServiceName { get; set; }
    [XmlElement(ElementName = "removeServicePackName", IsNullable = false)]
    public List<string> RemoveServicePackName { get; set; }
    [XmlElement(ElementName = "removeServiceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.UserService> RemoveServiceName { get; set; }
    [XmlElement(ElementName = "assignServicePackName", IsNullable = false)]
    public List<string> AssignServicePackName { get; set; }
    [XmlElement(ElementName = "assignServiceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.UserService> AssignServiceName { get; set; }
 }
}
