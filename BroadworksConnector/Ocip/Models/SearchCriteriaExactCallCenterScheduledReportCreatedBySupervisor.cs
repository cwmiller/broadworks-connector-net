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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:742""}]")]
    public class SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected bool _createdBySupervisor;

        [XmlElement(ElementName = "createdBySupervisor", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:742")]
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
