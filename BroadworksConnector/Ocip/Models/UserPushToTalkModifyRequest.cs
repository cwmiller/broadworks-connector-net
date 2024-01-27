using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Change the push to talk service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""22c82692327758edb5adf1f1db18fc71:123""}]")]
    public class UserPushToTalkModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"22c82692327758edb5adf1f1db18fc71:123")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected bool _allowAutoAnswer;

        [XmlElement(ElementName = "allowAutoAnswer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"22c82692327758edb5adf1f1db18fc71:123")]
        public bool AllowAutoAnswer
        {
            get => _allowAutoAnswer;
            set
            {
                AllowAutoAnswerSpecified = true;
                _allowAutoAnswer = value;
            }
        }

        [XmlIgnore]
        protected bool AllowAutoAnswerSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection _outgoingConnectionSelection;

        [XmlElement(ElementName = "outgoingConnectionSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"22c82692327758edb5adf1f1db18fc71:123")]
        public BroadWorksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection OutgoingConnectionSelection
        {
            get => _outgoingConnectionSelection;
            set
            {
                OutgoingConnectionSelectionSpecified = true;
                _outgoingConnectionSelection = value;
            }
        }

        [XmlIgnore]
        protected bool OutgoingConnectionSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.PushToTalkAccessListSelection _accessListSelection;

        [XmlElement(ElementName = "accessListSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"22c82692327758edb5adf1f1db18fc71:123")]
        public BroadWorksConnector.Ocip.Models.PushToTalkAccessListSelection AccessListSelection
        {
            get => _accessListSelection;
            set
            {
                AccessListSelectionSpecified = true;
                _accessListSelection = value;
            }
        }

        [XmlIgnore]
        protected bool AccessListSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _selectedUserIdList;

        [XmlElement(ElementName = "selectedUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"22c82692327758edb5adf1f1db18fc71:123")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList SelectedUserIdList
        {
            get => _selectedUserIdList;
            set
            {
                SelectedUserIdListSpecified = true;
                _selectedUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool SelectedUserIdListSpecified { get; set; }

    }
}
