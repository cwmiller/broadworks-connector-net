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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5399""}]")]
    public class ServiceProviderServicePackGetUtilizationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _servicePackName = new List<string>();

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5399")]
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

        private List<BroadWorksConnector.Ocip.Models.C.OCITable> _serviceUtilizationTable = new List<BroadWorksConnector.Ocip.Models.C.OCITable>();

        [XmlElement(ElementName = "serviceUtilizationTable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5399")]
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
