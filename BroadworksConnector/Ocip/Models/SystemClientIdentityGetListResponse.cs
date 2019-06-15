using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemClientIdentityGetListRequest.
    /// Returns a table with column headings:
    /// "Client Identity".
        /// <see cref="SystemClientIdentityGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemClientIdentityGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _clientIdentityTable;

        [XmlElement(ElementName = "clientIdentityTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ClientIdentityTable {
            get => _clientIdentityTable;
            set {
                ClientIdentityTableSpecified = true;
                _clientIdentityTable = value;
            }
        }

        [XmlIgnore]
        public bool ClientIdentityTableSpecified { get; set; }
        
    }
}
