using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSimultaneousRingFamilyGetRequest17.
    /// Contains a criteria table wich column heading: "Is Active", "Criteria Name", "Time Schedule", "Holiday Schedule", "Calls From" and "Blacklisted".
    /// <see cref="UserSimultaneousRingFamilyGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7829cd70c5c6e02768e0a59a5de29efe:136""}]")]
    public class UserSimultaneousRingFamilyGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"7829cd70c5c6e02768e0a59a5de29efe:136")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected bool _doNotRingIfOnCall;

        [XmlElement(ElementName = "doNotRingIfOnCall", IsNullable = false, Namespace = "")]
        [Group(@"7829cd70c5c6e02768e0a59a5de29efe:136")]
        public bool DoNotRingIfOnCall
        {
            get => _doNotRingIfOnCall;
            set
            {
                DoNotRingIfOnCallSpecified = true;
                _doNotRingIfOnCall = value;
            }
        }

        [XmlIgnore]
        protected bool DoNotRingIfOnCallSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SimultaneousRingNumber> _simultaneousRingNumber = new List<BroadWorksConnector.Ocip.Models.SimultaneousRingNumber>();

        [XmlElement(ElementName = "simultaneousRingNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7829cd70c5c6e02768e0a59a5de29efe:136")]
        public List<BroadWorksConnector.Ocip.Models.SimultaneousRingNumber> SimultaneousRingNumber
        {
            get => _simultaneousRingNumber;
            set
            {
                SimultaneousRingNumberSpecified = true;
                _simultaneousRingNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SimultaneousRingNumberSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        [Group(@"7829cd70c5c6e02768e0a59a5de29efe:136")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CriteriaTable
        {
            get => _criteriaTable;
            set
            {
                CriteriaTableSpecified = true;
                _criteriaTable = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaTableSpecified { get; set; }

    }
}
