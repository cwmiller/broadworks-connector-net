using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterRoutingPriorityOrder 
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private decimal _priority;

    [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
    public decimal Priority {
        get => _priority;
        set {
            PrioritySpecified = true;
            _priority = value;
        }
    }

    [XmlIgnore]
    public bool PrioritySpecified { get; set; }
}
}
