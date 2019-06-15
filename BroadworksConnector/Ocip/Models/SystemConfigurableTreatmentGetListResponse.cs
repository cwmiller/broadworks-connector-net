using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemConfigurableTreatmentGetListRequest. Contains a table with one row per treatment.
    /// The table columns are: "Treatment Id", "Description".
        /// <see cref="SystemConfigurableTreatmentGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemConfigurableTreatmentGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _treatmentTable;

        [XmlElement(ElementName = "treatmentTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TreatmentTable {
            get => _treatmentTable;
            set {
                TreatmentTableSpecified = true;
                _treatmentTable = value;
            }
        }

        [XmlIgnore]
        public bool TreatmentTableSpecified { get; set; }
        
    }
}
