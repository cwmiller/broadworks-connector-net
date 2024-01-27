using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used to sort the GroupCallPickupGetAvailableUserPagedSortedListRequest request.
    /// <see cref="GroupCallPickupGetAvailableUserPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e52f623f7e5f77c5ed7bb6ba0012d5cd:416""}]")]
    public class SortOrderGroupCallPickupGetAvailableUserPagedSortedList
    {

        protected BroadWorksConnector.Ocip.Models.SortByUserId _sortByUserId;

        [XmlElement(ElementName = "sortByUserId", IsNullable = false, Namespace = "")]
        [Group(@"e52f623f7e5f77c5ed7bb6ba0012d5cd:416")]
        public BroadWorksConnector.Ocip.Models.SortByUserId SortByUserId
        {
            get => _sortByUserId;
            set
            {
                SortByUserIdSpecified = true;
                _sortByUserId = value;
            }
        }

        [XmlIgnore]
        protected bool SortByUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByUserLastName _sortByUserLastName;

        [XmlElement(ElementName = "sortByUserLastName", IsNullable = false, Namespace = "")]
        [Group(@"e52f623f7e5f77c5ed7bb6ba0012d5cd:416")]
        public BroadWorksConnector.Ocip.Models.SortByUserLastName SortByUserLastName
        {
            get => _sortByUserLastName;
            set
            {
                SortByUserLastNameSpecified = true;
                _sortByUserLastName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByUserLastNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByUserFirstName _sortByUserFirstName;

        [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false, Namespace = "")]
        [Group(@"e52f623f7e5f77c5ed7bb6ba0012d5cd:416")]
        public BroadWorksConnector.Ocip.Models.SortByUserFirstName SortByUserFirstName
        {
            get => _sortByUserFirstName;
            set
            {
                SortByUserFirstNameSpecified = true;
                _sortByUserFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByUserFirstNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByDn _sortByDn;

        [XmlElement(ElementName = "sortByDn", IsNullable = false, Namespace = "")]
        [Group(@"e52f623f7e5f77c5ed7bb6ba0012d5cd:416")]
        public BroadWorksConnector.Ocip.Models.SortByDn SortByDn
        {
            get => _sortByDn;
            set
            {
                SortByDnSpecified = true;
                _sortByDn = value;
            }
        }

        [XmlIgnore]
        protected bool SortByDnSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByExtension _sortByExtension;

        [XmlElement(ElementName = "sortByExtension", IsNullable = false, Namespace = "")]
        [Group(@"e52f623f7e5f77c5ed7bb6ba0012d5cd:416")]
        public BroadWorksConnector.Ocip.Models.SortByExtension SortByExtension
        {
            get => _sortByExtension;
            set
            {
                SortByExtensionSpecified = true;
                _sortByExtension = value;
            }
        }

        [XmlIgnore]
        protected bool SortByExtensionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByDepartmentName _sortByDepartmentName;

        [XmlElement(ElementName = "sortByDepartmentName", IsNullable = false, Namespace = "")]
        [Group(@"e52f623f7e5f77c5ed7bb6ba0012d5cd:416")]
        public BroadWorksConnector.Ocip.Models.SortByDepartmentName SortByDepartmentName
        {
            get => _sortByDepartmentName;
            set
            {
                SortByDepartmentNameSpecified = true;
                _sortByDepartmentName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByDepartmentNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByEmailAddress _sortByEmailAddress;

        [XmlElement(ElementName = "sortByEmailAddress", IsNullable = false, Namespace = "")]
        [Group(@"e52f623f7e5f77c5ed7bb6ba0012d5cd:416")]
        public BroadWorksConnector.Ocip.Models.SortByEmailAddress SortByEmailAddress
        {
            get => _sortByEmailAddress;
            set
            {
                SortByEmailAddressSpecified = true;
                _sortByEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SortByEmailAddressSpecified { get; set; }

    }
}
