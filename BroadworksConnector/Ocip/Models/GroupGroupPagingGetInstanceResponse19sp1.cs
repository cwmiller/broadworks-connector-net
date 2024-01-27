using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupGroupPagingGetInstanceRequest19sp1.
    /// Contains the service profile information.
    /// 
    /// The following element is only used in AS data mode and not returned in XS data mode :
    /// networkClassOfService
    /// <see cref="GroupGroupPagingGetInstanceRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8ede928f2a9c1318573ba9c7a105655c:315""}]")]
    public class GroupGroupPagingGetInstanceResponse19sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:315")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile
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
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:315")]
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
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:315")]
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
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:315")]
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
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:315")]
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
