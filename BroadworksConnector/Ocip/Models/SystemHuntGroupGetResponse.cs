using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemHuntGroupGetRequest.
    /// Replaced by: SystemHuntGroupGetResponse17
    /// <see cref="SystemHuntGroupGetRequest"/>
    /// <see cref="SystemHuntGroupGetResponse17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27282""}]")]
    public class SystemHuntGroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _anonymousInsteadOfPrivateCLID;

        [XmlElement(ElementName = "anonymousInsteadOfPrivateCLID", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27282")]
        public bool AnonymousInsteadOfPrivateCLID
        {
            get => _anonymousInsteadOfPrivateCLID;
            set
            {
                AnonymousInsteadOfPrivateCLIDSpecified = true;
                _anonymousInsteadOfPrivateCLID = value;
            }
        }

        [XmlIgnore]
        protected bool AnonymousInsteadOfPrivateCLIDSpecified { get; set; }

        protected bool _removeHuntGroupNameFromCLID;

        [XmlElement(ElementName = "removeHuntGroupNameFromCLID", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27282")]
        public bool RemoveHuntGroupNameFromCLID
        {
            get => _removeHuntGroupNameFromCLID;
            set
            {
                RemoveHuntGroupNameFromCLIDSpecified = true;
                _removeHuntGroupNameFromCLID = value;
            }
        }

        [XmlIgnore]
        protected bool RemoveHuntGroupNameFromCLIDSpecified { get; set; }

    }
}
