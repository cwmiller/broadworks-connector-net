using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderOfficeZoneUnassignListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _officeZoneName;

    [XmlElement(ElementName = "officeZoneName", IsNullable = false, Namespace = "")]
    public List<string> OfficeZoneName {
        get => _officeZoneName;
        set {
            OfficeZoneNameSpecified = true;
            _officeZoneName = value;
        }
    }

    [XmlIgnore]
    public bool OfficeZoneNameSpecified { get; set; }
    private string _defaultOfficeZoneName;

    [XmlElement(ElementName = "defaultOfficeZoneName", IsNullable = false, Namespace = "")]
    public string DefaultOfficeZoneName {
        get => _defaultOfficeZoneName;
        set {
            DefaultOfficeZoneNameSpecified = true;
            _defaultOfficeZoneName = value;
        }
    }

    [XmlIgnore]
    public bool DefaultOfficeZoneNameSpecified { get; set; }
}
}
