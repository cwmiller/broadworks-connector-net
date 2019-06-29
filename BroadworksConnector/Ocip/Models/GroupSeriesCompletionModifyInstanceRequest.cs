using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies a Series Completion group. Replaces the entire list of users in the group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b974dc59b4b32d9f5952a0442ecaefa8:195""}]")]
    public class GroupSeriesCompletionModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"b974dc59b4b32d9f5952a0442ecaefa8:195")]
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
        [Group(@"b974dc59b4b32d9f5952a0442ecaefa8:195")]
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

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"b974dc59b4b32d9f5952a0442ecaefa8:195")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private string _newName;

        [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b974dc59b4b32d9f5952a0442ecaefa8:195")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NewName
        {
            get => _newName;
            set
            {
                NewNameSpecified = true;
                _newName = value;
            }
        }

        [XmlIgnore]
        protected bool NewNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _userIdList;

        [XmlElement(ElementName = "userIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b974dc59b4b32d9f5952a0442ecaefa8:195")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList UserIdList
        {
            get => _userIdList;
            set
            {
                UserIdListSpecified = true;
                _userIdList = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdListSpecified { get; set; }

    }
}
