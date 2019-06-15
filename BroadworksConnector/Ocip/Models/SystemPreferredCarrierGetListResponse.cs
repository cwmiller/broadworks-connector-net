using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemPreferredCarrierGetListRequest. Contains a table with one row per carrier.
    /// The table columns are: "Carrier", "Country Code", "CIC", "Is Intra-Lata", "Is Inter-Lata", "Is International".
    /// The value in the "Is Intra-Lata", "Is Inter-Lata", and "Is International" columns is one of "true" or "false".
        /// <see cref="SystemPreferredCarrierGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPreferredCarrierGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _systemCarrierTable;

        [XmlElement(ElementName = "systemCarrierTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SystemCarrierTable {
            get => _systemCarrierTable;
            set {
                SystemCarrierTableSpecified = true;
                _systemCarrierTable = value;
            }
        }

        [XmlIgnore]
        public bool SystemCarrierTableSpecified { get; set; }
        
    }
}
