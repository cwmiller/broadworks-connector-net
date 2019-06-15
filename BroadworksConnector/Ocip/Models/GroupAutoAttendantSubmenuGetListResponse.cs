using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupAutoAttendantSubmenuGetListRequest.
    /// Contains a table with column headings:
    /// "Submenu Id" "Is Used".
    /// The column values for "Is Used" can either be true, or false.
        /// <see cref="GroupAutoAttendantSubmenuGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAutoAttendantSubmenuGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _submenuTable;

        [XmlElement(ElementName = "submenuTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SubmenuTable {
            get => _submenuTable;
            set {
                SubmenuTableSpecified = true;
                _submenuTable = value;
            }
        }

        [XmlIgnore]
        public bool SubmenuTableSpecified { get; set; }
        
    }
}
