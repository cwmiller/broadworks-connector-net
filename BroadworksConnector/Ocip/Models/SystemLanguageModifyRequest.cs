using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a language properties in the system.
    /// If the becomeDefaultLanguage element is present, the language in this request becomes
    /// the default language for the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced by: SystemLanguageModifyRequest22.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemLanguageModifyRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27402""}]")]
    public class SystemLanguageModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27402")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Language
        {
            get => _language;
            set
            {
                LanguageSpecified = true;
                _language = value;
            }
        }

        [XmlIgnore]
        protected bool LanguageSpecified { get; set; }

        private bool _becomeDefaultLanguage;

        [XmlElement(ElementName = "becomeDefaultLanguage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27402")]
        public bool BecomeDefaultLanguage
        {
            get => _becomeDefaultLanguage;
            set
            {
                BecomeDefaultLanguageSpecified = true;
                _becomeDefaultLanguage = value;
            }
        }

        [XmlIgnore]
        protected bool BecomeDefaultLanguageSpecified { get; set; }

        private string _locale;

        [XmlElement(ElementName = "locale", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27402")]
        [MaxLength(5)]
        public string Locale
        {
            get => _locale;
            set
            {
                LocaleSpecified = true;
                _locale = value;
            }
        }

        [XmlIgnore]
        protected bool LocaleSpecified { get; set; }

        private string _encoding;

        [XmlElement(ElementName = "encoding", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27402")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Encoding
        {
            get => _encoding;
            set
            {
                EncodingSpecified = true;
                _encoding = value;
            }
        }

        [XmlIgnore]
        protected bool EncodingSpecified { get; set; }

    }
}
