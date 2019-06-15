using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupFindMeFollowMeGetAlertingGroupListRequest.
    /// Contains a table with column headings:
    /// "Name", "Priority".
        /// <see cref="GroupFindMeFollowMeGetAlertingGroupListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupFindMeFollowMeGetAlertingGroupListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _alertingGroupTable;

        [XmlElement(ElementName = "alertingGroupTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AlertingGroupTable {
            get => _alertingGroupTable;
            set {
                AlertingGroupTableSpecified = true;
                _alertingGroupTable = value;
            }
        }

        [XmlIgnore]
        public bool AlertingGroupTableSpecified { get; set; }
        
    }
}
