using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackMigrationTaskDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _taskName;

    [XmlElement(ElementName = "taskName", IsNullable = false, Namespace = "")]
    public string TaskName {
        get => _taskName;
        set {
            TaskNameSpecified = true;
            _taskName = value;
        }
    }

    [XmlIgnore]
    public bool TaskNameSpecified { get; set; }
}
}
