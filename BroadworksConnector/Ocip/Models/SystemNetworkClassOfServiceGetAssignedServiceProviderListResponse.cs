using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the
    /// SystemNetworkClassOfServiceGetAssignedServiceProviderListRequest.
    /// The response contains a table of all Service Providers that have
    /// the given Network Class of Service assigned. The column headings are
    /// "Service Provider Id", "Service Provider Name" and "Is Enterprise".
        /// <see cref="SystemNetworkClassOfServiceGetAssignedServiceProviderListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkClassOfServiceGetAssignedServiceProviderListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderTable;

        [XmlElement(ElementName = "serviceProviderTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderTable {
            get => _serviceProviderTable;
            set {
                ServiceProviderTableSpecified = true;
                _serviceProviderTable = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderTableSpecified { get; set; }
        
    }
}
