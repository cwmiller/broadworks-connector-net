using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCommunicationBarringDigitPatternCriteriaGetListRequest.
    /// The response contains a table of all Digit Pattern Criteria defined at the system level. The column headings are "Name" and "Description"
        /// <see cref="SystemCommunicationBarringDigitPatternCriteriaGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringDigitPatternCriteriaGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CriteriaTable {
            get => _criteriaTable;
            set {
                CriteriaTableSpecified = true;
                _criteriaTable = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaTableSpecified { get; set; }
        
    }
}
