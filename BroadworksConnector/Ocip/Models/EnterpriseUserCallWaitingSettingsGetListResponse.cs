using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseUserCallWaitingSettingsGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _userCallWaitingTable;

        [XmlElement(ElementName = "userCallWaitingTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable UserCallWaitingTable
        {
            get => _userCallWaitingTable;
            set
            {
                UserCallWaitingTableSpecified = true;
                _userCallWaitingTable = value;
            }
        }

        [XmlIgnore]
        public bool UserCallWaitingTableSpecified { get; set; }
    }
}
