using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOfficeZoneGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private List<string> _zoneName;

    [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
    public List<string> ZoneName {
        get => _zoneName;
        set {
            ZoneNameSpecified = true;
            _zoneName = value;
        }
    }

    [XmlIgnore]
    public bool ZoneNameSpecified { get; set; }
    private string _primaryZoneName;

    [XmlElement(ElementName = "primaryZoneName", IsNullable = false, Namespace = "")]
    public string PrimaryZoneName {
        get => _primaryZoneName;
        set {
            PrimaryZoneNameSpecified = true;
            _primaryZoneName = value;
        }
    }

    [XmlIgnore]
    public bool PrimaryZoneNameSpecified { get; set; }
}
}
