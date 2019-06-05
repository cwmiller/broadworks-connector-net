using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderCommunicationBarringProfileGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _profileTable;

    [XmlElement(ElementName = "profileTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ProfileTable {
        get => _profileTable;
        set {
            ProfileTableSpecified = true;
            _profileTable = value;
        }
    }

    [XmlIgnore]
    public bool ProfileTableSpecified { get; set; }
}
}
