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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:6263""}]")]
    public class ServiceProviderServicePackGetServiceUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _serviceUsageTable;

        [XmlElement(ElementName = "serviceUsageTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6263")]
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
