using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserBroadWorksReceptionistEnterpriseNoteGetRequest.
    /// <see cref="UserBroadWorksReceptionistEnterpriseNoteGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb12998f4f9e45cedde01f08569f4c7c:254""}]")]
    public class UserBroadWorksReceptionistEnterpriseNoteGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _receptionistNote;

        [XmlElement(ElementName = "receptionistNote", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:254")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ReceptionistNote
        {
            get => _receptionistNote;
            set
            {
                ReceptionistNoteSpecified = true;
                _receptionistNote = value;
            }
        }

        [XmlIgnore]
        protected bool ReceptionistNoteSpecified { get; set; }

    }
}
