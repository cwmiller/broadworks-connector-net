using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAutoAttendantGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _autoAttendantTable;

        [XmlElement(ElementName = "autoAttendantTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable AutoAttendantTable
        {
            get => _autoAttendantTable;
            set
            {
                AutoAttendantTableSpecified = true;
                _autoAttendantTable = value;
            }
        }

        [XmlIgnore]
        public bool AutoAttendantTableSpecified { get; set; }
    }
}
