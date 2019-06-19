using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderLanguageGetAvailableListRequest.
    /// The language table column headings are: "Language", "Locale" and "Encoding".
    /// <see cref="ServiceProviderLanguageGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:3998""}]")]
    public class ServiceProviderLanguageGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _defaultLanguage;

        [XmlElement(ElementName = "defaultLanguage", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3998")]
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
        public bool DefaultLanguageSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _languageTable;

        [XmlElement(ElementName = "languageTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3998")]
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
        public bool LanguageTableSpecified { get; set; }

    }
}
