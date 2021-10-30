using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a language to the system.
    /// The command will fail in Amplify data mode if the locale element is greater than 5 characters in length.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11408""}]")]
    public class SystemLanguageAddRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11408")]
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

        private string _locale;

        [XmlElement(ElementName = "locale", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11408")]
        [MaxLength(20)]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11408")]
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
