using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkSynchingServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _preferredNetworkServerNetAddress;

    [XmlElement(ElementName = "preferredNetworkServerNetAddress", IsNullable = false, Namespace = "")]
    public string PreferredNetworkServerNetAddress {
        get => _preferredNetworkServerNetAddress;
        set {
            PreferredNetworkServerNetAddressSpecified = true;
            _preferredNetworkServerNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool PreferredNetworkServerNetAddressSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _networkSynchingServerTable;

    [XmlElement(ElementName = "networkSynchingServerTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable NetworkSynchingServerTable {
        get => _networkSynchingServerTable;
        set {
            NetworkSynchingServerTableSpecified = true;
            _networkSynchingServerTable = value;
        }
    }

    [XmlIgnore]
    public bool NetworkSynchingServerTableSpecified { get; set; }
}
}
