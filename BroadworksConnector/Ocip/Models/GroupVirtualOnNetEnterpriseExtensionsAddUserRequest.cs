using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Adds Virtual On-Net users to a Group. It is possible to add
    /// either: a single user,  or a list of users, or a range of users,
    /// or any combination thereof.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""179b744b0183abe614e8c32c17c96b7e:97""}]")]
    public class GroupVirtualOnNetEnterpriseExtensionsAddUserRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:97")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:97")]
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

        private List<BroadWorksConnector.Ocip.Models.VirtualOnNetUser> _virtualOnNetUser = new List<BroadWorksConnector.Ocip.Models.VirtualOnNetUser>();

        [XmlElement(ElementName = "virtualOnNetUser", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:97")]
        public List<BroadWorksConnector.Ocip.Models.VirtualOnNetUser> VirtualOnNetUser
        {
            get => _virtualOnNetUser;
            set
            {
                VirtualOnNetUserSpecified = true;
                _virtualOnNetUser = value;
            }
        }

        [XmlIgnore]
        protected bool VirtualOnNetUserSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.VirtualOnNetUserRange> _virtualOnNetUserRange = new List<BroadWorksConnector.Ocip.Models.VirtualOnNetUserRange>();

        [XmlElement(ElementName = "virtualOnNetUserRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:97")]
        public List<BroadWorksConnector.Ocip.Models.VirtualOnNetUserRange> VirtualOnNetUserRange
        {
            get => _virtualOnNetUserRange;
            set
            {
                VirtualOnNetUserRangeSpecified = true;
                _virtualOnNetUserRange = value;
            }
        }

        [XmlIgnore]
        protected bool VirtualOnNetUserRangeSpecified { get; set; }

    }
}
