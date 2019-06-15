using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSecurityClassificationGetClassificationUserUsageListRequest.
    /// Contains a table with column headings:
    /// "User ID", "Last Name", "First Name", "Phone Number", "Extension", "Service Provider Id", "Group Id".
        /// <see cref="SystemSecurityClassificationGetClassificationUserUsageListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSecurityClassificationGetClassificationUserUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _usageTable;

        [XmlElement(ElementName = "usageTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UsageTable {
            get => _usageTable;
            set {
                UsageTableSpecified = true;
                _usageTable = value;
            }
        }

        [XmlIgnore]
        public bool UsageTableSpecified { get; set; }
        
    }
}
