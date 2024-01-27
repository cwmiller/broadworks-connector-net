using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for call center scheduled report created by a
    /// supervisor or administrator.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:776""}]")]
    public class SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected bool _createdBySupervisor;

        [XmlElement(ElementName = "createdBySupervisor", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:776")]
        public bool CreatedBySupervisor
        {
            get => _createdBySupervisor;
            set
            {
                CreatedBySupervisorSpecified = true;
                _createdBySupervisor = value;
            }
        }

        [XmlIgnore]
        protected bool CreatedBySupervisorSpecified { get; set; }

    }
}
