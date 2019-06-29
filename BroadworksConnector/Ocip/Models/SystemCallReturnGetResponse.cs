using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallReturnGetRequest.
    /// <see cref="SystemCallReturnGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ca38ce43363a73a1079bbf73920b7a45:55""}]")]
    public class SystemCallReturnGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _twoLevelActivation;

        [XmlElement(ElementName = "twoLevelActivation", IsNullable = false, Namespace = "")]
        [Group(@"ca38ce43363a73a1079bbf73920b7a45:55")]
        public bool TwoLevelActivation
        {
            get => _twoLevelActivation;
            set
            {
                TwoLevelActivationSpecified = true;
                _twoLevelActivation = value;
            }
        }

        [XmlIgnore]
        protected bool TwoLevelActivationSpecified { get; set; }

        private bool _provideDate;

        [XmlElement(ElementName = "provideDate", IsNullable = false, Namespace = "")]
        [Group(@"ca38ce43363a73a1079bbf73920b7a45:55")]
        public bool ProvideDate
        {
            get => _provideDate;
            set
            {
                ProvideDateSpecified = true;
                _provideDate = value;
            }
        }

        [XmlIgnore]
        protected bool ProvideDateSpecified { get; set; }

        private bool _lastUnansweredCallOnly;

        [XmlElement(ElementName = "lastUnansweredCallOnly", IsNullable = false, Namespace = "")]
        [Group(@"ca38ce43363a73a1079bbf73920b7a45:55")]
        public bool LastUnansweredCallOnly
        {
            get => _lastUnansweredCallOnly;
            set
            {
                LastUnansweredCallOnlySpecified = true;
                _lastUnansweredCallOnly = value;
            }
        }

        [XmlIgnore]
        protected bool LastUnansweredCallOnlySpecified { get; set; }

        private string _confirmationKey;

        [XmlElement(ElementName = "confirmationKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ca38ce43363a73a1079bbf73920b7a45:55")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ConfirmationKey
        {
            get => _confirmationKey;
            set
            {
                ConfirmationKeySpecified = true;
                _confirmationKey = value;
            }
        }

        [XmlIgnore]
        protected bool ConfirmationKeySpecified { get; set; }

        private bool _allowRestrictedNumber;

        [XmlElement(ElementName = "allowRestrictedNumber", IsNullable = false, Namespace = "")]
        [Group(@"ca38ce43363a73a1079bbf73920b7a45:55")]
        public bool AllowRestrictedNumber
        {
            get => _allowRestrictedNumber;
            set
            {
                AllowRestrictedNumberSpecified = true;
                _allowRestrictedNumber = value;
            }
        }

        [XmlIgnore]
        protected bool AllowRestrictedNumberSpecified { get; set; }

        private bool _deleteNumberAfterAnsweredCallReturn;

        [XmlElement(ElementName = "deleteNumberAfterAnsweredCallReturn", IsNullable = false, Namespace = "")]
        [Group(@"ca38ce43363a73a1079bbf73920b7a45:55")]
        public bool DeleteNumberAfterAnsweredCallReturn
        {
            get => _deleteNumberAfterAnsweredCallReturn;
            set
            {
                DeleteNumberAfterAnsweredCallReturnSpecified = true;
                _deleteNumberAfterAnsweredCallReturn = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteNumberAfterAnsweredCallReturnSpecified { get; set; }

    }
}
