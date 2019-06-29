using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used to sort the ServiceProviderAdminGetPagedSortedListRequest request.
    /// <see cref="ServiceProviderAdminGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:6019""}]")]
    public class SortOrderServiceProviderAdminGetPagedSortedList
    {

        private BroadWorksConnector.Ocip.Models.SortByAdminId _sortByAdminId;

        [XmlElement(ElementName = "sortByAdminId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6019")]
        public BroadWorksConnector.Ocip.Models.SortByAdminId SortByAdminId
        {
            get => _sortByAdminId;
            set
            {
                SortByAdminIdSpecified = true;
                _sortByAdminId = value;
            }
        }

        [XmlIgnore]
        protected bool SortByAdminIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByAdminLastName _sortByAdminLastName;

        [XmlElement(ElementName = "sortByAdminLastName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6019")]
        public BroadWorksConnector.Ocip.Models.SortByAdminLastName SortByAdminLastName
        {
            get => _sortByAdminLastName;
            set
            {
                SortByAdminLastNameSpecified = true;
                _sortByAdminLastName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByAdminLastNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByAdminFirstName _sortByAdminFirstName;

        [XmlElement(ElementName = "sortByAdminFirstName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6019")]
        public BroadWorksConnector.Ocip.Models.SortByAdminFirstName SortByAdminFirstName
        {
            get => _sortByAdminFirstName;
            set
            {
                SortByAdminFirstNameSpecified = true;
                _sortByAdminFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByAdminFirstNameSpecified { get; set; }

    }
}
