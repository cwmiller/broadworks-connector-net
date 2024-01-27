using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a user creation task for a trunk group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1469"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1480""}]}]")]
    public class GroupTrunkGroupUserCreationTaskAddRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.TrunkGroupKey _trunkGroupKey;

        [XmlElement(ElementName = "trunkGroupKey", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1469")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupKey TrunkGroupKey
        {
            get => _trunkGroupKey;
            set
            {
                TrunkGroupKeySpecified = true;
                _trunkGroupKey = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupKeySpecified { get; set; }

        protected string _taskName;

        [XmlElement(ElementName = "taskName", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1469")]
        [MinLength(1)]
        [MaxLength(80)]
        public string TaskName
        {
            get => _taskName;
            set
            {
                TaskNameSpecified = true;
                _taskName = value;
            }
        }

        [XmlIgnore]
        protected bool TaskNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationUserIdFormat _userIdFormat;

        [XmlElement(ElementName = "userIdFormat", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1469")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationUserIdFormat UserIdFormat
        {
            get => _userIdFormat;
            set
            {
                UserIdFormatSpecified = true;
                _userIdFormat = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdFormatSpecified { get; set; }

        protected string _userIdDomain;

        [XmlElement(ElementName = "userIdDomain", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1469")]
        [MinLength(1)]
        [MaxLength(80)]
        public string UserIdDomain
        {
            get => _userIdDomain;
            set
            {
                UserIdDomainSpecified = true;
                _userIdDomain = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdDomainSpecified { get; set; }

        protected bool _populateExtension;

        [XmlElement(ElementName = "populateExtension", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1469")]
        public bool PopulateExtension
        {
            get => _populateExtension;
            set
            {
                PopulateExtensionSpecified = true;
                _populateExtension = value;
            }
        }

        [XmlIgnore]
        protected bool PopulateExtensionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat _linePortFormat;

        [XmlElement(ElementName = "linePortFormat", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1469")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat LinePortFormat
        {
            get => _linePortFormat;
            set
            {
                LinePortFormatSpecified = true;
                _linePortFormat = value;
            }
        }

        [XmlIgnore]
        protected bool LinePortFormatSpecified { get; set; }

        protected string _linePortDomain;

        [XmlElement(ElementName = "linePortDomain", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1469")]
        [MinLength(1)]
        [MaxLength(80)]
        public string LinePortDomain
        {
            get => _linePortDomain;
            set
            {
                LinePortDomainSpecified = true;
                _linePortDomain = value;
            }
        }

        [XmlIgnore]
        protected bool LinePortDomainSpecified { get; set; }

        protected bool _populateContact;

        [XmlElement(ElementName = "populateContact", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1469")]
        public bool PopulateContact
        {
            get => _populateContact;
            set
            {
                PopulateContactSpecified = true;
                _populateContact = value;
            }
        }

        [XmlIgnore]
        protected bool PopulateContactSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat _contactFormat;

        [XmlElement(ElementName = "contactFormat", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1469")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat ContactFormat
        {
            get => _contactFormat;
            set
            {
                ContactFormatSpecified = true;
                _contactFormat = value;
            }
        }

        [XmlIgnore]
        protected bool ContactFormatSpecified { get; set; }

        protected string _contactDomain;

        [XmlElement(ElementName = "contactDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1469")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ContactDomain
        {
            get => _contactDomain;
            set
            {
                ContactDomainSpecified = true;
                _contactDomain = value;
            }
        }

        [XmlIgnore]
        protected bool ContactDomainSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupTrunkGroupUserCreationTaskAddRequest14sp4UserPhoneNumbers _userPhoneNumbers;

        [XmlElement(ElementName = "userPhoneNumbers", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1480")]
        public BroadWorksConnector.Ocip.Models.GroupTrunkGroupUserCreationTaskAddRequest14sp4UserPhoneNumbers UserPhoneNumbers
        {
            get => _userPhoneNumbers;
            set
            {
                UserPhoneNumbersSpecified = true;
                _userPhoneNumbers = value;
            }
        }

        [XmlIgnore]
        protected bool UserPhoneNumbersSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupTrunkGroupUserCreationTaskAddRequest14sp4UserExtensions _userExtensions;

        [XmlElement(ElementName = "userExtensions", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1480")]
        public BroadWorksConnector.Ocip.Models.GroupTrunkGroupUserCreationTaskAddRequest14sp4UserExtensions UserExtensions
        {
            get => _userExtensions;
            set
            {
                UserExtensionsSpecified = true;
                _userExtensions = value;
            }
        }

        [XmlIgnore]
        protected bool UserExtensionsSpecified { get; set; }

        protected List<string> _servicePackName = new List<string>();

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1469")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> ServicePackName
        {
            get => _servicePackName;
            set
            {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.UserService> _userService = new List<BroadWorksConnector.Ocip.Models.UserService>();

        [XmlElement(ElementName = "userService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1469")]
        public List<BroadWorksConnector.Ocip.Models.UserService> UserService
        {
            get => _userService;
            set
            {
                UserServiceSpecified = true;
                _userService = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceSpecified { get; set; }

    }
}
