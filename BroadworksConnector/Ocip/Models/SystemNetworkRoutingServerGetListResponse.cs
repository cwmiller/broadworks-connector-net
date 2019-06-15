using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNetworkRoutingServerGetListRequest. The routing Network Server table column
    /// headings are: "Net Address", "Port", "Transport", "Poll", "OpState", "Description".
        /// <see cref="SystemNetworkRoutingServerGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkRoutingServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _networkRoutingServerTable;

        [XmlElement(ElementName = "networkRoutingServerTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable NetworkRoutingServerTable {
            get => _networkRoutingServerTable;
            set {
                NetworkRoutingServerTableSpecified = true;
                _networkRoutingServerTable = value;
            }
        }

        [XmlIgnore]
        public bool NetworkRoutingServerTableSpecified { get; set; }
        
    }
}
