using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupFindMeFollowMeGetInstanceListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Phone Number", "Extension", "Department", "Is Active".
    /// The column value for "Is Active" can either be true, or false.
        /// <see cref="GroupFindMeFollowMeGetInstanceListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupFindMeFollowMeGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _findMeFollowMeTable;

        [XmlElement(ElementName = "findMeFollowMeTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable FindMeFollowMeTable {
            get => _findMeFollowMeTable;
            set {
                FindMeFollowMeTableSpecified = true;
                _findMeFollowMeTable = value;
            }
        }

        [XmlIgnore]
        public bool FindMeFollowMeTableSpecified { get; set; }
        
    }
}
