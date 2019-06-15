using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNetworkSynchingServerGetListRequest. The Network Server table column
    /// headings are: "Net Address", "Port", "Description", "Order".
    /// The following columns are only used in XS data mode and not returned in AS data mode:
    /// Order
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// preferredNetworkServerNetAddress
        /// <see cref="SystemNetworkSynchingServerGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkSynchingServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _preferredNetworkServerNetAddress;

        [XmlElement(ElementName = "preferredNetworkServerNetAddress", IsNullable = false, Namespace = "")]
        public string PreferredNetworkServerNetAddress {
            get => _preferredNetworkServerNetAddress;
            set {
                PreferredNetworkServerNetAddressSpecified = true;
                _preferredNetworkServerNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool PreferredNetworkServerNetAddressSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _networkSynchingServerTable;

        [XmlElement(ElementName = "networkSynchingServerTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable NetworkSynchingServerTable {
            get => _networkSynchingServerTable;
            set {
                NetworkSynchingServerTableSpecified = true;
                _networkSynchingServerTable = value;
            }
        }

        [XmlIgnore]
        public bool NetworkSynchingServerTableSpecified { get; set; }
        
    }
}
