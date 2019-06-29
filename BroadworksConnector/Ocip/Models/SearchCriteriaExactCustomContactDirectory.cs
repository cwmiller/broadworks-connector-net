using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified custom contact directory.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:745""}]")]
    public class SearchCriteriaExactCustomContactDirectory : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private string _customContactDirectoryName;

        [XmlElement(ElementName = "customContactDirectoryName", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:745")]
        [MinLength(1)]
        [MaxLength(40)]
        public string CustomContactDirectoryName
        {
            get => _customContactDirectoryName;
            set
            {
                CustomContactDirectoryNameSpecified = true;
                _customContactDirectoryName = value;
            }
        }

        [XmlIgnore]
        protected bool CustomContactDirectoryNameSpecified { get; set; }

    }
}
