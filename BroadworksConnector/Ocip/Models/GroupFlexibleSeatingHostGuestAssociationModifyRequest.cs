using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the flexible seating host’s guest association attributes.
    /// The request fails if enforceAssociationLimit or associationLimitHours are changed when the host is associated to a guest.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""43afb2158d313a1d1a148124d7caba1e:315""}]")]
    public class GroupFlexibleSeatingHostGuestAssociationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:315")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }

        private bool _enforceAssociationLimit;

        [XmlElement(ElementName = "enforceAssociationLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:315")]
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
        public bool EnforceAssociationLimitSpecified { get; set; }

        private int _associationLimitHours;

        [XmlElement(ElementName = "associationLimitHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:315")]
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
        public bool AssociationLimitHoursSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.FlexibleSeatingHostAccessLevel _accessLevel;

        [XmlElement(ElementName = "accessLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:315")]
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
        public bool AccessLevelSpecified { get; set; }

        private bool _removeGuestAssociation;

        [XmlElement(ElementName = "removeGuestAssociation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:315")]
        public bool RemoveGuestAssociation
        {
            get => _removeGuestAssociation;
            set
            {
                RemoveGuestAssociationSpecified = true;
                _removeGuestAssociation = value;
            }
        }

        [XmlIgnore]
        public bool RemoveGuestAssociationSpecified { get; set; }

    }
}
