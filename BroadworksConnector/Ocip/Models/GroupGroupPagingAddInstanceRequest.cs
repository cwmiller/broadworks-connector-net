using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Group Paging instance to a group.
    /// The domain is required in the serviceUserId.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// The following element is only used in AS data mode and ignored in XS data mode:
    /// networkClassOfService
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8ede928f2a9c1318573ba9c7a105655c:66""}]")]
    public class GroupGroupPagingAddInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:66")]
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
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:66")]
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

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:66")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:66")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceProfileSpecified { get; set; }

        protected int _confirmationToneTimeoutSeconds;

        [XmlElement(ElementName = "confirmationToneTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:66")]
        [MinInclusive(1)]
        [MaxInclusive(20)]
        public int ConfirmationToneTimeoutSeconds
        {
            get => _confirmationToneTimeoutSeconds;
            set
            {
                ConfirmationToneTimeoutSecondsSpecified = true;
                _confirmationToneTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ConfirmationToneTimeoutSecondsSpecified { get; set; }

        protected bool _deliverOriginatorCLIDInstead;

        [XmlElement(ElementName = "deliverOriginatorCLIDInstead", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:66")]
        public bool DeliverOriginatorCLIDInstead
        {
            get => _deliverOriginatorCLIDInstead;
            set
            {
                DeliverOriginatorCLIDInsteadSpecified = true;
                _deliverOriginatorCLIDInstead = value;
            }
        }

        [XmlIgnore]
        protected bool DeliverOriginatorCLIDInsteadSpecified { get; set; }

        protected string _originatorCLIDPrefix;

        [XmlElement(ElementName = "originatorCLIDPrefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:66")]
        [MinLength(1)]
        [MaxLength(30)]
        public string OriginatorCLIDPrefix
        {
            get => _originatorCLIDPrefix;
            set
            {
                OriginatorCLIDPrefixSpecified = true;
                _originatorCLIDPrefix = value;
            }
        }

        [XmlIgnore]
        protected bool OriginatorCLIDPrefixSpecified { get; set; }

        protected string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:66")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceSpecified { get; set; }

    }
}
