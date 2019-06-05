using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _agentTable;

        [XmlElement(ElementName = "agentTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable AgentTable
        {
            get => _agentTable;
            set
            {
                AgentTableSpecified = true;
                _agentTable = value;
            }
        }

        [XmlIgnore]
        public bool AgentTableSpecified { get; set; }
    }
}
