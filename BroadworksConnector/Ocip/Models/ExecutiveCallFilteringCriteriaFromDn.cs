using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The from dn criteria used within an executive call filtering criteria add/get request.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2258""}]")]
    public class ExecutiveCallFilteringCriteriaFromDn
    {

        private BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringCriteriaDnSelection _fromDnCriteriaSelection;

        [XmlElement(ElementName = "fromDnCriteriaSelection", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2258")]
        public BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringCriteriaDnSelection FromDnCriteriaSelection
        {
            get => _fromDnCriteriaSelection;
            set
            {
                FromDnCriteriaSelectionSpecified = true;
                _fromDnCriteriaSelection = value;
            }
        }

        [XmlIgnore]
        public bool FromDnCriteriaSelectionSpecified { get; set; }

        private bool _includeAnonymousCallers;

        [XmlElement(ElementName = "includeAnonymousCallers", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2258")]
        public bool IncludeAnonymousCallers
        {
            get => _includeAnonymousCallers;
            set
            {
                IncludeAnonymousCallersSpecified = true;
                _includeAnonymousCallers = value;
            }
        }

        [XmlIgnore]
        public bool IncludeAnonymousCallersSpecified { get; set; }

        private bool _includeUnavailableCallers;

        [XmlElement(ElementName = "includeUnavailableCallers", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2258")]
        public bool IncludeUnavailableCallers
        {
            get => _includeUnavailableCallers;
            set
            {
                IncludeUnavailableCallersSpecified = true;
                _includeUnavailableCallers = value;
            }
        }

        [XmlIgnore]
        public bool IncludeUnavailableCallersSpecified { get; set; }

        private List<string> _phoneNumber = new List<string>();

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2258")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }

    }
}
