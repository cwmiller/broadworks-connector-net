using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular schedule type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:1179""}]")]
    public class SearchCriteriaExactScheduleType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.ScheduleType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:1179")]
        public BroadWorksConnector.Ocip.Models.ScheduleType Type
        {
            get => _type;
            set
            {
                TypeSpecified = true;
                _type = value;
            }
        }

        [XmlIgnore]
        protected bool TypeSpecified { get; set; }

    }
}
