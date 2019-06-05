using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaUserPersonalMultiPartPhoneListName : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private List<string> _value;

    [XmlElement(ElementName = "value", IsNullable = false, Namespace = "")]
    public List<string> Value {
        get => _value;
        set {
            ValueSpecified = true;
            _value = value;
        }
    }

    [XmlIgnore]
    public bool ValueSpecified { get; set; }
    private bool _isCaseInsensitive;

    [XmlElement(ElementName = "isCaseInsensitive", IsNullable = false, Namespace = "")]
    public bool IsCaseInsensitive {
        get => _isCaseInsensitive;
        set {
            IsCaseInsensitiveSpecified = true;
            _isCaseInsensitive = value;
        }
    }

    [XmlIgnore]
    public bool IsCaseInsensitiveSpecified { get; set; }
}
}
