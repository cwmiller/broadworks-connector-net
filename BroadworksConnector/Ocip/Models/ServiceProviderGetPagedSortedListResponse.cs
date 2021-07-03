using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderGetPagedSortedListRequest.
    /// Contains a table with column headings "Service Provider Id", "Service Provider Name"
    /// and "Is Enterprise", "Reseller Id" and "Service Provider External Id" and a row for each service provider or enterprise.
    /// 
    /// The following columns are only populated in AS data mode:
    /// "Reseller Id",
    /// "Service Provider External Id
    /// <see cref="ServiceProviderGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4529""}]")]
    public class ServiceProviderGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderTable;

        [XmlElement(ElementName = "serviceProviderTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4529")]
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
