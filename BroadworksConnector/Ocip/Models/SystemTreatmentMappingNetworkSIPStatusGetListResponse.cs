using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemTreatmentMappingNetworkSIPStatusGetListRequest. Contains a table with one row per mapping.
    /// The table columns are: "SIP Status Code", "Treatment Id".
        /// <see cref="SystemTreatmentMappingNetworkSIPStatusGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingNetworkSIPStatusGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _treatmentMappingTable;

        [XmlElement(ElementName = "treatmentMappingTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TreatmentMappingTable {
            get => _treatmentMappingTable;
            set {
                TreatmentMappingTableSpecified = true;
                _treatmentMappingTable = value;
            }
        }

        [XmlIgnore]
        public bool TreatmentMappingTableSpecified { get; set; }
        
    }
}
