using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemTreatmentMappingCallBlockingServiceGetListRequest. Contains a table with one row per mapping.
    /// The table columns are: "Service", "Treatment Id".
    /// 
    /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListResponse19sp1 in AS data mode
        /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListRequest"/>
        /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListResponse19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingCallBlockingServiceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
