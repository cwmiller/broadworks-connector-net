using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityServiceAccessCodeGetListResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _serviceAccessCodeTable;

    [XmlElement(ElementName = "serviceAccessCodeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceAccessCodeTable {
        get => _serviceAccessCodeTable;
        set {
            ServiceAccessCodeTableSpecified = true;
            _serviceAccessCodeTable = value;
        }
    }

    [XmlIgnore]
    public bool ServiceAccessCodeTableSpecified { get; set; }
}
}
