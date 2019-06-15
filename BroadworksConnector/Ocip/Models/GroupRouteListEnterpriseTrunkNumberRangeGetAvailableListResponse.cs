using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest.
    /// Contains a list of number ranges that are assigned to a group and still available for assignment to users within the group.
    /// The column headings are "Number Range Start", "Number Range End" and "Is Active".
        /// <see cref="GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _availableNumberRangeTable;

        [XmlElement(ElementName = "availableNumberRangeTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AvailableNumberRangeTable {
            get => _availableNumberRangeTable;
            set {
                AvailableNumberRangeTableSpecified = true;
                _availableNumberRangeTable = value;
            }
        }

        [XmlIgnore]
        public bool AvailableNumberRangeTableSpecified { get; set; }
        
    }
}
