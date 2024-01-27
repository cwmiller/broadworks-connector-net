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
    /// 
    /// The following elements are used in AS mode and ignored in XS data mode:
    /// onlyIntelligentDevice
    /// 
    /// The response is either GroupAccessDeviceGetAvailableDetailListResponse19 or
    /// ErrorResponse.
    /// <see cref="GroupAccessDeviceGetAvailableDetailListResponse19"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:749""}]")]
    public class GroupAccessDeviceGetAvailableDetailListRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse19>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:749")]
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
        [Group(@"4b0e7857796c636464362260a2f8e5ee:749")]
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
        [Group(@"4b0e7857796c636464362260a2f8e5ee:749")]
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
        [Group(@"4b0e7857796c636464362260a2f8e5ee:749")]
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

        protected bool _onlyIntelligentDevice;

        [XmlElement(ElementName = "onlyIntelligentDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:749")]
        public bool OnlyIntelligentDevice
        {
            get => _onlyIntelligentDevice;
            set
            {
                OnlyIntelligentDeviceSpecified = true;
                _onlyIntelligentDevice = value;
            }
        }

        [XmlIgnore]
        protected bool OnlyIntelligentDeviceSpecified { get; set; }

    }
}
