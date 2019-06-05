using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCapacityManagementGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _callCapacityGroupTable;

        [XmlElement(ElementName = "callCapacityGroupTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable CallCapacityGroupTable
        {
            get => _callCapacityGroupTable;
            set
            {
                CallCapacityGroupTableSpecified = true;
                _callCapacityGroupTable = value;
            }
        }

        [XmlIgnore]
        public bool CallCapacityGroupTableSpecified { get; set; }
    }
}
