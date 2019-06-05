using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseCallCenterAgentThresholdProfileGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _profilesTable;

        [XmlElement(ElementName = "profilesTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable ProfilesTable
        {
            get => _profilesTable;
            set
            {
                ProfilesTableSpecified = true;
                _profilesTable = value;
            }
        }

        [XmlIgnore]
        public bool ProfilesTableSpecified { get; set; }
    }
}
