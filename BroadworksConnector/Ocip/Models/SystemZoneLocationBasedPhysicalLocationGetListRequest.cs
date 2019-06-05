using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemZoneLocationBasedPhysicalLocationGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _zoneName;

    [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
    public string ZoneName {
        get => _zoneName;
        set {
            ZoneNameSpecified = true;
            _zoneName = value;
        }
    }

    [XmlIgnore]
    public bool ZoneNameSpecified { get; set; }
    private int _responseSizeLimit;

    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
    public int ResponseSizeLimit {
        get => _responseSizeLimit;
        set {
            ResponseSizeLimitSpecified = true;
            _responseSizeLimit = value;
        }
    }

    [XmlIgnore]
    public bool ResponseSizeLimitSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaPhysicalLocation> _searchCriteriaPhysicalLocation;

    [XmlElement(ElementName = "searchCriteriaPhysicalLocation", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaPhysicalLocation> SearchCriteriaPhysicalLocation {
        get => _searchCriteriaPhysicalLocation;
        set {
            SearchCriteriaPhysicalLocationSpecified = true;
            _searchCriteriaPhysicalLocation = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaPhysicalLocationSpecified { get; set; }
}
}
