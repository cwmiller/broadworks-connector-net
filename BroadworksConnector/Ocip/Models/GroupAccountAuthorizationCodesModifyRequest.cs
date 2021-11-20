using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Change the group's account/authorization codes setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""65df37199ec43e5d21a187db39d63158:196""}]")]
    public class GroupAccountAuthorizationCodesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"65df37199ec43e5d21a187db39d63158:196")]
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
        [Group(@"65df37199ec43e5d21a187db39d63158:196")]
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

        private BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeType _codeType;

        [XmlElement(ElementName = "codeType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"65df37199ec43e5d21a187db39d63158:196")]
        public BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeType CodeType
        {
            get => _codeType;
            set
            {
                CodeTypeSpecified = true;
                _codeType = value;
            }
        }

        [XmlIgnore]
        protected bool CodeTypeSpecified { get; set; }

        private int _numberOfDigits;

        [XmlElement(ElementName = "numberOfDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"65df37199ec43e5d21a187db39d63158:196")]
        [MinInclusive(2)]
        [MaxInclusive(14)]
        public int NumberOfDigits
        {
            get => _numberOfDigits;
            set
            {
                NumberOfDigitsSpecified = true;
                _numberOfDigits = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfDigitsSpecified { get; set; }

        private bool _allowLocalAndTollFreeCalls;

        [XmlElement(ElementName = "allowLocalAndTollFreeCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"65df37199ec43e5d21a187db39d63158:196")]
        public bool AllowLocalAndTollFreeCalls
        {
            get => _allowLocalAndTollFreeCalls;
            set
            {
                AllowLocalAndTollFreeCallsSpecified = true;
                _allowLocalAndTollFreeCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AllowLocalAndTollFreeCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _mandatoryUsageUserIdList;

        [XmlElement(ElementName = "mandatoryUsageUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"65df37199ec43e5d21a187db39d63158:196")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList MandatoryUsageUserIdList
        {
            get => _mandatoryUsageUserIdList;
            set
            {
                MandatoryUsageUserIdListSpecified = true;
                _mandatoryUsageUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool MandatoryUsageUserIdListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _optionalUsageUserIdList;

        [XmlElement(ElementName = "optionalUsageUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"65df37199ec43e5d21a187db39d63158:196")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList OptionalUsageUserIdList
        {
            get => _optionalUsageUserIdList;
            set
            {
                OptionalUsageUserIdListSpecified = true;
                _optionalUsageUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool OptionalUsageUserIdListSpecified { get; set; }

    }
}
