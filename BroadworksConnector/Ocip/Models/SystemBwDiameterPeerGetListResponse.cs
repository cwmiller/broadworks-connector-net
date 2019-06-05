using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterPeerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _peerTable;

    [XmlElement(ElementName = "peerTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable PeerTable {
        get => _peerTable;
        set {
            PeerTableSpecified = true;
            _peerTable = value;
        }
    }

    [XmlIgnore]
    public bool PeerTableSpecified { get; set; }
}
}
