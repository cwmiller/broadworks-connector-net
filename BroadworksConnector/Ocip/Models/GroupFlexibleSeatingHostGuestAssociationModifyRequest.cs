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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1d4e390f8cd01ca6f92589024d74dac6:258""}]")]
    public class GroupFlexibleSeatingHostGuestAssociationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:258")]
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
        protected bool ServiceUserIdSpecified { get; set; }

        protected bool _enforceAssociationLimit;

        [XmlElement(ElementName = "enforceAssociationLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:258")]
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

        protected int _associationLimitHours;

        [XmlElement(ElementName = "associationLimitHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:258")]
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

        protected BroadWorksConnector.Ocip.Models.FlexibleSeatingHostAccessLevel _accessLevel;

        [XmlElement(ElementName = "accessLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:258")]
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

        protected bool _removeGuestAssociation;

        [XmlElement(ElementName = "removeGuestAssociation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:258")]
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
        protected bool RemoveGuestAssociationSpecified { get; set; }

    }
}
