using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOfficeZoneGetAssignedServiceProviderListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _officeZoneName;

    [XmlElement(ElementName = "officeZoneName", IsNullable = false, Namespace = "")]
    public string OfficeZoneName {
        get => _officeZoneName;
        set {
            OfficeZoneNameSpecified = true;
            _officeZoneName = value;
        }
    }

    [XmlIgnore]
    public bool OfficeZoneNameSpecified { get; set; }
}
}
