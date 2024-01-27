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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fcf43b3a58ff66521262b4426bab8748:196""}]")]
    public class GroupAccountAuthorizationCodesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"fcf43b3a58ff66521262b4426bab8748:196")]
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
        [Group(@"fcf43b3a58ff66521262b4426bab8748:196")]
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

        protected BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeType _codeType;

        [XmlElement(ElementName = "codeType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fcf43b3a58ff66521262b4426bab8748:196")]
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

        protected int _numberOfDigits;

        [XmlElement(ElementName = "numberOfDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fcf43b3a58ff66521262b4426bab8748:196")]
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

        protected bool _allowLocalAndTollFreeCalls;

        [XmlElement(ElementName = "allowLocalAndTollFreeCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fcf43b3a58ff66521262b4426bab8748:196")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _mandatoryUsageUserIdList;

        [XmlElement(ElementName = "mandatoryUsageUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fcf43b3a58ff66521262b4426bab8748:196")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _optionalUsageUserIdList;

        [XmlElement(ElementName = "optionalUsageUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fcf43b3a58ff66521262b4426bab8748:196")]
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
