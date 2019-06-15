using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAdminGetPagedSortedListRequest.
    /// Contains a 7 column table with column headings "Administrator ID",
    /// "Last Name", "First Name", "Administrator Type", "Language", "Locale" and "Encoding".
    /// The following columns are only returned in AS data mode:
    /// "Locale" and "Encoding".
        /// <see cref="ServiceProviderAdminGetPagedSortedListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderAdminGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderAdminTable;

        [XmlElement(ElementName = "serviceProviderAdminTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderAdminTable {
            get => _serviceProviderAdminTable;
            set {
                ServiceProviderAdminTableSpecified = true;
                _serviceProviderAdminTable = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderAdminTableSpecified { get; set; }
        
    }
}
