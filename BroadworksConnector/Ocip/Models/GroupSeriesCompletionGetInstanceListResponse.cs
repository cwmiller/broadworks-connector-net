using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupSeriesCompletionGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public List<string> Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
}
}
