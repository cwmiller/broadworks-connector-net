using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemOCIGetACLListRequest.
    /// Returns a 2 coulmn table with column headings:
    /// "Net Address" and "Description".
        /// <see cref="SystemOCIGetACLListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOCIGetACLListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _aclTable;

        [XmlElement(ElementName = "aclTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AclTable {
            get => _aclTable;
            set {
                AclTableSpecified = true;
                _aclTable = value;
            }
        }

        [XmlIgnore]
        public bool AclTableSpecified { get; set; }
        
    }
}
