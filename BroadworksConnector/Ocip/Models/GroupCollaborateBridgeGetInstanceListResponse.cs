using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCollaborateBridgeGetInstanceListRequest.
    /// Contains a table with column headings: "Service User Id", "Name", "Phone Number", "Extension", "Department", "Participants", and "Is Default".
    /// The column values for "Is default" can either be true, or false.
        /// <see cref="GroupCollaborateBridgeGetInstanceListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCollaborateBridgeGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
