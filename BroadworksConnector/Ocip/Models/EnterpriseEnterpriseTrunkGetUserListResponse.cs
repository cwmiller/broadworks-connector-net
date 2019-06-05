using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseEnterpriseTrunkGetUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _enterpriseTrunkUserTable;

        [XmlElement(ElementName = "enterpriseTrunkUserTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable EnterpriseTrunkUserTable
        {
            get => _enterpriseTrunkUserTable;
            set
            {
                EnterpriseTrunkUserTableSpecified = true;
                _enterpriseTrunkUserTable = value;
            }
        }

        [XmlIgnore]
        public bool EnterpriseTrunkUserTableSpecified { get; set; }
    }
}
