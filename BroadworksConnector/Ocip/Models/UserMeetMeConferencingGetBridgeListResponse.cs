using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserMeetMeConferencingGetBridgeListRequest.
    /// Contains a table with column headings: "Bridge Id", "Name", "Phone Number", "Extension", "Ports", and "Is Active"
    /// The column values for "Is Active" can either be true, or false.
        /// <see cref="UserMeetMeConferencingGetBridgeListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserMeetMeConferencingGetBridgeListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _conferenceBridgeTable;

        [XmlElement(ElementName = "conferenceBridgeTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceBridgeTable {
            get => _conferenceBridgeTable;
            set {
                ConferenceBridgeTableSpecified = true;
                _conferenceBridgeTable = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceBridgeTableSpecified { get; set; }
        
    }
}
