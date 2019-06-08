using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderCommunicationBarringProfileGetCriteriaUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _profileTable;

    [XmlElement(ElementName = "profileTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ProfileTable {
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
