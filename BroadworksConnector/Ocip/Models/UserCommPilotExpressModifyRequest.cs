using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's commPilot express service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Engineering Note: This command is used internally by Call Processing.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de7795e1833d459a7eb89116d772fd78:77""}]")]
    public class UserCommPilotExpressModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"de7795e1833d459a7eb89116d772fd78:77")]
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

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressProfile? _profile;

        [XmlElement(ElementName = "profile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de7795e1833d459a7eb89116d772fd78:77")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressProfile? Profile
        {
            get => _profile;
            set
            {
                ProfileSpecified = true;
                _profile = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableInOfficeModify _availableInOffice;

        [XmlElement(ElementName = "availableInOffice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de7795e1833d459a7eb89116d772fd78:77")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableInOfficeModify AvailableInOffice
        {
            get => _availableInOffice;
            set
            {
                AvailableInOfficeSpecified = true;
                _availableInOffice = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableInOfficeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOfficeModify _availableOutOfOffice;

        [XmlElement(ElementName = "availableOutOfOffice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de7795e1833d459a7eb89116d772fd78:77")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOfficeModify AvailableOutOfOffice
        {
            get => _availableOutOfOffice;
            set
            {
                AvailableOutOfOfficeSpecified = true;
                _availableOutOfOffice = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableOutOfOfficeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressBusyModify _busy;

        [XmlElement(ElementName = "busy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de7795e1833d459a7eb89116d772fd78:77")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressBusyModify Busy
        {
            get => _busy;
            set
            {
                BusySpecified = true;
                _busy = value;
            }
        }

        [XmlIgnore]
        protected bool BusySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressUnavailableModify _unavailable;

        [XmlElement(ElementName = "unavailable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de7795e1833d459a7eb89116d772fd78:77")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressUnavailableModify Unavailable
        {
            get => _unavailable;
            set
            {
                UnavailableSpecified = true;
                _unavailable = value;
            }
        }

        [XmlIgnore]
        protected bool UnavailableSpecified { get; set; }

    }
}
