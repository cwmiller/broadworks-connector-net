using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of available access devices for assignment to a user
    /// within a group. The list includes devices created at the system, service provider, and group levels.
    /// The response is either GroupAccessDeviceGetAvailableDetailListResponse14 or
    /// ErrorResponse.
    /// 
    /// Replaced by: GroupAccessDeviceGetAvailableDetailListRequest19.
    /// <see cref="GroupAccessDeviceGetAvailableDetailListResponse14"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupAccessDeviceGetAvailableDetailListRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:3087""}]")]
    public class GroupAccessDeviceGetAvailableDetailListRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse14>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:3087")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:3087")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        protected bool _isMusicOnHold;

        [XmlElement(ElementName = "isMusicOnHold", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:3087")]
        public bool IsMusicOnHold
        {
            get => _isMusicOnHold;
            set
            {
                IsMusicOnHoldSpecified = true;
                _isMusicOnHold = value;
            }
        }

        [XmlIgnore]
        protected bool IsMusicOnHoldSpecified { get; set; }

        protected bool _onlyVideoCapable;

        [XmlElement(ElementName = "onlyVideoCapable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:3087")]
        public bool OnlyVideoCapable
        {
            get => _onlyVideoCapable;
            set
            {
                OnlyVideoCapableSpecified = true;
                _onlyVideoCapable = value;
            }
        }

        [XmlIgnore]
        protected bool OnlyVideoCapableSpecified { get; set; }

    }
}
