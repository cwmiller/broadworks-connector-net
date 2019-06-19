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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:1075""}]")]
    public class SearchCriteriaExactScheduleLevel : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private BroadWorksConnector.Ocip.Models.ScheduleLevel _level;

        [XmlElement(ElementName = "level", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:1075")]
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
        public bool LevelSpecified { get; set; }

    }
}
