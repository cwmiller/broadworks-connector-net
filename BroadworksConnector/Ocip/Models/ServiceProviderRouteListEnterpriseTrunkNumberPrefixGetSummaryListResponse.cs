using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderRouteListEnterpriseTrunkPrefixGetSummaryListRequest.
    /// The column headings are "Number Prefix", "Group Id" and "Is Active".
        /// <see cref="ServiceProviderRouteListEnterpriseTrunkPrefixGetSummaryListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _prefixSummaryTable;

        [XmlElement(ElementName = "prefixSummaryTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable PrefixSummaryTable {
            get => _prefixSummaryTable;
            set {
                PrefixSummaryTableSpecified = true;
                _prefixSummaryTable = value;
            }
        }

        [XmlIgnore]
        public bool PrefixSummaryTableSpecified { get; set; }
        
    }
}
