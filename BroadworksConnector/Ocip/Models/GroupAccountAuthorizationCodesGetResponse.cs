using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccountAuthorizationCodesGetRequest.
    /// The tables has the following column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address".
    /// <see cref="GroupAccountAuthorizationCodesGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""65df37199ec43e5d21a187db39d63158:176""}]")]
    public class GroupAccountAuthorizationCodesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        [Group(@"65df37199ec43e5d21a187db39d63158:176")]
        public BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeType Type
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

        protected int _numberOfDigits;

        [XmlElement(ElementName = "numberOfDigits", IsNullable = false, Namespace = "")]
        [Group(@"65df37199ec43e5d21a187db39d63158:176")]
        [MinInclusive(2)]
        [MaxInclusive(14)]
        public int NumberOfDigits
        {
            get => _numberOfDigits;
            set
            {
                NumberOfDigitsSpecified = true;
                _numberOfDigits = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfDigitsSpecified { get; set; }

        protected bool _allowLocalAndTollFreeCalls;

        [XmlElement(ElementName = "allowLocalAndTollFreeCalls", IsNullable = false, Namespace = "")]
        [Group(@"65df37199ec43e5d21a187db39d63158:176")]
        public bool AllowLocalAndTollFreeCalls
        {
            get => _allowLocalAndTollFreeCalls;
            set
            {
                AllowLocalAndTollFreeCallsSpecified = true;
                _allowLocalAndTollFreeCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AllowLocalAndTollFreeCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _mandatoryUsageUserTable;

        [XmlElement(ElementName = "mandatoryUsageUserTable", IsNullable = false, Namespace = "")]
        [Group(@"65df37199ec43e5d21a187db39d63158:176")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MandatoryUsageUserTable
        {
            get => _mandatoryUsageUserTable;
            set
            {
                MandatoryUsageUserTableSpecified = true;
                _mandatoryUsageUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool MandatoryUsageUserTableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _optionalUsageUserTable;

        [XmlElement(ElementName = "optionalUsageUserTable", IsNullable = false, Namespace = "")]
        [Group(@"65df37199ec43e5d21a187db39d63158:176")]
        public BroadWorksConnector.Ocip.Models.C.OCITable OptionalUsageUserTable
        {
            get => _optionalUsageUserTable;
            set
            {
                OptionalUsageUserTableSpecified = true;
                _optionalUsageUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool OptionalUsageUserTableSpecified { get; set; }

    }
}
