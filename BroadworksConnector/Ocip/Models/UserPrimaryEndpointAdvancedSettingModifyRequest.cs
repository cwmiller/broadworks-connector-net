using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Users Primary Endpoint line control settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// allowVideo
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3357""}]")]
    public class UserPrimaryEndpointAdvancedSettingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3357")]
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
        public bool UserIdSpecified { get; set; }

        private bool _allowOrigination;

        [XmlElement(ElementName = "allowOrigination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3357")]
        public bool AllowOrigination
        {
            get => _allowOrigination;
            set
            {
                AllowOriginationSpecified = true;
                _allowOrigination = value;
            }
        }

        [XmlIgnore]
        public bool AllowOriginationSpecified { get; set; }

        private bool _allowTermination;

        [XmlElement(ElementName = "allowTermination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3357")]
        public bool AllowTermination
        {
            get => _allowTermination;
            set
            {
                AllowTerminationSpecified = true;
                _allowTermination = value;
            }
        }

        [XmlIgnore]
        public bool AllowTerminationSpecified { get; set; }

        private bool _allowVideo;

        [XmlElement(ElementName = "allowVideo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3357")]
        public bool AllowVideo
        {
            get => _allowVideo;
            set
            {
                AllowVideoSpecified = true;
                _allowVideo = value;
            }
        }

        [XmlIgnore]
        public bool AllowVideoSpecified { get; set; }

    }
}
