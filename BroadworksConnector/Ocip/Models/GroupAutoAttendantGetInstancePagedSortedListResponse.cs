using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupAutoAttendantGetInstancePagedSortedListRequest.
    /// The response contains a table with columns:
    /// "Service User Id", "Name", "Phone Number", "Is Phone Number Activated", "Country Code",
    /// "National Prefix", "Extension", "Department", "Department Type", "Parent Department",
    /// "Parent Department Type", "Is Active", "Type".
    /// The column values for "Is Active" can either be true, or false.
    /// The column values for "Type" can either be Basic or Standard.
    /// The "Department Type" and "Parent Department Type" columns will contain the values "Enterprise" or "Group".
    /// 
    /// In XS Mode the value for the "Type" column will always be populated with Basic.
        /// <see cref="GroupAutoAttendantGetInstancePagedSortedListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAutoAttendantGetInstancePagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _autoAttendantTable;

        [XmlElement(ElementName = "autoAttendantTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AutoAttendantTable {
            get => _autoAttendantTable;
            set {
                AutoAttendantTableSpecified = true;
                _autoAttendantTable = value;
            }
        }

        [XmlIgnore]
        public bool AutoAttendantTableSpecified { get; set; }
        
    }
}
