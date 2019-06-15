using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderServicePackGetServiceUsageListRequest.
    /// The column headings are "Service Pack Name", "Total Packs" and "Allocated to Groups"
        /// <see cref="ServiceProviderServicePackGetServiceUsageListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderServicePackGetServiceUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceUsageTable;

        [XmlElement(ElementName = "serviceUsageTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceUsageTable {
            get => _serviceUsageTable;
            set {
                ServiceUsageTableSpecified = true;
                _serviceUsageTable = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUsageTableSpecified { get; set; }
        
    }
}
