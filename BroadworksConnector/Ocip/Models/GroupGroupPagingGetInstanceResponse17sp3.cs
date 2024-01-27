using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupGroupPagingGetInstanceRequest17sp3.
    /// Contains the service profile information.
    /// 
    /// Replaced by: GroupGroupPagingGetInstanceResponse19sp1
    /// <see cref="GroupGroupPagingGetInstanceRequest17sp3"/>
    /// <see cref="GroupGroupPagingGetInstanceResponse19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:10268""}]")]
    public class GroupGroupPagingGetInstanceResponse17sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10268")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17 ServiceInstanceProfile
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
        [Group(@"d8f04177e438f303b41c211e518706bf:10268")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:10268")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:10268")]
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

    }
}
