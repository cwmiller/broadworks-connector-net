using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAdminGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _groupAdminTable;

        [XmlElement(ElementName = "groupAdminTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable GroupAdminTable
        {
            get => _groupAdminTable;
            set
            {
                GroupAdminTableSpecified = true;
                _groupAdminTable = value;
            }
        }

        [XmlIgnore]
        public bool GroupAdminTableSpecified { get; set; }
    }
}
