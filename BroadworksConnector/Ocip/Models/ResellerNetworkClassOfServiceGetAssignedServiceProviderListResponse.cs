using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequest.
    /// Contains a table of Service Providers that have the Network Class of Service
    /// assigned. The column headings are: "Service Provider Id" and "Service Provider Name".
        /// <see cref="ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _spTable;

        [XmlElement(ElementName = "spTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SpTable {
            get => _spTable;
            set {
                SpTableSpecified = true;
                _spTable = value;
            }
        }

        [XmlIgnore]
        public bool SpTableSpecified { get; set; }
        
    }
}
