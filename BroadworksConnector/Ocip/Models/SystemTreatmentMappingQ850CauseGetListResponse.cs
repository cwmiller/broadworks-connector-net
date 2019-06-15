using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemTreatmentMappingQ850CauseGetListRequest. Contains a table with one row per mapping.
    /// The table columns are: "Q850 Cause Value", "Treatment Id".
        /// <see cref="SystemTreatmentMappingQ850CauseGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingQ850CauseGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
