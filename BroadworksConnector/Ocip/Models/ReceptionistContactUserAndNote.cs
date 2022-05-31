using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The Receptionist User (or VON User) and Receptionist Notes.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3595"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3596""}]}]")]
    public class ReceptionistContactUserAndNote
    {

        protected string _contactUserId;

        [XmlElement(ElementName = "contactUserId", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3596")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ContactUserId
        {
            get => _contactUserId;
            set
            {
                ContactUserIdSpecified = true;
                _contactUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ContactUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.VirtualOnNetUserKey _vonUser;

        [XmlElement(ElementName = "vonUser", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3596")]
        public BroadWorksConnector.Ocip.Models.VirtualOnNetUserKey VonUser
        {
            get => _vonUser;
            set
            {
                VonUserSpecified = true;
                _vonUser = value;
            }
        }

        [XmlIgnore]
        protected bool VonUserSpecified { get; set; }

        protected string _note;

        [XmlElement(ElementName = "note", IsNullable = true, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3595")]
        [MinLength(1)]
        [MaxLength(256)]
        public string Note
        {
            get => _note;
            set
            {
                NoteSpecified = true;
                _note = value;
            }
        }

        [XmlIgnore]
        protected bool NoteSpecified { get; set; }

    }
}
