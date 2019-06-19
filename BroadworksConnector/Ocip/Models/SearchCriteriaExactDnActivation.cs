using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular Dn activation state.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:880""}]")]
    public class SearchCriteriaExactDnActivation : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private bool _activated;

        [XmlElement(ElementName = "activated", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:880")]
        public bool Activated
        {
            get => _activated;
            set
            {
                ActivatedSpecified = true;
                _activated = value;
            }
        }

        [XmlIgnore]
        public bool ActivatedSpecified { get; set; }

    }
}
