using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for users with Route List feature assignment.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:1394""}]")]
    public class SearchCriteriaExactUserRouteListAssignment : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected bool _assigned;

        [XmlElement(ElementName = "assigned", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:1394")]
        public bool Assigned
        {
            get => _assigned;
            set
            {
                AssignedSpecified = true;
                _assigned = value;
            }
        }

        [XmlIgnore]
        protected bool AssignedSpecified { get; set; }

    }
}
