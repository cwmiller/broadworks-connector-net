using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a list of notes for an existing Receptionist user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// If some of the users add and some users fail to add, then the
    /// response will contain a WarningResponse containing only the
    /// a comma delimited list of users that failed to add. If the user
    /// sending the request is the not the owner of the Receptionist Note,
    /// then an ErrorResponse will be returned.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="WarningResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""44477d346d2631b033071e12af214ac8:275""}]")]
    public class UserBroadWorksReceptionistEnterpriseNoteModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _receptionistUserId;

        [XmlElement(ElementName = "receptionistUserId", IsNullable = false, Namespace = "")]
        [Group(@"44477d346d2631b033071e12af214ac8:275")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ReceptionistUserId
        {
            get => _receptionistUserId;
            set
            {
                ReceptionistUserIdSpecified = true;
                _receptionistUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ReceptionistUserIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.ReceptionistContactUserAndNote> _receptionistUserAndNote = new List<BroadWorksConnector.Ocip.Models.ReceptionistContactUserAndNote>();

        [XmlElement(ElementName = "receptionistUserAndNote", IsNullable = false, Namespace = "")]
        [Group(@"44477d346d2631b033071e12af214ac8:275")]
        public List<BroadWorksConnector.Ocip.Models.ReceptionistContactUserAndNote> ReceptionistUserAndNote
        {
            get => _receptionistUserAndNote;
            set
            {
                ReceptionistUserAndNoteSpecified = true;
                _receptionistUserAndNote = value;
            }
        }

        [XmlIgnore]
        protected bool ReceptionistUserAndNoteSpecified { get; set; }

    }
}
