using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAutoAttendantSubmenuGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _submenuTable;

        [XmlElement(ElementName = "submenuTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable SubmenuTable
        {
            get => _submenuTable;
            set
            {
                SubmenuTableSpecified = true;
                _submenuTable = value;
            }
        }

        [XmlIgnore]
        public bool SubmenuTableSpecified { get; set; }
    }
}
