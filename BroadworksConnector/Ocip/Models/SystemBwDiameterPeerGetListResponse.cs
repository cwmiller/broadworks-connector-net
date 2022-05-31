using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a 6 column table with column headings 'Instance', 'Identity', 'IP Address', 'Port', 'Enabled' and 'Secure'. One row is present for each peer.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2760""}]")]
    public class SystemBwDiameterPeerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _peerTable;

        [XmlElement(ElementName = "peerTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2760")]
        public BroadWorksConnector.Ocip.Models.C.OCITable PeerTable
        {
            get => _peerTable;
            set
            {
                PeerTableSpecified = true;
                _peerTable = value;
            }
        }

        [XmlIgnore]
        protected bool PeerTableSpecified { get; set; }

    }
}
