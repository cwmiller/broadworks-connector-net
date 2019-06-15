using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a 4 column table with column headings 'Instance', 'Realm', 'ApplicationID', and 'Default'.  One row is present for each Diameter routing realm.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBwDiameterRoutingRealmGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _routingRealmTable;

        [XmlElement(ElementName = "routingRealmTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RoutingRealmTable {
            get => _routingRealmTable;
            set {
                RoutingRealmTableSpecified = true;
                _routingRealmTable = value;
            }
        }

        [XmlIgnore]
        public bool RoutingRealmTableSpecified { get; set; }
        
    }
}
