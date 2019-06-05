using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactServiceProviderAdminType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminType _type;

    [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminType Type {
        get => _type;
        set {
            TypeSpecified = true;
            _type = value;
        }
    }

    [XmlIgnore]
    public bool TypeSpecified { get; set; }
}
}
