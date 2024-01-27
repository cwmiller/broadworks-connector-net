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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""00df0beea0b5305e1c9d56717c27f995:55""}]")]
    public class SystemCallReturnGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _twoLevelActivation;

        [XmlElement(ElementName = "twoLevelActivation", IsNullable = false, Namespace = "")]
        [Group(@"00df0beea0b5305e1c9d56717c27f995:55")]
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

        protected bool _provideDate;

        [XmlElement(ElementName = "provideDate", IsNullable = false, Namespace = "")]
        [Group(@"00df0beea0b5305e1c9d56717c27f995:55")]
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

        protected bool _lastUnansweredCallOnly;

        [XmlElement(ElementName = "lastUnansweredCallOnly", IsNullable = false, Namespace = "")]
        [Group(@"00df0beea0b5305e1c9d56717c27f995:55")]
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

        protected string _confirmationKey;

        [XmlElement(ElementName = "confirmationKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"00df0beea0b5305e1c9d56717c27f995:55")]
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

        protected bool _allowRestrictedNumber;

        [XmlElement(ElementName = "allowRestrictedNumber", IsNullable = false, Namespace = "")]
        [Group(@"00df0beea0b5305e1c9d56717c27f995:55")]
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

        protected bool _deleteNumberAfterAnsweredCallReturn;

        [XmlElement(ElementName = "deleteNumberAfterAnsweredCallReturn", IsNullable = false, Namespace = "")]
        [Group(@"00df0beea0b5305e1c9d56717c27f995:55")]
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
