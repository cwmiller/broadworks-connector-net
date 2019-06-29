using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupFlexibleSeatingHostGuestAssociationGetRequest.
    /// <see cref="GroupFlexibleSeatingHostGuestAssociationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""43afb2158d313a1d1a148124d7caba1e:290""}]")]
    public class GroupFlexibleSeatingHostGuestAssociationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enforceAssociationLimit;

        [XmlElement(ElementName = "enforceAssociationLimit", IsNullable = false, Namespace = "")]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:290")]
        public bool EnforceAssociationLimit
        {
            get => _enforceAssociationLimit;
            set
            {
                EnforceAssociationLimitSpecified = true;
                _enforceAssociationLimit = value;
            }
        }

        [XmlIgnore]
        protected bool EnforceAssociationLimitSpecified { get; set; }

        private int _associationLimitHours;

        [XmlElement(ElementName = "associationLimitHours", IsNullable = false, Namespace = "")]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:290")]
        [MinInclusive(1)]
        [MaxInclusive(999)]
        public int AssociationLimitHours
        {
            get => _associationLimitHours;
            set
            {
                AssociationLimitHoursSpecified = true;
                _associationLimitHours = value;
            }
        }

        [XmlIgnore]
        protected bool AssociationLimitHoursSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.FlexibleSeatingHostAccessLevel _accessLevel;

        [XmlElement(ElementName = "accessLevel", IsNullable = false, Namespace = "")]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:290")]
        public BroadWorksConnector.Ocip.Models.FlexibleSeatingHostAccessLevel AccessLevel
        {
            get => _accessLevel;
            set
            {
                AccessLevelSpecified = true;
                _accessLevel = value;
            }
        }

        [XmlIgnore]
        protected bool AccessLevelSpecified { get; set; }

        private string _guestLastName;

        [XmlElement(ElementName = "guestLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:290")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GuestLastName
        {
            get => _guestLastName;
            set
            {
                GuestLastNameSpecified = true;
                _guestLastName = value;
            }
        }

        [XmlIgnore]
        protected bool GuestLastNameSpecified { get; set; }

        private string _guestFirstName;

        [XmlElement(ElementName = "guestFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:290")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GuestFirstName
        {
            get => _guestFirstName;
            set
            {
                GuestFirstNameSpecified = true;
                _guestFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool GuestFirstNameSpecified { get; set; }

        private string _guestPhoneNumber;

        [XmlElement(ElementName = "guestPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:290")]
        [MinLength(1)]
        [MaxLength(23)]
        public string GuestPhoneNumber
        {
            get => _guestPhoneNumber;
            set
            {
                GuestPhoneNumberSpecified = true;
                _guestPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool GuestPhoneNumberSpecified { get; set; }

        private string _guestExtension;

        [XmlElement(ElementName = "guestExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:290")]
        [MinLength(2)]
        [MaxLength(20)]
        public string GuestExtension
        {
            get => _guestExtension;
            set
            {
                GuestExtensionSpecified = true;
                _guestExtension = value;
            }
        }

        [XmlIgnore]
        protected bool GuestExtensionSpecified { get; set; }

        private string _guestLocationDialingCode;

        [XmlElement(ElementName = "guestLocationDialingCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:290")]
        [MinLength(1)]
        [MaxLength(15)]
        public string GuestLocationDialingCode
        {
            get => _guestLocationDialingCode;
            set
            {
                GuestLocationDialingCodeSpecified = true;
                _guestLocationDialingCode = value;
            }
        }

        [XmlIgnore]
        protected bool GuestLocationDialingCodeSpecified { get; set; }

        private string _guestAssociationDateTime;

        [XmlElement(ElementName = "guestAssociationDateTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:290")]
        public string GuestAssociationDateTime
        {
            get => _guestAssociationDateTime;
            set
            {
                GuestAssociationDateTimeSpecified = true;
                _guestAssociationDateTime = value;
            }
        }

        [XmlIgnore]
        protected bool GuestAssociationDateTimeSpecified { get; set; }

    }
}
