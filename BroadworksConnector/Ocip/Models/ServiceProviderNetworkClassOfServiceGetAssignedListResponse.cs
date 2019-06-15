using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderNetworkClassOfServiceGetAssignedListRequest.
    /// Contains a table of all Network Classes of Service assigned to the
    /// service provider. The column headings are: "Name", "Description" and "Default".
        /// <see cref="ServiceProviderNetworkClassOfServiceGetAssignedListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderNetworkClassOfServiceGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _networkClassOfServiceTable;

        [XmlElement(ElementName = "networkClassOfServiceTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable NetworkClassOfServiceTable {
            get => _networkClassOfServiceTable;
            set {
                NetworkClassOfServiceTableSpecified = true;
                _networkClassOfServiceTable = value;
            }
        }

        [XmlIgnore]
        public bool NetworkClassOfServiceTableSpecified { get; set; }
        
    }
}
