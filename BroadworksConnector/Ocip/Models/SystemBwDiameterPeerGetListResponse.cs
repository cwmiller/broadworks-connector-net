using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterPeerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _peerTable;

    [XmlElement(ElementName = "peerTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable PeerTable {
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