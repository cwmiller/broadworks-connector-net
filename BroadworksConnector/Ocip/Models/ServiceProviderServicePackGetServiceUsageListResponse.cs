using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5365""}]")]
    public class ServiceProviderServicePackGetServiceUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceUsageTable;

        [XmlElement(ElementName = "serviceUsageTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5365")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceUsageTable
        {
            get => _serviceUsageTable;
            set
            {
                ServiceUsageTableSpecified = true;
                _serviceUsageTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUsageTableSpecified { get; set; }

    }
}
