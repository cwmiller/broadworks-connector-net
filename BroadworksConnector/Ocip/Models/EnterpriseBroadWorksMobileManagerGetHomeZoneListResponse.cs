using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseBroadWorksMobileManagerGetHomeZoneListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _homeZonesTable;

        [XmlElement(ElementName = "homeZonesTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable HomeZonesTable
        {
            get => _homeZonesTable;
            set
            {
                HomeZonesTableSpecified = true;
                _homeZonesTable = value;
            }
        }

        [XmlIgnore]
        public bool HomeZonesTableSpecified { get; set; }
    }
}
