using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactVirtualOnNetCallTypeName : BroadWorksConnector.Ocip.Models.SearchCriteria
{
    private string _virtualOnNetCallTypeName;

    [XmlElement(ElementName = "virtualOnNetCallTypeName", IsNullable = false, Namespace = "")]
    public string VirtualOnNetCallTypeName {
        get => _virtualOnNetCallTypeName;
        set {
            VirtualOnNetCallTypeNameSpecified = true;
            _virtualOnNetCallTypeName = value;
        }
    }

    [XmlIgnore]
    public bool VirtualOnNetCallTypeNameSpecified { get; set; }
}
}
