using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGETSSessionPriorityMapGetListRequest.
    /// The table columns are: "Priority Level" and "Session Priority Value".
        /// <see cref="SystemGETSSessionPriorityMapGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGETSSessionPriorityMapGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _sessionPriorityTable;

        [XmlElement(ElementName = "sessionPriorityTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SessionPriorityTable {
            get => _sessionPriorityTable;
            set {
                SessionPriorityTableSpecified = true;
                _sessionPriorityTable = value;
            }
        }

        [XmlIgnore]
        public bool SessionPriorityTableSpecified { get; set; }
        
    }
}
