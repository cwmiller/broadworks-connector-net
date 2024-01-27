using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderLanguageGetListRequest.
    /// <see cref="ServiceProviderLanguageGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:4899""}]")]
    public class ServiceProviderLanguageGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _language = new List<string>();

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4899")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> Language
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

        protected string _defaultLanguage;

        [XmlElement(ElementName = "defaultLanguage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4899")]
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

    }
}
