using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular schedule level.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactScheduleLevel : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private BroadWorksConnector.Ocip.Models.ScheduleLevel _level;

        [XmlElement(ElementName = "level", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ScheduleLevel Level {
            get => _level;
            set {
                LevelSpecified = true;
                _level = value;
            }
        }

        [XmlIgnore]
        public bool LevelSpecified { get; set; }
        
    }
}
