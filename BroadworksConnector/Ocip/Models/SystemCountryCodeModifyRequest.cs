using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the attributes of a country code.
    /// If becomeDefaultCountryCode is true, the country code
    /// in this request becomes the default country code for the system.
    /// The following elements are only used in AS data mode:
    /// disableNationalPrefixForOffNetCalls
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6944""}]")]
    public class SystemCountryCodeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6944")]
        [MaxLength(3)]
        [RegularExpression(@"[0-9]|[1-9][0-9]{1,2}")]
        public string CountryCode
        {
            get => _countryCode;
            set
            {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        protected bool CountryCodeSpecified { get; set; }

        protected int _ringPeriodMilliseconds;

        [XmlElement(ElementName = "ringPeriodMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6944")]
        [MinInclusive(1)]
        [MaxInclusive(12000)]
        public int RingPeriodMilliseconds
        {
            get => _ringPeriodMilliseconds;
            set
            {
                RingPeriodMillisecondsSpecified = true;
                _ringPeriodMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool RingPeriodMillisecondsSpecified { get; set; }

        protected int _offHookWarningTimerSeconds;

        [XmlElement(ElementName = "offHookWarningTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6944")]
        [MinInclusive(1)]
        [MaxInclusive(360)]
        public int OffHookWarningTimerSeconds
        {
            get => _offHookWarningTimerSeconds;
            set
            {
                OffHookWarningTimerSecondsSpecified = true;
                _offHookWarningTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool OffHookWarningTimerSecondsSpecified { get; set; }

        protected bool _enableNationalPrefix;

        [XmlElement(ElementName = "enableNationalPrefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6944")]
        public bool EnableNationalPrefix
        {
            get => _enableNationalPrefix;
            set
            {
                EnableNationalPrefixSpecified = true;
                _enableNationalPrefix = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNationalPrefixSpecified { get; set; }

        protected string _nationalPrefix;

        [XmlElement(ElementName = "nationalPrefix", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6944")]
        [MinLength(1)]
        [MaxLength(2)]
        public string NationalPrefix
        {
            get => _nationalPrefix;
            set
            {
                NationalPrefixSpecified = true;
                _nationalPrefix = value;
            }
        }

        [XmlIgnore]
        protected bool NationalPrefixSpecified { get; set; }

        protected bool _becomeDefaultCountryCode;

        [XmlElement(ElementName = "becomeDefaultCountryCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6944")]
        public bool BecomeDefaultCountryCode
        {
            get => _becomeDefaultCountryCode;
            set
            {
                BecomeDefaultCountryCodeSpecified = true;
                _becomeDefaultCountryCode = value;
            }
        }

        [XmlIgnore]
        protected bool BecomeDefaultCountryCodeSpecified { get; set; }

        protected int _maxCallWaitingTones;

        [XmlElement(ElementName = "maxCallWaitingTones", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6944")]
        [MinInclusive(1)]
        [MaxInclusive(20)]
        public int MaxCallWaitingTones
        {
            get => _maxCallWaitingTones;
            set
            {
                MaxCallWaitingTonesSpecified = true;
                _maxCallWaitingTones = value;
            }
        }

        [XmlIgnore]
        protected bool MaxCallWaitingTonesSpecified { get; set; }

        protected int _timeBetweenCallWaitingTonesMilliseconds;

        [XmlElement(ElementName = "timeBetweenCallWaitingTonesMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6944")]
        [MinInclusive(0)]
        [MaxInclusive(120000)]
        public int TimeBetweenCallWaitingTonesMilliseconds
        {
            get => _timeBetweenCallWaitingTonesMilliseconds;
            set
            {
                TimeBetweenCallWaitingTonesMillisecondsSpecified = true;
                _timeBetweenCallWaitingTonesMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool TimeBetweenCallWaitingTonesMillisecondsSpecified { get; set; }

        protected bool _disableNationalPrefixForOffNetCalls;

        [XmlElement(ElementName = "disableNationalPrefixForOffNetCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6944")]
        public bool DisableNationalPrefixForOffNetCalls
        {
            get => _disableNationalPrefixForOffNetCalls;
            set
            {
                DisableNationalPrefixForOffNetCallsSpecified = true;
                _disableNationalPrefixForOffNetCalls = value;
            }
        }

        [XmlIgnore]
        protected bool DisableNationalPrefixForOffNetCallsSpecified { get; set; }

    }
}
