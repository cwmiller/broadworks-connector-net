using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used to sort the EnterprisePhoneDirectoryGetPagedSortedListRequest request.
    /// <see cref="EnterprisePhoneDirectoryGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:1678""}]")]
    public class SortOrderEnterprisePhoneDirectoryGetPagedSortedList
    {

        private BroadWorksConnector.Ocip.Models.SortByUserLastName _sortByUserLastName;

        [XmlElement(ElementName = "sortByUserLastName", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1678")]
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

        private BroadWorksConnector.Ocip.Models.SortByUserFirstName _sortByUserFirstName;

        [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1678")]
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

        private BroadWorksConnector.Ocip.Models.SortByGroupLocationCode _sortByGroupLocationCode;

        [XmlElement(ElementName = "sortByGroupLocationCode", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1678")]
        public BroadWorksConnector.Ocip.Models.SortByGroupLocationCode SortByGroupLocationCode
        {
            get => _sortByGroupLocationCode;
            set
            {
                SortByGroupLocationCodeSpecified = true;
                _sortByGroupLocationCode = value;
            }
        }

        [XmlIgnore]
        protected bool SortByGroupLocationCodeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByMobilePhoneNumber _sortByMobilePhoneNumber;

        [XmlElement(ElementName = "sortByMobilePhoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1678")]
        public BroadWorksConnector.Ocip.Models.SortByMobilePhoneNumber SortByMobilePhoneNumber
        {
            get => _sortByMobilePhoneNumber;
            set
            {
                SortByMobilePhoneNumberSpecified = true;
                _sortByMobilePhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SortByMobilePhoneNumberSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByEmailAddress _sortByEmailAddress;

        [XmlElement(ElementName = "sortByEmailAddress", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1678")]
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

        private BroadWorksConnector.Ocip.Models.SortByDepartmentName _sortByDepartmentName;

        [XmlElement(ElementName = "sortByDepartmentName", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1678")]
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

        private BroadWorksConnector.Ocip.Models.SortByGroupName _sortByGroupName;

        [XmlElement(ElementName = "sortByGroupName", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1678")]
        public BroadWorksConnector.Ocip.Models.SortByGroupName SortByGroupName
        {
            get => _sortByGroupName;
            set
            {
                SortByGroupNameSpecified = true;
                _sortByGroupName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByGroupNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByYahooId _sortByYahooId;

        [XmlElement(ElementName = "sortByYahooId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1678")]
        public BroadWorksConnector.Ocip.Models.SortByYahooId SortByYahooId
        {
            get => _sortByYahooId;
            set
            {
                SortByYahooIdSpecified = true;
                _sortByYahooId = value;
            }
        }

        [XmlIgnore]
        protected bool SortByYahooIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByUserId _sortByUserId;

        [XmlElement(ElementName = "sortByUserId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1678")]
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

        private BroadWorksConnector.Ocip.Models.SortByImpId _sortByImpId;

        [XmlElement(ElementName = "sortByImpId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1678")]
        public BroadWorksConnector.Ocip.Models.SortByImpId SortByImpId
        {
            get => _sortByImpId;
            set
            {
                SortByImpIdSpecified = true;
                _sortByImpId = value;
            }
        }

        [XmlIgnore]
        protected bool SortByImpIdSpecified { get; set; }

    }
}
