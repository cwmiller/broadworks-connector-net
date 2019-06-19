using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular mobile dn availability.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:1000""}]")]
    public class SearchCriteriaExactMobileDnAvailability : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private bool _available;

        [XmlElement(ElementName = "available", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:1000")]
        public bool Available
        {
            get => _available;
            set
            {
                AvailableSpecified = true;
                _available = value;
            }
        }

        [XmlIgnore]
        public bool AvailableSpecified { get; set; }

    }
}
