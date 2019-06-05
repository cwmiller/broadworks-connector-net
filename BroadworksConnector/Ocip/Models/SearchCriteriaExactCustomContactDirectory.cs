using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactCustomContactDirectory : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private string _customContactDirectoryName;

    [XmlElement(ElementName = "customContactDirectoryName", IsNullable = false, Namespace = "")]
    public string CustomContactDirectoryName {
        get => _customContactDirectoryName;
        set {
            CustomContactDirectoryNameSpecified = true;
            _customContactDirectoryName = value;
        }
    }

    [XmlIgnore]
    public bool CustomContactDirectoryNameSpecified { get; set; }
}
}
