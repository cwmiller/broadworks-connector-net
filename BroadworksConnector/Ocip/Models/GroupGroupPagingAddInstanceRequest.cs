using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Group Paging instance to a group.
    /// The domain is required in the serviceUserId.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupGroupPagingAddInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile {
            get => _serviceInstanceProfile;
            set {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }
        
        private int _confirmationToneTimeoutSeconds;

        [XmlElement(ElementName = "confirmationToneTimeoutSeconds", IsNullable = false, Namespace = "")]
        public int ConfirmationToneTimeoutSeconds {
            get => _confirmationToneTimeoutSeconds;
            set {
                ConfirmationToneTimeoutSecondsSpecified = true;
                _confirmationToneTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool ConfirmationToneTimeoutSecondsSpecified { get; set; }
        
        private bool _deliverOriginatorCLIDInstead;

        [XmlElement(ElementName = "deliverOriginatorCLIDInstead", IsNullable = false, Namespace = "")]
        public bool DeliverOriginatorCLIDInstead {
            get => _deliverOriginatorCLIDInstead;
            set {
                DeliverOriginatorCLIDInsteadSpecified = true;
                _deliverOriginatorCLIDInstead = value;
            }
        }

        [XmlIgnore]
        public bool DeliverOriginatorCLIDInsteadSpecified { get; set; }
        
        private string _originatorCLIDPrefix;

        [XmlElement(ElementName = "originatorCLIDPrefix", IsNullable = false, Namespace = "")]
        public string OriginatorCLIDPrefix {
            get => _originatorCLIDPrefix;
            set {
                OriginatorCLIDPrefixSpecified = true;
                _originatorCLIDPrefix = value;
            }
        }

        [XmlIgnore]
        public bool OriginatorCLIDPrefixSpecified { get; set; }
        
        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        public string NetworkClassOfService {
            get => _networkClassOfService;
            set {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        public bool NetworkClassOfServiceSpecified { get; set; }
        
    }
}
