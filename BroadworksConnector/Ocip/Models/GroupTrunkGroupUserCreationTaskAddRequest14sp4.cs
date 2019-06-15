using System;
using System.Xml.Serialization;
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
     
    public class GroupTrunkGroupUserCreationTaskAddRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _trunkGroupKey;

        [XmlElement(ElementName = "trunkGroupKey", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupKey TrunkGroupKey {
            get => _trunkGroupKey;
            set {
                TrunkGroupKeySpecified = true;
                _trunkGroupKey = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupKeySpecified { get; set; }
        
        private string _taskName;

        [XmlElement(ElementName = "taskName", IsNullable = false, Namespace = "")]
        public string TaskName {
            get => _taskName;
            set {
                TaskNameSpecified = true;
                _taskName = value;
            }
        }

        [XmlIgnore]
        public bool TaskNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationUserIdFormat _userIdFormat;

        [XmlElement(ElementName = "userIdFormat", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationUserIdFormat UserIdFormat {
            get => _userIdFormat;
            set {
                UserIdFormatSpecified = true;
                _userIdFormat = value;
            }
        }

        [XmlIgnore]
        public bool UserIdFormatSpecified { get; set; }
        
        private string _userIdDomain;

        [XmlElement(ElementName = "userIdDomain", IsNullable = false, Namespace = "")]
        public string UserIdDomain {
            get => _userIdDomain;
            set {
                UserIdDomainSpecified = true;
                _userIdDomain = value;
            }
        }

        [XmlIgnore]
        public bool UserIdDomainSpecified { get; set; }
        
        private bool _populateExtension;

        [XmlElement(ElementName = "populateExtension", IsNullable = false, Namespace = "")]
        public bool PopulateExtension {
            get => _populateExtension;
            set {
                PopulateExtensionSpecified = true;
                _populateExtension = value;
            }
        }

        [XmlIgnore]
        public bool PopulateExtensionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat _linePortFormat;

        [XmlElement(ElementName = "linePortFormat", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat LinePortFormat {
            get => _linePortFormat;
            set {
                LinePortFormatSpecified = true;
                _linePortFormat = value;
            }
        }

        [XmlIgnore]
        public bool LinePortFormatSpecified { get; set; }
        
        private string _linePortDomain;

        [XmlElement(ElementName = "linePortDomain", IsNullable = false, Namespace = "")]
        public string LinePortDomain {
            get => _linePortDomain;
            set {
                LinePortDomainSpecified = true;
                _linePortDomain = value;
            }
        }

        [XmlIgnore]
        public bool LinePortDomainSpecified { get; set; }
        
        private bool _populateContact;

        [XmlElement(ElementName = "populateContact", IsNullable = false, Namespace = "")]
        public bool PopulateContact {
            get => _populateContact;
            set {
                PopulateContactSpecified = true;
                _populateContact = value;
            }
        }

        [XmlIgnore]
        public bool PopulateContactSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat _contactFormat;

        [XmlElement(ElementName = "contactFormat", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat ContactFormat {
            get => _contactFormat;
            set {
                ContactFormatSpecified = true;
                _contactFormat = value;
            }
        }

        [XmlIgnore]
        public bool ContactFormatSpecified { get; set; }
        
        private string _contactDomain;

        [XmlElement(ElementName = "contactDomain", IsNullable = false, Namespace = "")]
        public string ContactDomain {
            get => _contactDomain;
            set {
                ContactDomainSpecified = true;
                _contactDomain = value;
            }
        }

        [XmlIgnore]
        public bool ContactDomainSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupTrunkGroupUserCreationTaskAddRequest14sp4UserPhoneNumbers _userPhoneNumbers;

        [XmlElement(ElementName = "userPhoneNumbers", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupTrunkGroupUserCreationTaskAddRequest14sp4UserPhoneNumbers UserPhoneNumbers {
            get => _userPhoneNumbers;
            set {
                UserPhoneNumbersSpecified = true;
                _userPhoneNumbers = value;
            }
        }

        [XmlIgnore]
        public bool UserPhoneNumbersSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupTrunkGroupUserCreationTaskAddRequest14sp4UserExtensions _userExtensions;

        [XmlElement(ElementName = "userExtensions", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupTrunkGroupUserCreationTaskAddRequest14sp4UserExtensions UserExtensions {
            get => _userExtensions;
            set {
                UserExtensionsSpecified = true;
                _userExtensions = value;
            }
        }

        [XmlIgnore]
        public bool UserExtensionsSpecified { get; set; }
        
        private List<string> _servicePackName;

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        public List<string> ServicePackName {
            get => _servicePackName;
            set {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackNameSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.UserService> _userService;

        [XmlElement(ElementName = "userService", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.UserService> UserService {
            get => _userService;
            set {
                UserServiceSpecified = true;
                _userService = value;
            }
        }

        [XmlIgnore]
        public bool UserServiceSpecified { get; set; }
        
    }
}
