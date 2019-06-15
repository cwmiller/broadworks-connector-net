using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseSecurityClassificationCustomizationGetAvailableListRequest.
    /// Returns the available group security classifications.
    /// Contains a table with column headings:
    /// "SystemSecurityClassification", "CustomizedSecurityClassification"
        /// <see cref="EnterpriseSecurityClassificationCustomizationGetAvailableListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseSecurityClassificationCustomizationGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _securityClassificationNameTable;

        [XmlElement(ElementName = "securityClassificationNameTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SecurityClassificationNameTable {
            get => _securityClassificationNameTable;
            set {
                SecurityClassificationNameTableSpecified = true;
                _securityClassificationNameTable = value;
            }
        }

        [XmlIgnore]
        public bool SecurityClassificationNameTableSpecified { get; set; }
        
    }
}
