using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityServiceAccessCodeGetListRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceAccessCodeListName;

    [XmlElement(ElementName = "serviceAccessCodeListName", IsNullable = false, Namespace = "")]
    public string ServiceAccessCodeListName {
        get => _serviceAccessCodeListName;
        set {
            ServiceAccessCodeListNameSpecified = true;
            _serviceAccessCodeListName = value;
        }
    }

    [XmlIgnore]
    public bool ServiceAccessCodeListNameSpecified { get; set; }
}
}
