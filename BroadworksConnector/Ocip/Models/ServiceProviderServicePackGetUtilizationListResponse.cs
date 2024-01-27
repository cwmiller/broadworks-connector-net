using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:6297""}]")]
    public class ServiceProviderServicePackGetUtilizationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _servicePackName = new List<string>();

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6297")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> ServicePackName
        {
            get => _servicePackName;
            set
            {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.C.OCITable> _serviceUtilizationTable = new List<BroadWorksConnector.Ocip.Models.C.OCITable>();

        [XmlElement(ElementName = "serviceUtilizationTable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6297")]
        public List<BroadWorksConnector.Ocip.Models.C.OCITable> ServiceUtilizationTable
        {
            get => _serviceUtilizationTable;
            set
            {
                ServiceUtilizationTableSpecified = true;
                _serviceUtilizationTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUtilizationTableSpecified { get; set; }

    }
}
