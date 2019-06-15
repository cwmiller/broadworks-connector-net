using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupHuntGroupGetInstancePagedSortedListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Phone Number", "Is Phone Number Activated",
    /// "Country Code","National Prefix", "Extension", "Department", "Department Type",
    /// "Parent Department", "Parent Department Type", "Is Active", "Policy".
    /// The column values for "Is Active" can either be true, or false.
    /// NOTE: prior to release 14, the policy column did not match the HuntPolicy enumerated type.
        /// <see cref="GroupHuntGroupGetInstancePagedSortedListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupHuntGroupGetInstancePagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _huntGroupTable;

        [XmlElement(ElementName = "huntGroupTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable HuntGroupTable {
            get => _huntGroupTable;
            set {
                HuntGroupTableSpecified = true;
                _huntGroupTable = value;
            }
        }

        [XmlIgnore]
        public bool HuntGroupTableSpecified { get; set; }
        
    }
}
