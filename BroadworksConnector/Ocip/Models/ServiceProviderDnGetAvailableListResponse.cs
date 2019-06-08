using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDnGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _availableDn;

    [XmlElement(ElementName = "availableDn", IsNullable = false, Namespace = "")]
    public List<string> AvailableDn {
        get => _availableDn;
        set {
            AvailableDnSpecified = true;
            _availableDn = value;
        }
    }

    [XmlIgnore]
    public bool AvailableDnSpecified { get; set; }
}
}
