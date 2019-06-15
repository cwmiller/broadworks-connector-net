using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAlternateUserIdGetListRequest.
    /// The "User Type" column contains the corresponding enumerated UserType value.
    /// Contains a table of alternate user ids, the column headings are:
    /// "User Id", "Alternate User Id", "Group Id", "Organization Id", "Reseller Id" and "User Type".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
        /// <see cref="SystemAlternateUserIdGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAlternateUserIdGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _alternateUserIdTable;

        [XmlElement(ElementName = "alternateUserIdTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AlternateUserIdTable {
            get => _alternateUserIdTable;
            set {
                AlternateUserIdTableSpecified = true;
                _alternateUserIdTable = value;
            }
        }

        [XmlIgnore]
        public bool AlternateUserIdTableSpecified { get; set; }
        
    }
}
