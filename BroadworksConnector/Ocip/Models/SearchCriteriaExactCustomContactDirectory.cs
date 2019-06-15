using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified custom contact directory.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactCustomContactDirectory : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private string _customContactDirectoryName;

        [XmlElement(ElementName = "customContactDirectoryName", IsNullable = false, Namespace = "")]
        public string CustomContactDirectoryName {
            get => _customContactDirectoryName;
            set {
                CustomContactDirectoryNameSpecified = true;
                _customContactDirectoryName = value;
            }
        }

        [XmlIgnore]
        public bool CustomContactDirectoryNameSpecified { get; set; }
        
    }
}
