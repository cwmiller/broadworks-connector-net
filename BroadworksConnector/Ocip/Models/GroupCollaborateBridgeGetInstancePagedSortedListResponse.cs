using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCollaborateBridgeGetInstancePagedSortedListRequest.
    /// Contains a table with column headings: "Service User Id", "Name", "Phone Number", "Is Phone Number Activated",
    /// "Country Code","National Prefix", "Extension", "Department", "Department Type",
    /// "Parent Department", "Parent Department Type", "Participants", "Is Default", "Max Room Participants",
    /// "Is Support Outdial".
    /// The column values for "Is default", "Is Support Outdial" can either be true, or false.
        /// <see cref="GroupCollaborateBridgeGetInstancePagedSortedListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCollaborateBridgeGetInstancePagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _collaborateBridgeTable;

        [XmlElement(ElementName = "collaborateBridgeTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CollaborateBridgeTable {
            get => _collaborateBridgeTable;
            set {
                CollaborateBridgeTableSpecified = true;
                _collaborateBridgeTable = value;
            }
        }

        [XmlIgnore]
        public bool CollaborateBridgeTableSpecified { get; set; }
        
    }
}
