using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a list of authorization codes to the group's default or a department. When department is not
    /// specified, it is for the group default.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:193""}]")]
    public class GroupOutgoingCallingPlanDepartmentAuthorizationCodeAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:193")]
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
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:193")]
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

        protected BroadWorksConnector.Ocip.Models.DepartmentKey _departmentKey;

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:193")]
        public BroadWorksConnector.Ocip.Models.DepartmentKey DepartmentKey
        {
            get => _departmentKey;
            set
            {
                DepartmentKeySpecified = true;
                _departmentKey = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentKeySpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry> _codeEntry = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry>();

        [XmlElement(ElementName = "codeEntry", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:193")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry> CodeEntry
        {
            get => _codeEntry;
            set
            {
                CodeEntrySpecified = true;
                _codeEntry = value;
            }
        }

        [XmlIgnore]
        protected bool CodeEntrySpecified { get; set; }

    }
}
