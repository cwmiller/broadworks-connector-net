using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest.
    /// The response contains a table with columns: "Number Range Start", "Number Range End", "User Id",
    /// "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
    /// "Department", "Email Address", "Enterprise Trunk" and "Is Active".
    /// The "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number",
    /// "Extension", "Department" and "Email Address" columns contains the corresponding attributes of the user possessing the number range.
    /// The "Enterprise Trunk" column contains the enterprise trunk the user possessing the number range belongs to.
    /// The "Is Active" column indicates if the number range has been activated.
        /// <see cref="GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _numberRangeSummaryTable;

        [XmlElement(ElementName = "numberRangeSummaryTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable NumberRangeSummaryTable {
            get => _numberRangeSummaryTable;
            set {
                NumberRangeSummaryTableSpecified = true;
                _numberRangeSummaryTable = value;
            }
        }

        [XmlIgnore]
        public bool NumberRangeSummaryTableSpecified { get; set; }
        
    }
}
