using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDomainGetAssignedServiceProviderListRequest.
    /// The table columns are: "Service Provider Id", "Service Provider Name", "Is Enterprise" and "Reseller Id".
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
        /// <see cref="SystemDomainGetAssignedServiceProviderListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDomainGetAssignedServiceProviderListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
