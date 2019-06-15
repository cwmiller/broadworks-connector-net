using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderServicePackGetUtilizationListRequest.
    /// For each service pack, a table of groups utilizing the pack is returned.
    /// The utilization table column headings are "Group", "Total Packs" and "Assigned".
        /// <see cref="ServiceProviderServicePackGetUtilizationListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderServicePackGetUtilizationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _servicePackName;

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        public List<string> ServicePackName {
            get => _servicePackName;
            set {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackNameSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.C.OCITable> _serviceUtilizationTable;

        [XmlElement(ElementName = "serviceUtilizationTable", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.C.OCITable> ServiceUtilizationTable {
            get => _serviceUtilizationTable;
            set {
                ServiceUtilizationTableSpecified = true;
                _serviceUtilizationTable = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUtilizationTableSpecified { get; set; }
        
    }
}
