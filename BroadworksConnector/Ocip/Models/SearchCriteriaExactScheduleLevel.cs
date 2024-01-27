using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular schedule level.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:1198""}]")]
    public class SearchCriteriaExactScheduleLevel : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.ScheduleLevel _level;

        [XmlElement(ElementName = "level", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:1198")]
        public BroadWorksConnector.Ocip.Models.ScheduleLevel Level
        {
            get => _level;
            set
            {
                LevelSpecified = true;
                _level = value;
            }
        }

        [XmlIgnore]
        protected bool LevelSpecified { get; set; }

    }
}
