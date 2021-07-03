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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4820""}]")]
    public class ServiceProviderLanguageGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _language = new List<string>();

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4820")]
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

        private string _defaultLanguage;

        [XmlElement(ElementName = "defaultLanguage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4820")]
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
