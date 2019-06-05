using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupBroadWorksAnywhereGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _broadWorksAnywhereTable;

        [XmlElement(ElementName = "broadWorksAnywhereTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable BroadWorksAnywhereTable
        {
            get => _broadWorksAnywhereTable;
            set
            {
                BroadWorksAnywhereTableSpecified = true;
                _broadWorksAnywhereTable = value;
            }
        }

        [XmlIgnore]
        public bool BroadWorksAnywhereTableSpecified { get; set; }
    }
}
