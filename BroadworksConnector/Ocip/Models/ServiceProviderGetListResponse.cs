using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderGetListRequest.
    /// Contains a 3 column table with column headings "Service Provider Id", "Service Provider Name",
    /// "Is Enterprise" and "Reseller Id" and a row for each service provider or enterprise.
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
    /// <see cref="ServiceProviderGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:4563""}]")]
    public class ServiceProviderGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderTable;

        [XmlElement(ElementName = "serviceProviderTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4563")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderTable
        {
            get => _serviceProviderTable;
            set
            {
                ServiceProviderTableSpecified = true;
                _serviceProviderTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderTableSpecified { get; set; }

    }
}
