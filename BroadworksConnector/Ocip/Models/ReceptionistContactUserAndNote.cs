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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4084"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4085""}]}]")]
    public class ReceptionistContactUserAndNote
    {

        protected string _contactUserId;

        [XmlElement(ElementName = "contactUserId", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4085")]
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
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4085")]
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
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4084")]
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
