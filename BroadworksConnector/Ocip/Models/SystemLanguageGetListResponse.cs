using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLanguageGetListRequest.
    /// The language table column headings are: "Language", "Locale" and "Encoding".
    /// <see cref="SystemLanguageGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11579""}]")]
    public class SystemLanguageGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _defaultLanguage;

        [XmlElement(ElementName = "defaultLanguage", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11579")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DefaultLanguage
        {
            get => _defaultLanguage;
            set
            {
                DefaultLanguageSpecified = true;
                _defaultLanguage = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultLanguageSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _languageTable;

        [XmlElement(ElementName = "languageTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11579")]
        public BroadWorksConnector.Ocip.Models.C.OCITable LanguageTable
        {
            get => _languageTable;
            set
            {
                LanguageTableSpecified = true;
                _languageTable = value;
            }
        }

        [XmlIgnore]
        protected bool LanguageTableSpecified { get; set; }

    }
}
