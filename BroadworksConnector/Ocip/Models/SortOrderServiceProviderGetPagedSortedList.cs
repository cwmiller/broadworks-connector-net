using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used to sort the ServiceProviderGetPagedSortedListRequest request.
    /// <see cref="ServiceProviderGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:7210""}]")]
    public class SortOrderServiceProviderGetPagedSortedList
    {

        private BroadWorksConnector.Ocip.Models.SortByServiceProviderId _sortByServiceProviderId;

        [XmlElement(ElementName = "sortByServiceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:7210")]
        public BroadWorksConnector.Ocip.Models.SortByServiceProviderId SortByServiceProviderId
        {
            get => _sortByServiceProviderId;
            set
            {
                SortByServiceProviderIdSpecified = true;
                _sortByServiceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool SortByServiceProviderIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByServiceProviderName _sortByServiceProviderName;

        [XmlElement(ElementName = "sortByServiceProviderName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:7210")]
        public BroadWorksConnector.Ocip.Models.SortByServiceProviderName SortByServiceProviderName
        {
            get => _sortByServiceProviderName;
            set
            {
                SortByServiceProviderNameSpecified = true;
                _sortByServiceProviderName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByServiceProviderNameSpecified { get; set; }

    }
}
